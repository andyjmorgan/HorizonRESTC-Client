# VMware.Horizon.RESTAPI.Model.ADDomainMonitorConnectionServerV2
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique ID of the connection server. | 
**LastUpdatedTimestamp** | **long?** | The timestamp in milliseconds when the last update was obtained. Measured as epoch time. | [optional] 
**Name** | **string** | Connection server host name or IP address. | 
**Status** | **string** | Status of the connection to the domain. * UNCONTACTABLE: No domain controllers appear to be present on the network for this domain. * FULLY_ACCESSIBLE: The domain controller(s) are accepting bind operations. * CANNOT_BIND: The domain controller(s) are only accepting LDAP ping operations. * UNKNOWN: Cannot determine accessibility. | 
**TrustRelationship** | **string** | The trust relationship for the domain. * PRIMARY_DOMAIN: The domain is the domain that the broker is present in. * FROM_BROKER: The domain is trusted by the domain that the broker is in. * TO_BROKER: The domain trusts the broker&#39;s domain (this is for completeness and generally will not be used). * TWO_WAY: The domain has a two way trust relationship with the broker&#39;s domain. * TWO_WAY_FOREST: The domain is in the same forest as the broker&#39;s domain, implies two way trust. * MANUAL: The domain was manually configured (the trust has not been detected). * UNKNOWN: The trust relationship could not be determined. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

