# VMware.Horizon.RESTAPI.Model.FarmSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteInProgess** | **bool?** | Indicates whether the Farm is in the process of being deleted. Default value is false. | 
**DesktopId** | **string** | Desktop pool Id representing the RDS Desktop pool to which this Farm belongs. | [optional] 
**DisplayProtocolSettings** | [**FarmDisplayProtocolSettings**](FarmDisplayProtocolSettings.md) | Display protocol settings for session related to the Farm. | [optional] 
**LoadBalancerSettings** | [**FarmLoadBalancerSettings**](FarmLoadBalancerSettings.md) | Settings for load balancing the session requests across the RDS servers in the farm. | [optional] 
**ServerErrorThreshold** | **int?** | The minimum number of machines that must be fully operational in order toavoid showing the farm in an error state. Default value is 0. | [optional] 
**SessionSettings** | [**FarmSessionSettings**](FarmSessionSettings.md) | Session related settings for the Farm. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

