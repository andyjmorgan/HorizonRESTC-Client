# VMware.Horizon.RESTAPI.Model.BulkEntitlementResponseInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Details** | [**List&lt;EntitlementResponseInfo&gt;**](EntitlementResponseInfo.md) | List of entitlement response info objects correpsonding to each of the given ad-user-or-group SID. | [optional] 
**ErrorMessages** | **List&lt;string&gt;** | Reasons for the failure of the operation. | [optional] 
**Id** | **string** | Unique ID representing the resource for the entitlement operation. | [optional] 
**StatusCode** | **int?** | Response HTTP status code of the operation. | [optional] 
**Timestamp** | **long?** | Timestamp in milliseconds when the operation failed. Measured as epoch time. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

