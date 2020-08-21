using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMware.Horizon.RESTAPI.Client.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizonRESTClient client = new HorizonRESTClient("https://yourconnectionserver/rest");

            try
            {
                client.Logon("username", "password", "domain");
                var farms = client.Monitoring.ListFarmMonitors();
                var RDSHServers = client.Monitoring.ListRDSServerMonitors();
                var ConnectionServers = client.Monitoring.ListConnectionServerMonitors();


                // demo the ability to refresh
                client.TryRefreshSession();

                var pools = client.Inventory.ListDesktopPools();

                var pool = client.Inventory.GetDesktopPool(pools[0].Id);
                var sessions = client.Inventory.ListSessionInfo();

                // log out when complete
                client.LogOut();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception trapped during routine: {0}", ex.ToString());
            }


        }
    }
}
