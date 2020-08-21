# VMware.Horizon.RESTAPI.Model.DesktopPoolInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | Description of the Desktop Pool. The maximum length is 1024 characters. | [optional] 
**DisplayName** | **string** | Display name of the Desktop Pool. The maximum length is 256 characters. | [optional] 
**Enabled** | **bool?** | Indicates whether the Desktop Pool is enabled for brokering. | 
**Id** | **string** | Unique ID representing Desktop Pool. | 
**Name** | **string** | Name of the Desktop Pool. The maximum length is 64 characters. | 
**Settings** | [**DesktopPoolSettings**](DesktopPoolSettings.md) | Settings related to the Desktop Pool. | 
**Source** | **string** | Source of the Machines in this Desktop Pool. * INSTANT_CLONE: The Desktop Pool uses instant clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * LINKED_CLONE: The Desktop Pool uses linked clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * VIRTUAL_CENTER: The Desktop Pool uses Virtual Center as source for provisioning the machines.Applicable for AUTOMATED and MANUAL type desktop pools. * RDS: The Desktop Pool is backed by Farm. The Farm used in this Desktop Pool can be of any Source. * UNMANAGED: The Desktop Pool holds the non-vCenter source machines that includes physical computers,blade PCs and non-vCenter servers. Applicable for MANUAL type desktop pools. | 
**Type** | **string** | Type of the Desktop Pool. * AUTOMATED: Automated Desktop Pool. * MANUAL: Manual Desktop Pool. * RDS: RDS Desktop Pool. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

