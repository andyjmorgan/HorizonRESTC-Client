# VMware.Horizon.RESTAPI.Model.ADUserOrGroupSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Container** | **string** | AD container for this user or group. | [optional] 
**Description** | **string** | Description number of this user or group. Supported Filters : &#39;Equals&#39;, &#39;StartsWith&#39;, &#39;Contains&#39;. | [optional] 
**DisplayName** | **string** | Login name with domain of this user or group. | [optional] 
**DistinguishedName** | **string** | Active Directory distinguished name for this user or group. | [optional] 
**Domain** | **string** | DNS name of the domain in which this user or group belongs. Supported Filters : &#39;Equals&#39;.  Also, if &#39;Or&#39; filter is used anywhere in filter string for this model class, then that &#39;Or&#39; filter should nest only &#39;Equals&#39; filter on &#39;domain&#39; field. | 
**Email** | **string** | Email address of this user or group. Supported Filters : &#39;Equals&#39;, &#39;StartsWith&#39;, &#39;Contains&#39;. | [optional] 
**FirstName** | **string** | First name of this user or group. | [optional] 
**Group** | **bool?** | Indicates if this object represents a group. This field is NOT supported in filter string. To use any filter on &#39;group&#39;, use &#39;group_only&#39; query param directly. | 
**Guid** | **string** | GUID of the user or group in RFC 4122 format. Supported Filters : &#39;Equals&#39;. | 
**Id** | **string** | Unique SID representing this AD User or Group. | 
**KioskUser** | **bool?** | Indicates if this user or group is a \&quot;kiosk user\&quot; that supports client authentication. Client authentication is the process of supporting client devices directly logging into resources. | [optional] 
**LastName** | **string** | Last name of this user or group. | [optional] 
**LoginName** | **string** | Login name of this user or group.  Supported Filters : &#39;Equals&#39;, &#39;StartsWith&#39;, &#39;Contains&#39;. | [optional] 
**LongDisplayName** | **string** | Login name, domain and name for this user or group, else display name | [optional] 
**Name** | **string** | Name of this user or group.  Supported Filters : &#39;Equals&#39;, &#39;StartsWith&#39;, &#39;Contains&#39;. | [optional] 
**Phone** | **string** | Phone number of this user. Supported Filters : &#39;Equals&#39;, &#39;StartsWith&#39;, &#39;Contains&#39;. | [optional] 
**UserDisplayName** | **string** | User or group&#39;s display name. This corresponds with displayName attribute in AD. | [optional] 
**UserPrincipalName** | **string** | User Principal name(UPN) of this user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

