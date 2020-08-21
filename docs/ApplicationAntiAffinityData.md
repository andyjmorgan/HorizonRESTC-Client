# VMware.Horizon.RESTAPI.Model.ApplicationAntiAffinityData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AntiAffinityCount** | **int?** | Maximum number of other applications that can be running on the RDS Server before the RDS Server is rejected for new application sessions. | 
**AntiAffinityPatterns** | **List&lt;string&gt;** | Set of pattern strings to match against process names on a RDS Server when attempting to launch a session for this Application. For each application running on an RDSServer that matches one of the patterns, the tally against the count threshold is incremented.&lt;br&gt;Pattern strings may contain wildcard characters. &#39;*&#39; matches zero or more characters. &#39;?&#39; matches exactly one character. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

