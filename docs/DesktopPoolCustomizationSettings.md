# VMware.Horizon.RESTAPI.Model.DesktopPoolCustomizationSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdContainerRdn** | **string** | Applicable To: Linked/instant clone automated desktop pools.&lt;br&gt;View Composer and Instant Clone Engine Active Directory container for QuickPrep and ClonePrep. | [optional] 
**CloneprepCustomizationSettings** | [**DesktopPoolCloneprepCustomizationSettings**](DesktopPoolCloneprepCustomizationSettings.md) | Settings when ClonePrep customization is requested. | [optional] 
**CustomizationType** | **string** | Type of customization to use. * NONE: Applicable To: Full clone automated desktop pools.&lt;br&gt;No customization. * QUICK_PREP: Applicable To: Linked clone automated desktop pools.&lt;br&gt;QuickPrep is a VMware system tool executed by View Composer during a linked-clone machine deployment. QuickPrep personalizes each machine created from the Master image. * SYS_PREP: Applicable To: All automated desktop pools.&lt;br&gt;Microsoft Sysprep is a tool to deploy the configured operating system installation from a base image. The machine can then be customized based on an answer script. Sysprep can modify a larger number of configurable parameters than QuickPrep. * CLONE_PREP: Applicable To: Instant clone automated desktop pools.&lt;br&gt;ClonePrep is a VMware system tool executed by Instant Clone Engine during a instant clone machine deployment. ClonePrep personalizes each machine created from the Master image. | [optional] 
**DoNotPowerOnVmsAfterCreation** | **bool?** | Whether to power on VMs after creation. This is the settings when customization will be done manually. | [optional] 
**InstantCloneDomainAccountId** | **string** | Applicable To: Instant clone automated desktop pools.&lt;br&gt;Instant clone domain account. This is the administrator which will add the machines to its domain upon creation. | [optional] 
**QuickprepCustomizationSettings** | [**DesktopPoolQuickprepCustomizationSettings**](DesktopPoolQuickprepCustomizationSettings.md) | Settings when QuickPrep customization is requested. | [optional] 
**ReusePreExistingAccounts** | **bool?** | Applicable To: Manual and automated desktop pools.&lt;br&gt;Whether to allow the use of existing AD computer accounts when the VM names of newly created clones match the existing computer account names. This is applicable only for automated desktop pools. | [optional] 
**SysprepCustomizationSpecId** | **string** | Customization specification to use when Sysprep customization is requested. | [optional] 
**ViewComposerDomainAccountId** | **string** | Applicable To: Linked clone automated desktop pools.&lt;br&gt;View Composer domain account. This is the administrator which will add the machines to its domain upon creation. This must be set for linked-clone automated desktop pools. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

