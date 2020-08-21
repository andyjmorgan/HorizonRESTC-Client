# VMware.Horizon.RESTAPI.Model.LoadBalancerMetricSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CpuThreshold** | **int?** | Represents threshold of CPU usage, in percentage. If the value is 0,then this metric will not be considered for load balancing. Default value is 0. | [optional] 
**DiskQueueLengthThreshold** | **int?** | Represents the threshold of average number of both read and write requests that werequeued for the selected disk during the sample interval. If the value is 0,then this metric will not be considered for load balancing. Default value is 0. | [optional] 
**DiskReadLatencyThreshold** | **int?** | Represents the threshold of average time, in milliseconds, of a read of data from the disk. If the value is 0,then this metric will not be considered for load balancing. Default value is 0. | [optional] 
**DiskWriteLatencyThreshold** | **int?** | Represents the threshold of average time, in milliseconds, of a write of data to the disk.If the value is 0, then this metric will not be considered for load balancing. Default value is 0. | [optional] 
**IncludeSessionCount** | **bool?** | Whether to include session count for load balancing. Default value is true. | [optional] 
**MemoryThreshold** | **int?** | Represents threshold of memory usage, in percentage.If the value is 0, then this metric will not be considered for load balancing. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

