# VMware.Horizon.RESTAPI.Model.FarmDisplayProtocolSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowDisplayProtocolOverride** | **bool?** | Indicates whether the display protocol settings could be overridden.If set to false, then default_display_protocol is used.Default value is true. | 
**DefaultDisplayProtocol** | **string** | The default server display protocol. Default value is PCOIP. * RDP: Microsoft Remote Desktop Protocol. * PCOIP: PCoIP protocol. * BLAST: BLAST protocol. | 
**GridVgpusEnabled** | **bool?** | If this is true, the host or cluster associated with the farm must support NVIDIA GRID andvGPU types required by the RDSH desktop virtualMachines, VmTemplate, or BaseImageSnapshot.If this is false, RDSH instant clone farm must not support NVIDIA GRID vGPUs.Default value is false. | [optional] 
**HtmlAccessEnabled** | **bool?** | This property is no longer in use for Horizon Components. It is always set to true. HTML Access, enabled by VMware Blast technology, allows users to connect to Horizon machines from Web browsers. Horizon Client software does not have to be installed on the client devices. To enable HTML Access, you must install the HTML Machine Access feature pack. | 
**SessionCollaborationEnabled** | **bool?** | Enable session collaboration feature. Session collaborationallows a user to share their remote session with other users.BLAST must be configured as a supported protocol in supported_display_protocols.Default value is false. | 
**VgpuGridProfile** | **string** | NVIDIA GRID vGPUs might have multiple profiles and any one of the available profiles can beapplied to newly created instant clone RDSH server. The profile specified in this field will beused in the newly created instant clone RDSH server. Will be set if enable_grid_vgpus set to true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

