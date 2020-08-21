# VMware.Horizon.RESTAPI.Model.VirtualMachineInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HardwareVersion** | **int?** | Hardware version for this VM. | 
**Id** | **string** | Unique ID representing a VM. | 
**IncompatibleReasons** | **List&lt;string&gt;** | Reasons that may preclude this Virtual Machine from having its snapshots used in linked or instant clone desktop or farm. | [optional] 
**Name** | **string** | VM name. | 
**OperatingSystem** | **string** | Operating system. * UNKNOWN: Unknown * WINDOWS_XP: Windows XP * WINDOWS_VISTA: Windows Vista * WINDOWS_7: Windows 7 * WINDOWS_8: Windows 8 * WINDOWS_10: Windows 10 * WINDOWS_SERVER_2003: Windows Server 2003 * WINDOWS_SERVER_2008: Windows Server 2008 * WINDOWS_SERVER_2008_R2: Windows Server 2008 R2 * WINDOWS_SERVER_2012: Windows Server 2012 * WINDOWS_SERVER_2012_R2: Windows Server 2012 R2 * WINDOWS_SERVER_2016_OR_ABOVE: Windows Server 2016 or above * LINUX_OTHER: Linux (other) * LINUX_SERVER_OTHER: Linux server (other) * LINUX_UBUNTU: Linux (Ubuntu) * LINUX_RHEL: Linux (Red Hat Enterprise) * LINUX_SUSE: Linux (Suse) * LINUX_CENTOS: Linux (CentOS) | 
**OperatingSystemDisplayName** | **string** | Operating system display name from Virtual Center. | 
**Path** | **string** | VM path. | 
**VGputype** | **string** | Virtual GPU type. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

