# VMware.Horizon.RESTAPI.Model.FarmSessionSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisconnectedSessionTimeoutMinutes** | **int?** | Disconnected sessions timeout (in minutes).Will be set when disconnected_session_timeout_policy is set to AFTER. | [optional] 
**DisconnectedSessionTimeoutPolicy** | **string** | Log-off policy after disconnected session. Default value is NEVER. * IMMEDIATELY: Immmediately Logoff after user disconnect. * AFTER: Logoff after the specified number of minutes after user disconnect. * NEVER: Do not logoff after user disconnect. | 
**EmptySessionTimeoutMinutes** | **int?** | Application empty session timeout in minutes. An empty session that has no remote-ablewindow is disconnected after the timeout. Default value is 1.Will be set when the empty_session_timeout_policy set to AFTER. | [optional] 
**EmptySessionTimeoutPolicy** | **string** | Application empty session timeout policy. Default value is AFTER. * IMMEDIATE: Empty session will be disconnected immediately. * NEVER: Empty session will never disconnected. * AFTER: Empty session will be disconnected after specified number of minutes. | 
**LogoffAfterTimeout** | **bool?** | After timeout, empty application sessions are logged off when set to true. Otherwise sessions are disconnected.Default value is false. | 
**PreLaunchSessionTimeoutMinutes** | **int?** | Application pre-launch session timeout in minutes. A pre-launch session is disconnected after the timeout.Will be set only when pre_launch_timeout_policy is set to AFTER. | [optional] 
**PreLaunchSessionTimeoutPolicy** | **string** | Pre-launch session timeout policy for the application sessions on this Farm. * AFTER: Pre-launched session is disconnected after specified number of minutes. * NEVER: Pre-launched session is never disconnected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

