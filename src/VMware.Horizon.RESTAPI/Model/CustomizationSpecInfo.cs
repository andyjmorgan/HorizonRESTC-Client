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
    /// Information related to customization specification created in vCenter.
    /// </summary>
    [DataContract]
    public partial class CustomizationSpecInfo :  IEquatable<CustomizationSpecInfo>, IValidatableObject
    {
        /// <summary>
        /// Guest Operating system. * UNKNOWN: Unknown * WINDOWS: Windows * LINUX: Linux
        /// </summary>
        /// <value>Guest Operating system. * UNKNOWN: Unknown * WINDOWS: Windows * LINUX: Linux</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GuestOsEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 1,
            
            /// <summary>
            /// Enum WINDOWS for value: WINDOWS
            /// </summary>
            [EnumMember(Value = "WINDOWS")]
            WINDOWS = 2,
            
            /// <summary>
            /// Enum LINUX for value: LINUX
            /// </summary>
            [EnumMember(Value = "LINUX")]
            LINUX = 3
        }

        /// <summary>
        /// Guest Operating system. * UNKNOWN: Unknown * WINDOWS: Windows * LINUX: Linux
        /// </summary>
        /// <value>Guest Operating system. * UNKNOWN: Unknown * WINDOWS: Windows * LINUX: Linux</value>
        [DataMember(Name="guest_os", EmitDefaultValue=false)]
        public GuestOsEnum? GuestOs { get; set; }
        /// <summary>
        /// Defines IncompatibleReasons
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IncompatibleReasonsEnum
        {
            
            /// <summary>
            /// Enum DHCPNOTCONFIGURED for value: DHCP_NOT_CONFIGURED
            /// </summary>
            [EnumMember(Value = "DHCP_NOT_CONFIGURED")]
            DHCPNOTCONFIGURED = 1,
            
            /// <summary>
            /// Enum UNSUPPORTEDOS for value: UNSUPPORTED_OS
            /// </summary>
            [EnumMember(Value = "UNSUPPORTED_OS")]
            UNSUPPORTEDOS = 2
        }


        /// <summary>
        /// Reasons that may preclude this customization specification from being used in desktop pool creation.
        /// </summary>
        /// <value>Reasons that may preclude this customization specification from being used in desktop pool creation.</value>
        [DataMember(Name="incompatible_reasons", EmitDefaultValue=false)]
        public List<IncompatibleReasonsEnum> IncompatibleReasons { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomizationSpecInfo" /> class.
        /// </summary>
        /// <param name="description">Customization specification description..</param>
        /// <param name="guestOs">Guest Operating system. * UNKNOWN: Unknown * WINDOWS: Windows * LINUX: Linux.</param>
        /// <param name="id">Unique ID representing the customization specification..</param>
        /// <param name="incompatibleReasons">Reasons that may preclude this customization specification from being used in desktop pool creation..</param>
        /// <param name="name">Name of the customization specification..</param>
        public CustomizationSpecInfo(string description = default(string), GuestOsEnum? guestOs = default(GuestOsEnum?), string id = default(string), List<IncompatibleReasonsEnum> incompatibleReasons = default(List<IncompatibleReasonsEnum>), string name = default(string))
        {
            this.Description = description;
            this.GuestOs = guestOs;
            this.Id = id;
            this.IncompatibleReasons = incompatibleReasons;
            this.Name = name;
        }
        
        /// <summary>
        /// Customization specification description.
        /// </summary>
        /// <value>Customization specification description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }


        /// <summary>
        /// Unique ID representing the customization specification.
        /// </summary>
        /// <value>Unique ID representing the customization specification.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Name of the customization specification.
        /// </summary>
        /// <value>Name of the customization specification.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomizationSpecInfo {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GuestOs: ").Append(GuestOs).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IncompatibleReasons: ").Append(IncompatibleReasons).Append("\n");
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
            return this.Equals(input as CustomizationSpecInfo);
        }

        /// <summary>
        /// Returns true if CustomizationSpecInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomizationSpecInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomizationSpecInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.GuestOs == input.GuestOs ||
                    (this.GuestOs != null &&
                    this.GuestOs.Equals(input.GuestOs))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IncompatibleReasons == input.IncompatibleReasons ||
                    this.IncompatibleReasons != null &&
                    this.IncompatibleReasons.SequenceEqual(input.IncompatibleReasons)
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.GuestOs != null)
                    hashCode = hashCode * 59 + this.GuestOs.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncompatibleReasons != null)
                    hashCode = hashCode * 59 + this.IncompatibleReasons.GetHashCode();
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
