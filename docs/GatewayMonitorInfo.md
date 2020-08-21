# VMware.Horizon.RESTAPI.Model.GatewayMonitorInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveConnectionCount** | **int?** | Number of active connections for the gateway. Includes PCoIP and BLAST connection counts. | [optional] 
**BlastConnectionCount** | **int?** | Number of BLAST connections for the gateway. | [optional] 
**Details** | [**GatewayMonitorDetails**](GatewayMonitorDetails.md) | Details of the gateway. | 
**Id** | **string** | Unique ID of the Gateway. | 
**Name** | **string** | Gateway name. | 
**PcoipConnectionCount** | **int?** | Number of PCoIP connections for the gateway. | [optional] 
**Status** | **string** | Status of the Gateway. * NOT_CONTACTED: There has been no contact from the gateway. * PROBLEM: The gateway has reported a problem. * STALE: Gateway is stale. Gateway will be marked as stale when Connection Server does not receive any request from the Gateway in last two successive intervals. * OK: The Gateway is working as expected. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

