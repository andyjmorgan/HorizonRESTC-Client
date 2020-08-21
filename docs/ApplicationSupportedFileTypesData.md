# VMware.Horizon.RESTAPI.Model.ApplicationSupportedFileTypesData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EnableAutoUpdateFileTypes** | **bool?** | Whether or not the file types supported by this application should be allowed to automatically update to reflect changes reported by the agent. Typically this should be set to false if the application has manually configured supported file types. Default is true. | 
**EnableAutoUpdateOtherFileTypes** | **bool?** | Whether or not the other file types supported by this application should be allowed to automatically update to reflect changes reported by the agent. Typically this should be set to false if the application has manually configured supported file types. | 
**FileTypes** | [**List&lt;ApplicationFileTypeData&gt;**](ApplicationFileTypeData.md) | Set of file types reported by the application as supported (if this application is discovered) or as specified by the administrator (if this application is manually configured). If unset, this application does not present any file type support. | [optional] 
**OtherFileTypes** | [**List&lt;ApplicationOtherFileTypeData&gt;**](ApplicationOtherFileTypeData.md) | This represents the different file types reported by Application that can be passed from agent to client via broker or as specified by the administrator (if this application is manually configured). If unset, this application does not present any other file type support. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

