# VMware.Horizon.RESTAPI.Model.InstalledApplicationInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExecutablePath** | **string** | Path to application executable. | [optional] 
**FileTypes** | [**List&lt;ApplicationFileTypeData&gt;**](ApplicationFileTypeData.md) | Set of file types reported by the application as supported. If unset, this application does not present any file type support. | [optional] 
**Name** | **string** | Application name information, as sent by RDSServer/machine during application discovery. | [optional] 
**OtherFileTypes** | [**List&lt;ApplicationOtherFileTypeData&gt;**](ApplicationOtherFileTypeData.md) | This represents the different file types reported by Application that can be passed from horizon agent to horizon client via connection server. If unset, this application does not present any other file type support. | [optional] 
**Publisher** | **string** | Application publisher | [optional] 
**Version** | **string** | Application version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

