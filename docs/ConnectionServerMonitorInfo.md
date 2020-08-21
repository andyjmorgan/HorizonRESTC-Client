# VMware.Horizon.RESTAPI.Model.ConnectionServerMonitorInfo
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificate** | [**CertificateMonitorInfo**](CertificateMonitorInfo.md) | Connection Server certificate information. | 
**ConnectionCount** | **int?** | Number of connections to this Connection Server. | [optional] 
**CsReplications** | [**List&lt;ConnectionServerMonitorCSReplication&gt;**](ConnectionServerMonitorCSReplication.md) | Connection Server replication status with respect to the Peer Connection Servers in the same cluster. | [optional] 
**DefaultCertificate** | **bool?** | Indicates whether server has the default certificate. | [optional] 
**Details** | [**ConnectionServerMonitorDetails**](ConnectionServerMonitorDetails.md) | Details about the Connection Server. | 
**Id** | **string** | Unique ID of the Connection Server. | 
**Name** | **string** | Connection Server host name or IP address. | 
**Services** | [**List&lt;ConnectionServerMonitorServiceStatus&gt;**](ConnectionServerMonitorServiceStatus.md) | Connection Server related Windows services information. | [optional] 
**SessionProtocolData** | [**List&lt;ConnectionServerSessionProtocolData&gt;**](ConnectionServerSessionProtocolData.md) | PCoIP, RDP or BLAST protocol sessions details when clients connect directly to the connection server. | [optional] 
**SessionThreshold** | **int?** | The maximum number of connections allowed for the connection server through the Horizon client. If all of the secure gateways (HTTP(S)/PCOIP/BLAST) are enabled, this field denotes the maximum number of connections allowed for the connection server.If none of the secure gateways(HTTP(S)/PCOIP/BLAST) are enabled, sessionThreshold value will not be set. | [optional] 
**Status** | **string** | Status of the Connection Server. * OK: The Connection Server is working properly. * ERROR: Error occurred when connecting to Connection Server. * NOT_RESPONDING: The Connection Server is not responding. * UNKNOWN: Status of Connection Server is unknown. | 
**TunnelConnectionCount** | **int?** | Number of connections tunneled through this Connection Server. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

