# VMware.Horizon.RESTAPI.Model.ImageManagementStreamCreateSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdditionalDetails** | **Dictionary&lt;string, string&gt;** | Additional details about image management stream. | [optional] 
**Description** | **string** | Image management stream description. | [optional] 
**Name** | **string** | Image management stream name. | 
**OperatingSystem** | **string** | Operating system. * UNKNOWN: Unknown * WINDOWS_XP: Windows XP * WINDOWS_VISTA: Windows Vista * WINDOWS_7: Windows 7 * WINDOWS_8: Windows 8 * WINDOWS_10: Windows 10 * WINDOWS_SERVER_2003: Windows Server 2003 * WINDOWS_SERVER_2008: Windows Server 2008 * WINDOWS_SERVER_2008_R2: Windows Server 2008 R2 * WINDOWS_SERVER_2012: Windows Server 2012 * WINDOWS_SERVER_2012_R2: Windows Server 2012 R2 * WINDOWS_SERVER_2016_OR_ABOVE: Windows Server 2016 or above * LINUX_OTHER: Linux (other) * LINUX_SERVER_OTHER: Linux server (other) * LINUX_UBUNTU: Linux (Ubuntu) * LINUX_RHEL: Linux (Red Hat Enterprise) * LINUX_SUSE: Linux (Suse) * LINUX_CENTOS: Linux (CentOS) | 
**Publisher** | **string** | Image management stream publisher | [optional] 
**Source** | **string** | Image management stream source. * MARKET_PLACE: Image management stream is from market place. * UPLOADED: Image management stream is uploaded. * COPIED_FROM_STREAM: Image management stream is copied from another stream. * COPIED_FROM_VERSION: Image management stream is copied from a version. | 
**Status** | **string** | Image management stream status. * AVAILABLE: Image management stream is available for desktop pools/farms to be created. * DELETED: Image management stream is deleted. * DISABLED: Image management stream is disabled and no further desktop pools/farms can be created using the same. * FAILED: Image management stream creation has failed. * IN_PROGRESS: Image management stream creation is in progress. * PARTIALLY_AVAILABLE: Image management version for this stream could not be created in one or more environments. * PENDING: Image management stream is in pending state. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

