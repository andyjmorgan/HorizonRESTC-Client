using System;
using VMware.Horizon.RESTAPI.Client;
using Newtonsoft.Json;
using System.Linq;
using System.Web;
using System.Net;
using System.Text;
using System.Net.Security;
using VMware.Horizon.RESTAPI.Model;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using VMware.Horizon.RESTAPI.CustomModel;

namespace HorizonEntitlementsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizonRESTClient Client = new HorizonRESTClient("https://pod1hcon1.lab.local/rest");
            try
            {
                
                Client.Logon("UserName", "Password", "Domain");
                var pools = Client.Inventory.ListDesktopPools();

                foreach(var pool in pools)
                {



                    Console.WriteLine("Pool: {0}", pool.Name);
                    VMware.Horizon.RESTAPI.Model.EntitlementInfo entitlements = Client.Entitlements.GetDesktopPoolEntitlements(pool.Id);
                    Console.WriteLine("Entitlement: {0} - Groups: {1}", entitlements.Id, entitlements.AdUserOrGroupIds.Count);
                    foreach(var UserOrGroup in entitlements.AdUserOrGroupIds)
                    {
                        var info = Client.External.GetADUserOrGroupInfo(UserOrGroup);
                        Console.WriteLine("IsGroup: {0} DisplayName: {1}", info.Group, info.DisplayName);

                    }

                    var DeleteList = new System.Collections.Generic.List<VMware.Horizon.RESTAPI.Model.EntitlementSpec>();
                    DeleteList.Add(new VMware.Horizon.RESTAPI.Model.EntitlementSpec
                    {
                        Id = entitlements.Id,
                        AdUserOrGroupIds = entitlements.AdUserOrGroupIds
                    });
                    var Deleteresults = Client.Entitlements.BulkDeleteDesktopPoolEntitlements(DeleteList);
                    foreach(var result in Deleteresults)
                    {
                        if(result.StatusCode != 200)
                        {
                            Console.WriteLine("Failed to delete an entitlement: {0]", JsonConvert.SerializeObject(result, Formatting.Indented));
                        }
                    }


                    Filter.SingleFilter sf = new Filter.SingleFilter(Filter.FilterTypes.Contains);
                    sf.name = "name";
                    sf.value = "vdiusers";
                    var adgroups = Client.External.ListADUserOrGroupSummary(filter: sf.StringifyFilter());

                    var AddList = new List<VMware.Horizon.RESTAPI.Model.EntitlementSpec>();

                    EntitlementSpec es = new EntitlementSpec
                    {
                        Id = pool.Id,
                        AdUserOrGroupIds = adgroups.Select(x=> x.Id).ToList()
                    };

                    AddList.Add(es);

                    var j = Client.Entitlements.BulkCreateDesktopPoolEntitlements(AddList);

                    var allSessions = Client.Inventory.ListSessionInfo(new Pagination(1,1));

                    var ThisPoolSessions = allSessions.Where(x => x.DesktopPoolId == pool.Id).ToList();
                    if (ThisPoolSessions.Count > 0)
                    {

                        Console.WriteLine("sending messages to: {0} sessions", ThisPoolSessions.Count);
                        SessionSendMessageSpec ssms = new SessionSendMessageSpec(
                            "This desktop will be reassigned in 15 minutes, you should save your work and log off before then",
                            SessionSendMessageSpec.MessageTypeEnum.WARNING,
                            ThisPoolSessions.Select(x => x.Id).ToList()
                        );
                        var SendMessageResult =  Client.Inventory.SendMessageToSessions(ssms);
                    }

                    if(ThisPoolSessions.Count > 0)
                    {
                        var NonEntitledUserSessions = new List<string>();
                        foreach(var session in ThisPoolSessions)
                        {
                            var UserDetails = Client.External.GetADUserOrGroupInfo(session.UserId);
                            if (UserDetails.GroupMembershipIds.Where(x => es.AdUserOrGroupIds.Contains(x)).Count() <= 0)
                            {
                                Console.WriteLine("User: {0} is no longer entitled to use this desktop", UserDetails.Name);
                                NonEntitledUserSessions.Add(session.Id);
                            }
                        }
                        if(NonEntitledUserSessions.Count > 0)
                        {
                            Console.WriteLine("Logging out: {0} sessions", NonEntitledUserSessions.Count);
                            List<BulkItemResponseInfo> LogOffResult = Client.Inventory.LogOffSessions(NonEntitledUserSessions, forced: true);
                        }
                        
                    }
                   

                }

                Client.LogOut();
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}
