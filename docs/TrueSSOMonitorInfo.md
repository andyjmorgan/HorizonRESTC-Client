# VMware.Horizon.RESTAPI.Model.TrueSSOMonitorInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdDomainDnsName** | **string** | The DNS name of the domain. | 
**AdDomainId** | **string** | Unique ID of the AD Domain. | 
**AdDomainStatus** | **string** | The state of the domain health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the domain is OK as reported by the enrollment servers. * WARN: At least one of the enrollment servers has a warning. * ERROR: At least one of the enrollment servers is in an error state. | 
**CertificateServerDetails** | [**List&lt;CertificateServerDetails&gt;**](CertificateServerDetails.md) | Details of each certificate server. | 
**Enabled** | **bool?** | Indicates if the True SSO connector is enabled. | 
**Id** | **string** | Unique ID of the True SSO Connector. | 
**Name** | **string** | True SSO connector name. | 
**PrimaryEnrollmentServer** | [**EnrollmentServerDetails**](EnrollmentServerDetails.md) | The primary enrollment server details. | 
**SecondaryEnrollmentServer** | [**EnrollmentServerDetails**](EnrollmentServerDetails.md) | The secondary enrollment server details. | [optional] 
**Status** | **string** | Overall status of the True SSO connector. * OK: All the components of the True SSO connector are fine. * WARN: At least one component of the True SSO connector has a warning. * ERROR: At least one component of the True SSO connector has an error. | 
**TemplateName** | **string** | Unique name for the True SSO template. | 
**TemplateStatus** | **string** | The state of the template health, taken as the most severe reported by one of the enrollment servers. * OK: The state of the template is OK as reported by the enrollment servers. * WARN: At least one enrollment server reports a warning on this template. * ERROR: At least one enrollment server reports an error on this template. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

