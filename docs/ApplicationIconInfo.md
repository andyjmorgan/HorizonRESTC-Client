# VMware.Horizon.RESTAPI.Model.ApplicationIconInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicationPoolIds** | **List&lt;string&gt;** | An application icon could be shared by multiple application pools. This is a set of application pool IDs this icon represents. | [optional] 
**Data** | **byte[]** | Icon image data in PNG format. | [optional] 
**Height** | **int?** | Icon height. | [optional] 
**IconHash** | **string** | MD5 hash of icon image data, to enable quick icon lookup. | [optional] 
**IconSource** | **string** | Source of the application icon. The icon can be from Machine/RDS Agent or custom icon. * HORIZON_AGENT: When the icon is from machine/RDS agent. * HORIZON_CONNECTION_SERVER: When the icon is uploaded by the administrator through connection server. | [optional] 
**Id** | **string** | Unique ID representing application icon. | [optional] 
**Width** | **int?** | Icon width. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

