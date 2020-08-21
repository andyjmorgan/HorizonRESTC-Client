# VMware.Horizon.RESTAPI.Model.DesktopPoolProvisioningSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddVirtualTpm** | **bool?** | Whether to add Virtual TPM device. | [optional] 
**BaseSnapshotId** | **string** | Applicable To: Linked/instant clone automated desktop pools.&lt;br&gt;Base image snapshot for linked clone desktop pool and current image snapshot for instant clone desktop pool. | [optional] 
**DatacenterId** | **string** | Datacenter within which the desktop pool is configured. | [optional] 
**HostOrClusterId** | **string** | Host or cluster where the machines are deployed in. | [optional] 
**ImStreamId** | **string** | Applicable To: Full/instant clone automated desktop pools.&lt;br&gt;Image management stream used in desktop pool when Image Management feature is enabled. | [optional] 
**ImTagId** | **string** | Applicable To: Full/instant clone automated desktop pools.&lt;br&gt;Image management tag associated with the selected image management stream which is used in desktop pool when Image Management feature is enabled. | [optional] 
**MinReadyVmsOnVcomposerMaintenance** | **int?** | Applicable To: Linked clone automated desktop pools.&lt;br&gt;Minimum number of ready (provisioned) machines during View Composer maintenance operations. | [optional] 
**ParentVmId** | **string** | Applicable To: Linked/instant clone automated desktop pools.&lt;br&gt;Base image VM for linked clone desktop pool and current image for instant clone desktop pool. | [optional] 
**ResourcePoolId** | **string** | Resource pool to deploy the machines. | [optional] 
**VmFolderId** | **string** | VM folder where the machines are deployed to. | [optional] 
**VmTemplateId** | **string** | Applicable To: Full clone automated desktop pools.&lt;br&gt;Template from which full clone machines are deployed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

