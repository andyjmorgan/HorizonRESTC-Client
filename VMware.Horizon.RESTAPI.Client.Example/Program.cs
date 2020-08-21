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
            HorizonRESTClient client = new HorizonRESTClient("https://connectionserver.domain.local/rest");

            try
            {
                client.Logon("username", "password", "domain");
                
                // list all farms health
                var farms = client.Monitoring.ListFarmMonitors();

                // list all rdsh servers health
                var RDSHServers = client.Monitoring.ListRDSServerMonitors();

                //list all connection servers health
                var ConnectionServers = client.Monitoring.ListConnectionServerMonitors();


                // demo the ability to refresh
                client.TryRefreshSession();

                var pools = client.Inventory.ListDesktopPools();
                
                // get information about the first pool
                var pool = client.Inventory.GetDesktopPool(pools[0].Id);

                // pull active sessions
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
