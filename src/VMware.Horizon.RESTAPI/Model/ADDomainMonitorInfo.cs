/* 
 * Horizon Server API
 *
 * Welcome to the Horizon Server API Reference documentation. This API reference provides comprehensive information about status of all Horizon Server components and resources.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = VMware.Horizon.RESTAPI.Client.SwaggerDateConverter;

namespace VMware.Horizon.RESTAPI.Model
{
    /// <summary>
    /// Monitoring information related to AD Domain.
    /// </summary>
    [DataContract]
    public partial class ADDomainMonitorInfo :  IEquatable<ADDomainMonitorInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADDomainMonitorInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ADDomainMonitorInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ADDomainMonitorInfo" /> class.
        /// </summary>
        /// <param name="connectionServers">Information about the AD Domain connections from each of the connection servers..</param>
        /// <param name="dnsName">The DNS name for the domain. (required).</param>
        /// <param name="netbiosName">The NetBIOS name for the domain. (required).</param>
        /// <param name="nt4Domain">If this is an NT4 domain or not. (required).</param>
        public ADDomainMonitorInfo(List<ADDomainMonitorConnectionServer> connectionServers = default(List<ADDomainMonitorConnectionServer>), string dnsName = default(string), string netbiosName = default(string), bool? nt4Domain = default(bool?))
        {
            // to ensure "dnsName" is required (not null)
            if (dnsName == null)
            {
                throw new InvalidDataException("dnsName is a required property for ADDomainMonitorInfo and cannot be null");
            }
            else
            {
                this.DnsName = dnsName;
            }
            // to ensure "netbiosName" is required (not null)
            if (netbiosName == null)
            {
                throw new InvalidDataException("netbiosName is a required property for ADDomainMonitorInfo and cannot be null");
            }
            else
            {
                this.NetbiosName = netbiosName;
            }
            // to ensure "nt4Domain" is required (not null)
            if (nt4Domain == null)
            {
                throw new InvalidDataException("nt4Domain is a required property for ADDomainMonitorInfo and cannot be null");
            }
            else
            {
                this.Nt4Domain = nt4Domain;
            }
            this.ConnectionServers = connectionServers;
        }
        
        /// <summary>
        /// Information about the AD Domain connections from each of the connection servers.
        /// </summary>
        /// <value>Information about the AD Domain connections from each of the connection servers.</value>
        [DataMember(Name="connection_servers", EmitDefaultValue=false)]
        public List<ADDomainMonitorConnectionServer> ConnectionServers { get; set; }

        /// <summary>
        /// The DNS name for the domain.
        /// </summary>
        /// <value>The DNS name for the domain.</value>
        [DataMember(Name="dns_name", EmitDefaultValue=false)]
        public string DnsName { get; set; }

        /// <summary>
        /// The NetBIOS name for the domain.
        /// </summary>
        /// <value>The NetBIOS name for the domain.</value>
        [DataMember(Name="netbios_name", EmitDefaultValue=false)]
        public string NetbiosName { get; set; }

        /// <summary>
        /// If this is an NT4 domain or not.
        /// </summary>
        /// <value>If this is an NT4 domain or not.</value>
        [DataMember(Name="nt4_domain", EmitDefaultValue=false)]
        public bool? Nt4Domain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ADDomainMonitorInfo {\n");
            sb.Append("  ConnectionServers: ").Append(ConnectionServers).Append("\n");
            sb.Append("  DnsName: ").Append(DnsName).Append("\n");
            sb.Append("  NetbiosName: ").Append(NetbiosName).Append("\n");
            sb.Append("  Nt4Domain: ").Append(Nt4Domain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ADDomainMonitorInfo);
        }

        /// <summary>
        /// Returns true if ADDomainMonitorInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ADDomainMonitorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ADDomainMonitorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectionServers == input.ConnectionServers ||
                    this.ConnectionServers != null &&
                    this.ConnectionServers.SequenceEqual(input.ConnectionServers)
                ) && 
                (
                    this.DnsName == input.DnsName ||
                    (this.DnsName != null &&
                    this.DnsName.Equals(input.DnsName))
                ) && 
                (
                    this.NetbiosName == input.NetbiosName ||
                    (this.NetbiosName != null &&
                    this.NetbiosName.Equals(input.NetbiosName))
                ) && 
                (
                    this.Nt4Domain == input.Nt4Domain ||
                    (this.Nt4Domain != null &&
                    this.Nt4Domain.Equals(input.Nt4Domain))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ConnectionServers != null)
                    hashCode = hashCode * 59 + this.ConnectionServers.GetHashCode();
                if (this.DnsName != null)
                    hashCode = hashCode * 59 + this.DnsName.GetHashCode();
                if (this.NetbiosName != null)
                    hashCode = hashCode * 59 + this.NetbiosName.GetHashCode();
                if (this.Nt4Domain != null)
                    hashCode = hashCode * 59 + this.Nt4Domain.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
