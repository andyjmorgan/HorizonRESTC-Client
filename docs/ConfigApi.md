# VMware.Horizon.RESTAPI.Api.ConfigApi

All URIs are relative to *https://localhost/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateICDomainAccount**](ConfigApi.md#createicdomainaccount) | **POST** /config/v1/ic-domain-accounts | Creates instant clone domain account.
[**CreateIMAsset**](ConfigApi.md#createimasset) | **POST** /config/v1/im-assets | Creates image management asset.
[**CreateIMAssets**](ConfigApi.md#createimassets) | **POST** /config/v1/im-assets/action/bulk-create | Creates one or more image management assets. Each of the index of result in the response, correspond to the index of the original asset.
[**CreateIMStream**](ConfigApi.md#createimstream) | **POST** /config/v1/im-streams | Creates image management stream.
[**CreateIMStreams**](ConfigApi.md#createimstreams) | **POST** /config/v1/im-streams/action/bulk-create | Creates one or more image management streams. Each of the index of result in the response, correspond to the index of the original stream.
[**CreateIMTag**](ConfigApi.md#createimtag) | **POST** /config/v1/im-tags | Creates image management tag.
[**CreateIMTags**](ConfigApi.md#createimtags) | **POST** /config/v1/im-tags/action/bulk-create | Creates one or more image management tags. Each of the index of result in the response, correspond to the index of the original tag.
[**CreateIMVersion**](ConfigApi.md#createimversion) | **POST** /config/v1/im-versions | Creates image management version.
[**CreateIMVersions**](ConfigApi.md#createimversions) | **POST** /config/v1/im-versions/action/bulk-create | Creates one or more image management versions. Each of the index of result in the response, correspond to the index of the original version.
[**DeleteICDomainAccount**](ConfigApi.md#deleteicdomainaccount) | **DELETE** /config/v1/ic-domain-accounts/{id} | Deletes instant clone domain account.
[**DeleteIMAsset**](ConfigApi.md#deleteimasset) | **DELETE** /config/v1/im-assets/{id} | Deletes image management asset.
[**DeleteIMStream**](ConfigApi.md#deleteimstream) | **DELETE** /config/v1/im-streams/{id} | Deletes image management stream.
[**DeleteIMTag**](ConfigApi.md#deleteimtag) | **DELETE** /config/v1/im-tags/{id} | Deletes image management tag.
[**DeleteIMVersion**](ConfigApi.md#deleteimversion) | **DELETE** /config/v1/im-versions/{id} | Deletes image management version.
[**GetEnvironmentUsingGET**](ConfigApi.md#getenvironmentusingget) | **GET** /config/v1/environment-properties | Retrieves the environment settings.
[**GetFeatureSettingsUsingGET**](ConfigApi.md#getfeaturesettingsusingget) | **GET** /config/v1/settings/feature | Retrieves the feature settings.
[**GetGeneralSettingsUsingGET**](ConfigApi.md#getgeneralsettingsusingget) | **GET** /config/v1/settings/general | Retrieves the general settings.
[**GetICDomainAccount**](ConfigApi.md#geticdomainaccount) | **GET** /config/v1/ic-domain-accounts/{id} | Gets instant clone domain account.
[**GetIMAsset**](ConfigApi.md#getimasset) | **GET** /config/v1/im-assets/{id} | Gets image management asset.
[**GetIMStream**](ConfigApi.md#getimstream) | **GET** /config/v1/im-streams/{id} | Gets image management stream.
[**GetIMTag**](ConfigApi.md#getimtag) | **GET** /config/v1/im-tags/{id} | Gets image management tag.
[**GetIMVersion**](ConfigApi.md#getimversion) | **GET** /config/v1/im-versions/{id} | Gets image management version.
[**GetSecuritySettingsUsingGET**](ConfigApi.md#getsecuritysettingsusingget) | **GET** /config/v1/settings/security | Retrieves the security settings.
[**GetSettingsUsingGET**](ConfigApi.md#getsettingsusingget) | **GET** /config/v1/settings | Retrieves the configuration settings.
[**ListICDomainAccounts**](ConfigApi.md#listicdomainaccounts) | **GET** /config/v1/ic-domain-accounts | Lists instant clone domain accounts of the environment.
[**ListIMAssets**](ConfigApi.md#listimassets) | **GET** /config/v1/im-assets | Lists image management assets.
[**ListIMStreams**](ConfigApi.md#listimstreams) | **GET** /config/v1/im-streams | Lists image management streams.
[**ListIMTags**](ConfigApi.md#listimtags) | **GET** /config/v1/im-tags | Lists image management tags.
[**ListIMVersions**](ConfigApi.md#listimversions) | **GET** /config/v1/im-versions | Lists image management versions.
[**ListRCXServers**](ConfigApi.md#listrcxservers) | **GET** /config/v1/rcx/servers | Lists RCX servers of the cluster.
[**ListVCInfo**](ConfigApi.md#listvcinfo) | **GET** /config/v1/virtual-centers | Lists Virtual Centers configured in the environment.
[**RegisterRCXClient**](ConfigApi.md#registerrcxclient) | **POST** /config/v1/rcx/clients | Registers the RCX client
[**UnregisterRCXClient**](ConfigApi.md#unregisterrcxclient) | **DELETE** /config/v1/rcx/clients/{id} | Unregisters the given RCX Client
[**UpdateFeatureSettingsUsingPUT**](ConfigApi.md#updatefeaturesettingsusingput) | **PUT** /config/v1/settings/feature | Updates the feature settings.
[**UpdateGeneralSettingsUsingPUT**](ConfigApi.md#updategeneralsettingsusingput) | **PUT** /config/v1/settings/general | Updates the general settings.
[**UpdateICDomainAccount**](ConfigApi.md#updateicdomainaccount) | **PUT** /config/v1/ic-domain-accounts/{id} | Updates instant clone domain account.
[**UpdateIMAsset**](ConfigApi.md#updateimasset) | **PUT** /config/v1/im-assets/{id} | Updates image management asset.
[**UpdateIMStream**](ConfigApi.md#updateimstream) | **PUT** /config/v1/im-streams/{id} | Updates image management stream.
[**UpdateIMTag**](ConfigApi.md#updateimtag) | **PUT** /config/v1/im-tags/{id} | Updates image management tag.
[**UpdateIMVersion**](ConfigApi.md#updateimversion) | **PUT** /config/v1/im-versions/{id} | Updates image management version.
[**UpdateRCXClient**](ConfigApi.md#updatercxclient) | **PUT** /config/v1/rcx/clients/{id} | Updates the given RCX client.
[**UpdateSecuritySettingsUsingPUT**](ConfigApi.md#updatesecuritysettingsusingput) | **PUT** /config/v1/settings/security | Updates the security settings.
[**UpdateSettingsUsingPUT**](ConfigApi.md#updatesettingsusingput) | **PUT** /config/v1/settings | Updates the configuration settings.


<a name="createicdomainaccount"></a>
# **CreateICDomainAccount**
> void CreateICDomainAccount (InstantCloneDomainAccountCreateSpec body)

Creates instant clone domain account.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateICDomainAccountExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new InstantCloneDomainAccountCreateSpec(); // InstantCloneDomainAccountCreateSpec | Instant clone domain account object to be created.

            try
            {
                // Creates instant clone domain account.
                apiInstance.CreateICDomainAccount(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateICDomainAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstantCloneDomainAccountCreateSpec**](InstantCloneDomainAccountCreateSpec.md)| Instant clone domain account object to be created. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimasset"></a>
# **CreateIMAsset**
> void CreateIMAsset (ImageManagementAssetCreateSpec body)

Creates image management asset.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateIMAssetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new ImageManagementAssetCreateSpec(); // ImageManagementAssetCreateSpec | Image management asset object to be created.

            try
            {
                // Creates image management asset.
                apiInstance.CreateIMAsset(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateIMAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImageManagementAssetCreateSpec**](ImageManagementAssetCreateSpec.md)| Image management asset object to be created. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimassets"></a>
# **CreateIMAssets**
> List<BulkItemResponseInfo> CreateIMAssets (List<ImageManagementAssetCreateSpec> body)

Creates one or more image management assets. Each of the index of result in the response, correspond to the index of the original asset.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateIMAssetsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new List<ImageManagementAssetCreateSpec>(); // List<ImageManagementAssetCreateSpec> | List of Image management asset object to be created in bulk.

            try
            {
                // Creates one or more image management assets. Each of the index of result in the response, correspond to the index of the original asset.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.CreateIMAssets(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateIMAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;ImageManagementAssetCreateSpec&gt;**](ImageManagementAssetCreateSpec.md)| List of Image management asset object to be created in bulk. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimstream"></a>
# **CreateIMStream**
> void CreateIMStream (ImageManagementStreamCreateSpec body)

Creates image management stream.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateIMStreamExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new ImageManagementStreamCreateSpec(); // ImageManagementStreamCreateSpec | Image management stream object to be created.

            try
            {
                // Creates image management stream.
                apiInstance.CreateIMStream(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateIMStream: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImageManagementStreamCreateSpec**](ImageManagementStreamCreateSpec.md)| Image management stream object to be created. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimstreams"></a>
# **CreateIMStreams**
> List<BulkItemResponseInfo> CreateIMStreams (List<ImageManagementStreamCreateSpec> body)

Creates one or more image management streams. Each of the index of result in the response, correspond to the index of the original stream.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateIMStreamsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new List<ImageManagementStreamCreateSpec>(); // List<ImageManagementStreamCreateSpec> | List of Image management stream object to be created in bulk.

            try
            {
                // Creates one or more image management streams. Each of the index of result in the response, correspond to the index of the original stream.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.CreateIMStreams(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateIMStreams: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;ImageManagementStreamCreateSpec&gt;**](ImageManagementStreamCreateSpec.md)| List of Image management stream object to be created in bulk. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimtag"></a>
# **CreateIMTag**
> void CreateIMTag (ImageManagementTagCreateSpec body)

Creates image management tag.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateIMTagExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new ImageManagementTagCreateSpec(); // ImageManagementTagCreateSpec | Image management tag object to be created.

            try
            {
                // Creates image management tag.
                apiInstance.CreateIMTag(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateIMTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImageManagementTagCreateSpec**](ImageManagementTagCreateSpec.md)| Image management tag object to be created. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimtags"></a>
# **CreateIMTags**
> List<BulkItemResponseInfo> CreateIMTags (List<ImageManagementTagCreateSpec> body)

Creates one or more image management tags. Each of the index of result in the response, correspond to the index of the original tag.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateIMTagsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new List<ImageManagementTagCreateSpec>(); // List<ImageManagementTagCreateSpec> | List of Image management tag object to be created in bulk.

            try
            {
                // Creates one or more image management tags. Each of the index of result in the response, correspond to the index of the original tag.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.CreateIMTags(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateIMTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;ImageManagementTagCreateSpec&gt;**](ImageManagementTagCreateSpec.md)| List of Image management tag object to be created in bulk. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimversion"></a>
# **CreateIMVersion**
> void CreateIMVersion (ImageManagementVersionCreateSpec body)

Creates image management version.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateIMVersionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new ImageManagementVersionCreateSpec(); // ImageManagementVersionCreateSpec | Image management version object to be created.

            try
            {
                // Creates image management version.
                apiInstance.CreateIMVersion(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateIMVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImageManagementVersionCreateSpec**](ImageManagementVersionCreateSpec.md)| Image management version object to be created. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createimversions"></a>
# **CreateIMVersions**
> List<BulkItemResponseInfo> CreateIMVersions (List<ImageManagementVersionCreateSpec> body)

Creates one or more image management versions. Each of the index of result in the response, correspond to the index of the original version.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class CreateIMVersionsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new List<ImageManagementVersionCreateSpec>(); // List<ImageManagementVersionCreateSpec> | List of Image management version object to be created in bulk.

            try
            {
                // Creates one or more image management versions. Each of the index of result in the response, correspond to the index of the original version.
                List&lt;BulkItemResponseInfo&gt; result = apiInstance.CreateIMVersions(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.CreateIMVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;ImageManagementVersionCreateSpec&gt;**](ImageManagementVersionCreateSpec.md)| List of Image management version object to be created in bulk. | 

### Return type

[**List<BulkItemResponseInfo>**](BulkItemResponseInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteicdomainaccount"></a>
# **DeleteICDomainAccount**
> void DeleteICDomainAccount (string id)

Deletes instant clone domain account.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class DeleteICDomainAccountExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Deletes instant clone domain account.
                apiInstance.DeleteICDomainAccount(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.DeleteICDomainAccount: " + e.Message );
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

<a name="deleteimasset"></a>
# **DeleteIMAsset**
> void DeleteIMAsset (string id)

Deletes image management asset.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class DeleteIMAssetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Deletes image management asset.
                apiInstance.DeleteIMAsset(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.DeleteIMAsset: " + e.Message );
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

<a name="deleteimstream"></a>
# **DeleteIMStream**
> void DeleteIMStream (string id)

Deletes image management stream.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class DeleteIMStreamExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Deletes image management stream.
                apiInstance.DeleteIMStream(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.DeleteIMStream: " + e.Message );
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

<a name="deleteimtag"></a>
# **DeleteIMTag**
> void DeleteIMTag (string id)

Deletes image management tag.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class DeleteIMTagExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Deletes image management tag.
                apiInstance.DeleteIMTag(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.DeleteIMTag: " + e.Message );
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

<a name="deleteimversion"></a>
# **DeleteIMVersion**
> void DeleteIMVersion (string id)

Deletes image management version.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class DeleteIMVersionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Deletes image management version.
                apiInstance.DeleteIMVersion(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.DeleteIMVersion: " + e.Message );
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

<a name="getenvironmentusingget"></a>
# **GetEnvironmentUsingGET**
> EnvironmentInfo GetEnvironmentUsingGET ()

Retrieves the environment settings.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetEnvironmentUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();

            try
            {
                // Retrieves the environment settings.
                EnvironmentInfo result = apiInstance.GetEnvironmentUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetEnvironmentUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**EnvironmentInfo**](EnvironmentInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfeaturesettingsusingget"></a>
# **GetFeatureSettingsUsingGET**
> FeatureSettings GetFeatureSettingsUsingGET ()

Retrieves the feature settings.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetFeatureSettingsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();

            try
            {
                // Retrieves the feature settings.
                FeatureSettings result = apiInstance.GetFeatureSettingsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetFeatureSettingsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**FeatureSettings**](FeatureSettings.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getgeneralsettingsusingget"></a>
# **GetGeneralSettingsUsingGET**
> GeneralSettings GetGeneralSettingsUsingGET ()

Retrieves the general settings.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetGeneralSettingsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();

            try
            {
                // Retrieves the general settings.
                GeneralSettings result = apiInstance.GetGeneralSettingsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetGeneralSettingsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**GeneralSettings**](GeneralSettings.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="geticdomainaccount"></a>
# **GetICDomainAccount**
> InstantCloneDomainAccountInfo GetICDomainAccount (string id)

Gets instant clone domain account.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetICDomainAccountExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Gets instant clone domain account.
                InstantCloneDomainAccountInfo result = apiInstance.GetICDomainAccount(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetICDomainAccount: " + e.Message );
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

[**InstantCloneDomainAccountInfo**](InstantCloneDomainAccountInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimasset"></a>
# **GetIMAsset**
> ImageManagementAssetInfo GetIMAsset (string id)

Gets image management asset.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetIMAssetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Gets image management asset.
                ImageManagementAssetInfo result = apiInstance.GetIMAsset(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetIMAsset: " + e.Message );
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

[**ImageManagementAssetInfo**](ImageManagementAssetInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimstream"></a>
# **GetIMStream**
> ImageManagementStreamInfo GetIMStream (string id)

Gets image management stream.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetIMStreamExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Gets image management stream.
                ImageManagementStreamInfo result = apiInstance.GetIMStream(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetIMStream: " + e.Message );
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

[**ImageManagementStreamInfo**](ImageManagementStreamInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimtag"></a>
# **GetIMTag**
> ImageManagementTagInfo GetIMTag (string id)

Gets image management tag.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetIMTagExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Gets image management tag.
                ImageManagementTagInfo result = apiInstance.GetIMTag(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetIMTag: " + e.Message );
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

[**ImageManagementTagInfo**](ImageManagementTagInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getimversion"></a>
# **GetIMVersion**
> ImageManagementVersionInfo GetIMVersion (string id)

Gets image management version.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetIMVersionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Gets image management version.
                ImageManagementVersionInfo result = apiInstance.GetIMVersion(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetIMVersion: " + e.Message );
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

[**ImageManagementVersionInfo**](ImageManagementVersionInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsecuritysettingsusingget"></a>
# **GetSecuritySettingsUsingGET**
> SecuritySettings GetSecuritySettingsUsingGET ()

Retrieves the security settings.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetSecuritySettingsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();

            try
            {
                // Retrieves the security settings.
                SecuritySettings result = apiInstance.GetSecuritySettingsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetSecuritySettingsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SecuritySettings**](SecuritySettings.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsettingsusingget"></a>
# **GetSettingsUsingGET**
> SettingsInfo GetSettingsUsingGET ()

Retrieves the configuration settings.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class GetSettingsUsingGETExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();

            try
            {
                // Retrieves the configuration settings.
                SettingsInfo result = apiInstance.GetSettingsUsingGET();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.GetSettingsUsingGET: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SettingsInfo**](SettingsInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listicdomainaccounts"></a>
# **ListICDomainAccounts**
> List<InstantCloneDomainAccountInfo> ListICDomainAccounts ()

Lists instant clone domain accounts of the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListICDomainAccountsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();

            try
            {
                // Lists instant clone domain accounts of the environment.
                List&lt;InstantCloneDomainAccountInfo&gt; result = apiInstance.ListICDomainAccounts();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.ListICDomainAccounts: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<InstantCloneDomainAccountInfo>**](InstantCloneDomainAccountInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listimassets"></a>
# **ListIMAssets**
> List<ImageManagementAssetInfo> ListIMAssets (string imVersionId)

Lists image management assets.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListIMAssetsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var imVersionId = imVersionId_example;  // string | Image management version ID

            try
            {
                // Lists image management assets.
                List&lt;ImageManagementAssetInfo&gt; result = apiInstance.ListIMAssets(imVersionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.ListIMAssets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imVersionId** | **string**| Image management version ID | 

### Return type

[**List<ImageManagementAssetInfo>**](ImageManagementAssetInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listimstreams"></a>
# **ListIMStreams**
> List<ImageManagementStreamInfo> ListIMStreams ()

Lists image management streams.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListIMStreamsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();

            try
            {
                // Lists image management streams.
                List&lt;ImageManagementStreamInfo&gt; result = apiInstance.ListIMStreams();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.ListIMStreams: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<ImageManagementStreamInfo>**](ImageManagementStreamInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listimtags"></a>
# **ListIMTags**
> List<ImageManagementTagInfo> ListIMTags (string imStreamId)

Lists image management tags.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListIMTagsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var imStreamId = imStreamId_example;  // string | Image management stream ID

            try
            {
                // Lists image management tags.
                List&lt;ImageManagementTagInfo&gt; result = apiInstance.ListIMTags(imStreamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.ListIMTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imStreamId** | **string**| Image management stream ID | 

### Return type

[**List<ImageManagementTagInfo>**](ImageManagementTagInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listimversions"></a>
# **ListIMVersions**
> List<ImageManagementVersionInfo> ListIMVersions (string imStreamId)

Lists image management versions.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListIMVersionsExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var imStreamId = imStreamId_example;  // string | Image management stream ID

            try
            {
                // Lists image management versions.
                List&lt;ImageManagementVersionInfo&gt; result = apiInstance.ListIMVersions(imStreamId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.ListIMVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **imStreamId** | **string**| Image management stream ID | 

### Return type

[**List<ImageManagementVersionInfo>**](ImageManagementVersionInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listrcxservers"></a>
# **ListRCXServers**
> List<RCXServerInfo> ListRCXServers ()

Lists RCX servers of the cluster.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListRCXServersExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();

            try
            {
                // Lists RCX servers of the cluster.
                List&lt;RCXServerInfo&gt; result = apiInstance.ListRCXServers();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.ListRCXServers: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<RCXServerInfo>**](RCXServerInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listvcinfo"></a>
# **ListVCInfo**
> List<VirtualCenterInfo> ListVCInfo ()

Lists Virtual Centers configured in the environment.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class ListVCInfoExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();

            try
            {
                // Lists Virtual Centers configured in the environment.
                List&lt;VirtualCenterInfo&gt; result = apiInstance.ListVCInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.ListVCInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<VirtualCenterInfo>**](VirtualCenterInfo.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registerrcxclient"></a>
# **RegisterRCXClient**
> void RegisterRCXClient (RCXClientRegisterSpec body)

Registers the RCX client

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class RegisterRCXClientExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new RCXClientRegisterSpec(); // RCXClientRegisterSpec | RCX client object to be registered.

            try
            {
                // Registers the RCX client
                apiInstance.RegisterRCXClient(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.RegisterRCXClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RCXClientRegisterSpec**](RCXClientRegisterSpec.md)| RCX client object to be registered. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unregisterrcxclient"></a>
# **UnregisterRCXClient**
> void UnregisterRCXClient (string id)

Unregisters the given RCX Client

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UnregisterRCXClientExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var id = id_example;  // string | id

            try
            {
                // Unregisters the given RCX Client
                apiInstance.UnregisterRCXClient(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UnregisterRCXClient: " + e.Message );
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

<a name="updatefeaturesettingsusingput"></a>
# **UpdateFeatureSettingsUsingPUT**
> void UpdateFeatureSettingsUsingPUT (FeatureSettingsUpdateSpec body)

Updates the feature settings.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateFeatureSettingsUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new FeatureSettingsUpdateSpec(); // FeatureSettingsUpdateSpec | Feature settings object to be updated.

            try
            {
                // Updates the feature settings.
                apiInstance.UpdateFeatureSettingsUsingPUT(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateFeatureSettingsUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FeatureSettingsUpdateSpec**](FeatureSettingsUpdateSpec.md)| Feature settings object to be updated. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updategeneralsettingsusingput"></a>
# **UpdateGeneralSettingsUsingPUT**
> void UpdateGeneralSettingsUsingPUT (GeneralSettingsUpdateSpec body)

Updates the general settings.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateGeneralSettingsUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new GeneralSettingsUpdateSpec(); // GeneralSettingsUpdateSpec | General settings object to be updated.

            try
            {
                // Updates the general settings.
                apiInstance.UpdateGeneralSettingsUsingPUT(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateGeneralSettingsUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**GeneralSettingsUpdateSpec**](GeneralSettingsUpdateSpec.md)| General settings object to be updated. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateicdomainaccount"></a>
# **UpdateICDomainAccount**
> void UpdateICDomainAccount (InstantCloneDomainAccountUpdateSpec body, string id)

Updates instant clone domain account.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateICDomainAccountExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new InstantCloneDomainAccountUpdateSpec(); // InstantCloneDomainAccountUpdateSpec | Instant clone domain account object to be updated.
            var id = id_example;  // string | id

            try
            {
                // Updates instant clone domain account.
                apiInstance.UpdateICDomainAccount(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateICDomainAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InstantCloneDomainAccountUpdateSpec**](InstantCloneDomainAccountUpdateSpec.md)| Instant clone domain account object to be updated. | 
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateimasset"></a>
# **UpdateIMAsset**
> void UpdateIMAsset (ImageManagementAssetUpdateSpec body, string id)

Updates image management asset.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateIMAssetExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new ImageManagementAssetUpdateSpec(); // ImageManagementAssetUpdateSpec | Image management asset object to be updated.
            var id = id_example;  // string | id

            try
            {
                // Updates image management asset.
                apiInstance.UpdateIMAsset(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateIMAsset: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImageManagementAssetUpdateSpec**](ImageManagementAssetUpdateSpec.md)| Image management asset object to be updated. | 
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateimstream"></a>
# **UpdateIMStream**
> void UpdateIMStream (ImageManagementStreamUpdateSpec body, string id)

Updates image management stream.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateIMStreamExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new ImageManagementStreamUpdateSpec(); // ImageManagementStreamUpdateSpec | Image management stream object to be updated.
            var id = id_example;  // string | id

            try
            {
                // Updates image management stream.
                apiInstance.UpdateIMStream(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateIMStream: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImageManagementStreamUpdateSpec**](ImageManagementStreamUpdateSpec.md)| Image management stream object to be updated. | 
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateimtag"></a>
# **UpdateIMTag**
> void UpdateIMTag (ImageManagementTagUpdateSpec body, string id)

Updates image management tag.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateIMTagExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new ImageManagementTagUpdateSpec(); // ImageManagementTagUpdateSpec | Image management tag object to be updated.
            var id = id_example;  // string | id

            try
            {
                // Updates image management tag.
                apiInstance.UpdateIMTag(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateIMTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImageManagementTagUpdateSpec**](ImageManagementTagUpdateSpec.md)| Image management tag object to be updated. | 
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateimversion"></a>
# **UpdateIMVersion**
> void UpdateIMVersion (ImageManagementVersionUpdateSpec body, string id)

Updates image management version.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateIMVersionExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new ImageManagementVersionUpdateSpec(); // ImageManagementVersionUpdateSpec | Image management version object to be updated.
            var id = id_example;  // string | id

            try
            {
                // Updates image management version.
                apiInstance.UpdateIMVersion(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateIMVersion: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ImageManagementVersionUpdateSpec**](ImageManagementVersionUpdateSpec.md)| Image management version object to be updated. | 
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatercxclient"></a>
# **UpdateRCXClient**
> void UpdateRCXClient (RCXClientUpdateSpec body, string id)

Updates the given RCX client.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateRCXClientExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new RCXClientUpdateSpec(); // RCXClientUpdateSpec | RCX client object to be updated.
            var id = id_example;  // string | id

            try
            {
                // Updates the given RCX client.
                apiInstance.UpdateRCXClient(body, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateRCXClient: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RCXClientUpdateSpec**](RCXClientUpdateSpec.md)| RCX client object to be updated. | 
 **id** | **string**| id | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesecuritysettingsusingput"></a>
# **UpdateSecuritySettingsUsingPUT**
> void UpdateSecuritySettingsUsingPUT (SecuritySettingsUpdateSpec body)

Updates the security settings.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateSecuritySettingsUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new SecuritySettingsUpdateSpec(); // SecuritySettingsUpdateSpec | Security settings object to be updated.

            try
            {
                // Updates the security settings.
                apiInstance.UpdateSecuritySettingsUsingPUT(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateSecuritySettingsUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SecuritySettingsUpdateSpec**](SecuritySettingsUpdateSpec.md)| Security settings object to be updated. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesettingsusingput"></a>
# **UpdateSettingsUsingPUT**
> void UpdateSettingsUsingPUT (SettingsUpdateSpec body)

Updates the configuration settings.

### Example
```csharp
using System;
using System.Diagnostics;
using VMware.Horizon.RESTAPI.Api;
using VMware.Horizon.RESTAPI.Client;
using VMware.Horizon.RESTAPI.Model;

namespace Example
{
    public class UpdateSettingsUsingPUTExample
    {
        public void main()
        {
            // Configure API key authorization: Bearer
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ConfigApi();
            var body = new SettingsUpdateSpec(); // SettingsUpdateSpec | Configuration settings object to be updated.

            try
            {
                // Updates the configuration settings.
                apiInstance.UpdateSettingsUsingPUT(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ConfigApi.UpdateSettingsUsingPUT: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SettingsUpdateSpec**](SettingsUpdateSpec.md)| Configuration settings object to be updated. | 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: */*

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

