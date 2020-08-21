# VMware.Horizon.RESTAPI.Model.RCXServerInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID representing RCX server. | 
**Name** | **string** | FQDN/IP address of the RCX server. | 
**Port** | **int?** | RCX server&#39;s port. | 
**Status** | **string** | This indicates the current status of RCX server. * UP: RCX server is running. * DOWN: RCX server is down. * UNKNOWN: RCX server status is unknown. | 
**Thumbprints** | [**List&lt;CertificateThumbprint&gt;**](CertificateThumbprint.md) | Thumbprints of the RCX server certificates. | [optional] 
**Version** | **string** | Version information of RCX server. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

