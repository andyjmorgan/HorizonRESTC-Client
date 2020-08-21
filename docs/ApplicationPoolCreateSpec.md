# VMware.Horizon.RESTAPI.Model.ApplicationPoolCreateSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AntiAffinityData** | [**ApplicationAntiAffinityData**](ApplicationAntiAffinityData.md) | Configure to enable anti-affinity rules. When an anti-affinity rule is configured for an application pool, Horizon Connection Server attempts to launch the application only on RDS servers that have sufficient resources to run the application. This feature can be useful for controlling applications that consume large amounts of CPU or memory resources.&lt;br&gt;An anti-affinity rule consists of an application matching pattern and a maximum count. For example, the application matching pattern might be autocad.exe and the maximum count might be 2. | [optional] 
**CategoryFolderName** | **string** | Name of the category folder in the user&#39;s OS containing a shortcut to the application. Unset if the application does not belong to a category. | [optional] 
**CsRestrictionTags** | **List&lt;string&gt;** | Connection server restrictions. Application pool can be accessed from only those connection server instances that have a matching tag in this list. Null or empty list means that the application pool can be accessed from any connection server. | [optional] 
**Description** | **string** | Notes about the application pool. | [optional] 
**DesktopPoolId** | **string** | ID of the desktop pool from which this application pool is to be created. Once an application pool is created from a desktop pool, it is always associated with that desktop pool, and cannot be removed from the desktop pool, or added to another desktop pool. Either this or farm id should be set. | [optional] 
**DisplayName** | **string** | The display name is the name that users will see in Horizon client. If the display name is left blank, it defaults to name. | [optional] 
**EnableClientRestrictions** | **bool?** | Indicates whether client restrictions are to be applied to application pool. Currently it is valid for application pool created from farm. Default value is false. | [optional] 
**EnablePreLaunch** | **bool?** | Whether to pre-launch the application. Default value is false. | [optional] 
**Enabled** | **bool?** | Indicates whether the application pool is enabled. Default value is true | [optional] 
**ExecutablePath** | **string** | Path to application executable. | 
**FarmId** | **string** | ID of the farm from which this application pool is to be created. Once an application pool is created from a farm, it is always associated with that farm, and cannot be removed from the farm, or added to another farm. Either this or desktop pool id should be set. | [optional] 
**MaxMultiSessions** | **int?** | Maximum number of multi-sessions a user can have in this application pool. This property is required if multi-session mode is set to \&quot;ENABLED_DEFAULT_OFF\&quot;, \&quot;ENABLED_DEFAULT_ON\&quot;, or \&quot;ENABLED_ENFORCED\&quot;Default value is 1. | [optional] 
**MultiSessionMode** | **string** | Multi-session mode for the application pool. An application launched in multi-session mode does not support reconnect behavior when user logs in from a different client instance. Multi-session mode should be disabled when pre-launch is enabled.Default value is \&quot;DISABLED\&quot; * DISABLED: Multi-session is not supported for this application. * ENABLED_DEFAULT_OFF: Multi-session is supported for this application but is disabled by default. The client would need to explicitly request multi-session launch, if wanted. If a legacy client is used, this will always result in a single-session application launch. * ENABLED_DEFAULT_ON: Multi-session mode is supported for this application and is enabled by default. The client can request explicitly for single-session launch, if wanted. If a legacy client is used, this will always result in a multi-session application launch. * ENABLED_ENFORCED: Multi-session is supported for this application and it is enforced. The client can not select to launch this application as a single-session application. | [optional] 
**Name** | **string** | The application pool name is the unique identifier used to identify this application pool. This property must contain only alphanumerics, underscores, and dashes. The maximum length is 64 characters. | 
**Parameters** | **string** | Parameters to pass to application when launching. | [optional] 
**Publisher** | **string** | Application publisher | [optional] 
**ShortcutLocations** | **List&lt;string&gt;** | Locations of the category folder in the user&#39;s OS containing a shortcut to the desktop. The value must be set if category folder name is provided. | [optional] 
**StartFolder** | **string** | Starting folder for application | [optional] 
**SupportedFileTypesData** | [**ApplicationSupportedFileTypesData**](ApplicationSupportedFileTypesData.md) | Supported file types details. | [optional] 
**Version** | **string** | Application version. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

