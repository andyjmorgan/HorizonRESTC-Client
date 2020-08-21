# VMware.Horizon.RESTAPI.Model.DesktopPoolDatastoreSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatastoreId** | **string** | Id of the datastore. | [optional] 
**SdrsCluster** | **bool?** | Whether datastore represents a Storage DRS cluster. | [optional] 
**StorageOvercommit** | **string** | Storage overcommit determines how Horizon places new machines on the selected datastores. With an aggressive overcommit level, Horizon reserves less space for sparse disk growth, but fits more machines on the datastore. * NONE: No overcommit. * CONSERVATIVE: Conservative. * MODERATE: Moderate. * AGGRESSIVE: Aggressive. * UNBOUNDED: Unbounded. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

