## VMware Horizon Rest C# Client

This repo, is an example of the VMware Horizon REST API, converted using Swagger Codegen, for native use in .Net Framework. 

The documentation for the sub API's can be found here: 

https://code.vmware.com/apis/1007/view-rest-api

To speed up the digestion of the API, I've created a helper class to wrap up the authentication, refresh and log off attributes and embedded the sub API's under a single object to be utilized.

This repo contains:

- The native REST Object
- A helper class for quick start
- A sample console application for c# .Net Framework 4.7.2
- A sample console application for c# .Net Core 2.0
- A sample console application for vb .Net Framework 4.7.2



<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.7.2
- .NET Core 2.0

## Demo Application:

The demo project & code below are a small insight into how quickly you can begin consuming data from Horizon:

**c#**

``` c#
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
```

**VB.Net**

```vb
        Dim Client = New HorizonRESTClient("https://ConnectionServer.Domain.local/rest")
        Client.Logon("UserName", "Password", "Domain")

        ' list all farms health
        Dim farms = Client.Monitoring.ListFarmMonitors()
        Console.WriteLine("Farms: {0}", farms.Count)

        ' list all rdsh servers health
        Dim RDSHServers = Client.Monitoring.ListRDSServerMonitors()
        Console.WriteLine("RDSHServers: {0}", RDSHServers.Count)

        'list all connection servers health
        Dim ConnectionServers = Client.Monitoring.ListConnectionServerMonitors()
        Console.WriteLine("ConnectionServers: {0}", ConnectionServers.Count)

        ' demo the ability to refresh
        Client.RefreshToken()

        Dim Pools = Client.Inventory.ListDesktopPools()
        Console.WriteLine("pools: {0}", Pools.Count)

        ' get information about the first pool
        Dim Pool = Client.Inventory.GetDesktopPool(Pools(0).Id)
        Console.WriteLine("First Pool: {0}", Pool.DisplayName)

        ' pull active sessions
        Dim Sessions = Client.Inventory.ListSessionInfo()
        Console.WriteLine("sessions: {0}", Sessions.Count)

        ' log out when complete
        Client.LogOut()
        Console.ReadLine()
```
