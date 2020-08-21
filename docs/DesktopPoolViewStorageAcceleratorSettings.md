# VMware.Horizon.RESTAPI.Model.DesktopPoolViewStorageAcceleratorSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlackoutTimes** | [**List&lt;ViewStorageAcceleratorBlackoutTimeSettings&gt;**](ViewStorageAcceleratorBlackoutTimeSettings.md) | A list of blackout times. Storage accelerator regeneration and machine disk space reclamation do not occur during blackout times. The same blackout policy applies to both operations. If unset, no blackout times are used. | [optional] 
**RegenerateViewStorageAcceleratorDays** | **int?** | How often to regenerate the View Storage Accelerator cache. Measured in Days. | [optional] 
**UseViewStorageAccelerator** | **bool?** | Whether to use View Storage Accelerator. | [optional] 
**ViewStorageAcceleratorDiskTypes** | **string** | Disk types to enable for the View Storage Accelerator feature. This is only applicable to linked clone desktop pools. * OS_DISKS: OS disks. * OS_AND_PERSISTENT_DISKS: OS and persistent disks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

