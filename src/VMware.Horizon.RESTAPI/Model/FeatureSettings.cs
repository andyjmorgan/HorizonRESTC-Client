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
    /// Information related to Feature Settings.
    /// </summary>
    [DataContract]
    public partial class FeatureSettings :  IEquatable<FeatureSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureSettings" /> class.
        /// </summary>
        /// <param name="cloudManaged">Indicates whether this cluster/pod is managed by Horizon Cloud Services. This will be false only when there are no cloud managed machines..</param>
        /// <param name="enableHelpdesk">Determines whether Helpdesk feature is enabled or not. By default Helpdesk is enabled..</param>
        /// <param name="enableImageManagement">Determines whether Image Management feature is enabled or not. By default Image Management is disabled..</param>
        public FeatureSettings(bool? cloudManaged = default(bool?), bool? enableHelpdesk = default(bool?), bool? enableImageManagement = default(bool?))
        {
            this.CloudManaged = cloudManaged;
            this.EnableHelpdesk = enableHelpdesk;
            this.EnableImageManagement = enableImageManagement;
        }
        
        /// <summary>
        /// Indicates whether this cluster/pod is managed by Horizon Cloud Services. This will be false only when there are no cloud managed machines.
        /// </summary>
        /// <value>Indicates whether this cluster/pod is managed by Horizon Cloud Services. This will be false only when there are no cloud managed machines.</value>
        [DataMember(Name="cloud_managed", EmitDefaultValue=false)]
        public bool? CloudManaged { get; set; }

        /// <summary>
        /// Determines whether Helpdesk feature is enabled or not. By default Helpdesk is enabled.
        /// </summary>
        /// <value>Determines whether Helpdesk feature is enabled or not. By default Helpdesk is enabled.</value>
        [DataMember(Name="enable_helpdesk", EmitDefaultValue=false)]
        public bool? EnableHelpdesk { get; set; }

        /// <summary>
        /// Determines whether Image Management feature is enabled or not. By default Image Management is disabled.
        /// </summary>
        /// <value>Determines whether Image Management feature is enabled or not. By default Image Management is disabled.</value>
        [DataMember(Name="enable_image_management", EmitDefaultValue=false)]
        public bool? EnableImageManagement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureSettings {\n");
            sb.Append("  CloudManaged: ").Append(CloudManaged).Append("\n");
            sb.Append("  EnableHelpdesk: ").Append(EnableHelpdesk).Append("\n");
            sb.Append("  EnableImageManagement: ").Append(EnableImageManagement).Append("\n");
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
            return this.Equals(input as FeatureSettings);
        }

        /// <summary>
        /// Returns true if FeatureSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudManaged == input.CloudManaged ||
                    (this.CloudManaged != null &&
                    this.CloudManaged.Equals(input.CloudManaged))
                ) && 
                (
                    this.EnableHelpdesk == input.EnableHelpdesk ||
                    (this.EnableHelpdesk != null &&
                    this.EnableHelpdesk.Equals(input.EnableHelpdesk))
                ) && 
                (
                    this.EnableImageManagement == input.EnableImageManagement ||
                    (this.EnableImageManagement != null &&
                    this.EnableImageManagement.Equals(input.EnableImageManagement))
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
                if (this.CloudManaged != null)
                    hashCode = hashCode * 59 + this.CloudManaged.GetHashCode();
                if (this.EnableHelpdesk != null)
                    hashCode = hashCode * 59 + this.EnableHelpdesk.GetHashCode();
                if (this.EnableImageManagement != null)
                    hashCode = hashCode * 59 + this.EnableImageManagement.GetHashCode();
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
