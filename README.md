## VMware Horizon Rest C# Client

This repo, is an example of the VMware Horizon REST API, converted using Swagger Codegen, for native use in .Net Framework (>=4.5) c#. 

The documentation for the sub API's can be found here: 

https://code.vmware.com/apis/1007/view-rest-api

This repo contains:

- The native REST Object
- A helper class for quick start
- A sample console application

To speed up the digestion of the API, I've created a helper class to wrap up the authentication, refresh and log off attributes and embedded the sub API's under a single object to be utilized.


<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.5 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later
- VMware Horizon 8

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```


## Demo Application:

The demo project & code below are a small insight into how quickly you can begin consuming data from Horizon:

``` c#
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
```
