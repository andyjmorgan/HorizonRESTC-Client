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
            Client client = new Client("https://yourconnectionserver/rest");

            try
            {
                client.Logon("username", "password", "domain");
                var farms = client.Monitoring.ListFarmMonitors();
                var RDSHServers = client.Monitoring.ListRDSServerMonitors();
                var ConnectionServers = client.Monitoring.ListConnectionServerMonitors();

                client.TryRefreshSession();

                var pools = client.Inventory.ListDesktopPools();
                var sessions = client.Inventory.ListSessionInfo();

                client.LogOut();
                client.TryRefreshSession();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception trapped during routine: {0}", ex.ToString());
            }


        }
    }
}
