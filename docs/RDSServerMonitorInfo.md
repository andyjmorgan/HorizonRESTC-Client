# VMware.Horizon.RESTAPI.Model.RDSServerMonitorInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Details** | [**RDSServerMonitorDetails**](RDSServerMonitorDetails.md) | Server details of RDS Server. | 
**Enabled** | **bool?** | Indicates if RDS server is enabled. | 
**FarmId** | **string** | Indicates the Farm ID to which the RDS Server belongs to. | 
**Id** | **string** | Unique ID of the RDS server. | 
**LoadIndex** | **int?** | This value is similar to load_preference and represents the load on RDS Server in the range of 0 to 100. | [optional] 
**LoadPreference** | **string** | Based on the current load of this RDS Server, gives a measure of how preferential this server is to be chosen for new application sessions. * BLOCK: RDS Server is blocked and new sessions will not be accepted. * HEAVY: RDS Server is experiencing heavy load and should likely not be chosen for new sessions. * NORMAL: RDS Server is experiencing normal load and is okay to be chosen for new sessions. * LIGHT: RDS Server is experiencing light load and is okay to be chosen for new sessions. * UNKNOWN: RDS Server did not report a load preference. This is potentially a configuration issue if other RDS Servers in the same Farm do report load preferences. | [optional] 
**Name** | **string** | RDS Server name. | 
**SessionCount** | **int?** | RDS server session count. | [optional] 
**Status** | **string** | RDS server status. * OK: RDS Server is reachable. All applications (defined on its farm) are verified installed on the RDS Server. * WARNING: RDS Server is reachable. Some applications are detected as not installed on the RDS Server. * ERROR: RDS Server is unreachable, or, none of the applications are installed. * DISABLED: RDS Server is disabled. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

