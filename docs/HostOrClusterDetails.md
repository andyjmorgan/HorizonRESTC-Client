# VMware.Horizon.RESTAPI.Model.HostOrClusterDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cluster** | **bool?** | Whether or not this is a cluster or a host. | 
**DatacenterId** | **string** | Datacenter id for this host or cluster. | 
**IncompatibleReasons** | **List&lt;string&gt;** | Reasons that may preclude this Host Or Cluster from being used in desktop pool creation. | 
**Name** | **string** | Host or cluster display name. | 
**Path** | **string** | Host or cluster path. | 
**VcenterId** | **string** | Virtual Center id for this host or cluster. | 
**VgpuTypes** | **List&lt;string&gt;** | Types of NVIDIA GRID vGPUs supported by this host or at least one host on this cluster. If unset, this host or cluster does not support NVIDIA GRID vGPUs and cannot be used for desktop creation with NVIDIA GRID vGPU support enabled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

