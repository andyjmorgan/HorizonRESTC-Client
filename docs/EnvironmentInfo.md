# VMware.Horizon.RESTAPI.Model.EnvironmentInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterGuid** | **string** | The GUID of a group of Connection Servers sharing the same configuration. | 
**ClusterName** | **string** | The name of a group of Connection Servers sharing the same configuration. | 
**FipsModeEnabled** | **bool?** | Indicates if FIPS mode is enabled. | 
**IpMode** | **string** | Indicates the IP mode of the environment. * IPv4: The ip mode is IPv4. * IPv6: The ip mode is IPv6. | 
**LocalPodName** | **string** | The name of the current pod in the Multi-DataCenter Horizon Pod, the value will be null when PodFederation is not initialized. | [optional] 
**TimezoneOffset** | **int?** | Represents the clusters time zone offset from UTC in seconds. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

