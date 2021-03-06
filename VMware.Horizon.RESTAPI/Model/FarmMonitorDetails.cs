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
    /// Details of the Farm.
    /// </summary>
    [DataContract]
    public partial class FarmMonitorDetails :  IEquatable<FarmMonitorDetails>
    {
        /// <summary>
        /// Source of farm machines. This property is required if type is set to \&quot;AUTOMATED\&quot;. * LINKED_CLONE: Linked clone share the same base image and use less storage space than full RDS Servers. * INSTANT_CLONE: Instant clone engine uses vmfork technology to create the instant clones. These clones take much less time for provisioning.
        /// </summary>
        /// <value>Source of farm machines. This property is required if type is set to \&quot;AUTOMATED\&quot;. * LINKED_CLONE: Linked clone share the same base image and use less storage space than full RDS Servers. * INSTANT_CLONE: Instant clone engine uses vmfork technology to create the instant clones. These clones take much less time for provisioning.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum LINKEDCLONE for value: LINKED_CLONE
            /// </summary>
            [EnumMember(Value = "LINKED_CLONE")]
            LINKEDCLONE = 1,
            
            /// <summary>
            /// Enum INSTANTCLONE for value: INSTANT_CLONE
            /// </summary>
            [EnumMember(Value = "INSTANT_CLONE")]
            INSTANTCLONE = 2
        }

        /// <summary>
        /// Source of farm machines. This property is required if type is set to \&quot;AUTOMATED\&quot;. * LINKED_CLONE: Linked clone share the same base image and use less storage space than full RDS Servers. * INSTANT_CLONE: Instant clone engine uses vmfork technology to create the instant clones. These clones take much less time for provisioning.
        /// </summary>
        /// <value>Source of farm machines. This property is required if type is set to \&quot;AUTOMATED\&quot;. * LINKED_CLONE: Linked clone share the same base image and use less storage space than full RDS Servers. * INSTANT_CLONE: Instant clone engine uses vmfork technology to create the instant clones. These clones take much less time for provisioning.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum? Source { get; set; }
        /// <summary>
        /// Farm type. * AUTOMATED: Automated Farm. * MANUAL: Manual farm.
        /// </summary>
        /// <value>Farm type. * AUTOMATED: Automated Farm. * MANUAL: Manual farm.</value>
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
            MANUAL = 2
        }

        /// <summary>
        /// Farm type. * AUTOMATED: Automated Farm. * MANUAL: Manual farm.
        /// </summary>
        /// <value>Farm type. * AUTOMATED: Automated Farm. * MANUAL: Manual farm.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FarmMonitorDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FarmMonitorDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FarmMonitorDetails" /> class.
        /// </summary>
        /// <param name="source">Source of farm machines. This property is required if type is set to \&quot;AUTOMATED\&quot;. * LINKED_CLONE: Linked clone share the same base image and use less storage space than full RDS Servers. * INSTANT_CLONE: Instant clone engine uses vmfork technology to create the instant clones. These clones take much less time for provisioning..</param>
        /// <param name="type">Farm type. * AUTOMATED: Automated Farm. * MANUAL: Manual farm. (required).</param>
        public FarmMonitorDetails(SourceEnum? source = default(SourceEnum?), TypeEnum type = default(TypeEnum))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for FarmMonitorDetails and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Source = source;
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FarmMonitorDetails {\n");
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
            return this.Equals(input as FarmMonitorDetails);
        }

        /// <summary>
        /// Returns true if FarmMonitorDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of FarmMonitorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FarmMonitorDetails input)
        {
            if (input == null)
                return false;

            return 
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }

}
