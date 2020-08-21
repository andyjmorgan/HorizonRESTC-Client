# VMware.Horizon.RESTAPI.Model.PodEndPointData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool?** | Indicates whether an endpoint is enabled. A disabled endpoint will be excluded from participating inter-pod communication. | 
**Id** | **string** | Unique ID for a pod endpoint. | 
**Name** | **string** | Name for the pod endpoint. | 
**RoundtripTime** | **long?** | Round trip time (in milliseconds) for ping request between the local pod endpoint and the remote pod. | [optional] 
**Status** | **string** | Status of the pod endpoint. * ONLINE: Pod endpoint is online and functional. * UNCHECKED: Pod endpoint was offline and it just came back online but the system has not verified that it is functional. * OFFLINE: Pod endpoint is offline or unreachable. | 
**Url** | **string** | The URL for the pod endpoint. This address and special port will be used for inter-pod communication. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

