# VMware.Horizon.RESTAPI.Model.SecuritySettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClusterPublicKey** | **string** | The Base 64 encoded public key of the cluster in PEM format. | 
**ClusterPublicKeyId** | **string** | Key Id to identify the cluster&#39;s active key pair. | [optional] 
**DataRecoveryPasswordConfigured** | **bool?** | Indicates whether the backup recovery password has been configured. | 
**MessageSecurityMode** | **string** | Determines if signing and verification of the JMS messages passed between Horizon components takes place. * DISABLED: Message security mode is disabled. * MIXED: Message security mode is enabled but not enforced. * ENABLED: Message security mode is enabled. Unsigned messages are rejected by Horizon components. * ENHANCED: Message Security mode is Enhanced. Message signing and validation is performed based on the current Security Level and desktop Message Security mode. | 
**MessageSecurityStatus** | **string** | The status of the JMS message security. This tracks the application of changes to messageSecurityMode. * READY: The cluster is performing at the specified message security mode. * INITIALIZING_ENHANCED: The cluster is initializing a transition to the ENHANCED message security mode. * PENDING_ENHANCED: The cluster is propagating the change to ENHANCED message security mode to all nodes. * LEAVING_ENHANCED: The cluster is leaving the ENHANCED message security mode. | 
**ReAuthSecureTunnelAfterInterruption** | **bool?** | Determines if user credentials must be re-authenticated after a network interruption when Horizon clients use secure tunnel connections to Horizon resources. When you select this setting, if a secure tunnel connection ends during a session, Horizon Client requires the user to re-authenticate before reconnecting. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

