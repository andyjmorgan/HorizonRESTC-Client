# VMware.Horizon.RESTAPI.Model.DesktopPoolCloneprepCustomizationSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PostSynchronizationScriptName** | **string** | Post synchronization script. ClonePrep can run a customization script on instant-clone machines after they are created or recovered or a new image is pushed. Provide the path to the script on the parent virtual machine. | [optional] 
**PostSynchronizationScriptParameters** | **string** | Post synchronization script parameters. | [optional] 
**PowerOffScriptName** | **string** | Power off script. ClonePrep can run a customization script on instant-clone machines before they are powered off. Provide the path to the script on the parent virtual machine. | [optional] 
**PowerOffScriptParameters** | **string** | Power off script parameters. | [optional] 
**PrimingComputerAccount** | **string** | Instant Clone publishing needs an additional computer account in the same AD domain as the clones. This field accepts the pre-created computer accounts. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

