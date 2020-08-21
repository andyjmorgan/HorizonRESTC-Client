# VMware.Horizon.RESTAPI.Model.SAMLAuthenticatorMonitorConnectionServer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID of the Connection Server. | 
**Name** | **string** | Connection server host name or IP address. | 
**Status** | **string** | Status of the SAML authenticator with respect to this Connection Server. * OK: The connection to SAML authenticator is working properly. * ERROR: Error occurred when connecting to SAML authenticator. * WARN: The connection to SAML authenticator has minor issues. * UNKNOWN: State of SAML authenticator is unknown. | 
**ThumbprintAccepted** | **bool?** | Indicates if the thumbprint of the SAML authenticator was accepted. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

