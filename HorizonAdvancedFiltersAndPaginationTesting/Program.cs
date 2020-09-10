using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.CustomModel;

namespace HorizonAdvancedFiltersAndPaginationTesting
{
    class Program
    {
        static HorizonRESTClient Client = null;

        static VMware.Horizon.RESTAPI.CustomModel.Filter.SingleFilter GetAppPoolFilter()
        {
            Filter.SingleFilter sf = new VMware.Horizon.RESTAPI.CustomModel.Filter.SingleFilter(VMware.Horizon.RESTAPI.CustomModel.Filter.FilterTypes.Contains);
            sf.name = "display_name";
            sf.value = "Calc";
            return sf;
        }

        static VMware.Horizon.RESTAPI.CustomModel.Filter.SingleFilter GetMachineFilter()
        {
            Filter.SingleFilter sf = new VMware.Horizon.RESTAPI.CustomModel.Filter.SingleFilter(VMware.Horizon.RESTAPI.CustomModel.Filter.FilterTypes.Contains);
            sf.name = "name";
            sf.value = "10x64";
            return sf;
        }

        static Filter.ChainFilter GetMachineChainedFilter()
        {
            Filter.ChainFilter cf = new Filter.ChainFilter(Filter.FilterTypes.And);
            cf.filters.Add(GetMachineFilter());
            var filter2 = new Filter.SingleFilter(Filter.FilterTypes.Contains, "dns_name", "dev");
            cf.filters.Add(filter2);

            return cf;
        }
        static async Task<bool> TestAsyncMethods()
        {

            try
            {
                var AppPoolFilter = await Client.Inventory.ListApplicationPoolsAsync(new VMware.Horizon.RESTAPI.CustomModel.Pagination(1, 1), GetAppPoolFilter().StringifyFilter());
                var AppPool = await Client.Inventory.ListApplicationPoolsAsync(new Pagination(1, 1));
                Console.WriteLine("- Async - Calc Application pools. Filtered: {0} Unfiltered: {1}", AppPoolFilter.Count(), AppPool.Count());

                var Machines = await Client.Inventory.ListMachinesUsingGETAsync(new Pagination(1, 1));
                var filteredMachines = await Client.Inventory.ListMachinesUsingGETAsync(new Pagination(1, 1), GetMachineFilter().StringifyFilter());
                var ChainedFilterMachines = await Client.Inventory.ListMachinesUsingGETAsync(filter: GetMachineChainedFilter().StringifyFilter());
                Console.WriteLine("- Async - Machines: Filtered: {0} Unfiltered: {1} Chained: {2}", Machines.Count(), filteredMachines.Count(), ChainedFilterMachines.Count());

                var sessions = await Client.Inventory.ListSessionInfoAsync(new Pagination(1, 1));

                Console.WriteLine("- Async - Sessions: {0}", sessions.Count());

                var DesktopPools = await Client.Inventory.ListDesktopPoolsV2Async(new Pagination(1, 1));

                Console.WriteLine("- Async - Desktop Pools: {0}", DesktopPools.Count());

                foreach(var desktop in DesktopPools)
                {
                    Filter.SingleFilter sf = new Filter.SingleFilter(Filter.FilterTypes.Equals, "id", desktop.Id);
                    var entitlementsFilter = await Client.Entitlements.ListDesktopPoolEntitlementsAsync(new Pagination(1, 1), sf.StringifyFilter());
                    var entitlement = await Client.Entitlements.GetDesktopPoolEntitlementsAsync(desktop.Id);
                    Console.WriteLine("- async - {0} Desktop entitlement query - Filtered: {1}, Directed {2}", desktop.Name, entitlementsFilter.Count, entitlement.Id);
                }

                foreach (var app in AppPool)
                {
                    Filter.SingleFilter sf = new Filter.SingleFilter(Filter.FilterTypes.Equals, "id", app.Id);
                    var entitlementsFilter = await Client.Entitlements.ListApplicationPoolEntitlementsAsync(new Pagination(1, 1), sf.StringifyFilter());
                    var entitlement = await Client.Entitlements.GetApplicationPoolEntitlementsAsync(app.Id);
                    Console.WriteLine("- async - {0} App entitlement query - Filtered: {1}, Directed {2}", app.Name, entitlementsFilter.Count, entitlement.Id);
                }

                Filter.SingleFilter gsf = new Filter.SingleFilter(Filter.FilterTypes.Contains);
                gsf.name = "name";
                gsf.value = "domain";

                var groups =await Client.External.ListADUserOrGroupSummaryAsync(true.ToString());
                var pagedgroups = await Client.External.ListADUserOrGroupSummaryAsync(true.ToString(), new Pagination(1, 1));
                var filteredgroups = await Client.External.ListADUserOrGroupSummaryAsync(true.ToString(), new Pagination(1, 1), gsf.StringifyFilter());

                Console.WriteLine("- Async - Groups: {0}, PagedGroups: {1}, Filtered Groups: {2}", groups.Count, pagedgroups.Count, filteredgroups.Count);

                gsf.value = "sales";

                var users = await Client.External.ListADUserOrGroupSummaryAsync(false.ToString());
                var pagedusers = await Client.External.ListADUserOrGroupSummaryAsync(false.ToString(), new Pagination(1, 1));
                var filteredusers = await Client.External.ListADUserOrGroupSummaryAsync(false.ToString(), new Pagination(1, 1), gsf.StringifyFilter());

                Console.WriteLine("- Async - users: {0}, Pagedusers: {1}, Filtered users: {2}", users.Count, pagedusers.Count, filteredusers.Count);

                Console.WriteLine("ASync Job Finished");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception during SYNC routine: {0}", ex.ToString());
            }


            return true;
        }
        static void Main(string[] args)
        {
            Client = new HorizonRESTClient("https://pod1hcon1.lab.local/rest");
            try
            {

                Client.Logon("UserName", "Password", "Domain");

                TestAsyncMethods();

                var AppPoolFilter =Client.Inventory.ListApplicationPools(new VMware.Horizon.RESTAPI.CustomModel.Pagination(1, 1), GetAppPoolFilter().StringifyFilter());
                var AppPool =Client.Inventory.ListApplicationPools(new Pagination(1, 1));
                Console.WriteLine("Calc Application pools. Filtered: {0} Unfiltered: {1}", AppPoolFilter.Count(), AppPool.Count());


                var Machines =Client.Inventory.ListMachinesUsingGET(new Pagination(1, 1));
                var filteredMachines =Client.Inventory.ListMachinesUsingGET(new Pagination(1, 1), GetMachineFilter().StringifyFilter());
                var ChainedFilterMachines =Client.Inventory.ListMachinesUsingGET(filter: GetMachineChainedFilter().StringifyFilter());
                Console.WriteLine("Machines: Filtered: {0} Unfiltered: {1} Chained: {2}", Machines.Count(), filteredMachines.Count(), ChainedFilterMachines.Count());

                var sessions =Client.Inventory.ListSessionInfo(new Pagination(1, 1));

                Console.WriteLine("Sessions: {0}", sessions.Count());

                var DesktopPools =Client.Inventory.ListDesktopPoolsV2(new Pagination(1, 1));

                Console.WriteLine("Desktop Pools: {0}", DesktopPools.Count());

                foreach (var desktop in DesktopPools)
                {
                    Filter.SingleFilter sf = new Filter.SingleFilter(Filter.FilterTypes.Equals, "id", desktop.Id);
                    var entitlementsFilter =  Client.Entitlements.ListDesktopPoolEntitlements(new Pagination(1, 1), sf.StringifyFilter());
                    var entitlement =  Client.Entitlements.GetDesktopPoolEntitlements(desktop.Id);
                    Console.WriteLine("{0} Desktop entitlement query - Filtered: {1}, Directed {2}", desktop.Name, entitlementsFilter.Count, entitlement.Id);
                }

                foreach (var app in AppPool)
                {
                    Filter.SingleFilter sf = new Filter.SingleFilter(Filter.FilterTypes.Equals, "id", app.Id);
                    var entitlementsFilter =  Client.Entitlements.ListApplicationPoolEntitlements(new Pagination(1, 1), sf.StringifyFilter());
                    var entitlement =  Client.Entitlements.GetApplicationPoolEntitlements(app.Id);
                    Console.WriteLine("{0} App entitlement query - Filtered: {1}, Directed {2}", app.Name, entitlementsFilter.Count, entitlement.Id);
                }

                Filter.SingleFilter gsf = new Filter.SingleFilter(Filter.FilterTypes.Contains);
                gsf.name = "name";
                gsf.value = "domain";

                var groups =  Client.External.ListADUserOrGroupSummary(true.ToString());
                var pagedgroups =  Client.External.ListADUserOrGroupSummary(true.ToString(), new Pagination(1, 1));
                var filteredgroups =  Client.External.ListADUserOrGroupSummary(true.ToString(), new Pagination(1, 1), gsf.StringifyFilter());

                Console.WriteLine("Groups: {0}, PagedGroups: {1}, Filtered Groups: {2}", groups.Count, pagedgroups.Count, filteredgroups.Count);

                gsf.value = "sales";

                var users =  Client.External.ListADUserOrGroupSummary(false.ToString());
                var pagedusers =  Client.External.ListADUserOrGroupSummary(false.ToString(), new Pagination(1, 1));
                var filteredusers =  Client.External.ListADUserOrGroupSummary(false.ToString(), new Pagination(1, 1), gsf.StringifyFilter());

                Console.WriteLine("users: {0}, Pagedusers: {1}, Filtered users: {2}", users.Count, pagedusers.Count, filteredusers.Count);

                Console.WriteLine("Sync Job Finished");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception during SYNC routine: {0}", ex.ToString());
            }

            Console.ReadLine();
            Client.LogOut();

        }
    }
}
