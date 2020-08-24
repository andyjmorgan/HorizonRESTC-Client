using System;
using VMware.Horizon.RESTAPI.Client;

namespace NetCore2CSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizonRESTClient client = new HorizonRESTClient("https://ConnectionServer.Domain.local/rest");
            try
            {
                client.Logon("UserName", "Password", "Domain");

                // list all farms health
                var farms = client.Monitoring.ListFarmMonitors();
                Console.WriteLine("Farms: {0}", farms.Count);

                // list all rdsh servers health
                var RDSHServers = client.Monitoring.ListRDSServerMonitors();
                Console.WriteLine("RDSHServers: {0}", RDSHServers.Count);

                //list all connection servers health
                var ConnectionServers = client.Monitoring.ListConnectionServerMonitors();
                Console.WriteLine("ConnectionServers: {0}", ConnectionServers.Count);

                // demo the ability to refresh
                client.RefreshToken();

                var Pools = client.Inventory.ListDesktopPools();
                Console.WriteLine("pools: {0}", Pools.Count);

                // get information about the first pool
                var Pool = client.Inventory.GetDesktopPool(Pools[0].Id);
                Console.WriteLine("First Pool: {0}", Pool.DisplayName);

                // pull active sessions
                var Sessions = client.Inventory.ListSessionInfo();
                Console.WriteLine("sessions: {0}", Sessions.Count);

                // log out when complete
                client.LogOut();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception trapped during routine: {0}", ex.ToString());
            }
        }
    }
}
