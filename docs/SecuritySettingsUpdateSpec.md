# VMware.Horizon.RESTAPI.Model.SecuritySettingsUpdateSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataRecoveryPasswordHash** | **List&lt;string&gt;** | The SHA-256 hash of the (UTF-8) data recovery password. | [optional] 
**DataRecoveryPasswordHint** | **string** | The data recovery password hint. This property has a maximum length of 128 characters. | [optional] 
**MessageSecurityMode** | **string** | Determines if signing and verification of the JMS messages passed between Horizon components takes place. * DISABLED: Message security mode is disabled. * MIXED: Message security mode is enabled but not enforced. * ENABLED: Message security mode is enabled. Unsigned messages are rejected by Horizon components. * ENHANCED: Message Security mode is Enhanced. Message signing and validation is performed based on the current Security Level and desktop Message Security mode. | 
**ReAuthSecureTunnelAfterInterruption** | **bool?** | Determines if user credentials must be re-authenticated after a network interruption when Horizon clients use secure tunnel connections to Horizon resources. When you select this setting, if a secure tunnel connection ends during a session, Horizon Client requires the user to re-authenticate before reconnecting. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

