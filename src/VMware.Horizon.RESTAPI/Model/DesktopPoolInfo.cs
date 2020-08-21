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
    /// Information related to Desktop Pool.
    /// </summary>
    [DataContract]
    public partial class DesktopPoolInfo :  IEquatable<DesktopPoolInfo>, IValidatableObject
    {
        /// <summary>
        /// Source of the Machines in this Desktop Pool. * INSTANT_CLONE: The Desktop Pool uses instant clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * LINKED_CLONE: The Desktop Pool uses linked clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * VIRTUAL_CENTER: The Desktop Pool uses Virtual Center as source for provisioning the machines.Applicable for AUTOMATED and MANUAL type desktop pools. * RDS: The Desktop Pool is backed by Farm. The Farm used in this Desktop Pool can be of any Source. * UNMANAGED: The Desktop Pool holds the non-vCenter source machines that includes physical computers,blade PCs and non-vCenter servers. Applicable for MANUAL type desktop pools.
        /// </summary>
        /// <value>Source of the Machines in this Desktop Pool. * INSTANT_CLONE: The Desktop Pool uses instant clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * LINKED_CLONE: The Desktop Pool uses linked clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * VIRTUAL_CENTER: The Desktop Pool uses Virtual Center as source for provisioning the machines.Applicable for AUTOMATED and MANUAL type desktop pools. * RDS: The Desktop Pool is backed by Farm. The Farm used in this Desktop Pool can be of any Source. * UNMANAGED: The Desktop Pool holds the non-vCenter source machines that includes physical computers,blade PCs and non-vCenter servers. Applicable for MANUAL type desktop pools.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum INSTANTCLONE for value: INSTANT_CLONE
            /// </summary>
            [EnumMember(Value = "INSTANT_CLONE")]
            INSTANTCLONE = 1,
            
            /// <summary>
            /// Enum LINKEDCLONE for value: LINKED_CLONE
            /// </summary>
            [EnumMember(Value = "LINKED_CLONE")]
            LINKEDCLONE = 2,
            
            /// <summary>
            /// Enum VIRTUALCENTER for value: VIRTUAL_CENTER
            /// </summary>
            [EnumMember(Value = "VIRTUAL_CENTER")]
            VIRTUALCENTER = 3,
            
            /// <summary>
            /// Enum RDS for value: RDS
            /// </summary>
            [EnumMember(Value = "RDS")]
            RDS = 4,
            
            /// <summary>
            /// Enum UNMANAGED for value: UNMANAGED
            /// </summary>
            [EnumMember(Value = "UNMANAGED")]
            UNMANAGED = 5
        }

        /// <summary>
        /// Source of the Machines in this Desktop Pool. * INSTANT_CLONE: The Desktop Pool uses instant clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * LINKED_CLONE: The Desktop Pool uses linked clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * VIRTUAL_CENTER: The Desktop Pool uses Virtual Center as source for provisioning the machines.Applicable for AUTOMATED and MANUAL type desktop pools. * RDS: The Desktop Pool is backed by Farm. The Farm used in this Desktop Pool can be of any Source. * UNMANAGED: The Desktop Pool holds the non-vCenter source machines that includes physical computers,blade PCs and non-vCenter servers. Applicable for MANUAL type desktop pools.
        /// </summary>
        /// <value>Source of the Machines in this Desktop Pool. * INSTANT_CLONE: The Desktop Pool uses instant clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * LINKED_CLONE: The Desktop Pool uses linked clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * VIRTUAL_CENTER: The Desktop Pool uses Virtual Center as source for provisioning the machines.Applicable for AUTOMATED and MANUAL type desktop pools. * RDS: The Desktop Pool is backed by Farm. The Farm used in this Desktop Pool can be of any Source. * UNMANAGED: The Desktop Pool holds the non-vCenter source machines that includes physical computers,blade PCs and non-vCenter servers. Applicable for MANUAL type desktop pools.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum Source { get; set; }
        /// <summary>
        /// Type of the Desktop Pool. * AUTOMATED: Automated Desktop Pool. * MANUAL: Manual Desktop Pool. * RDS: RDS Desktop Pool.
        /// </summary>
        /// <value>Type of the Desktop Pool. * AUTOMATED: Automated Desktop Pool. * MANUAL: Manual Desktop Pool. * RDS: RDS Desktop Pool.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum AUTOMATED for value: AUTOMATED
            /// </summary>
            [EnumMember(Value = "AUTOMATED")]
            AUTOMATED = 1,
            
            /// <summary>
            /// Enum MANUAL for value: MANUAL
            /// </summary>
            [EnumMember(Value = "MANUAL")]
            MANUAL = 2,
            
            /// <summary>
            /// Enum RDS for value: RDS
            /// </summary>
            [EnumMember(Value = "RDS")]
            RDS = 3
        }

        /// <summary>
        /// Type of the Desktop Pool. * AUTOMATED: Automated Desktop Pool. * MANUAL: Manual Desktop Pool. * RDS: RDS Desktop Pool.
        /// </summary>
        /// <value>Type of the Desktop Pool. * AUTOMATED: Automated Desktop Pool. * MANUAL: Manual Desktop Pool. * RDS: RDS Desktop Pool.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopPoolInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DesktopPoolInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopPoolInfo" /> class.
        /// </summary>
        /// <param name="description">Description of the Desktop Pool. The maximum length is 1024 characters..</param>
        /// <param name="displayName">Display name of the Desktop Pool. The maximum length is 256 characters..</param>
        /// <param name="enabled">Indicates whether the Desktop Pool is enabled for brokering. (required).</param>
        /// <param name="id">Unique ID representing Desktop Pool. (required).</param>
        /// <param name="name">Name of the Desktop Pool. The maximum length is 64 characters. (required).</param>
        /// <param name="settings">Settings related to the Desktop Pool. (required).</param>
        /// <param name="source">Source of the Machines in this Desktop Pool. * INSTANT_CLONE: The Desktop Pool uses instant clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * LINKED_CLONE: The Desktop Pool uses linked clone technology for provisioning the machines.Applicable for AUTOMATED type desktop pools. * VIRTUAL_CENTER: The Desktop Pool uses Virtual Center as source for provisioning the machines.Applicable for AUTOMATED and MANUAL type desktop pools. * RDS: The Desktop Pool is backed by Farm. The Farm used in this Desktop Pool can be of any Source. * UNMANAGED: The Desktop Pool holds the non-vCenter source machines that includes physical computers,blade PCs and non-vCenter servers. Applicable for MANUAL type desktop pools. (required).</param>
        /// <param name="type">Type of the Desktop Pool. * AUTOMATED: Automated Desktop Pool. * MANUAL: Manual Desktop Pool. * RDS: RDS Desktop Pool. (required).</param>
        public DesktopPoolInfo(string description = default(string), string displayName = default(string), bool? enabled = default(bool?), string id = default(string), string name = default(string), DesktopPoolSettings settings = default(DesktopPoolSettings), SourceEnum source = default(SourceEnum), TypeEnum type = default(TypeEnum))
        {
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for DesktopPoolInfo and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for DesktopPoolInfo and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for DesktopPoolInfo and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new InvalidDataException("settings is a required property for DesktopPoolInfo and cannot be null");
            }
            else
            {
                this.Settings = settings;
            }
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for DesktopPoolInfo and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for DesktopPoolInfo and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Description = description;
            this.DisplayName = displayName;
        }
        
        /// <summary>
        /// Description of the Desktop Pool. The maximum length is 1024 characters.
        /// </summary>
        /// <value>Description of the Desktop Pool. The maximum length is 1024 characters.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Display name of the Desktop Pool. The maximum length is 256 characters.
        /// </summary>
        /// <value>Display name of the Desktop Pool. The maximum length is 256 characters.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Indicates whether the Desktop Pool is enabled for brokering.
        /// </summary>
        /// <value>Indicates whether the Desktop Pool is enabled for brokering.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Unique ID representing Desktop Pool.
        /// </summary>
        /// <value>Unique ID representing Desktop Pool.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Name of the Desktop Pool. The maximum length is 64 characters.
        /// </summary>
        /// <value>Name of the Desktop Pool. The maximum length is 64 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Settings related to the Desktop Pool.
        /// </summary>
        /// <value>Settings related to the Desktop Pool.</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public DesktopPoolSettings Settings { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopPoolInfo {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as DesktopPoolInfo);
        }

        /// <summary>
        /// Returns true if DesktopPoolInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DesktopPoolInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesktopPoolInfo input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                ) && 
                (
                    this.Settings == input.Settings ||
                    (this.Settings != null &&
                    this.Settings.Equals(input.Settings))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Settings != null)
                    hashCode = hashCode * 59 + this.Settings.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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