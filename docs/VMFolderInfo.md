# VMware.Horizon.RESTAPI.Model.VMFolderInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Children** | [**List&lt;VMFolderInfo&gt;**](VMFolderInfo.md) | Child nodes of the VM folder. | [optional] 
**DatacenterId** | **string** | Datacenter id for this VM folder. | [optional] 
**Id** | **string** | Unique ID representing the VM folder. | [optional] 
**IncompatibleReasons** | **List&lt;string&gt;** | Reasons that may preclude this VM folder from being used in desktop pool or farm. | [optional] 
**Name** | **string** | VM folder name. | [optional] 
**Path** | **string** | VM folder path. | [optional] 
**Type** | **string** | VM folder type. * DATACENTER: A datacenter that serves as a folder suitable for use in desktop pool/farm. * FOLDER: A regular folder suitable for use in desktop pool/farm. * OTHER: Other folder type that cannot be used in desktop pool/farm. | [optional] 
**VcenterId** | **string** | Virtual Center id for this VM folder. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

