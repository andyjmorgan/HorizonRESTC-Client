# VMware.Horizon.RESTAPI.Model.BaseSnapshotInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedTimestamp** | **long?** | Epoch time in milli seconds, when the VM snapshot was created. | [optional] 
**Description** | **string** | Description of the VM snapshot. | [optional] 
**DiskSizeMb** | **long?** | Sum of capacities of all the virtual disks in the VM snapshot, in MB. | [optional] 
**HardwareVersion** | **int?** | VM snapshot hardware version | [optional] 
**Id** | **string** | Unique ID representing the VM snapshot. | [optional] 
**IncompatibleReasons** | **List&lt;string&gt;** | Reasons that may preclude this VM snapshot from being used in linked/instant clone desktop pool or farm creation. | [optional] 
**MaxNumberOfMonitors** | **int?** | Maximum number of monitors set in SVGA settings for the VM snapshot in vCenter. | [optional] 
**MaxResolutionOfAnyOneMonitor** | **string** | Maximum resolution of any one monitor set in SVGA settings for the VM snapshot in vCenter. | [optional] 
**MemoryMb** | **int?** | The physical memory size of VM snapshot, in MB | [optional] 
**MemoryReservationMb** | **long?** | Amount of memory that is guaranteed available to the virtual machine, in MB. | [optional] 
**Name** | **string** | VM snapshot name. | [optional] 
**Path** | **string** | VM snapshot path. | [optional] 
**Renderer3d** | **string** | Indicate how the virtual video device for the VM snapshot renders 3D graphics. Will be set only if VM snapshot supports 3D functions. * MANAGE_BY_VSPHERE_CLIENT: 3D rendering managed by vSphere Client. * AUTOMATIC: 3D rendering is automatic. * SOFTWARE: 3D rendering is software dependent. The software renderer is supported (at minimum) on virtual hardware version 8 in a vSphere 5.0 environment. * HARDWARE: 3D rendering is hardware dependent. The hardware-based renderer is supported (at minimum) on virtual hardware version 9 in a vSphere 5.1 environment. * DISABLED: 3D rendering is disabled. | [optional] 
**TotalVideoMemoryMb** | **double?** | Total video memory in MB set in SVGA settings for the VM snapshot in vCenter. | [optional] 
**VcenterId** | **string** | Virtual Center id for this VM snapshot. | [optional] 
**VgpuType** | **string** | NVIDIA GRID vGPU type configured on this VM snapshot. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

