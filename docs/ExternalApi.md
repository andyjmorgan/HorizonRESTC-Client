# VMware.Horizon.RESTAPI.Api.ExternalApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ChangeUserPassword**](ExternalApi.md#changeuserpassword) | **POST** /external/v1/ad-users-or-groups/action/change-user-password | Changes the password of AD User
[**GetADUserOrGroupInfo**](ExternalApi.md#getaduserorgroupinfo) | **GET** /external/v1/ad-users-or-groups/{id} | Get information related to AD User or Group
[**ListADDomains**](ExternalApi.md#listaddomains) | **GET** /external/v1/ad-domains | Lists information related to AD Domains of the environment.
[**ListADUserOrGroupSummary**](ExternalApi.md#listaduserorgroupsummary) | **GET** /external/v1/ad-users-or-groups | Lists AD users or groups information.
[**ListBaseSnapshots**](ExternalApi.md#listbasesnapshots) | **GET** /external/v1/base-snapshots | Lists all the VM snapshots from the vCenter for a given VM.
[**ListBaseVMs**](ExternalApi.md#listbasevms) | **GET** /external/v1/base-vms | Lists all the VMs from a vCenter or a datacenter in that vCenter which may be suitable as snapshots for instant/linked clone desktop or farm creation.
[**ListCustomizationSpecs**](ExternalApi.md#listcustomizationspecs) | **GET** /external/v1/customization-specifications | Lists all the customization specifications from the vCenter.
[**ListDatacenters**](ExternalApi.md#listdatacenters) | **GET** /external/v1/datacenters | Lists all the datacenters of a vCenter.
[**ListDatastorePaths**](ExternalApi.md#listdatastorepaths) | **GET** /external/v1/datastore-paths | Lists all the folder paths within a Datastore from vCenter.
[**ListHostsOrClusters**](ExternalApi.md#listhostsorclusters) | **GET** /external/v1/hosts-or-clusters | Lists all the hosts or clusters of the datacenter.
[**ListNetworkInterfaceCards**](ExternalApi.md#listnetworkinterfacecards) | **GET** /external/v1/network-interface-cards | Returns a list of network interface cards (NICs) suitable for configuration on a desktop pool/farm.
[**ListNetworkLabels**](ExternalApi.md#listnetworklabels) | **GET** /external/v1/network-labels | Retrieves all network labels on the given host or cluster
[**ListResourcePools**](ExternalApi.md#listresourcepools) | **GET** /external/v1/resource-pools | Lists all the resource pools from the vCenter for the given host or cluster.
[**ListVMFolders**](ExternalApi.md#listvmfolders) | **GET** /external/v1/vm-folders | Lists all the VM folders from the vCenter for the given datacenter.
[**ListVMTemplates**](ExternalApi.md#listvmtemplates) | **GET** /external/v1/vm-templates | Lists all the VM templates from a vCenter or a datacenter for the given vCenter which may be suitable for full clone desktop pool creation.
[**Listdatastores**](ExternalApi.md#listdatastores) | **GET** /external/v1/datastores | Lists all the datastoress from the vCenter for the given host or cluster.
[**ValidateADUserEncryptedCredentials**](ExternalApi.md#validateaduserencryptedcredentials) | **POST** /external/v1/ad-users-or-groups/action/validate-user-encrypted-credentials | Validates the encrypted credentials of AD User


<a name="changeuserpassword"></a>
# **ChangeUserPassword**
> ADUserInfo ChangeUserPassword (ADUserChangePasswordSpec body)

Changes the password of AD User

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ChangeUserPasswordExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var body = new ADUserChangePasswordSpec(); // ADUserChangePasswordSpec | AD user password object to be changed.

            try
            {
                // Changes the password of AD User
                ADUserInfo result = apiInstance.ChangeUserPassword(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ChangeUserPassword: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ADUserChangePasswordSpec**](ADUserChangePasswordSpec.md)| AD user password object to be changed. | 

### Return type

[**ADUserInfo**](ADUserInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaduserorgroupinfo"></a>
# **GetADUserOrGroupInfo**
> ADUserOrGroupInfo GetADUserOrGroupInfo (string id)

Get information related to AD User or Group

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetADUserOrGroupInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var id = id_example;  // string | id

            try
            {
                // Get information related to AD User or Group
                ADUserOrGroupInfo result = apiInstance.GetADUserOrGroupInfo(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.GetADUserOrGroupInfo: " + e.Message );
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

[**ADUserOrGroupInfo**](ADUserOrGroupInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaddomains"></a>
# **ListADDomains**
> List<ADDomainInfo> ListADDomains ()

Lists information related to AD Domains of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListADDomainsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();

            try
            {
                // Lists information related to AD Domains of the environment.
                List&lt;ADDomainInfo&gt; result = apiInstance.ListADDomains();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListADDomains: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ADDomainInfo>**](ADDomainInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listaduserorgroupsummary"></a>
# **ListADUserOrGroupSummary**
> List<ADUserOrGroupSummary> ListADUserOrGroupSummary (string groupOnly = null)

Lists AD users or groups information.

This API supports <b>Pagination</b> and <b>Filters.</b><br/>For Pagination, optional query params of 'page' and 'size' needs to be send.<br/>For Filters, refer to 'ADUserOrGroupSummary' model description to find supported filters on specific field.<br/>For full information on using Filters, refer to 'Horizon Server REST Pagination and Filter Guide' of 'VMware Horizon Server API' in code.vmware.com

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListADUserOrGroupSummaryExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var groupOnly = groupOnly_example;  // string | Presence of this query param indicates to filter only groups or only users.   If passed as \"true\", then only groups are returned.  If passed as \"false\", then only users are returned.  If not passed passed at all, then both types are returned. (optional) 

            try
            {
                // Lists AD users or groups information.
                List&lt;ADUserOrGroupSummary&gt; result = apiInstance.ListADUserOrGroupSummary(groupOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListADUserOrGroupSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupOnly** | **string**| Presence of this query param indicates to filter only groups or only users.   If passed as \&quot;true\&quot;, then only groups are returned.  If passed as \&quot;false\&quot;, then only users are returned.  If not passed passed at all, then both types are returned. | [optional] 

### Return type

[**List<ADUserOrGroupSummary>**](ADUserOrGroupSummary.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbasesnapshots"></a>
# **ListBaseSnapshots**
> List<BaseSnapshotInfo> ListBaseSnapshots (string baseVmId, string vcenterId)

Lists all the VM snapshots from the vCenter for a given VM.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListBaseSnapshotsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var baseVmId = baseVmId_example;  // string | VM ID
            var vcenterId = vcenterId_example;  // string | Virtual Center ID

            try
            {
                // Lists all the VM snapshots from the vCenter for a given VM.
                List&lt;BaseSnapshotInfo&gt; result = apiInstance.ListBaseSnapshots(baseVmId, vcenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListBaseSnapshots: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **baseVmId** | **string**| VM ID | 
 **vcenterId** | **string**| Virtual Center ID | 

### Return type

[**List<BaseSnapshotInfo>**](BaseSnapshotInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listbasevms"></a>
# **ListBaseVMs**
> List<BaseVMInfo> ListBaseVMs (string vcenterId, string datacenterId = null)

Lists all the VMs from a vCenter or a datacenter in that vCenter which may be suitable as snapshots for instant/linked clone desktop or farm creation.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListBaseVMsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var vcenterId = vcenterId_example;  // string | Virtual Center ID
            var datacenterId = datacenterId_example;  // string | Datacenter ID (optional) 

            try
            {
                // Lists all the VMs from a vCenter or a datacenter in that vCenter which may be suitable as snapshots for instant/linked clone desktop or farm creation.
                List&lt;BaseVMInfo&gt; result = apiInstance.ListBaseVMs(vcenterId, datacenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListBaseVMs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcenterId** | **string**| Virtual Center ID | 
 **datacenterId** | **string**| Datacenter ID | [optional] 

### Return type

[**List<BaseVMInfo>**](BaseVMInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcustomizationspecs"></a>
# **ListCustomizationSpecs**
> List<CustomizationSpecInfo> ListCustomizationSpecs (string vcenterId)

Lists all the customization specifications from the vCenter.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListCustomizationSpecsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var vcenterId = vcenterId_example;  // string | Virtual Center ID

            try
            {
                // Lists all the customization specifications from the vCenter.
                List&lt;CustomizationSpecInfo&gt; result = apiInstance.ListCustomizationSpecs(vcenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListCustomizationSpecs: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcenterId** | **string**| Virtual Center ID | 

### Return type

[**List<CustomizationSpecInfo>**](CustomizationSpecInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdatacenters"></a>
# **ListDatacenters**
> List<DatacenterInfo> ListDatacenters (string vcenterId)

Lists all the datacenters of a vCenter.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListDatacentersExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var vcenterId = vcenterId_example;  // string | Virtual Center ID

            try
            {
                // Lists all the datacenters of a vCenter.
                List&lt;DatacenterInfo&gt; result = apiInstance.ListDatacenters(vcenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListDatacenters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcenterId** | **string**| Virtual Center ID | 

### Return type

[**List<DatacenterInfo>**](DatacenterInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdatastorepaths"></a>
# **ListDatastorePaths**
> List<DatastorePathInfo> ListDatastorePaths (string datastoreId, string vcenterId)

Lists all the folder paths within a Datastore from vCenter.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListDatastorePathsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var datastoreId = datastoreId_example;  // string | Datastore ID
            var vcenterId = vcenterId_example;  // string | Virtual Center ID

            try
            {
                // Lists all the folder paths within a Datastore from vCenter.
                List&lt;DatastorePathInfo&gt; result = apiInstance.ListDatastorePaths(datastoreId, vcenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListDatastorePaths: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datastoreId** | **string**| Datastore ID | 
 **vcenterId** | **string**| Virtual Center ID | 

### Return type

[**List<DatastorePathInfo>**](DatastorePathInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listhostsorclusters"></a>
# **ListHostsOrClusters**
> List<HostOrClusterInfo> ListHostsOrClusters (string datacenterId, string vcenterId)

Lists all the hosts or clusters of the datacenter.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListHostsOrClustersExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var datacenterId = datacenterId_example;  // string | Datacenter ID
            var vcenterId = vcenterId_example;  // string | Virtual Center ID

            try
            {
                // Lists all the hosts or clusters of the datacenter.
                List&lt;HostOrClusterInfo&gt; result = apiInstance.ListHostsOrClusters(datacenterId, vcenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListHostsOrClusters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datacenterId** | **string**| Datacenter ID | 
 **vcenterId** | **string**| Virtual Center ID | 

### Return type

[**List<HostOrClusterInfo>**](HostOrClusterInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnetworkinterfacecards"></a>
# **ListNetworkInterfaceCards**
> List<NetworkInterfaceCardInfo> ListNetworkInterfaceCards (string vcenterId, string baseSnapshotId = null, string baseVmId = null, string vmTemplateId = null)

Returns a list of network interface cards (NICs) suitable for configuration on a desktop pool/farm.

If the base VM and snapshot are specified, then the NICs  present on the given snapshot are listed.<br/> If the template is specified then the NICs present on the given template are listed.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListNetworkInterfaceCardsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var vcenterId = vcenterId_example;  // string | Virtual Center ID
            var baseSnapshotId = baseSnapshotId_example;  // string | Base Snapshot ID (optional) 
            var baseVmId = baseVmId_example;  // string | Base VM ID (optional) 
            var vmTemplateId = vmTemplateId_example;  // string | VM Template ID (optional) 

            try
            {
                // Returns a list of network interface cards (NICs) suitable for configuration on a desktop pool/farm.
                List&lt;NetworkInterfaceCardInfo&gt; result = apiInstance.ListNetworkInterfaceCards(vcenterId, baseSnapshotId, baseVmId, vmTemplateId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListNetworkInterfaceCards: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcenterId** | **string**| Virtual Center ID | 
 **baseSnapshotId** | **string**| Base Snapshot ID | [optional] 
 **baseVmId** | **string**| Base VM ID | [optional] 
 **vmTemplateId** | **string**| VM Template ID | [optional] 

### Return type

[**List<NetworkInterfaceCardInfo>**](NetworkInterfaceCardInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listnetworklabels"></a>
# **ListNetworkLabels**
> List<NetworkLabelInfo> ListNetworkLabels (string hostOrClusterId, string vcenterId, string networkType = null)

Retrieves all network labels on the given host or cluster

API retrieves by filtering on the network type (if specified) that may be suitable for configuration with a desktop pool/farm's network interface card.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListNetworkLabelsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var hostOrClusterId = hostOrClusterId_example;  // string | Host or Cluster ID
            var vcenterId = vcenterId_example;  // string | Virtual Center ID
            var networkType = networkType_example;  // string | Network Type * NETWORK: Standard network. * OPAQUE_NETWORK: Opaque network. * DISTRUBUTED_VIRTUAL_PORT_GROUP: DVS Port group. (optional) 

            try
            {
                // Retrieves all network labels on the given host or cluster
                List&lt;NetworkLabelInfo&gt; result = apiInstance.ListNetworkLabels(hostOrClusterId, vcenterId, networkType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListNetworkLabels: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostOrClusterId** | **string**| Host or Cluster ID | 
 **vcenterId** | **string**| Virtual Center ID | 
 **networkType** | **string**| Network Type * NETWORK: Standard network. * OPAQUE_NETWORK: Opaque network. * DISTRUBUTED_VIRTUAL_PORT_GROUP: DVS Port group. | [optional] 

### Return type

[**List<NetworkLabelInfo>**](NetworkLabelInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listresourcepools"></a>
# **ListResourcePools**
> List<ResourcePoolInfo> ListResourcePools (string hostOrClusterId, string vcenterId)

Lists all the resource pools from the vCenter for the given host or cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListResourcePoolsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var hostOrClusterId = hostOrClusterId_example;  // string | Host or Cluster ID
            var vcenterId = vcenterId_example;  // string | Virtual Center ID

            try
            {
                // Lists all the resource pools from the vCenter for the given host or cluster.
                List&lt;ResourcePoolInfo&gt; result = apiInstance.ListResourcePools(hostOrClusterId, vcenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListResourcePools: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostOrClusterId** | **string**| Host or Cluster ID | 
 **vcenterId** | **string**| Virtual Center ID | 

### Return type

[**List<ResourcePoolInfo>**](ResourcePoolInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listvmfolders"></a>
# **ListVMFolders**
> List<VMFolderInfo> ListVMFolders (string datacenterId, string vcenterId)

Lists all the VM folders from the vCenter for the given datacenter.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListVMFoldersExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var datacenterId = datacenterId_example;  // string | Datacenter ID
            var vcenterId = vcenterId_example;  // string | Virtual Center ID

            try
            {
                // Lists all the VM folders from the vCenter for the given datacenter.
                List&lt;VMFolderInfo&gt; result = apiInstance.ListVMFolders(datacenterId, vcenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListVMFolders: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **datacenterId** | **string**| Datacenter ID | 
 **vcenterId** | **string**| Virtual Center ID | 

### Return type

[**List<VMFolderInfo>**](VMFolderInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listvmtemplates"></a>
# **ListVMTemplates**
> List<VMTemplateInfo> ListVMTemplates (string vcenterId, string datacenterId = null)

Lists all the VM templates from a vCenter or a datacenter for the given vCenter which may be suitable for full clone desktop pool creation.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListVMTemplatesExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var vcenterId = vcenterId_example;  // string | Virtual Center ID
            var datacenterId = datacenterId_example;  // string | Datacenter ID (optional) 

            try
            {
                // Lists all the VM templates from a vCenter or a datacenter for the given vCenter which may be suitable for full clone desktop pool creation.
                List&lt;VMTemplateInfo&gt; result = apiInstance.ListVMTemplates(vcenterId, datacenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ListVMTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vcenterId** | **string**| Virtual Center ID | 
 **datacenterId** | **string**| Datacenter ID | [optional] 

### Return type

[**List<VMTemplateInfo>**](VMTemplateInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listdatastores"></a>
# **Listdatastores**
> List<DatastoreInfo> Listdatastores (string hostOrClusterId, string vcenterId)

Lists all the datastoress from the vCenter for the given host or cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListdatastoresExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var hostOrClusterId = hostOrClusterId_example;  // string | Host or Cluster ID
            var vcenterId = vcenterId_example;  // string | Virtual Center ID

            try
            {
                // Lists all the datastoress from the vCenter for the given host or cluster.
                List&lt;DatastoreInfo&gt; result = apiInstance.Listdatastores(hostOrClusterId, vcenterId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.Listdatastores: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hostOrClusterId** | **string**| Host or Cluster ID | 
 **vcenterId** | **string**| Virtual Center ID | 

### Return type

[**List<DatastoreInfo>**](DatastoreInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validateaduserencryptedcredentials"></a>
# **ValidateADUserEncryptedCredentials**
> ADUserInfo ValidateADUserEncryptedCredentials (ADUserEncryptedCredentialSpec body)

Validates the encrypted credentials of AD User

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ValidateADUserEncryptedCredentialsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ExternalApi();
            var body = new ADUserEncryptedCredentialSpec(); // ADUserEncryptedCredentialSpec | AD user encrypted credentials object to be validated.

            try
            {
                // Validates the encrypted credentials of AD User
                ADUserInfo result = apiInstance.ValidateADUserEncryptedCredentials(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalApi.ValidateADUserEncryptedCredentials: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ADUserEncryptedCredentialSpec**](ADUserEncryptedCredentialSpec.md)| AD user encrypted credentials object to be validated. | 

### Return type

[**ADUserInfo**](ADUserInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

