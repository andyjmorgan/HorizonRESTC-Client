# VMware.Horizon.RESTAPI.Model.ImageManagementAssetInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalDetails** | **Dictionary&lt;string, string&gt;** | Additional details about image management asset. | [optional] 
**BaseSnapshotId** | **string** | Virtual machine snapshot. Must be set if vm_template_id is unset. | 
**BaseVmId** | **string** | Virtual machine ID. Must be set if vm_template_id is unset. | 
**CloneType** | **string** | Image management asset clone type. * FULL_CLONE: Image management asset to be used in full clone automated desktop pool. * INSTANT_CLONE: Image management asset to be used in instant clone desktop pool/farm. | 
**DatacenterId** | **string** | Datacenter where this asset is created. | 
**Id** | **string** | Unique ID representing image management asset. | 
**ImStreamId** | **string** | Image management stream to which this asset belongs to. | 
**ImVersionId** | **string** | Image management version to which this asset belongs to. | 
**ImageType** | **string** | Image management asset image type. * RDSH_APPS: Image management asset to be used for farm creation which is be used in application. * RDSH_DESKTOP: Image management asset is for farm creation to be created. * VDI_DESKTOP: Image management asset is available for desktops/farms to be created. | 
**Status** | **string** | Image management asset status. * AVAILABLE: Image management asset is available for desktop pools/farms to be created. * DEPLOYING_VM: Image management asset is deploying VM on the virtual center. * DEPLOYMENT_DONE: Image management asset VM deployed on the virtual center. * DELETED: Image management asset has been deleted. * DISABLED: Image management asset has been disabled and no further pool/farm operation can be done using the same. * FAILED: Image management asset creation has failed. * REPLICATING: Copying the specialized images across all virtual centers. * RETRY_PENDING: When image management asset creation has failed, retry action is pending for asset to be created. * SPECIALIZING_VM: Image management asset is being published and specialized internally like installing agents etc. | 
**VcenterId** | **string** | Virtual Center where this asset is created. | 
**VmTemplateId** | **string** | Virtual machine template ID. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

