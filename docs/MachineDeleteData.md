# VMware.Horizon.RESTAPI.Model.MachineDeleteData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowDeleteFromMultiDesktopPools** | **bool?** | Determines whether the machines from different desktop pools can be deleted. This defaults to false in which case only machines belonging to single desktop pool can be deleted. If true, machines from different desktop pools can be deleted. | [optional] 
**ArchiveDatastoreId** | **string** | Determines the datastore where the persistent user disk will be saved for future use. Both this as well as the archiveDatastorePathId need to be set. If this is unset and archivePersistentDisk is specified, the persistent disk is archived in place. | [optional] 
**ArchiveDatastorePathId** | **string** | Determines the location in the datastore where the persistent user disk will be saved for future use. If this is set, then archiveDatastoreId also needs to be specified.If this is unset and archivePersistentDisk is specified, the persistent disk is archived in place. | [optional] 
**ArchivePersistentDisk** | **bool?** | Determines whether to detach the persistent user disk and save it for future use. This can only be specified for linked-clone desktops with redirectWindowsProfile enabled, in which case it defaults to true.  | [optional] 
**DeleteFromDisk** | **bool?** | Determines whether the Machine VM should be deleted from vCenter Server. This is only applicable for managed machines. This must always be true for machines in linked and instant clone desktops. This defaults to true for linked and instant clone machines and false for all other types. If this is true, then machine being deleted must not have any active user session, otherwise delete operation would fail. | [optional] 
**ForceLogoffSession** | **bool?** | Determines whether active session on the machine to be logged off before deletion. This is only applicable for managed machines. If true, active session on the machine will be logged off before Machine delete. Otherwise,it will result in an exception.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

