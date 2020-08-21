# VMware.Horizon.RESTAPI.Model.FarmInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Farm description. The maximum length is 1024 characters. | [optional] 
**DisplayName** | **string** | Display name of the Farm. The maximum length is 256 characters. | [optional] 
**Enabled** | **bool?** | Indicates whether the Farm is enabled for brokering. Default value is true. | [optional] 
**Id** | **string** | Unique ID representing Farm. | 
**Name** | **string** | Name of the Farm. The maximum length is 64 characters. | 
**Settings** | [**FarmSettings**](FarmSettings.md) | Settings related to the Farm. | 
**Source** | **string** | Type of the Farm. * INSTANT_CLONE: The Farm uses instant clone technology for provisioning the RDS Servers.Applicable for AUTOMATED type Farms only. * LINKED_CLONE: The Farm uses linked clone technology for provisioning the RDS Servers.Applicable for AUTOMATED type Farms only. | [optional] 
**Type** | **string** | Type of the Farm. * AUTOMATED: Automated Farm. * MANUAL: Manual Farm. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

