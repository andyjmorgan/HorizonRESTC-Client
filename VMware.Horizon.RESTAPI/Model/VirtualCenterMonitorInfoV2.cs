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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = VMware.Horizon.RESTAPI.Client.SwaggerDateConverter;

namespace VMware.Horizon.RESTAPI.Model
{
    /// <summary>
    /// Monitoring information related to a Virtual Center
    /// </summary>
    [DataContract]
    public partial class VirtualCenterMonitorInfoV2 :  IEquatable<VirtualCenterMonitorInfoV2>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualCenterMonitorInfoV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VirtualCenterMonitorInfoV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VirtualCenterMonitorInfoV2" /> class.
        /// </summary>
        /// <param name="connectionServers">Information about the Virtual Center connections from each of the connection servers. (required).</param>
        /// <param name="datastores">Information about the datastores of the Virtual Center. (required).</param>
        /// <param name="desktopPoolsAndFarmsCount">Number of Desktop Pools And Farms managed by the virtual center (required).</param>
        /// <param name="details">Details about the Virtual Center. (required).</param>
        /// <param name="hosts">Information about the ESX hosts added in the Virtual Center. (required).</param>
        /// <param name="id">Unique ID of the Virtual Center. (required).</param>
        /// <param name="name">Virtual Center server name or IP address. (required).</param>
        public VirtualCenterMonitorInfoV2(List<VCMonitorConnectionServerV2> connectionServers = default(List<VCMonitorConnectionServerV2>), List<VCMonitorDatastore> datastores = default(List<VCMonitorDatastore>), int? desktopPoolsAndFarmsCount = default(int?), VCMonitorDetails details = default(VCMonitorDetails), List<VCMonitorHost> hosts = default(List<VCMonitorHost>), string id = default(string), string name = default(string))
        {
            // to ensure "connectionServers" is required (not null)
            if (connectionServers == null)
            {
                throw new InvalidDataException("connectionServers is a required property for VirtualCenterMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.ConnectionServers = connectionServers;
            }
            // to ensure "datastores" is required (not null)
            if (datastores == null)
            {
                throw new InvalidDataException("datastores is a required property for VirtualCenterMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.Datastores = datastores;
            }
            // to ensure "desktopPoolsAndFarmsCount" is required (not null)
            if (desktopPoolsAndFarmsCount == null)
            {
                throw new InvalidDataException("desktopPoolsAndFarmsCount is a required property for VirtualCenterMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.DesktopPoolsAndFarmsCount = desktopPoolsAndFarmsCount;
            }
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for VirtualCenterMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.Details = details;
            }
            // to ensure "hosts" is required (not null)
            if (hosts == null)
            {
                throw new InvalidDataException("hosts is a required property for VirtualCenterMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.Hosts = hosts;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for VirtualCenterMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for VirtualCenterMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
        }
        
        /// <summary>
        /// Information about the Virtual Center connections from each of the connection servers.
        /// </summary>
        /// <value>Information about the Virtual Center connections from each of the connection servers.</value>
        [DataMember(Name="connection_servers", EmitDefaultValue=false)]
        public List<VCMonitorConnectionServerV2> ConnectionServers { get; set; }

        /// <summary>
        /// Information about the datastores of the Virtual Center.
        /// </summary>
        /// <value>Information about the datastores of the Virtual Center.</value>
        [DataMember(Name="datastores", EmitDefaultValue=false)]
        public List<VCMonitorDatastore> Datastores { get; set; }

        /// <summary>
        /// Number of Desktop Pools And Farms managed by the virtual center
        /// </summary>
        /// <value>Number of Desktop Pools And Farms managed by the virtual center</value>
        [DataMember(Name="desktop_pools_and_farms_count", EmitDefaultValue=false)]
        public int? DesktopPoolsAndFarmsCount { get; set; }

        /// <summary>
        /// Details about the Virtual Center.
        /// </summary>
        /// <value>Details about the Virtual Center.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public VCMonitorDetails Details { get; set; }

        /// <summary>
        /// Information about the ESX hosts added in the Virtual Center.
        /// </summary>
        /// <value>Information about the ESX hosts added in the Virtual Center.</value>
        [DataMember(Name="hosts", EmitDefaultValue=false)]
        public List<VCMonitorHost> Hosts { get; set; }

        /// <summary>
        /// Unique ID of the Virtual Center.
        /// </summary>
        /// <value>Unique ID of the Virtual Center.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Virtual Center server name or IP address.
        /// </summary>
        /// <value>Virtual Center server name or IP address.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualCenterMonitorInfoV2 {\n");
            sb.Append("  ConnectionServers: ").Append(ConnectionServers).Append("\n");
            sb.Append("  Datastores: ").Append(Datastores).Append("\n");
            sb.Append("  DesktopPoolsAndFarmsCount: ").Append(DesktopPoolsAndFarmsCount).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Hosts: ").Append(Hosts).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as VirtualCenterMonitorInfoV2);
        }

        /// <summary>
        /// Returns true if VirtualCenterMonitorInfoV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of VirtualCenterMonitorInfoV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirtualCenterMonitorInfoV2 input)
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
                    this.Datastores == input.Datastores ||
                    this.Datastores != null &&
                    this.Datastores.SequenceEqual(input.Datastores)
                ) && 
                (
                    this.DesktopPoolsAndFarmsCount == input.DesktopPoolsAndFarmsCount ||
                    (this.DesktopPoolsAndFarmsCount != null &&
                    this.DesktopPoolsAndFarmsCount.Equals(input.DesktopPoolsAndFarmsCount))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Datastores != null)
                    hashCode = hashCode * 59 + this.Datastores.GetHashCode();
                if (this.DesktopPoolsAndFarmsCount != null)
                    hashCode = hashCode * 59 + this.DesktopPoolsAndFarmsCount.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }

}
