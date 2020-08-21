# VMware.Horizon.RESTAPI.Model.VMTemplateInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatacenterId** | **string** | Datacenter id for this VM template. | 
**DiskSizeInBytes** | **long?** | Sum of capacities of all the virtual disks in the template, in bytes. | 
**Id** | **string** | Unique ID representing a VM template. | 
**IncompatibleReasons** | **List&lt;string&gt;** | Reasons that may preclude this VM template from being used in full clone desktop pool creation. | 
**MemoryMb** | **int?** | Memory size of the VM template, in MB | 
**Name** | **string** | VM template name. | 
**OperatingSystem** | **string** | Operating system. * UNKNOWN: Unknown * WINDOWS_XP: Windows XP * WINDOWS_VISTA: Windows Vista * WINDOWS_7: Windows 7 * WINDOWS_8: Windows 8 * WINDOWS_10: Windows 10 * WINDOWS_SERVER_2003: Windows Server 2003 * WINDOWS_SERVER_2008: Windows Server 2008 * WINDOWS_SERVER_2008_R2: Windows Server 2008 R2 * WINDOWS_SERVER_2012: Windows Server 2012 * WINDOWS_SERVER_2012_R2: Windows Server 2012 R2 * WINDOWS_SERVER_2016_OR_ABOVE: Windows Server 2016 or above * LINUX_OTHER: Linux (other) * LINUX_SERVER_OTHER: Linux server (other) * LINUX_UBUNTU: Linux (Ubuntu) * LINUX_RHEL: Linux (Red Hat Enterprise) * LINUX_SUSE: Linux (Suse) * LINUX_CENTOS: Linux (CentOS) | 
**OperatingSystemDisplayName** | **string** | Operating system display name from Virtual Center. | 
**Path** | **string** | VM template path. | 
**VcenterId** | **string** | ID of the vCenter to which this VM template belongs to. | 
**VgpuType** | **string** | NVIDIA GRID vGPU type configured on this VM template. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

