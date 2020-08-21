# VMware.Horizon.RESTAPI.Model.VCMonitorHost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuCoreCount** | **int?** | Number of physical CPU cores on the host. | [optional] 
**CpuMhz** | **int?** | CPU speed per core in Mhz. This might be an averaged value if the speed is not uniform across all cores. | [optional] 
**Details** | [**VCMonitorHostDetails**](VCMonitorHostDetails.md) | Details of the ESX Host. | 
**MemorySizeMb** | **int?** | The physical memory size in mega bytes. | [optional] 
**Status** | **string** | Status of the host connection. * CONNECTED: The host is successfully connected to Virtual Center server. * DISCONNECTED: The host is disconnected from Virtual Center server. * NOT_RESPONDING: The host is not responding. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

