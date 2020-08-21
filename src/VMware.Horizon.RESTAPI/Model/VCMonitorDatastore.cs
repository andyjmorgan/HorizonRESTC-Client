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
    /// Information about the datastore of the host(s) connected to the given Virtual Center.
    /// </summary>
    [DataContract]
    public partial class VCMonitorDatastore :  IEquatable<VCMonitorDatastore>, IValidatableObject
    {
        /// <summary>
        /// Status of the datastore. * ACCESSIBLE: The datastore is accessible. * NOT_ACCESSIBLE: The datastore is not accessible.
        /// </summary>
        /// <value>Status of the datastore. * ACCESSIBLE: The datastore is accessible. * NOT_ACCESSIBLE: The datastore is not accessible.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum ACCESSIBLE for value: ACCESSIBLE
            /// </summary>
            [EnumMember(Value = "ACCESSIBLE")]
            ACCESSIBLE = 1,
            
            /// <summary>
            /// Enum NOTACCESSIBLE for value: NOT_ACCESSIBLE
            /// </summary>
            [EnumMember(Value = "NOT_ACCESSIBLE")]
            NOTACCESSIBLE = 2
        }

        /// <summary>
        /// Status of the datastore. * ACCESSIBLE: The datastore is accessible. * NOT_ACCESSIBLE: The datastore is not accessible.
        /// </summary>
        /// <value>Status of the datastore. * ACCESSIBLE: The datastore is accessible. * NOT_ACCESSIBLE: The datastore is not accessible.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Type of the datastore. * VMFS: VMFS datastore. * VSAN: VSAN datastore.
        /// </summary>
        /// <value>Type of the datastore. * VMFS: VMFS datastore. * VSAN: VSAN datastore.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum VMFS for value: VMFS
            /// </summary>
            [EnumMember(Value = "VMFS")]
            VMFS = 1,
            
            /// <summary>
            /// Enum VSAN for value: VSAN
            /// </summary>
            [EnumMember(Value = "VSAN")]
            VSAN = 2
        }

        /// <summary>
        /// Type of the datastore. * VMFS: VMFS datastore. * VSAN: VSAN datastore.
        /// </summary>
        /// <value>Type of the datastore. * VMFS: VMFS datastore. * VSAN: VSAN datastore.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VCMonitorDatastore" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VCMonitorDatastore() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VCMonitorDatastore" /> class.
        /// </summary>
        /// <param name="capacityMb">The capacity of the datastore in megabytes. (required).</param>
        /// <param name="details">Details about the datastore. (required).</param>
        /// <param name="freeSpaceMb">The free space on the datastore in megabytes. (required).</param>
        /// <param name="status">Status of the datastore. * ACCESSIBLE: The datastore is accessible. * NOT_ACCESSIBLE: The datastore is not accessible. (required).</param>
        /// <param name="type">Type of the datastore. * VMFS: VMFS datastore. * VSAN: VSAN datastore. (required).</param>
        public VCMonitorDatastore(int? capacityMb = default(int?), VCMonitorDatastoreDetails details = default(VCMonitorDatastoreDetails), int? freeSpaceMb = default(int?), StatusEnum status = default(StatusEnum), TypeEnum type = default(TypeEnum))
        {
            // to ensure "capacityMb" is required (not null)
            if (capacityMb == null)
            {
                throw new InvalidDataException("capacityMb is a required property for VCMonitorDatastore and cannot be null");
            }
            else
            {
                this.CapacityMb = capacityMb;
            }
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for VCMonitorDatastore and cannot be null");
            }
            else
            {
                this.Details = details;
            }
            // to ensure "freeSpaceMb" is required (not null)
            if (freeSpaceMb == null)
            {
                throw new InvalidDataException("freeSpaceMb is a required property for VCMonitorDatastore and cannot be null");
            }
            else
            {
                this.FreeSpaceMb = freeSpaceMb;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for VCMonitorDatastore and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for VCMonitorDatastore and cannot be null");
            }
            else
            {
                this.Type = type;
            }
        }
        
        /// <summary>
        /// The capacity of the datastore in megabytes.
        /// </summary>
        /// <value>The capacity of the datastore in megabytes.</value>
        [DataMember(Name="capacity_mb", EmitDefaultValue=false)]
        public int? CapacityMb { get; set; }

        /// <summary>
        /// Details about the datastore.
        /// </summary>
        /// <value>Details about the datastore.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public VCMonitorDatastoreDetails Details { get; set; }

        /// <summary>
        /// The free space on the datastore in megabytes.
        /// </summary>
        /// <value>The free space on the datastore in megabytes.</value>
        [DataMember(Name="free_space_mb", EmitDefaultValue=false)]
        public int? FreeSpaceMb { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VCMonitorDatastore {\n");
            sb.Append("  CapacityMb: ").Append(CapacityMb).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  FreeSpaceMb: ").Append(FreeSpaceMb).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as VCMonitorDatastore);
        }

        /// <summary>
        /// Returns true if VCMonitorDatastore instances are equal
        /// </summary>
        /// <param name="input">Instance of VCMonitorDatastore to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VCMonitorDatastore input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CapacityMb == input.CapacityMb ||
                    (this.CapacityMb != null &&
                    this.CapacityMb.Equals(input.CapacityMb))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.FreeSpaceMb == input.FreeSpaceMb ||
                    (this.FreeSpaceMb != null &&
                    this.FreeSpaceMb.Equals(input.FreeSpaceMb))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.CapacityMb != null)
                    hashCode = hashCode * 59 + this.CapacityMb.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.FreeSpaceMb != null)
                    hashCode = hashCode * 59 + this.FreeSpaceMb.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
