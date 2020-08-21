# VMware.Horizon.RESTAPI.Model.GeneralSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationSsoTimeoutMinutes** | **int?** | The time allowed to elapse after a user has authenticated before the application SSO credentials are locked unless the user&#39;s Horizon client supports idle sessions and the user remains active. | [optional] 
**ApplicationSsoTimeoutPolicy** | **string** | Specifies the policy for the maximum time after which single sign on will be disabled for application sessions. * DISABLED_AFTER: Single sign on will be disabled after the specified number of minutes has elapsed since the user connected to Horizon Connection Server. * DISABLED: Single sign on is disabled. * ENABLED: Single sign on is enabled. | 
**BlockRestrictedClients** | **bool?** | Indicates whether restricted Horizon clients should be blocked by the Connection Server. | [optional] 
**ClientIdleSessionTimeoutMinutes** | **int?** | Determines how long a user can be idle before the Connection Server takes measure to protect the session. | [optional] 
**ClientIdleSessionTimeoutPolicy** | **string** | Specifies the policy for the maximum time that a that a user can be idle before the Connection Server takes measure to protect the session. * TIMEOUT_AFTER: The timeout is set for a configurable time. * NEVER: The timeout has been disabled. | 
**ClientMaxSessionTimeoutMinutes** | **int?** | Determines how long a user can keep a session open after logging in to the Connection Server. When a session times out, the session is terminated and the Horizon client is disconnected from the resource. This property has a default value of 600 and a minimum value of 5. This property is required if clientMaxSessionTimeoutPolicy is set to TIMEOUT_AFTER. | [optional] 
**ClientMaxSessionTimeoutPolicy** | **string** | Client max session lifetime policy. This property has a default value of TIMEOUT_AFTER. A value of TIMEOUT_AFTER indicates that the Horizon client session times out after a configurable session length. A value of NEVER indicates that the Horizon client session will not time out and will only end due to inactivity. * TIMEOUT_AFTER: The timeout is set for a configurable time. * NEVER: The timeout has been disabled. | 
**ClientSessionTimeoutMinutes** | **int?** | Determines the maximum length of time that a session will be kept active if there is no traffic between the Horizon client and the Connection Server. | 
**ConsoleSessionTimeoutMinutes** | **int?** | Determines how long an idle admin console session continues before the session times out. | [optional] 
**DisplayPreLoginMessage** | **bool?** | Indicates whether to show a disclaimer or other message when the Horizon Client user logs in. This change will take effect on next login for each user. | [optional] 
**DisplayWarningBeforeForcedLogoff** | **bool?** | Indicates whether to display a warning message when users are forced to log off because a scheduled or immediate update such as a machine-refresh operation is about to start. | [optional] 
**EnableAutomaticStatusUpdates** | **bool?** | Enable updation of the global status of the application periodically. The Dashboard Information is also updated at regular intervals when Dashboard page is active. | [optional] 
**EnableCredentialCleanupForHtmlaccess** | **bool?** | Indicates whether to clean up session credentials when one tab connecting to remote machine/application is closed. | [optional] 
**EnableMultiFactorReAuthentication** | **bool?** | Enables 2 factor re-authentication after idle session timeout. | [optional] 
**EnableSendingDomainList** | **bool?** | Indicates whether the domain list will be sent to the Horizon client. Since domain list will be sent before user is authenticated with server, it could disclose domain information to external users. | [optional] 
**EnableServerInSingleUserMode** | **bool?** | Permits RDSServer operating systems to be used for non-RDS Machines. | [optional] 
**ForcedLogoffMessage** | **string** | The warning to be displayed before logging off the user. | [optional] 
**ForcedLogoffTimeoutMinutes** | **int?** | The time to wait after the warning is displayed and before logging off the user. | [optional] 
**HideDomainListInClient** | **bool?** | Whether to hide the list of domains in the Horizon client user interface. If value set to true, the user will need to provide a UPN (e.g. user@domain) or a logon name in the format domain\\\\user when logging in. | [optional] 
**HideServerInformationInClient** | **bool?** | Indicates whether to hide the server URL in the Horizon client user interface. | [optional] 
**MachineSsoTimeoutMinutes** | **int?** | Single sign on will be disabled after the specified time has elapsed since the user connected to Connection Server. | [optional] 
**MachineSsoTimeoutPolicy** | **string** | Specifies the policy for the maximum time after which single sign on will be disabled after a user connects to the Connection Server. * DISABLED_AFTER: Single sign on will be disabled after the specified number of minutes has elapsed since the user connected to Horizon Connection Server. * DISABLED: Single sign on is disabled. * ENABLED: Single sign on is enabled. | 
**PreLoginMessage** | **string** | Displays a disclaimer or another message to Horizon Client users when they log in. No message will be displayed if this is not set. | [optional] 
**RestrictedClientData** | [**List&lt;RestrictedClientData&gt;**](RestrictedClientData.md) | List of restricted Horizon Clients. | [optional] 
**RestrictedClientMessage** | **string** | The message to be displayed to Horizon clients which are blocked by the Connection Server. | [optional] 
**StoreCalOnClient** | **bool?** | Determines whether or not to store the RDS Per Device Client Access License on Horizon client devices. This value can be true only if Store Client Access License on Connection Server is true. | 
**StoreCalOnConnectionServer** | **bool?** | Determines whether or not to store the RDS Per Device Client Access License on Connection Server. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

