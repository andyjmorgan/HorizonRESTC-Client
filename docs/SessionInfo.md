# VMware.Horizon.RESTAPI.Model.SessionInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessGroupId** | **string** | Access group id associated with the session.  For a non-RDS desktop session, this is the desktop pool&#39;s access group id.  For an RDS desktop session, this is the RDS desktop pool&#39;s farm&#39;s access group id.  For an application session, this is the application&#39;s farm&#39;s access group id. | [optional] 
**AgentVersion** | **string** | Version of agent This property need not be set. | [optional] 
**ApplicationNames** | **List&lt;string&gt;** | Names of the applications launched in the session.  It will be only set when session_type is APPLICATION. | [optional] 
**BrokerUserId** | **string** | User SID for the broker user associated with the session.  It will be unset for non-broker sessions. | [optional] 
**BrokeredRemotely** | **bool?** | Indicates whether the session is brokered from a remote pod.  It is set only if the Horizon View agent where the session resides is version 6.0 or later. | [optional] 
**ClientData** | [**ClientData**](ClientData.md) | Client data associated with the session. | [optional] 
**DesktopPoolId** | **string** | Unique desktop pool id for the session.  This is unset if the session is not brokered through a desktop, such as for direct console access. | [optional] 
**DisconnectedTime** | **long?** | Epoch time in milli seconds, when the session was last disconnected.  This will be unset if the session&#39;s machine has an error state, or if the session has never been disconnected. | [optional] 
**FarmId** | **string** | Unique farm id for this RDS desktop or application session. This is unset if the session is not brokered through a farm, such as for application sessions or direct console access. | [optional] 
**Id** | **string** | Unique id representing a session. | [optional] 
**IdleDuration** | **long?** | Idle time duration in minutes, indicating how long the end user of the session has been idle for. This property need not be set. | [optional] 
**LastSessionDurationMs** | **long?** | Duration of the last connection period of the session in milli seconds. If the session is currently connected, this is the duration that the session has been in connected state. If the session is currently disconnected, this is the duration of its previous connection period. This will be unset on error. | [optional] 
**MachineId** | **string** | Unique machine id for the session.  This is unset for RDS Desktop or application sessions. If desktop pool id is unset, it is the id of registered un-managed physical machine. | [optional] 
**RdsServerId** | **string** | Unique RDS server id for the RDS desktop or application session. This property need not be set. | [optional] 
**ResourcedRemotely** | **bool?** | Indicates whether the session is running on remote pod resource. | [optional] 
**SecurityGatewayData** | [**SecurityGatewayData**](SecurityGatewayData.md) | Security gateway data associated with the session. | [optional] 
**SessionProtocol** | **string** | Protocol for the session.  It will be unset for disconnected sessions. * PCOIP: Display protocol is PCoIP. * RDP: Display protocol is RDP. * BLAST: Display protocol is BLAST. * CONSOLE: Display protocol is console. * UNKNOWN: Display protocol is unknown. | [optional] 
**SessionState** | **string** | State of session. * CONNECTED: Session is connected * DISCONNECTED: Session is disconnected * PENDING: Session is pending | [optional] 
**SessionType** | **string** | Type of session. * DESKTOP: Desktop or RDS desktop session. * APPLICATION: Application session. | [optional] 
**StartTime** | **long?** | Epoch time in milli seconds, when the session was originally logged in.  The lifecycle of a session begins at login and ends at logout, with any number of connect and disconnect occurrences in between. The first connection time will be shortly after this time.  This property need not be set. | [optional] 
**Unauthenticated** | **bool?** | Indicates whether the session is of unauthenticated access user.  This property need not be set. | [optional] 
**UserId** | **string** | Unique SID of the user logged into the session.  It may not match the broker user id for non-SSO scenarios. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

