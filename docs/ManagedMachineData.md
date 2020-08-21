# VMware.Horizon.RESTAPI.Model.ManagedMachineData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CloneErrorMessage** | **string** | Cloning error message for this machine. This will be set for machine belonging to automated desktop pools when the machine&#39;s state is in PROVISIONING_ERROR or ERROR state. | [optional] 
**CloneErrorTime** | **long?** | Cloning error time for this machine in milliseconds. Measured as epoch time. This will be set for machine belonging to automated desktop pools when the machine&#39;s state is in PROVISIONING_ERROR or ERROR state. | [optional] 
**CreateTime** | **long?** | Time at which the machine was created in milliseconds. Measured as epoch time. | [optional] 
**HostName** | **string** | The name of the host on which this virtual machine is registered. | [optional] 
**InHoldCustomization** | **bool?** | This condition determines if this virtual machine should be on hold before customization is started.&lt;br&gt;Supported Filters : &#39;Equals&#39;. | [optional] 
**InMaintenanceMode** | **bool?** | Indicates whether the Machine is in maintenance mode. | [optional] 
**MemoryMb** | **int?** | The virtual machine physical memory in MB. | [optional] 
**MissingInVcenter** | **bool?** | This condition determines if the virtual machine is missing in vCenter Server.&lt;br&gt;Supported Filters : &#39;Equals&#39;. | [optional] 
**NetworkLabels** | [**List&lt;NetworkLabelData&gt;**](NetworkLabelData.md) | The network label(s) associated with this Machine. The network label(s) automatically assigned by Horizon to this Machine. These may differ from the actual labels if manually changed after automatic assignment or if there was an error in assignment. Labels are only assigned if the feature is enabled on this Machine&#39;s Desktop Pool. | [optional] 
**Path** | **string** | The virtual machine path.&lt;br&gt;Supported Filters : &#39;Equals&#39;, &#39;StartsWith&#39;, &#39;EndsWith&#39; and &#39;Contains&#39;.Field name to be used in filter : managedMachineData.path. | 
**StorageAcceleratorState** | **string** | The Horizon Storage Accelerator state. Storage acceleration will be available for managed machines if configured.&lt;br&gt;Supported Filters : &#39;Equals&#39;. * OFF: The Storage Accelerator is off. * CURRENT: The machine cached data is updated. * OUT_OF_DATE: The machine cached data is not updated and requires regeneration. * ERROR: The Storage Accelerator has encountered an error. | [optional] 
**VirtualCenterId** | **string** | The ID of the Virtual Center managing this machine.&lt;br&gt;Supported Filters : &#39;Equals&#39;. | 
**VirtualDisks** | [**List&lt;VirtualDiskData&gt;**](VirtualDiskData.md) | The virtual disks comprising the virtual machine. | [optional] 
**VirtualMachinePowerState** | **string** | The virtual machine power state.&lt;br&gt;Supported Filters : &#39;Equals&#39;. * POWERED_OFF: The machine is powered off. * POWERED_ON: The machine is powered on. * SUSPENDED: The machine is suspended. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

