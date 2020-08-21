# VMware.Horizon.RESTAPI.Model.DesktopPoolInstantClonePushImageSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddVirtualTpm** | **bool?** | Whether to add Virtual TPM device. | [optional] 
**LogoffPolicy** | **string** | Determines when to perform the operation on machines which have an active session. * FORCE_LOGOFF: Users will be forced to log off when the system is ready to operate on their virtual machines. Before being forcibly logged off, users may have a grace period in which to save their work (Global Settings). * WAIT_FOR_LOGOFF: Wait for connected users to disconnect before the task starts. The operation starts immediately on machines without active sessions. | [optional] 
**StartTime** | **long?** | When to start the operation. If unset or the time is in the past, the operation will begin immediately. Measured as epoch time. | [optional] 
**StopOnFirstError** | **bool?** | Indicates that the operation should stop on first error. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

