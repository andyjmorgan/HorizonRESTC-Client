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
    /// Information related to Settings.
    /// </summary>
    [DataContract]
    public partial class SettingsInfo :  IEquatable<SettingsInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettingsInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsInfo" /> class.
        /// </summary>
        /// <param name="featureSettings">Settings related to specific features. (required).</param>
        /// <param name="generalSettings">General settings determine session time-out lengths, status updates in Horizon Console, and whether prelogin and warning messages are displayed. (required).</param>
        /// <param name="securitySettings">Security settings determine whether Horizon clients are reauthenticated after interruptions, message security mode is enabled and SSO is used for local resource operations. (required).</param>
        public SettingsInfo(FeatureSettings featureSettings = default(FeatureSettings), GeneralSettings generalSettings = default(GeneralSettings), SecuritySettings securitySettings = default(SecuritySettings))
        {
            // to ensure "featureSettings" is required (not null)
            if (featureSettings == null)
            {
                throw new InvalidDataException("featureSettings is a required property for SettingsInfo and cannot be null");
            }
            else
            {
                this.FeatureSettings = featureSettings;
            }
            // to ensure "generalSettings" is required (not null)
            if (generalSettings == null)
            {
                throw new InvalidDataException("generalSettings is a required property for SettingsInfo and cannot be null");
            }
            else
            {
                this.GeneralSettings = generalSettings;
            }
            // to ensure "securitySettings" is required (not null)
            if (securitySettings == null)
            {
                throw new InvalidDataException("securitySettings is a required property for SettingsInfo and cannot be null");
            }
            else
            {
                this.SecuritySettings = securitySettings;
            }
        }
        
        /// <summary>
        /// Settings related to specific features.
        /// </summary>
        /// <value>Settings related to specific features.</value>
        [DataMember(Name="feature_settings", EmitDefaultValue=false)]
        public FeatureSettings FeatureSettings { get; set; }

        /// <summary>
        /// General settings determine session time-out lengths, status updates in Horizon Console, and whether prelogin and warning messages are displayed.
        /// </summary>
        /// <value>General settings determine session time-out lengths, status updates in Horizon Console, and whether prelogin and warning messages are displayed.</value>
        [DataMember(Name="general_settings", EmitDefaultValue=false)]
        public GeneralSettings GeneralSettings { get; set; }

        /// <summary>
        /// Security settings determine whether Horizon clients are reauthenticated after interruptions, message security mode is enabled and SSO is used for local resource operations.
        /// </summary>
        /// <value>Security settings determine whether Horizon clients are reauthenticated after interruptions, message security mode is enabled and SSO is used for local resource operations.</value>
        [DataMember(Name="security_settings", EmitDefaultValue=false)]
        public SecuritySettings SecuritySettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingsInfo {\n");
            sb.Append("  FeatureSettings: ").Append(FeatureSettings).Append("\n");
            sb.Append("  GeneralSettings: ").Append(GeneralSettings).Append("\n");
            sb.Append("  SecuritySettings: ").Append(SecuritySettings).Append("\n");
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
            return this.Equals(input as SettingsInfo);
        }

        /// <summary>
        /// Returns true if SettingsInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SettingsInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettingsInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeatureSettings == input.FeatureSettings ||
                    (this.FeatureSettings != null &&
                    this.FeatureSettings.Equals(input.FeatureSettings))
                ) && 
                (
                    this.GeneralSettings == input.GeneralSettings ||
                    (this.GeneralSettings != null &&
                    this.GeneralSettings.Equals(input.GeneralSettings))
                ) && 
                (
                    this.SecuritySettings == input.SecuritySettings ||
                    (this.SecuritySettings != null &&
                    this.SecuritySettings.Equals(input.SecuritySettings))
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
                if (this.FeatureSettings != null)
                    hashCode = hashCode * 59 + this.FeatureSettings.GetHashCode();
                if (this.GeneralSettings != null)
                    hashCode = hashCode * 59 + this.GeneralSettings.GetHashCode();
                if (this.SecuritySettings != null)
                    hashCode = hashCode * 59 + this.SecuritySettings.GetHashCode();
                return hashCode;
            }
        }
    }

}
