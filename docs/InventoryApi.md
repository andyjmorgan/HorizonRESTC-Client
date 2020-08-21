# VMware.Horizon.RESTAPI.Api.InventoryApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMachines**](InventoryApi.md#addmachines) | **POST** /inventory/v1/desktop-pools/{id}/action/add-machines | Adds machines to the given manual desktop pool.
[**AddMachinesByName**](InventoryApi.md#addmachinesbyname) | **POST** /inventory/v1/desktop-pools/{id}/action/add-machines-by-name | Adds the named machines to the given desktop pool.
[**AssignUsers**](InventoryApi.md#assignusers) | **POST** /inventory/v1/machines/{id}/action/assign-users | Assigns the specified users to the machine.
[**CreateApplicationPool**](InventoryApi.md#createapplicationpool) | **POST** /inventory/v1/application-pools | Creates an application pool.
[**DeleteApplicationPool**](InventoryApi.md#deleteapplicationpool) | **DELETE** /inventory/v1/application-pools/{id} | Deletes application pool.
[**DeleteMachine**](InventoryApi.md#deletemachine) | **DELETE** /inventory/v1/machines/{id} | Deletes the machine.
[**DeleteMachines**](InventoryApi.md#deletemachines) | **DELETE** /inventory/v1/machines | Deletes the specified machines.
[**DisconnectSessions**](InventoryApi.md#disconnectsessions) | **POST** /inventory/v1/sessions/action/disconnect | Disconnects user sessions
[**EnterMaintenance**](InventoryApi.md#entermaintenance) | **POST** /inventory/v1/machines/action/enter-maintenance | Puts the machines into maintenance mode.
[**ExitMaintenance**](InventoryApi.md#exitmaintenance) | **POST** /inventory/v1/machines/action/exit-maintenance | Puts the machines out of maintenance mode.
[**GetApplicationIcon**](InventoryApi.md#getapplicationicon) | **GET** /inventory/v1/application-icons/{id} | Gets application icon.
[**GetApplicationPool**](InventoryApi.md#getapplicationpool) | **GET** /inventory/v1/application-pools/{id} | Gets application pool.
[**GetDesktopPool**](InventoryApi.md#getdesktoppool) | **GET** /inventory/v1/desktop-pools/{id} | Gets the Desktop Pool information.
[**GetDesktopPoolV2**](InventoryApi.md#getdesktoppoolv2) | **GET** /inventory/v2/desktop-pools/{id} | Gets the desktop pool information.
[**GetFarm**](InventoryApi.md#getfarm) | **GET** /inventory/v1/farms/{id} | Gets the Farm information.
[**GetMachineUsingGET**](InventoryApi.md#getmachineusingget) | **GET** /inventory/v1/machines/{id} | Gets the Machine information.
[**GetSessionInfo**](InventoryApi.md#getsessioninfo) | **GET** /inventory/v1/sessions/{id} | Gets the Session information.
[**ListApplicationIcons**](InventoryApi.md#listapplicationicons) | **GET** /inventory/v1/application-icons | Lists the application icons for the given application pool.
[**ListApplicationPools**](InventoryApi.md#listapplicationpools) | **GET** /inventory/v1/application-pools | Lists the application pools in the environment.
[**ListDesktopPools**](InventoryApi.md#listdesktoppools) | **GET** /inventory/v1/desktop-pools | Lists the Desktop Pools in the environment.
[**ListDesktopPoolsV2**](InventoryApi.md#listdesktoppoolsv2) | **GET** /inventory/v2/desktop-pools | Lists the desktop pools in the environment.
[**ListFarms**](InventoryApi.md#listfarms) | **GET** /inventory/v1/farms | Lists the Farms in the environment.
[**ListInstalledApplications**](InventoryApi.md#listinstalledapplications) | **GET** /inventory/v1/desktop-pools/{id}/installed-applications | Lists the installed applications on the given desktop pool.
[**ListInstalledApplications1**](InventoryApi.md#listinstalledapplications1) | **GET** /inventory/v1/farms/{id}/installed-applications | Lists the installed applications on the given farm.
[**ListMachinesUsingGET**](InventoryApi.md#listmachinesusingget) | **GET** /inventory/v1/machines | Lists the Machines in the environment.
[**ListSessionInfo**](InventoryApi.md#listsessioninfo) | **GET** /inventory/v1/sessions | Lists the Session information in the environment.
[**LogOffSessions**](InventoryApi.md#logoffsessions) | **POST** /inventory/v1/sessions/action/logoff | Logs off user sessions, if they are not locked.
[**RebuildMachines**](InventoryApi.md#rebuildmachines) | **POST** /inventory/v1/machines/action/rebuild | Rebuilds the specified machines.
[**RecoverMachines**](InventoryApi.md#recovermachines) | **POST** /inventory/v1/machines/action/recover | Recovers the specified machines.
[**RemoveMachines**](InventoryApi.md#removemachines) | **POST** /inventory/v1/desktop-pools/{id}/action/remove-machines | Removes machines from the given manual desktop pool.
[**ResetMachines**](InventoryApi.md#resetmachines) | **POST** /inventory/v1/machines/action/reset | Resets the specified machines.
[**ResetSessions**](InventoryApi.md#resetsessions) | **POST** /inventory/v1/sessions/action/reset | Resets machine of user sessions. The machine must be managed by Virtual Center and the session cannot be an application or an RDS desktop session.
[**RestartMachines**](InventoryApi.md#restartmachines) | **POST** /inventory/v1/machines/action/restart | Restarts the specified machines.
[**RestartSessions**](InventoryApi.md#restartsessions) | **POST** /inventory/v1/sessions/action/restart | Restarts machine of user sessions. The machine must be managed by Virtual Center and the session cannot be an application or an RDS desktop session.
[**SendMessageToSessions**](InventoryApi.md#sendmessagetosessions) | **POST** /inventory/v1/sessions/action/send-message | Sends the message to user sessions
[**UnassignUsers**](InventoryApi.md#unassignusers) | **POST** /inventory/v1/machines/{id}/action/unassign-users | Un-assigns the specified users from the machine.
[**UpdateApplicationPool**](InventoryApi.md#updateapplicationpool) | **PUT** /inventory/v1/application-pools/{id} | Updates application pool.


<a name="addmachines"></a>
# **AddMachines**
> List<BulkItemResponseInfo> AddMachines (List<string> body, string id)

Adds machines to the given manual desktop pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class AddMachinesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of Machine Ids representing the machines to be added to the desktop pool.
            var id = id_example;  // string | id

            try
            {
                // Adds machines to the given manual desktop pool.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.AddMachines(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.AddMachines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of Machine Ids representing the machines to be added to the desktop pool. | 
 **id** | **string**| id | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmachinesbyname"></a>
# **AddMachinesByName**
> List<BulkItemResponseInfo> AddMachinesByName (List<MachineSpecifiedName> body, string id)

Adds the named machines to the given desktop pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class AddMachinesByNameExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = new List<MachineSpecifiedName>(); // List<MachineSpecifiedName> | List of MachineSpecifiedName representing the machines to be added to the desktop pool.
            var id = id_example;  // string | id

            try
            {
                // Adds the named machines to the given desktop pool.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.AddMachinesByName(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.AddMachinesByName: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;MachineSpecifiedName&gt;**](MachineSpecifiedName.md)| List of MachineSpecifiedName representing the machines to be added to the desktop pool. | 
 **id** | **string**| id | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="assignusers"></a>
# **AssignUsers**
> List<BulkItemResponseInfo> AssignUsers (List<string> body, string id)

Assigns the specified users to the machine.

Each response entity in the result corresponds to a user SID in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class AssignUsersExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of User SIDs representing the users to be assigned to the machine.
            var id = id_example;  // string | id

            try
            {
                // Assigns the specified users to the machine.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.AssignUsers(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.AssignUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of User SIDs representing the users to be assigned to the machine. | 
 **id** | **string**| id | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createapplicationpool"></a>
# **CreateApplicationPool**
> void CreateApplicationPool (ApplicationPoolCreateSpec body)

Creates an application pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateApplicationPoolExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = new ApplicationPoolCreateSpec(); // ApplicationPoolCreateSpec | Application pool object to be created.

            try
            {
                // Creates an application pool.
                apiInstance.CreateApplicationPool(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.CreateApplicationPool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationPoolCreateSpec**](ApplicationPoolCreateSpec.md)| Application pool object to be created. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteapplicationpool"></a>
# **DeleteApplicationPool**
> void DeleteApplicationPool (string id)

Deletes application pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class DeleteApplicationPoolExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Deletes application pool.
                apiInstance.DeleteApplicationPool(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.DeleteApplicationPool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemachine"></a>
# **DeleteMachine**
> void DeleteMachine (MachineDeleteData body, string id)

Deletes the machine.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class DeleteMachineExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = new MachineDeleteData(); // MachineDeleteData | The specification applicable to deleting the machine.
            var id = id_example;  // string | id

            try
            {
                // Deletes the machine.
                apiInstance.DeleteMachine(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.DeleteMachine: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MachineDeleteData**](MachineDeleteData.md)| The specification applicable to deleting the machine. | 
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemachines"></a>
# **DeleteMachines**
> List<BulkItemResponseInfo> DeleteMachines (MachineDeleteSpec body)

Deletes the specified machines.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class DeleteMachinesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = new MachineDeleteSpec(); // MachineDeleteSpec | The machines and specification for deletion.

            try
            {
                // Deletes the specified machines.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.DeleteMachines(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.DeleteMachines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MachineDeleteSpec**](MachineDeleteSpec.md)| The machines and specification for deletion. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disconnectsessions"></a>
# **DisconnectSessions**
> List<BulkItemResponseInfo> DisconnectSessions (List<string> body)

Disconnects user sessions

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class DisconnectSessionsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of session ids to be disconnected.

            try
            {
                // Disconnects user sessions
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.DisconnectSessions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.DisconnectSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of session ids to be disconnected. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="entermaintenance"></a>
# **EnterMaintenance**
> List<BulkItemResponseInfo> EnterMaintenance (List<string> body)

Puts the machines into maintenance mode.

When in maintenance mode, users cannot access the machines. Each response entity in the result corresponds to a machine id in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class EnterMaintenanceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of Machine Ids representing the machines to be put into maintenance mode.

            try
            {
                // Puts the machines into maintenance mode.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.EnterMaintenance(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.EnterMaintenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of Machine Ids representing the machines to be put into maintenance mode. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="exitmaintenance"></a>
# **ExitMaintenance**
> List<BulkItemResponseInfo> ExitMaintenance (List<string> body)

Puts the machines out of maintenance mode.

Each response entity in the result corresponds to a machine id in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ExitMaintenanceExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of Machine Ids representing the machines to be put out of maintenance mode.

            try
            {
                // Puts the machines out of maintenance mode.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.ExitMaintenance(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ExitMaintenance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of Machine Ids representing the machines to be put out of maintenance mode. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationicon"></a>
# **GetApplicationIcon**
> ApplicationIconInfo GetApplicationIcon (string id)

Gets application icon.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetApplicationIconExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Gets application icon.
                ApplicationIconInfo result = apiInstance.GetApplicationIcon(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetApplicationIcon: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**ApplicationIconInfo**](ApplicationIconInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationpool"></a>
# **GetApplicationPool**
> ApplicationPoolInfo GetApplicationPool (string id)

Gets application pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetApplicationPoolExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Gets application pool.
                ApplicationPoolInfo result = apiInstance.GetApplicationPool(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetApplicationPool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**ApplicationPoolInfo**](ApplicationPoolInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdesktoppool"></a>
# **GetDesktopPool**
> DesktopPoolInfo GetDesktopPool (string id)

Gets the Desktop Pool information.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetDesktopPoolExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Gets the Desktop Pool information.
                DesktopPoolInfo result = apiInstance.GetDesktopPool(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetDesktopPool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**DesktopPoolInfo**](DesktopPoolInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdesktoppoolv2"></a>
# **GetDesktopPoolV2**
> DesktopPoolInfoV2 GetDesktopPoolV2 (string id)

Gets the desktop pool information.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetDesktopPoolV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Gets the desktop pool information.
                DesktopPoolInfoV2 result = apiInstance.GetDesktopPoolV2(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetDesktopPoolV2: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**DesktopPoolInfoV2**](DesktopPoolInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfarm"></a>
# **GetFarm**
> FarmInfo GetFarm (string id)

Gets the Farm information.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetFarmExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Gets the Farm information.
                FarmInfo result = apiInstance.GetFarm(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetFarm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**FarmInfo**](FarmInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmachineusingget"></a>
# **GetMachineUsingGET**
> MachineInfo GetMachineUsingGET (string id)

Gets the Machine information.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetMachineUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Gets the Machine information.
                MachineInfo result = apiInstance.GetMachineUsingGET(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetMachineUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**MachineInfo**](MachineInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsessioninfo"></a>
# **GetSessionInfo**
> SessionInfo GetSessionInfo (string id)

Gets the Session information.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetSessionInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Gets the Session information.
                SessionInfo result = apiInstance.GetSessionInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.GetSessionInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**SessionInfo**](SessionInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapplicationicons"></a>
# **ListApplicationIcons**
> List<ApplicationIconInfo> ListApplicationIcons (string applicationPoolId)

Lists the application icons for the given application pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListApplicationIconsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var applicationPoolId = applicationPoolId_example;  // string | Application Pool ID

            try
            {
                // Lists the application icons for the given application pool.
                List&lt;ApplicationIconInfo&gt; result = apiInstance.ListApplicationIcons(applicationPoolId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListApplicationIcons: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **applicationPoolId** | **string**| Application Pool ID | 

### Return type

[**List<ApplicationIconInfo>**](ApplicationIconInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapplicationpools"></a>
# **ListApplicationPools**
> List<ApplicationPoolInfo> ListApplicationPools ()

Lists the application pools in the environment.

This API supports <b>Pagination</b> and <b>Filters.</b><br/>For Pagination, optional query params of 'page' and 'size' needs to be send.<br/>For filters, refer to 'ApplicationPoolInfo' model description to find supported filters on specific field.<br/>For full information on using filters, refer to 'Horizon Server REST Pagination and Filter Guide' of 'VMware Horizon Server API' in code.vmware.com

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListApplicationPoolsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();

            try
            {
                // Lists the application pools in the environment.
                List&lt;ApplicationPoolInfo&gt; result = apiInstance.ListApplicationPools();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListApplicationPools: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ApplicationPoolInfo>**](ApplicationPoolInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdesktoppools"></a>
# **ListDesktopPools**
> List<DesktopPoolInfo> ListDesktopPools ()

Lists the Desktop Pools in the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListDesktopPoolsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();

            try
            {
                // Lists the Desktop Pools in the environment.
                List&lt;DesktopPoolInfo&gt; result = apiInstance.ListDesktopPools();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListDesktopPools: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DesktopPoolInfo>**](DesktopPoolInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdesktoppoolsv2"></a>
# **ListDesktopPoolsV2**
> List<DesktopPoolInfoV2> ListDesktopPoolsV2 ()

Lists the desktop pools in the environment.

This API supports <b>Pagination</b>.<br/>For Pagination, optional query params of 'page' and 'size' needs to be send.<br/>

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListDesktopPoolsV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();

            try
            {
                // Lists the desktop pools in the environment.
                List&lt;DesktopPoolInfoV2&gt; result = apiInstance.ListDesktopPoolsV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListDesktopPoolsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<DesktopPoolInfoV2>**](DesktopPoolInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfarms"></a>
# **ListFarms**
> List<FarmInfo> ListFarms ()

Lists the Farms in the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListFarmsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();

            try
            {
                // Lists the Farms in the environment.
                List&lt;FarmInfo&gt; result = apiInstance.ListFarms();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListFarms: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FarmInfo>**](FarmInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinstalledapplications"></a>
# **ListInstalledApplications**
> List<InstalledApplicationInfo> ListInstalledApplications (string id)

Lists the installed applications on the given desktop pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListInstalledApplicationsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Lists the installed applications on the given desktop pool.
                List&lt;InstalledApplicationInfo&gt; result = apiInstance.ListInstalledApplications(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListInstalledApplications: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**List<InstalledApplicationInfo>**](InstalledApplicationInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listinstalledapplications1"></a>
# **ListInstalledApplications1**
> List<InstalledApplicationInfo> ListInstalledApplications1 (string id)

Lists the installed applications on the given farm.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListInstalledApplications1Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var id = id_example;  // string | id

            try
            {
                // Lists the installed applications on the given farm.
                List&lt;InstalledApplicationInfo&gt; result = apiInstance.ListInstalledApplications1(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListInstalledApplications1: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| id | 

### Return type

[**List<InstalledApplicationInfo>**](InstalledApplicationInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listmachinesusingget"></a>
# **ListMachinesUsingGET**
> List<MachineInfo> ListMachinesUsingGET ()

Lists the Machines in the environment.

This API supports <b>Pagination</b> and <b>Filters.</b><br/>For Pagination, optional query params of 'page' and 'size' need to be sent.<br/>For Filters, refer to 'MachineInfo' model description to find supported filters on specific field.<br/>For full information on using Filters, refer to 'Horizon Server REST Pagination and Filter Guide' of 'VMware Horizon Server API' in code.vmware.com

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListMachinesUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();

            try
            {
                // Lists the Machines in the environment.
                List&lt;MachineInfo&gt; result = apiInstance.ListMachinesUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListMachinesUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MachineInfo>**](MachineInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsessioninfo"></a>
# **ListSessionInfo**
> List<SessionInfo> ListSessionInfo ()

Lists the Session information in the environment.

This API supports <b>Pagination</b>.<br/>For Pagination, optional query params of 'page' and 'size' needs to be send.<br/>

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListSessionInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();

            try
            {
                // Lists the Session information in the environment.
                List&lt;SessionInfo&gt; result = apiInstance.ListSessionInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ListSessionInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SessionInfo>**](SessionInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logoffsessions"></a>
# **LogOffSessions**
> List<BulkItemResponseInfo> LogOffSessions (List<string> body, bool? forced = null)

Logs off user sessions, if they are not locked.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class LogOffSessionsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of session ids to be logged off.
            var forced = true;  // bool? | Indicates to Log off session forcibly.  If passed as \"true\", then sessions are logoff forcibly, even if they are locked.  If passed as \"false\" or not passed at all, then sessions will be normally logged off, if they are not locked. (optional)  (default to false)

            try
            {
                // Logs off user sessions, if they are not locked.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.LogOffSessions(body, forced);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.LogOffSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of session ids to be logged off. | 
 **forced** | **bool?**| Indicates to Log off session forcibly.  If passed as \&quot;true\&quot;, then sessions are logoff forcibly, even if they are locked.  If passed as \&quot;false\&quot; or not passed at all, then sessions will be normally logged off, if they are not locked. | [optional] [default to false]

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rebuildmachines"></a>
# **RebuildMachines**
> List<BulkItemResponseInfo> RebuildMachines (List<string> body)

Rebuilds the specified machines.

Each response entity in the result corresponds to a machine id in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class RebuildMachinesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of Machine Ids representing the machines to be rebuilt.

            try
            {
                // Rebuilds the specified machines.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.RebuildMachines(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.RebuildMachines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of Machine Ids representing the machines to be rebuilt. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="recovermachines"></a>
# **RecoverMachines**
> List<BulkItemResponseInfo> RecoverMachines (List<string> body)

Recovers the specified machines.

Each response entity in the result corresponds to a machine id in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class RecoverMachinesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of Machine Ids representing the machines to be recovered.

            try
            {
                // Recovers the specified machines.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.RecoverMachines(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.RecoverMachines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of Machine Ids representing the machines to be recovered. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removemachines"></a>
# **RemoveMachines**
> List<BulkItemResponseInfo> RemoveMachines (List<string> body, string id)

Removes machines from the given manual desktop pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class RemoveMachinesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of Machine Ids representing the machines to be removed from the desktop pool.
            var id = id_example;  // string | id

            try
            {
                // Removes machines from the given manual desktop pool.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.RemoveMachines(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.RemoveMachines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of Machine Ids representing the machines to be removed from the desktop pool. | 
 **id** | **string**| id | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetmachines"></a>
# **ResetMachines**
> List<BulkItemResponseInfo> ResetMachines (List<string> body)

Resets the specified machines.

Each response entity in the result corresponds to a machine id in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ResetMachinesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of Machine Ids representing the machines to be reset.

            try
            {
                // Resets the specified machines.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.ResetMachines(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ResetMachines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of Machine Ids representing the machines to be reset. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="resetsessions"></a>
# **ResetSessions**
> List<BulkItemResponseInfo> ResetSessions (List<string> body)

Resets machine of user sessions. The machine must be managed by Virtual Center and the session cannot be an application or an RDS desktop session.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ResetSessionsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of session ids to be reset.

            try
            {
                // Resets machine of user sessions. The machine must be managed by Virtual Center and the session cannot be an application or an RDS desktop session.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.ResetSessions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.ResetSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of session ids to be reset. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restartmachines"></a>
# **RestartMachines**
> List<BulkItemResponseInfo> RestartMachines (List<string> body)

Restarts the specified machines.

Each response entity in the result corresponds to a machine id in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class RestartMachinesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of Machine Ids representing the machines to be restarted.

            try
            {
                // Restarts the specified machines.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.RestartMachines(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.RestartMachines: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of Machine Ids representing the machines to be restarted. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restartsessions"></a>
# **RestartSessions**
> List<BulkItemResponseInfo> RestartSessions (List<string> body)

Restarts machine of user sessions. The machine must be managed by Virtual Center and the session cannot be an application or an RDS desktop session.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class RestartSessionsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of session ids to be restarted.

            try
            {
                // Restarts machine of user sessions. The machine must be managed by Virtual Center and the session cannot be an application or an RDS desktop session.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.RestartSessions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.RestartSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of session ids to be restarted. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendmessagetosessions"></a>
# **SendMessageToSessions**
> List<BulkItemResponseInfo> SendMessageToSessions (SessionSendMessageSpec body)

Sends the message to user sessions

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class SendMessageToSessionsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = new SessionSendMessageSpec(); // SessionSendMessageSpec | Message information object to be sent to sessions.

            try
            {
                // Sends the message to user sessions
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.SendMessageToSessions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.SendMessageToSessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SessionSendMessageSpec**](SessionSendMessageSpec.md)| Message information object to be sent to sessions. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unassignusers"></a>
# **UnassignUsers**
> List<BulkItemResponseInfo> UnassignUsers (List<string> body, string id)

Un-assigns the specified users from the machine.

Each response entity in the result corresponds to a user SID in the input.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UnassignUsersExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = ;  // List<string> | List of User SIDs representing the users to be un-assigned from the machine.
            var id = id_example;  // string | id

            try
            {
                // Un-assigns the specified users from the machine.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.UnassignUsers(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.UnassignUsers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **List&lt;string&gt;**| List of User SIDs representing the users to be un-assigned from the machine. | 
 **id** | **string**| id | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateapplicationpool"></a>
# **UpdateApplicationPool**
> void UpdateApplicationPool (ApplicationPoolUpdateSpec body, string id)

Updates application pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateApplicationPoolExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InventoryApi();
            var body = new ApplicationPoolUpdateSpec(); // ApplicationPoolUpdateSpec | Application pool object to be updated.
            var id = id_example;  // string | id

            try
            {
                // Updates application pool.
                apiInstance.UpdateApplicationPool(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InventoryApi.UpdateApplicationPool: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApplicationPoolUpdateSpec**](ApplicationPoolUpdateSpec.md)| Application pool object to be updated. | 
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

