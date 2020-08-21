# VMware.Horizon.RESTAPI.Model.ApplicationPoolInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessGroupId** | **string** | Access groups can organize the entities (like application pools, desktop pools) in the organization. They can also be used for delegated administration. For application pool, this is the same as that of the farm or desktop pool that the application pool belongs to.&lt;br&gt;Supported Filters: &#39;Equals&#39;. | 
**AntiAffinityData** | [**ApplicationAntiAffinityData**](ApplicationAntiAffinityData.md) | Anti-affinity data. When an anti-affinity rule is configured for an application pool, Horizon Connection Server attempts to launch the application only on RDS servers that have sufficient resources to run the application. This feature can be useful for controlling applications that consume large amounts of CPU or memory resources.&lt;br&gt;An anti-affinity rule consists of an application matching pattern and a maximum count. For example, the application matching pattern might be autocad.exe and the maximum count might be 2. | [optional] 
**CategoryFolderName** | **string** | Name of the category folder in the user&#39;s OS containing a shortcut to the application. Unset if the application does not belong to a category. | [optional] 
**CsRestrictionTags** | **List&lt;string&gt;** | Connection server restrictions. Application pool can be accessed from only those connection server instances that have a matching tag in this list. Null or empty list means that the application pool can be accessed from any connection server. | [optional] 
**CustomizedIconIds** | **List&lt;string&gt;** | List of customized icon IDs associated with the application which the user has configured. | [optional] 
**Description** | **string** | Notes about the application pool.&lt;br&gt;Supported Filters: &#39;Equals&#39;, &#39;StartsWith&#39; and &#39;Contains&#39;. | [optional] 
**DesktopPoolId** | **string** | ID of the desktop pool from which this application pool is created. Either this or farm id will be set.&lt;br&gt;Supported Filters: &#39;Equals&#39;. | [optional] 
**DisplayName** | **string** | The display name is the name that users will see when they connect to view client. If the display name is left blank, it defaults to name.&lt;br&gt;Supported Filters: &#39;Equals&#39;, &#39;StartsWith&#39; and &#39;Contains&#39;. | [optional] 
**EnableClientRestrictions** | **bool?** | Indicates whether client restrictions are to be applied to application pool. Currently it is valid for application pool created from farm.&lt;br&gt;Supported Filters: &#39;Equals&#39;. | [optional] 
**EnablePreLaunch** | **bool?** | Whether to pre-launch the application.&lt;br&gt;Supported Filters: &#39;Equals&#39;. | [optional] 
**Enabled** | **bool?** | Indicates whether the application pool is enabled.&lt;br&gt;Supported Filters: &#39;Equals&#39;. | 
**ExecutablePath** | **string** | Path to application executable.&lt;br&gt;Supported Filters: &#39;Equals&#39;, &#39;StartsWith&#39;, &#39;EndsWith&#39; and &#39;Contains&#39;. | 
**FarmId** | **string** | ID of the farm from which this application pool is created. Either this or desktop pool id will be set.&lt;br&gt;Supported Filters: &#39;Equals&#39;. | [optional] 
**IconIds** | **List&lt;string&gt;** | List of icon IDs associated with the application which are fetched from the agent. | [optional] 
**Id** | **string** | Unique ID representing application pool. | 
**MaxMultiSessions** | **int?** | Maximum number of multi-sessions a user can have in this application pool. This property is required if multi-session mode is set to \&quot;ENABLED_DEFAULT_OFF\&quot;, \&quot;ENABLED_DEFAULT_ON\&quot;, or \&quot;ENABLED_ENFORCED\&quot; | [optional] 
**MultiSessionMode** | **string** | Multi-session mode for the application pool. An application launched in multi-session mode does not support reconnect behavior when user logs in from a different client instance. Multi-session mode should be disabled when pre-launch is enabled.&lt;br&gt;Supported Filters: &#39;Equals&#39;. * DISABLED: Multi-session is not supported for this application. * ENABLED_DEFAULT_OFF: Multi-session is supported for this application but is disabled by default. The client would need to explicitly request multi-session launch, if wanted. If a legacy client is used, this will always result in a single-session application launch. * ENABLED_DEFAULT_ON: Multi-session mode is supported for this application and is enabled by default. The client can request explicitly for single-session launch, if wanted. If a legacy client is used, this will always result in a multi-session application launch. * ENABLED_ENFORCED: Multi-session is supported for this application and it is enforced. The client can not select to launch this application as a single-session application. | [optional] 
**Name** | **string** | The application name is the unique identifier used to identify this application pool. This property must contain only alphanumerics, underscores, and dashes. The maximum length is 64 characters.&lt;br&gt;Supported Filters: &#39;Equals&#39;, &#39;StartsWith&#39; and &#39;Contains&#39;. | 
**Parameters** | **string** | Parameters to pass to application when launching. | [optional] 
**Publisher** | **string** | Application publisher.&lt;br&gt;Supported Filters: &#39;Equals&#39;, &#39;StartsWith&#39; and &#39;Contains&#39;. | [optional] 
**ShortcutLocations** | **List&lt;string&gt;** | Locations of the category folder in the user&#39;s OS containing a shortcut to the application. The value must be set if category folder name is provided. | [optional] 
**StartFolder** | **string** | Starting folder for application. | [optional] 
**SupportedFileTypesData** | [**ApplicationSupportedFileTypesData**](ApplicationSupportedFileTypesData.md) | Supported file types details. | [optional] 
**Version** | **string** | Application version.&lt;br&gt;Supported Filters: &#39;Equals&#39;, &#39;StartsWith&#39; and &#39;Contains&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

