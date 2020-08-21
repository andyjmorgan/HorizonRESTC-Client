# VMware.Horizon.RESTAPI.Model.ADUserChangePasswordSpec
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domain** | **string** | The domain of user. Note that domain is optional if UPN is supplied. | [optional] 
**KeyId** | **string** | The keyId of the cluster&#39;s SSO KeyPair used to encrypt the password key. | 
**NewEncryptedPassword** | **string** | New password for the user in encrypted format. | 
**OldEncryptedPassword** | **string** | Old password for the user in encrypted format. | 
**ProtectedPasswordKey** | **string** | Decryption key for the password. This key is itself encrypted with cluster&#39;s SSO keypair. | 
**Username** | **string** | The username or UPN. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

