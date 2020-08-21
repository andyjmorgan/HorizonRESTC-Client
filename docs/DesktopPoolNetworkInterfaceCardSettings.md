# VMware.Horizon.RESTAPI.Model.DesktopPoolNetworkInterfaceCardSettings
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NetworkInterfaceCardId** | **string** | The network interface card id for these settings. | [optional] 
**NetworkInterfaceCardName** | **string** | The network interface card name. | [optional] 
**NetworkLabelAssignmentSpecs** | [**List&lt;NetworkLabelAssignmentSettings&gt;**](NetworkLabelAssignmentSettings.md) | Automatic network label assignment feature settings for this NIC. By default, newly provisioned machines of an automated desktop pool retain their parent image&#39;s network labels on each of their network interface cards. In certain circumstances, notably dealing with VLAN subset sizing and DHCP IP address availability, it may be desirable for the desktop pool to instead use different network labels for these newly provisioned machines. This feature allows an administrator to provide a per NIC list of network labels and their maximum availability to be automatically distributed to newly provisioned machines. &lt;br&gt; If this is unset, the feature is disabled.&lt;br&gt; Starting at the alphabetically first network label specification in the list that has not yet been assigned its maximum count for this NIC on this desktop pool, the desktop pool will have its next provisioned machine&#39;s NIC assigned that label. If all network labels in this list have reached their maximum count, this desktop pool will have further provisioned machines assigned the last label in the list over capacity, and an error will be logged. Not all labels need be configured. &lt;br&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

