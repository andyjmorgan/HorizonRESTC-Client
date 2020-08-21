# VMware.Horizon.RESTAPI.Api.EntitlementsApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkCreateApplicationPoolEntitlements**](EntitlementsApi.md#bulkcreateapplicationpoolentitlements) | **POST** /entitlements/v1/application-pools | Create the bulk entitlements for a set of application pools
[**BulkCreateDesktopPoolEntitlements**](EntitlementsApi.md#bulkcreatedesktoppoolentitlements) | **POST** /entitlements/v1/desktop-pools | Create the bulk entitlements for a set of desktop pools
[**BulkDeleteApplicationPoolEntitlements**](EntitlementsApi.md#bulkdeleteapplicationpoolentitlements) | **DELETE** /entitlements/v1/application-pools | Delete the bulk entitlements for a set of application pools
[**BulkDeleteDesktopPoolEntitlements**](EntitlementsApi.md#bulkdeletedesktoppoolentitlements) | **DELETE** /entitlements/v1/desktop-pools | Delete the bulk entitlements for a set of desktop pools
[**GetApplicationPoolEntitlements**](EntitlementsApi.md#getapplicationpoolentitlements) | **GET** /entitlements/v1/application-pools/{id} | Returns the IDs of users or groups entitled to a given application pool.
[**GetDesktopPoolEntitlements**](EntitlementsApi.md#getdesktoppoolentitlements) | **GET** /entitlements/v1/desktop-pools/{id} | Returns the IDs of users or groups entitled to a given desktop pool.
[**ListApplicationPoolEntitlements**](EntitlementsApi.md#listapplicationpoolentitlements) | **GET** /entitlements/v1/application-pools | Lists the entitlements for Application Pools in the environment.
[**ListDesktopPoolEntitlements**](EntitlementsApi.md#listdesktoppoolentitlements) | **GET** /entitlements/v1/desktop-pools | Lists the entitlements for Desktop Pools in the environment.


<a name="bulkcreateapplicationpoolentitlements"></a>
# **BulkCreateApplicationPoolEntitlements**
> List<BulkEntitlementResponseInfo> BulkCreateApplicationPoolEntitlements (List<EntitlementSpec> body)

Create the bulk entitlements for a set of application pools

The input spec must not contain duplicate Ids.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class BulkCreateApplicationPoolEntitlementsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EntitlementsApi();
            var body = new List<EntitlementSpec>(); // List<EntitlementSpec> | Specifications for bulk application entitlements to be created.

            try
            {
                // Create the bulk entitlements for a set of application pools
                List&lt;BulkEntitlementResponseInfo&gt; result = apiInstance.BulkCreateApplicationPoolEntitlements(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntitlementsApi.BulkCreateApplicationPoolEntitlements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;EntitlementSpec&gt;**](EntitlementSpec.md)| Specifications for bulk application entitlements to be created. | 

### Return type

[**List<BulkEntitlementResponseInfo>**](BulkEntitlementResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkcreatedesktoppoolentitlements"></a>
# **BulkCreateDesktopPoolEntitlements**
> List<BulkEntitlementResponseInfo> BulkCreateDesktopPoolEntitlements (List<EntitlementSpec> body)

Create the bulk entitlements for a set of desktop pools

The input spec must not contain duplicate Ids.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class BulkCreateDesktopPoolEntitlementsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EntitlementsApi();
            var body = new List<EntitlementSpec>(); // List<EntitlementSpec> | Specifications for bulk desktop entitlements to be created.

            try
            {
                // Create the bulk entitlements for a set of desktop pools
                List&lt;BulkEntitlementResponseInfo&gt; result = apiInstance.BulkCreateDesktopPoolEntitlements(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntitlementsApi.BulkCreateDesktopPoolEntitlements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;EntitlementSpec&gt;**](EntitlementSpec.md)| Specifications for bulk desktop entitlements to be created. | 

### Return type

[**List<BulkEntitlementResponseInfo>**](BulkEntitlementResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkdeleteapplicationpoolentitlements"></a>
# **BulkDeleteApplicationPoolEntitlements**
> List<BulkEntitlementResponseInfo> BulkDeleteApplicationPoolEntitlements (List<EntitlementSpec> body)

Delete the bulk entitlements for a set of application pools

The input spec must not contain duplicate Ids.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class BulkDeleteApplicationPoolEntitlementsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EntitlementsApi();
            var body = new List<EntitlementSpec>(); // List<EntitlementSpec> | Specifications for bulk application entitlements to be deleted.

            try
            {
                // Delete the bulk entitlements for a set of application pools
                List&lt;BulkEntitlementResponseInfo&gt; result = apiInstance.BulkDeleteApplicationPoolEntitlements(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntitlementsApi.BulkDeleteApplicationPoolEntitlements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;EntitlementSpec&gt;**](EntitlementSpec.md)| Specifications for bulk application entitlements to be deleted. | 

### Return type

[**List<BulkEntitlementResponseInfo>**](BulkEntitlementResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkdeletedesktoppoolentitlements"></a>
# **BulkDeleteDesktopPoolEntitlements**
> List<BulkEntitlementResponseInfo> BulkDeleteDesktopPoolEntitlements (List<EntitlementSpec> body)

Delete the bulk entitlements for a set of desktop pools

The input spec must not contain duplicate Ids.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class BulkDeleteDesktopPoolEntitlementsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EntitlementsApi();
            var body = new List<EntitlementSpec>(); // List<EntitlementSpec> | Specifications for bulk desktop entitlements to be deleted.

            try
            {
                // Delete the bulk entitlements for a set of desktop pools
                List&lt;BulkEntitlementResponseInfo&gt; result = apiInstance.BulkDeleteDesktopPoolEntitlements(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntitlementsApi.BulkDeleteDesktopPoolEntitlements: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;EntitlementSpec&gt;**](EntitlementSpec.md)| Specifications for bulk desktop entitlements to be deleted. | 

### Return type

[**List<BulkEntitlementResponseInfo>**](BulkEntitlementResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getapplicationpoolentitlements"></a>
# **GetApplicationPoolEntitlements**
> EntitlementInfo GetApplicationPoolEntitlements (string id)

Returns the IDs of users or groups entitled to a given application pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetApplicationPoolEntitlementsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EntitlementsApi();
            var id = id_example;  // string | id

            try
            {
                // Returns the IDs of users or groups entitled to a given application pool.
                EntitlementInfo result = apiInstance.GetApplicationPoolEntitlements(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntitlementsApi.GetApplicationPoolEntitlements: " + e.Message );
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

[**EntitlementInfo**](EntitlementInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdesktoppoolentitlements"></a>
# **GetDesktopPoolEntitlements**
> EntitlementInfo GetDesktopPoolEntitlements (string id)

Returns the IDs of users or groups entitled to a given desktop pool.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetDesktopPoolEntitlementsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EntitlementsApi();
            var id = id_example;  // string | id

            try
            {
                // Returns the IDs of users or groups entitled to a given desktop pool.
                EntitlementInfo result = apiInstance.GetDesktopPoolEntitlements(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntitlementsApi.GetDesktopPoolEntitlements: " + e.Message );
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

[**EntitlementInfo**](EntitlementInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listapplicationpoolentitlements"></a>
# **ListApplicationPoolEntitlements**
> List<EntitlementInfo> ListApplicationPoolEntitlements ()

Lists the entitlements for Application Pools in the environment.

This API supports <b>Pagination</b> and <b>Filters.</b><br/>For Pagination, optional query params of 'page' and 'size' need to be sent.<br/>For Filters, refer to 'EntitlementInfo' model description to find supported filters on specific field.<br/>For full information on using Filters, refer to 'Horizon Server REST Pagination and Filter Guide' of 'VMware Horizon Server API' in documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListApplicationPoolEntitlementsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EntitlementsApi();

            try
            {
                // Lists the entitlements for Application Pools in the environment.
                List&lt;EntitlementInfo&gt; result = apiInstance.ListApplicationPoolEntitlements();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntitlementsApi.ListApplicationPoolEntitlements: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<EntitlementInfo>**](EntitlementInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdesktoppoolentitlements"></a>
# **ListDesktopPoolEntitlements**
> List<EntitlementInfo> ListDesktopPoolEntitlements ()

Lists the entitlements for Desktop Pools in the environment.

This API supports <b>Pagination</b> and <b>Filters.</b><br/>For Pagination, optional query params of 'page' and 'size' need to be sent.<br/>For Filters, refer to 'EntitlementInfo' model description to find supported filters on specific field.<br/>For full information on using Filters, refer to 'Horizon Server REST Pagination and Filter Guide' of 'VMware Horizon Server API' in documentation.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListDesktopPoolEntitlementsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new EntitlementsApi();

            try
            {
                // Lists the entitlements for Desktop Pools in the environment.
                List&lt;EntitlementInfo&gt; result = apiInstance.ListDesktopPoolEntitlements();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntitlementsApi.ListDesktopPoolEntitlements: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<EntitlementInfo>**](EntitlementInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

