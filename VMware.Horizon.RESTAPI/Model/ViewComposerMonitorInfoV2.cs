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
    /// Monitoring information related to View Composer.
    /// </summary>
    [DataContract]
    public partial class ViewComposerMonitorInfoV2 :  IEquatable<ViewComposerMonitorInfoV2>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewComposerMonitorInfoV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ViewComposerMonitorInfoV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewComposerMonitorInfoV2" /> class.
        /// </summary>
        /// <param name="connectionServers">Information about the View Composer connections from each of the connection servers. (required).</param>
        /// <param name="details">Details about the View Composer. (required).</param>
        /// <param name="name">View Composer server host name or IP address. (required).</param>
        /// <param name="port">View Composer server port number. (required).</param>
        public ViewComposerMonitorInfoV2(List<ViewComposerMonitorConnectionServerV2> connectionServers = default(List<ViewComposerMonitorConnectionServerV2>), ViewComposerMonitorDetails details = default(ViewComposerMonitorDetails), string name = default(string), int? port = default(int?))
        {
            // to ensure "connectionServers" is required (not null)
            if (connectionServers == null)
            {
                throw new InvalidDataException("connectionServers is a required property for ViewComposerMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.ConnectionServers = connectionServers;
            }
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for ViewComposerMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.Details = details;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ViewComposerMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "port" is required (not null)
            if (port == null)
            {
                throw new InvalidDataException("port is a required property for ViewComposerMonitorInfoV2 and cannot be null");
            }
            else
            {
                this.Port = port;
            }
        }
        
        /// <summary>
        /// Information about the View Composer connections from each of the connection servers.
        /// </summary>
        /// <value>Information about the View Composer connections from each of the connection servers.</value>
        [DataMember(Name="connection_servers", EmitDefaultValue=false)]
        public List<ViewComposerMonitorConnectionServerV2> ConnectionServers { get; set; }

        /// <summary>
        /// Details about the View Composer.
        /// </summary>
        /// <value>Details about the View Composer.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public ViewComposerMonitorDetails Details { get; set; }

        /// <summary>
        /// View Composer server host name or IP address.
        /// </summary>
        /// <value>View Composer server host name or IP address.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// View Composer server port number.
        /// </summary>
        /// <value>View Composer server port number.</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewComposerMonitorInfoV2 {\n");
            sb.Append("  ConnectionServers: ").Append(ConnectionServers).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
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
            return this.Equals(input as ViewComposerMonitorInfoV2);
        }

        /// <summary>
        /// Returns true if ViewComposerMonitorInfoV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewComposerMonitorInfoV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewComposerMonitorInfoV2 input)
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
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                return hashCode;
            }
        }
    }

}
