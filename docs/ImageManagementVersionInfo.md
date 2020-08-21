# VMware.Horizon.RESTAPI.Model.ImageManagementVersionInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalDetails** | **Dictionary&lt;string, string&gt;** | Additional details about image management version. | [optional] 
**Description** | **string** | Image management version description. | [optional] 
**Id** | **string** | Unique ID representing image management version. | 
**ImStreamId** | **string** | Image management stream ID | [optional] 
**Name** | **string** | Image management version name. | 
**Status** | **string** | Image management version status. * AVAILABLE: Image management version is available for desktop pools/farms to be created. * DEPLOYING_VM: Image management version is deploying VM on the selected pod. * DEPLOYMENT_DONE: Image management version status when VM deployment is done for the selected pod. * DELETED: Image management version has been deleted. * DISABLED: Image management version has been disabled and no further pool operation can be done using the same. * FAILED: Image management version creation has failed. * PARTIALLY_AVAILABLE: Some of the image management asset creation in some of the virtual centers have failed. * PUBLISHING: Image management version is being published and specialized internally like installing agents etc. * REPLICATING: Copying the specialized images across all virtual centers. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

