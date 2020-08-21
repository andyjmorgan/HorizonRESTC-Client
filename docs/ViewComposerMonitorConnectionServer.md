# VMware.Horizon.RESTAPI.Model.ViewComposerMonitorConnectionServer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificate** | [**CertificateMonitorInfo**](CertificateMonitorInfo.md) | Information related to certificate. | [optional] 
**Id** | **string** | Unique ID of the Connection Server. | 
**Name** | **string** | Connection server host name or IP address. | 
**Status** | **string** | Status of the View Composer with respect to this Connection Server. * OK: The connection to View Composer server is working properly. * MALFORMED_URL: The connection to View Composer server was not possible due to a malformed URL. * ERROR: Error occurred when connecting to View Composer server. * CERT_ERROR: Certificate validation error when connecting to the View Composer server. | 
**ThumbprintAccepted** | **bool?** | Indicates if the thumbprint of the View Composer was accepted. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

