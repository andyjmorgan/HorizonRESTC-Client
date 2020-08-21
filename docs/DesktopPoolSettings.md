# VMware.Horizon.RESTAPI.Model.DesktopPoolSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMutilpleSessionsPerUser** | **bool?** | Whether multiple sessions are allowed per user for this pool. This is valid for RDS desktop pools.For other Desktops, allow_multiple_sessions_per_user in settings will be applicable.Default value is false. | [optional] 
**CategoryFolderName** | **string** | Name of the category folder in the user&#39;s OS containing a shortcut to the desktop pool.Will be unset if the desktop does not belong to a category.This property defines valid folder names with a max length of 64 characters and up to 4 subdirectory levels.The subdirectories can be specified using a backslash, e.g. (dir1\\dir2\\dir3\\dir4). Folder names can&#39;t start orend with a backslash nor can there be 2 or more backslashes together. Combinations such as(\\dir1, dir1\\dir2\\, dir1\\\\dir2, dir1\\\\\\dir2) are invalid. The windows reserved keywords(CON, PRN, NUL, AUX, COM1 - COM9, LPT1 - LPT9 etc.) are not allowed in subdirectory names. | [optional] 
**CloudAssigned** | **bool?** | Indicates whether this desktop is assigned to a workspace in Horizon Cloud Services. Default value is false. | [optional] 
**CloudManaged** | **bool?** | Indicates whether this desktop is managed by Horizon Cloud Services.This can be false only when cloud_assigned is false. Default value is false. | [optional] 
**CsRestrictionTags** | **List&lt;string&gt;** | List of tags for which the access to the desktop pool is restricted to.No list indicates that desktop pool can be accessed from any connection server. | [optional] 
**DeleteInProgress** | **bool?** | Indicates whether the desktop pool is in the process of being deleted.Default value is false. | 
**DisplayProtocolSettings** | [**DesktopPoolDisplayProtocolSettings**](DesktopPoolDisplayProtocolSettings.md) | Remote display protocol settings. These relate to RDP/PCoIP/BLAST. | [optional] 
**EnableClientRestrictions** | **bool?** | Client restrictions to be applied to the desktop pool.Currently it is valid for RDS desktop pools only. Default value is false. | [optional] 
**SessionSettings** | [**DesktopPoolSessionSettings**](DesktopPoolSessionSettings.md) | Includes machine settings applicable when a user logs off or when a desktop pool is no longer keeping a machine as a spare. | [optional] 
**SessionType** | **string** | Supported session types for this desktop pool. If application sessions are selected to besupported then this desktop pool can be used for application pool creation. This will beuseful when the machines in the pool support application remoting. Default value of DESKTOP. * DESKTOP: Only desktop sessions are supported. * APPLICATION: Only application sessions are supported. * DESKTOP_AND_APPLICATION: Both desktop and application sessions are supported. | [optional] 
**ShortcutLocations** | **List&lt;string&gt;** | Locations of the category folder in the user&#39;s OS containing a shortcut to the desktop pool.The value will be present if categoryFolderName is set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

