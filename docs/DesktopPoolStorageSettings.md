# VMware.Horizon.RESTAPI.Model.DesktopPoolStorageSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Datastores** | [**List&lt;DesktopPoolDatastoreSettings&gt;**](DesktopPoolDatastoreSettings.md) | Datastores to store the machine (or the OS disk using other options for linked clone or instant clone machine storage) | [optional] 
**NonPersistentDiskDriveLetter** | **string** | Non persistent disk drive letter. | [optional] 
**NonPersistentDiskSizeMb** | **int?** | Size of the non persistent disk in MB. | [optional] 
**NonPersistentRedirectDisposableFiles** | **bool?** | Redirect disposable files to a non-persistent disk that will be deleted automatically when a user&#39;s session ends. | [optional] 
**PersistentDiskDatastores** | [**List&lt;DesktopPoolDatastoreSettings&gt;**](DesktopPoolDatastoreSettings.md) | Datastores to store persistent disks for linked clone machines. | [optional] 
**PersistentDiskDriveLetter** | **string** | Persistent disk drive letter. | [optional] 
**PersistentDiskSizeMb** | **int?** | Size of the persistent disk in MB. | [optional] 
**ReclaimVmDiskSpace** | **bool?** | With vSphere 5.x, virtual machines can be configured to use a space efficient disk format that supports reclamation of unused disk space (such as deleted files). This option reclaims unused disk space on each virtual machine. The operation is initiated when an estimate of used disk space exceeds the specified threshold. | [optional] 
**ReclamationThresholdMb** | **long?** | Initiate reclamation when unused space on virtual machine exceeds the threshold in MB. | [optional] 
**RedirectWindowsProfile** | **bool?** | Windows profiles will be redirected to persistent disks, which are not affected by View Composer operations such as refresh, recompose and rebalance. | [optional] 
**ReplicaDiskDatastoreId** | **string** | Datastore to store replica disks for linked clone and instant clone machines. | [optional] 
**UseNativeSnapshots** | **bool?** | Applicable To: Linked/instant clone automated desktop pool.&lt;br&gt;Native NFS Snapshots (VAAI - vStorage API for Array Integration) is a hardware feature of certain storage arrays. It uses native snapshotting technology to provide linked clone functionality. | [optional] 
**UseSeparateDatastoresPersistentAndOsDisks** | **bool?** | Whether to use separate datastores for persistent and OS disks. | [optional] 
**UseSeparateDatastoresReplicaAndOsDisks** | **bool?** | Whether to use separate datastores for replica and OS disks. | [optional] 
**UseVsan** | **bool?** | Whether to use vSphere vSAN. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

