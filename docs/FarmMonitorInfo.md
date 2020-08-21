# VMware.Horizon.RESTAPI.Model.FarmMonitorInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationCount** | **int?** | Number of Applications published from the farm. | [optional] 
**Details** | [**FarmMonitorDetails**](FarmMonitorDetails.md) | Details of Farm. | 
**Id** | **string** | Unique ID of the Farm. | 
**Name** | **string** | Farm name. | 
**RdsServerCount** | **int?** | Number of RDS Servers in the farm. | [optional] 
**Status** | **string** | Status of Farm. * OK: Farm is enabled and no servers are in WARNING or ERROR state. One or more server(s) may be DISABLED (including the case where all of them are DISABLED). * WARNING: Farm is enabled. One or more of the following is true: 1) One or more server(s) is either in WARNING or ERROR (not exceeding the predefined threshold) state. 2) The RDS Servers in this Farm present a mix of both known and unknown load preferences. * ERROR: Farm is enabled. One or more server(s) (exceeding the predefined threshold) is in ERROR state, or, for Automated Farms, there could be a provisioning error. * DISABLED: Farm is disabled. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

