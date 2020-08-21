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
    /// Settings for QuickPrep customization.
    /// </summary>
    [DataContract]
    public partial class DesktopPoolQuickprepCustomizationSettings :  IEquatable<DesktopPoolQuickprepCustomizationSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopPoolQuickprepCustomizationSettings" /> class.
        /// </summary>
        /// <param name="postSynchronizationScriptParameters">Post synchronization script parameters..</param>
        /// <param name="postSynchronizationScriptPath">Post synchronization script. QuickPrep can run a customization script on linked-clone machines after they are created, recomposed, and refreshed. Provide the path to the script on the parent virtual machine..</param>
        /// <param name="powerOffScriptParameters">Power off script parameters..</param>
        /// <param name="powerOffScriptPath">Power off script. QuickPrep can run a customization script on linked-clone machines before they are powered off. Provide the path to the script on the parent virtual machine..</param>
        public DesktopPoolQuickprepCustomizationSettings(string postSynchronizationScriptParameters = default(string), string postSynchronizationScriptPath = default(string), string powerOffScriptParameters = default(string), string powerOffScriptPath = default(string))
        {
            this.PostSynchronizationScriptParameters = postSynchronizationScriptParameters;
            this.PostSynchronizationScriptPath = postSynchronizationScriptPath;
            this.PowerOffScriptParameters = powerOffScriptParameters;
            this.PowerOffScriptPath = powerOffScriptPath;
        }
        
        /// <summary>
        /// Post synchronization script parameters.
        /// </summary>
        /// <value>Post synchronization script parameters.</value>
        [DataMember(Name="post_synchronization_script_parameters", EmitDefaultValue=false)]
        public string PostSynchronizationScriptParameters { get; set; }

        /// <summary>
        /// Post synchronization script. QuickPrep can run a customization script on linked-clone machines after they are created, recomposed, and refreshed. Provide the path to the script on the parent virtual machine.
        /// </summary>
        /// <value>Post synchronization script. QuickPrep can run a customization script on linked-clone machines after they are created, recomposed, and refreshed. Provide the path to the script on the parent virtual machine.</value>
        [DataMember(Name="post_synchronization_script_path", EmitDefaultValue=false)]
        public string PostSynchronizationScriptPath { get; set; }

        /// <summary>
        /// Power off script parameters.
        /// </summary>
        /// <value>Power off script parameters.</value>
        [DataMember(Name="power_off_script_parameters", EmitDefaultValue=false)]
        public string PowerOffScriptParameters { get; set; }

        /// <summary>
        /// Power off script. QuickPrep can run a customization script on linked-clone machines before they are powered off. Provide the path to the script on the parent virtual machine.
        /// </summary>
        /// <value>Power off script. QuickPrep can run a customization script on linked-clone machines before they are powered off. Provide the path to the script on the parent virtual machine.</value>
        [DataMember(Name="power_off_script_path", EmitDefaultValue=false)]
        public string PowerOffScriptPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopPoolQuickprepCustomizationSettings {\n");
            sb.Append("  PostSynchronizationScriptParameters: ").Append(PostSynchronizationScriptParameters).Append("\n");
            sb.Append("  PostSynchronizationScriptPath: ").Append(PostSynchronizationScriptPath).Append("\n");
            sb.Append("  PowerOffScriptParameters: ").Append(PowerOffScriptParameters).Append("\n");
            sb.Append("  PowerOffScriptPath: ").Append(PowerOffScriptPath).Append("\n");
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
            return this.Equals(input as DesktopPoolQuickprepCustomizationSettings);
        }

        /// <summary>
        /// Returns true if DesktopPoolQuickprepCustomizationSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DesktopPoolQuickprepCustomizationSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesktopPoolQuickprepCustomizationSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostSynchronizationScriptParameters == input.PostSynchronizationScriptParameters ||
                    (this.PostSynchronizationScriptParameters != null &&
                    this.PostSynchronizationScriptParameters.Equals(input.PostSynchronizationScriptParameters))
                ) && 
                (
                    this.PostSynchronizationScriptPath == input.PostSynchronizationScriptPath ||
                    (this.PostSynchronizationScriptPath != null &&
                    this.PostSynchronizationScriptPath.Equals(input.PostSynchronizationScriptPath))
                ) && 
                (
                    this.PowerOffScriptParameters == input.PowerOffScriptParameters ||
                    (this.PowerOffScriptParameters != null &&
                    this.PowerOffScriptParameters.Equals(input.PowerOffScriptParameters))
                ) && 
                (
                    this.PowerOffScriptPath == input.PowerOffScriptPath ||
                    (this.PowerOffScriptPath != null &&
                    this.PowerOffScriptPath.Equals(input.PowerOffScriptPath))
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
                if (this.PostSynchronizationScriptParameters != null)
                    hashCode = hashCode * 59 + this.PostSynchronizationScriptParameters.GetHashCode();
                if (this.PostSynchronizationScriptPath != null)
                    hashCode = hashCode * 59 + this.PostSynchronizationScriptPath.GetHashCode();
                if (this.PowerOffScriptParameters != null)
                    hashCode = hashCode * 59 + this.PowerOffScriptParameters.GetHashCode();
                if (this.PowerOffScriptPath != null)
                    hashCode = hashCode * 59 + this.PowerOffScriptPath.GetHashCode();
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
