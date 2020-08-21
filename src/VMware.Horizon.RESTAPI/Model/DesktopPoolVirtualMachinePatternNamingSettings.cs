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
    /// Settings related to specification of VMs with a naming pattern.
    /// </summary>
    [DataContract]
    public partial class DesktopPoolVirtualMachinePatternNamingSettings :  IEquatable<DesktopPoolVirtualMachinePatternNamingSettings>, IValidatableObject
    {
        /// <summary>
        /// Determines when the machines are provisioned. * ON_DEMAND: Provision machines on demand. * UP_FRONT: Provision all machines up-front.
        /// </summary>
        /// <value>Determines when the machines are provisioned. * ON_DEMAND: Provision machines on demand. * UP_FRONT: Provision all machines up-front.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProvisioningTimeEnum
        {
            
            /// <summary>
            /// Enum ONDEMAND for value: ON_DEMAND
            /// </summary>
            [EnumMember(Value = "ON_DEMAND")]
            ONDEMAND = 1,
            
            /// <summary>
            /// Enum UPFRONT for value: UP_FRONT
            /// </summary>
            [EnumMember(Value = "UP_FRONT")]
            UPFRONT = 2
        }

        /// <summary>
        /// Determines when the machines are provisioned. * ON_DEMAND: Provision machines on demand. * UP_FRONT: Provision all machines up-front.
        /// </summary>
        /// <value>Determines when the machines are provisioned. * ON_DEMAND: Provision machines on demand. * UP_FRONT: Provision all machines up-front.</value>
        [DataMember(Name="provisioning_time", EmitDefaultValue=false)]
        public ProvisioningTimeEnum? ProvisioningTime { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopPoolVirtualMachinePatternNamingSettings" /> class.
        /// </summary>
        /// <param name="maxNumberOfMachines">Maximum number of machines in the desktop pool..</param>
        /// <param name="minNumberOfMachines">The minimum number of machines to have provisioned if on demand provisioning is selected..</param>
        /// <param name="namingPattern">Virtual machines will be named according to the specified naming pattern..</param>
        /// <param name="numberOfSpareMachines">Number of spare powered on machines..</param>
        /// <param name="provisioningTime">Determines when the machines are provisioned. * ON_DEMAND: Provision machines on demand. * UP_FRONT: Provision all machines up-front..</param>
        public DesktopPoolVirtualMachinePatternNamingSettings(int? maxNumberOfMachines = default(int?), int? minNumberOfMachines = default(int?), string namingPattern = default(string), int? numberOfSpareMachines = default(int?), ProvisioningTimeEnum? provisioningTime = default(ProvisioningTimeEnum?))
        {
            this.MaxNumberOfMachines = maxNumberOfMachines;
            this.MinNumberOfMachines = minNumberOfMachines;
            this.NamingPattern = namingPattern;
            this.NumberOfSpareMachines = numberOfSpareMachines;
            this.ProvisioningTime = provisioningTime;
        }
        
        /// <summary>
        /// Maximum number of machines in the desktop pool.
        /// </summary>
        /// <value>Maximum number of machines in the desktop pool.</value>
        [DataMember(Name="max_number_of_machines", EmitDefaultValue=false)]
        public int? MaxNumberOfMachines { get; set; }

        /// <summary>
        /// The minimum number of machines to have provisioned if on demand provisioning is selected.
        /// </summary>
        /// <value>The minimum number of machines to have provisioned if on demand provisioning is selected.</value>
        [DataMember(Name="min_number_of_machines", EmitDefaultValue=false)]
        public int? MinNumberOfMachines { get; set; }

        /// <summary>
        /// Virtual machines will be named according to the specified naming pattern.
        /// </summary>
        /// <value>Virtual machines will be named according to the specified naming pattern.</value>
        [DataMember(Name="naming_pattern", EmitDefaultValue=false)]
        public string NamingPattern { get; set; }

        /// <summary>
        /// Number of spare powered on machines.
        /// </summary>
        /// <value>Number of spare powered on machines.</value>
        [DataMember(Name="number_of_spare_machines", EmitDefaultValue=false)]
        public int? NumberOfSpareMachines { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopPoolVirtualMachinePatternNamingSettings {\n");
            sb.Append("  MaxNumberOfMachines: ").Append(MaxNumberOfMachines).Append("\n");
            sb.Append("  MinNumberOfMachines: ").Append(MinNumberOfMachines).Append("\n");
            sb.Append("  NamingPattern: ").Append(NamingPattern).Append("\n");
            sb.Append("  NumberOfSpareMachines: ").Append(NumberOfSpareMachines).Append("\n");
            sb.Append("  ProvisioningTime: ").Append(ProvisioningTime).Append("\n");
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
            return this.Equals(input as DesktopPoolVirtualMachinePatternNamingSettings);
        }

        /// <summary>
        /// Returns true if DesktopPoolVirtualMachinePatternNamingSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DesktopPoolVirtualMachinePatternNamingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesktopPoolVirtualMachinePatternNamingSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxNumberOfMachines == input.MaxNumberOfMachines ||
                    (this.MaxNumberOfMachines != null &&
                    this.MaxNumberOfMachines.Equals(input.MaxNumberOfMachines))
                ) && 
                (
                    this.MinNumberOfMachines == input.MinNumberOfMachines ||
                    (this.MinNumberOfMachines != null &&
                    this.MinNumberOfMachines.Equals(input.MinNumberOfMachines))
                ) && 
                (
                    this.NamingPattern == input.NamingPattern ||
                    (this.NamingPattern != null &&
                    this.NamingPattern.Equals(input.NamingPattern))
                ) && 
                (
                    this.NumberOfSpareMachines == input.NumberOfSpareMachines ||
                    (this.NumberOfSpareMachines != null &&
                    this.NumberOfSpareMachines.Equals(input.NumberOfSpareMachines))
                ) && 
                (
                    this.ProvisioningTime == input.ProvisioningTime ||
                    (this.ProvisioningTime != null &&
                    this.ProvisioningTime.Equals(input.ProvisioningTime))
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
                if (this.MaxNumberOfMachines != null)
                    hashCode = hashCode * 59 + this.MaxNumberOfMachines.GetHashCode();
                if (this.MinNumberOfMachines != null)
                    hashCode = hashCode * 59 + this.MinNumberOfMachines.GetHashCode();
                if (this.NamingPattern != null)
                    hashCode = hashCode * 59 + this.NamingPattern.GetHashCode();
                if (this.NumberOfSpareMachines != null)
                    hashCode = hashCode * 59 + this.NumberOfSpareMachines.GetHashCode();
                if (this.ProvisioningTime != null)
                    hashCode = hashCode * 59 + this.ProvisioningTime.GetHashCode();
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