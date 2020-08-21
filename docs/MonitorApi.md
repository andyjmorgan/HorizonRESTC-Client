# VMware.Horizon.RESTAPI.Api.MonitorApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetConnectionServerMonitorInfoV2**](MonitorApi.md#getconnectionservermonitorinfov2) | **GET** /monitor/v1/connection-servers/{id} | Gets monitoring information related to Connection Server.
[**GetEventDatabaseMonitor**](MonitorApi.md#geteventdatabasemonitor) | **GET** /monitor/event-database | Returns monitoring information related to Event database of the environment.
[**GetFarmMonitorInfo**](MonitorApi.md#getfarmmonitorinfo) | **GET** /monitor/v1/farms/{id} | Gets monitoring information related to farm.
[**GetGatewayMonitorInfo**](MonitorApi.md#getgatewaymonitorinfo) | **GET** /monitor/v1/gateways/{id} | Gets monitoring information related to a Gateway.
[**GetPodMonitorInfoV2**](MonitorApi.md#getpodmonitorinfov2) | **GET** /monitor/v1/pods/{id} | Gets monitoring information related to the remote pod.
[**GetRDSServerMonitors**](MonitorApi.md#getrdsservermonitors) | **GET** /monitor/v1/rds-servers/{id} | Gets monitoring information related to RDS Server.
[**GetSAMLAuthenticatorMonitorInfo**](MonitorApi.md#getsamlauthenticatormonitorinfo) | **GET** /monitor/v1/saml-authenticators/{id} | Gets Monitoring Information related to a SAML Authenticator
[**GetTrueSSOMonitorInfo**](MonitorApi.md#gettruessomonitorinfo) | **GET** /monitor/v1/true-sso/{id} | Gets monitoring information related to a True SSO connector.
[**GetViewComposerByVCId**](MonitorApi.md#getviewcomposerbyvcid) | **GET** /monitor/v1/view-composers/{vcId} | Gets monitoring information of view composer for a given virtual center
[**GetVirtualCenterMonitorInfo**](MonitorApi.md#getvirtualcentermonitorinfo) | **GET** /monitor/v1/virtual-centers/{id} | Gets monitoring information related to Virtual Center.
[**ListADDomainMonitorInfosV2**](MonitorApi.md#listaddomainmonitorinfosv2) | **GET** /monitor/v2/ad-domains | Lists monitoring information related to AD Domains of the environment.
[**ListADDomainMonitors**](MonitorApi.md#listaddomainmonitors) | **GET** /monitor/ad-domains | Lists monitoring information related to AD Domains of the environment.
[**ListConnectionServerMonitors**](MonitorApi.md#listconnectionservermonitors) | **GET** /monitor/connection-servers | Lists monitoring information related to Connection Servers of the environment.
[**ListConnectionServerMonitorsV2**](MonitorApi.md#listconnectionservermonitorsv2) | **GET** /monitor/v2/connection-servers | Lists monitoring information related to Connection Servers of the environment.
[**ListFarmMonitors**](MonitorApi.md#listfarmmonitors) | **GET** /monitor/farms | Lists monitoring information related to Farms of the environment.
[**ListGatewayMonitorInfoV1**](MonitorApi.md#listgatewaymonitorinfov1) | **GET** /monitor/gateways | Lists monitoring information related to Gateways registered in the environment.
[**ListGatewayMonitorInfoV2**](MonitorApi.md#listgatewaymonitorinfov2) | **GET** /monitor/v2/gateways | Lists monitoring information related to Gateways registered in the environment.
[**ListPodMonitorInfosV1**](MonitorApi.md#listpodmonitorinfosv1) | **GET** /monitor/v1/pods | Lists monitoring information related to the remote pods.
[**ListPodMonitorInfosV2**](MonitorApi.md#listpodmonitorinfosv2) | **GET** /monitor/v2/pods | Lists monitoring information related to the remote pods.
[**ListRDSServerMonitors**](MonitorApi.md#listrdsservermonitors) | **GET** /monitor/rds-servers | Lists monitoring information related to RDS Servers of the environment.
[**ListSAMLAuthenticatorMonitorsV1**](MonitorApi.md#listsamlauthenticatormonitorsv1) | **GET** /monitor/saml-authenticators | Lists monitoring information related to SAML Authenticators of the environment.
[**ListSAMLAuthenticatorMonitorsV2**](MonitorApi.md#listsamlauthenticatormonitorsv2) | **GET** /monitor/v2/saml-authenticators | Lists monitoring information related to SAML Authenticators of the environment.
[**ListTrueSSOMonitorInfos**](MonitorApi.md#listtruessomonitorinfos) | **GET** /monitor/v1/true-sso | Lists monitoring information related to True SSO connectors.
[**ListViewComposerMonitorsV1**](MonitorApi.md#listviewcomposermonitorsv1) | **GET** /monitor/view-composers | Lists monitoring information related to View Composers of the environment.
[**ListViewComposerMonitorsV2**](MonitorApi.md#listviewcomposermonitorsv2) | **GET** /monitor/v2/view-composers | Lists monitoring information related to View Composers of the environment.
[**ListVirtualCenterMonitors**](MonitorApi.md#listvirtualcentermonitors) | **GET** /monitor/virtual-centers | Lists monitoring information related to Virtual Centers of the environment.
[**ListVirtualCenterMonitorsV2**](MonitorApi.md#listvirtualcentermonitorsv2) | **GET** /monitor/v2/virtual-centers | Lists monitoring information related to Virtual Centers of the environment.


<a name="getconnectionservermonitorinfov2"></a>
# **GetConnectionServerMonitorInfoV2**
> ConnectionServerMonitorInfoV2 GetConnectionServerMonitorInfoV2 (string id)

Gets monitoring information related to Connection Server.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetConnectionServerMonitorInfoV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();
            var id = id_example;  // string | id

            try
            {
                // Gets monitoring information related to Connection Server.
                ConnectionServerMonitorInfoV2 result = apiInstance.GetConnectionServerMonitorInfoV2(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetConnectionServerMonitorInfoV2: " + e.Message );
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

[**ConnectionServerMonitorInfoV2**](ConnectionServerMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geteventdatabasemonitor"></a>
# **GetEventDatabaseMonitor**
> EventDatabaseMonitorInfo GetEventDatabaseMonitor ()

Returns monitoring information related to Event database of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetEventDatabaseMonitorExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Returns monitoring information related to Event database of the environment.
                EventDatabaseMonitorInfo result = apiInstance.GetEventDatabaseMonitor();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetEventDatabaseMonitor: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**EventDatabaseMonitorInfo**](EventDatabaseMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfarmmonitorinfo"></a>
# **GetFarmMonitorInfo**
> FarmMonitorInfo GetFarmMonitorInfo (string id)

Gets monitoring information related to farm.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetFarmMonitorInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();
            var id = id_example;  // string | id

            try
            {
                // Gets monitoring information related to farm.
                FarmMonitorInfo result = apiInstance.GetFarmMonitorInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetFarmMonitorInfo: " + e.Message );
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

[**FarmMonitorInfo**](FarmMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgatewaymonitorinfo"></a>
# **GetGatewayMonitorInfo**
> GatewayMonitorInfoV2 GetGatewayMonitorInfo (string id)

Gets monitoring information related to a Gateway.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetGatewayMonitorInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();
            var id = id_example;  // string | id

            try
            {
                // Gets monitoring information related to a Gateway.
                GatewayMonitorInfoV2 result = apiInstance.GetGatewayMonitorInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetGatewayMonitorInfo: " + e.Message );
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

[**GatewayMonitorInfoV2**](GatewayMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpodmonitorinfov2"></a>
# **GetPodMonitorInfoV2**
> PodMonitorInfoV2 GetPodMonitorInfoV2 (string id)

Gets monitoring information related to the remote pod.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetPodMonitorInfoV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();
            var id = id_example;  // string | id

            try
            {
                // Gets monitoring information related to the remote pod.
                PodMonitorInfoV2 result = apiInstance.GetPodMonitorInfoV2(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetPodMonitorInfoV2: " + e.Message );
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

[**PodMonitorInfoV2**](PodMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrdsservermonitors"></a>
# **GetRDSServerMonitors**
> RDSServerMonitorInfo GetRDSServerMonitors (string id)

Gets monitoring information related to RDS Server.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetRDSServerMonitorsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();
            var id = id_example;  // string | id

            try
            {
                // Gets monitoring information related to RDS Server.
                RDSServerMonitorInfo result = apiInstance.GetRDSServerMonitors(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetRDSServerMonitors: " + e.Message );
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

[**RDSServerMonitorInfo**](RDSServerMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsamlauthenticatormonitorinfo"></a>
# **GetSAMLAuthenticatorMonitorInfo**
> SAMLAuthenticatorMonitorInfoV2 GetSAMLAuthenticatorMonitorInfo (string id)

Gets Monitoring Information related to a SAML Authenticator

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetSAMLAuthenticatorMonitorInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();
            var id = id_example;  // string | id

            try
            {
                // Gets Monitoring Information related to a SAML Authenticator
                SAMLAuthenticatorMonitorInfoV2 result = apiInstance.GetSAMLAuthenticatorMonitorInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetSAMLAuthenticatorMonitorInfo: " + e.Message );
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

[**SAMLAuthenticatorMonitorInfoV2**](SAMLAuthenticatorMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettruessomonitorinfo"></a>
# **GetTrueSSOMonitorInfo**
> TrueSSOMonitorInfo GetTrueSSOMonitorInfo (string id)

Gets monitoring information related to a True SSO connector.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetTrueSSOMonitorInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();
            var id = id_example;  // string | id

            try
            {
                // Gets monitoring information related to a True SSO connector.
                TrueSSOMonitorInfo result = apiInstance.GetTrueSSOMonitorInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetTrueSSOMonitorInfo: " + e.Message );
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

[**TrueSSOMonitorInfo**](TrueSSOMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getviewcomposerbyvcid"></a>
# **GetViewComposerByVCId**
> ViewComposerMonitorInfoV2 GetViewComposerByVCId (string vcId)

Gets monitoring information of view composer for a given virtual center

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetViewComposerByVCIdExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();
            var vcId = vcId_example;  // string | vcId

            try
            {
                // Gets monitoring information of view composer for a given virtual center
                ViewComposerMonitorInfoV2 result = apiInstance.GetViewComposerByVCId(vcId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetViewComposerByVCId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcId** | **string**| vcId | 

### Return type

[**ViewComposerMonitorInfoV2**](ViewComposerMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getvirtualcentermonitorinfo"></a>
# **GetVirtualCenterMonitorInfo**
> VirtualCenterMonitorInfoV2 GetVirtualCenterMonitorInfo (string id)

Gets monitoring information related to Virtual Center.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetVirtualCenterMonitorInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();
            var id = id_example;  // string | id

            try
            {
                // Gets monitoring information related to Virtual Center.
                VirtualCenterMonitorInfoV2 result = apiInstance.GetVirtualCenterMonitorInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.GetVirtualCenterMonitorInfo: " + e.Message );
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

[**VirtualCenterMonitorInfoV2**](VirtualCenterMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaddomainmonitorinfosv2"></a>
# **ListADDomainMonitorInfosV2**
> List<ADDomainMonitorInfoV2> ListADDomainMonitorInfosV2 ()

Lists monitoring information related to AD Domains of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListADDomainMonitorInfosV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to AD Domains of the environment.
                List&lt;ADDomainMonitorInfoV2&gt; result = apiInstance.ListADDomainMonitorInfosV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListADDomainMonitorInfosV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ADDomainMonitorInfoV2>**](ADDomainMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaddomainmonitors"></a>
# **ListADDomainMonitors**
> List<ADDomainMonitorInfo> ListADDomainMonitors ()

Lists monitoring information related to AD Domains of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListADDomainMonitorsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to AD Domains of the environment.
                List&lt;ADDomainMonitorInfo&gt; result = apiInstance.ListADDomainMonitors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListADDomainMonitors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ADDomainMonitorInfo>**](ADDomainMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listconnectionservermonitors"></a>
# **ListConnectionServerMonitors**
> List<ConnectionServerMonitorInfo> ListConnectionServerMonitors ()

Lists monitoring information related to Connection Servers of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListConnectionServerMonitorsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to Connection Servers of the environment.
                List&lt;ConnectionServerMonitorInfo&gt; result = apiInstance.ListConnectionServerMonitors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListConnectionServerMonitors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ConnectionServerMonitorInfo>**](ConnectionServerMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listconnectionservermonitorsv2"></a>
# **ListConnectionServerMonitorsV2**
> List<ConnectionServerMonitorInfoV2> ListConnectionServerMonitorsV2 ()

Lists monitoring information related to Connection Servers of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListConnectionServerMonitorsV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to Connection Servers of the environment.
                List&lt;ConnectionServerMonitorInfoV2&gt; result = apiInstance.ListConnectionServerMonitorsV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListConnectionServerMonitorsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ConnectionServerMonitorInfoV2>**](ConnectionServerMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listfarmmonitors"></a>
# **ListFarmMonitors**
> List<FarmMonitorInfo> ListFarmMonitors ()

Lists monitoring information related to Farms of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListFarmMonitorsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to Farms of the environment.
                List&lt;FarmMonitorInfo&gt; result = apiInstance.ListFarmMonitors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListFarmMonitors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<FarmMonitorInfo>**](FarmMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgatewaymonitorinfov1"></a>
# **ListGatewayMonitorInfoV1**
> List<GatewayMonitorInfo> ListGatewayMonitorInfoV1 ()

Lists monitoring information related to Gateways registered in the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListGatewayMonitorInfoV1Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to Gateways registered in the environment.
                List&lt;GatewayMonitorInfo&gt; result = apiInstance.ListGatewayMonitorInfoV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListGatewayMonitorInfoV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<GatewayMonitorInfo>**](GatewayMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listgatewaymonitorinfov2"></a>
# **ListGatewayMonitorInfoV2**
> List<GatewayMonitorInfoV2> ListGatewayMonitorInfoV2 ()

Lists monitoring information related to Gateways registered in the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListGatewayMonitorInfoV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to Gateways registered in the environment.
                List&lt;GatewayMonitorInfoV2&gt; result = apiInstance.ListGatewayMonitorInfoV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListGatewayMonitorInfoV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<GatewayMonitorInfoV2>**](GatewayMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpodmonitorinfosv1"></a>
# **ListPodMonitorInfosV1**
> List<PodMonitorInfo> ListPodMonitorInfosV1 ()

Lists monitoring information related to the remote pods.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListPodMonitorInfosV1Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to the remote pods.
                List&lt;PodMonitorInfo&gt; result = apiInstance.ListPodMonitorInfosV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListPodMonitorInfosV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PodMonitorInfo>**](PodMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpodmonitorinfosv2"></a>
# **ListPodMonitorInfosV2**
> List<PodMonitorInfoV2> ListPodMonitorInfosV2 ()

Lists monitoring information related to the remote pods.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListPodMonitorInfosV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to the remote pods.
                List&lt;PodMonitorInfoV2&gt; result = apiInstance.ListPodMonitorInfosV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListPodMonitorInfosV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<PodMonitorInfoV2>**](PodMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrdsservermonitors"></a>
# **ListRDSServerMonitors**
> List<RDSServerMonitorInfo> ListRDSServerMonitors ()

Lists monitoring information related to RDS Servers of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListRDSServerMonitorsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to RDS Servers of the environment.
                List&lt;RDSServerMonitorInfo&gt; result = apiInstance.ListRDSServerMonitors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListRDSServerMonitors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RDSServerMonitorInfo>**](RDSServerMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsamlauthenticatormonitorsv1"></a>
# **ListSAMLAuthenticatorMonitorsV1**
> List<SAMLAuthenticatorMonitorInfo> ListSAMLAuthenticatorMonitorsV1 ()

Lists monitoring information related to SAML Authenticators of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListSAMLAuthenticatorMonitorsV1Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to SAML Authenticators of the environment.
                List&lt;SAMLAuthenticatorMonitorInfo&gt; result = apiInstance.ListSAMLAuthenticatorMonitorsV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListSAMLAuthenticatorMonitorsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SAMLAuthenticatorMonitorInfo>**](SAMLAuthenticatorMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsamlauthenticatormonitorsv2"></a>
# **ListSAMLAuthenticatorMonitorsV2**
> List<SAMLAuthenticatorMonitorInfoV2> ListSAMLAuthenticatorMonitorsV2 ()

Lists monitoring information related to SAML Authenticators of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListSAMLAuthenticatorMonitorsV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to SAML Authenticators of the environment.
                List&lt;SAMLAuthenticatorMonitorInfoV2&gt; result = apiInstance.ListSAMLAuthenticatorMonitorsV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListSAMLAuthenticatorMonitorsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<SAMLAuthenticatorMonitorInfoV2>**](SAMLAuthenticatorMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtruessomonitorinfos"></a>
# **ListTrueSSOMonitorInfos**
> List<TrueSSOMonitorInfo> ListTrueSSOMonitorInfos ()

Lists monitoring information related to True SSO connectors.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListTrueSSOMonitorInfosExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to True SSO connectors.
                List&lt;TrueSSOMonitorInfo&gt; result = apiInstance.ListTrueSSOMonitorInfos();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListTrueSSOMonitorInfos: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TrueSSOMonitorInfo>**](TrueSSOMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listviewcomposermonitorsv1"></a>
# **ListViewComposerMonitorsV1**
> List<ViewComposerMonitorInfo> ListViewComposerMonitorsV1 ()

Lists monitoring information related to View Composers of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListViewComposerMonitorsV1Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to View Composers of the environment.
                List&lt;ViewComposerMonitorInfo&gt; result = apiInstance.ListViewComposerMonitorsV1();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListViewComposerMonitorsV1: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ViewComposerMonitorInfo>**](ViewComposerMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listviewcomposermonitorsv2"></a>
# **ListViewComposerMonitorsV2**
> List<ViewComposerMonitorInfoV2> ListViewComposerMonitorsV2 ()

Lists monitoring information related to View Composers of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListViewComposerMonitorsV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to View Composers of the environment.
                List&lt;ViewComposerMonitorInfoV2&gt; result = apiInstance.ListViewComposerMonitorsV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListViewComposerMonitorsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ViewComposerMonitorInfoV2>**](ViewComposerMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listvirtualcentermonitors"></a>
# **ListVirtualCenterMonitors**
> List<VirtualCenterMonitorInfo> ListVirtualCenterMonitors ()

Lists monitoring information related to Virtual Centers of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListVirtualCenterMonitorsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to Virtual Centers of the environment.
                List&lt;VirtualCenterMonitorInfo&gt; result = apiInstance.ListVirtualCenterMonitors();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListVirtualCenterMonitors: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<VirtualCenterMonitorInfo>**](VirtualCenterMonitorInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listvirtualcentermonitorsv2"></a>
# **ListVirtualCenterMonitorsV2**
> List<VirtualCenterMonitorInfoV2> ListVirtualCenterMonitorsV2 ()

Lists monitoring information related to Virtual Centers of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListVirtualCenterMonitorsV2Example
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MonitorApi();

            try
            {
                // Lists monitoring information related to Virtual Centers of the environment.
                List&lt;VirtualCenterMonitorInfoV2&gt; result = apiInstance.ListVirtualCenterMonitorsV2();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MonitorApi.ListVirtualCenterMonitorsV2: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<VirtualCenterMonitorInfoV2>**](VirtualCenterMonitorInfoV2.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

