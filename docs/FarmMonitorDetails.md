# VMware.Horizon.RESTAPI.Model.FarmMonitorDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | Source of farm machines. This property is required if type is set to \&quot;AUTOMATED\&quot;. * LINKED_CLONE: Linked clone share the same base image and use less storage space than full RDS Servers. * INSTANT_CLONE: Instant clone engine uses vmfork technology to create the instant clones. These clones take much less time for provisioning. | [optional] 
**Type** | **string** | Farm type. * AUTOMATED: Automated Farm. * MANUAL: Manual farm. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

