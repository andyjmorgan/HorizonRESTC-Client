# VMware.Horizon.RESTAPI.Model.NetworkLabelAssignmentSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool?** | Whether or not this specification is enabled. While this specification is disabled, automatic network label assigment for this desktop pool will skip over the network label in this spec. | [optional] 
**MaxLabel** | **int?** | The maximum number of times this label can be assigned to a machine. Note this count only encompasses this spec. That is, this label may be used for other NICs and in other Desktop pools, but those assignments will not be counted towards this total. This count also does not include assignments of this label to machines not under the control of View. | [optional] 
**MaxLabelType** | **string** | This type specifies whether or not there is a maximum limit to the number of times this label may be assigned to machines within this spec. While this specification is enabled and unlimited, specs after this one in the NIC&#39;s network label specification list will never be used. * UNLIMITED: The network label assignment specification has no limit on the number of labels to assign. * LIMITED: The network label assignment specification has a limited number of labels to assign. | [optional] 
**NetworkLabelName** | **string** | The network label id for this spec. This network label must not have any incompatibility reasons that would preclude it from automatic machine assignment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

