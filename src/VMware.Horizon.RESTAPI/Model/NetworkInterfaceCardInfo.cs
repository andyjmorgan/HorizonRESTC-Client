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
    /// Information related to network interface card.
    /// </summary>
    [DataContract]
    public partial class NetworkInterfaceCardInfo :  IEquatable<NetworkInterfaceCardInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkInterfaceCardInfo" /> class.
        /// </summary>
        /// <param name="id">Unique ID representing the network interface card..</param>
        /// <param name="macAddress">Network interface card MAC address..</param>
        /// <param name="name">Network interface card name..</param>
        public NetworkInterfaceCardInfo(string id = default(string), string macAddress = default(string), string name = default(string))
        {
            this.Id = id;
            this.MacAddress = macAddress;
            this.Name = name;
        }
        
        /// <summary>
        /// Unique ID representing the network interface card.
        /// </summary>
        /// <value>Unique ID representing the network interface card.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Network interface card MAC address.
        /// </summary>
        /// <value>Network interface card MAC address.</value>
        [DataMember(Name="mac_address", EmitDefaultValue=false)]
        public string MacAddress { get; set; }

        /// <summary>
        /// Network interface card name.
        /// </summary>
        /// <value>Network interface card name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkInterfaceCardInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
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
            return this.Equals(input as NetworkInterfaceCardInfo);
        }

        /// <summary>
        /// Returns true if NetworkInterfaceCardInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkInterfaceCardInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkInterfaceCardInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MacAddress == input.MacAddress ||
                    (this.MacAddress != null &&
                    this.MacAddress.Equals(input.MacAddress))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MacAddress != null)
                    hashCode = hashCode * 59 + this.MacAddress.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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