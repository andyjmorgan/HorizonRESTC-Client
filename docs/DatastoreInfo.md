# VMware.Horizon.RESTAPI.Model.DatastoreInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapacityMb** | **long?** | Maximum capacity of this datastore, in MB. | [optional] 
**DatacenterId** | **string** | Datacenter id for this datastore. | [optional] 
**DiskType** | **string** | Disk type of the datastore. * SSD: Solid State Drive disk type. * NON_SSD: NON-Solid State Drive disk type. * UNKNOWN: Unknown disk type. * NON_VMFS: NON-VMFS disk type. | [optional] 
**FileSystemType** | **string** | File system type of the datastore. * VMFS: Virtual Machine File System. * NFS: Network File System. * VSAN: vSAN File System. * VVOL: Virtual Volumes. | [optional] 
**FreeSpaceMb** | **long?** | Available capacity of this datastore, in MB. | [optional] 
**HostOrClusterId** | **string** | Host or Cluster id for this datastore. | [optional] 
**Id** | **string** | Unique ID representing the datastore. | [optional] 
**IncompatibleReasons** | **List&lt;string&gt;** | Reasons that may preclude this Datastore from being used in desktop pool/farm. | [optional] 
**LocalDatastore** | **bool?** | Indicates if this datastore is local to a single host. | [optional] 
**Name** | **string** | Datastore name. | [optional] 
**NumberOfVms** | **int?** | Indicates the number of virtual machines the datastore has for desktop pool/farm when applicable | [optional] 
**Path** | **string** | Datastore path. | [optional] 
**VcenterId** | **string** | Virtual Center id for this datastore. | [optional] 
**VmfsMajorVersion** | **string** | The VMFS major version number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

