# VMware.Horizon.RESTAPI.Model.NetworkLabelInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AvailablePorts** | **int?** | Available ports in network label. | [optional] 
**Id** | **string** | Unique ID representing the network label. | [optional] 
**IncompatibleReasons** | **List&lt;string&gt;** | Reasons that may preclude this Network Label from being used in desktoppool/farm configuration. | [optional] 
**LabelType** | **string** | Network label type. * EARLY_BINDING: A free Distributed Virtual Port will be selected and assigned to a Virtual Machine when the Virtual Machine is reconfigured to connect to the portgroup. Instant clones desktop pools/farms only support port group type of early binding. * EPHEMERAL: A Distributed Virtual Port will be created and assigned to a Virtual Machine when the Virtual Machine is powered on, and will be deleted when the Virtual Machine is powered off. An ephemeral portgroup has no limit on the number of ports that can be a part of this portgroup. In cases where the vCenter Server is unavailable the host can create conflict ports in this portgroup to be used by a Virtual Machine at power on. * LATE_BINDING: Deprecated as of vSphere API 5.0 A free DistributedVirtualPort will be selected and assigned to a Virtual Machine when the Virtual Machine is powered on. | [optional] 
**MaxPorts** | **int?** | The total number of ports present. | [optional] 
**Name** | **string** | Network label name. | [optional] 
**SwitchType** | **string** | Network label switch type. * STANDARD_SWITCH: Standard Switch. * DISTRIBUTED_VIRTUAL_SWITCH: Distributed Virtual Switch. * NSX_NETWORK_SWITCH: NSX network Switch. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

