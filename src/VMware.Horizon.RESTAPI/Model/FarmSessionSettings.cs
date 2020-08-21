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
    /// Session related settings for the Farm.
    /// </summary>
    [DataContract]
    public partial class FarmSessionSettings :  IEquatable<FarmSessionSettings>, IValidatableObject
    {
        /// <summary>
        /// Log-off policy after disconnected session. Default value is NEVER. * IMMEDIATELY: Immmediately Logoff after user disconnect. * AFTER: Logoff after the specified number of minutes after user disconnect. * NEVER: Do not logoff after user disconnect.
        /// </summary>
        /// <value>Log-off policy after disconnected session. Default value is NEVER. * IMMEDIATELY: Immmediately Logoff after user disconnect. * AFTER: Logoff after the specified number of minutes after user disconnect. * NEVER: Do not logoff after user disconnect.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisconnectedSessionTimeoutPolicyEnum
        {
            
            /// <summary>
            /// Enum IMMEDIATELY for value: IMMEDIATELY
            /// </summary>
            [EnumMember(Value = "IMMEDIATELY")]
            IMMEDIATELY = 1,
            
            /// <summary>
            /// Enum AFTER for value: AFTER
            /// </summary>
            [EnumMember(Value = "AFTER")]
            AFTER = 2,
            
            /// <summary>
            /// Enum NEVER for value: NEVER
            /// </summary>
            [EnumMember(Value = "NEVER")]
            NEVER = 3
        }

        /// <summary>
        /// Log-off policy after disconnected session. Default value is NEVER. * IMMEDIATELY: Immmediately Logoff after user disconnect. * AFTER: Logoff after the specified number of minutes after user disconnect. * NEVER: Do not logoff after user disconnect.
        /// </summary>
        /// <value>Log-off policy after disconnected session. Default value is NEVER. * IMMEDIATELY: Immmediately Logoff after user disconnect. * AFTER: Logoff after the specified number of minutes after user disconnect. * NEVER: Do not logoff after user disconnect.</value>
        [DataMember(Name="disconnected_session_timeout_policy", EmitDefaultValue=false)]
        public DisconnectedSessionTimeoutPolicyEnum DisconnectedSessionTimeoutPolicy { get; set; }
        /// <summary>
        /// Application empty session timeout policy. Default value is AFTER. * IMMEDIATE: Empty session will be disconnected immediately. * NEVER: Empty session will never disconnected. * AFTER: Empty session will be disconnected after specified number of minutes.
        /// </summary>
        /// <value>Application empty session timeout policy. Default value is AFTER. * IMMEDIATE: Empty session will be disconnected immediately. * NEVER: Empty session will never disconnected. * AFTER: Empty session will be disconnected after specified number of minutes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EmptySessionTimeoutPolicyEnum
        {
            
            /// <summary>
            /// Enum IMMEDIATE for value: IMMEDIATE
            /// </summary>
            [EnumMember(Value = "IMMEDIATE")]
            IMMEDIATE = 1,
            
            /// <summary>
            /// Enum NEVER for value: NEVER
            /// </summary>
            [EnumMember(Value = "NEVER")]
            NEVER = 2,
            
            /// <summary>
            /// Enum AFTER for value: AFTER
            /// </summary>
            [EnumMember(Value = "AFTER")]
            AFTER = 3
        }

        /// <summary>
        /// Application empty session timeout policy. Default value is AFTER. * IMMEDIATE: Empty session will be disconnected immediately. * NEVER: Empty session will never disconnected. * AFTER: Empty session will be disconnected after specified number of minutes.
        /// </summary>
        /// <value>Application empty session timeout policy. Default value is AFTER. * IMMEDIATE: Empty session will be disconnected immediately. * NEVER: Empty session will never disconnected. * AFTER: Empty session will be disconnected after specified number of minutes.</value>
        [DataMember(Name="empty_session_timeout_policy", EmitDefaultValue=false)]
        public EmptySessionTimeoutPolicyEnum EmptySessionTimeoutPolicy { get; set; }
        /// <summary>
        /// Pre-launch session timeout policy for the application sessions on this Farm. * AFTER: Pre-launched session is disconnected after specified number of minutes. * NEVER: Pre-launched session is never disconnected.
        /// </summary>
        /// <value>Pre-launch session timeout policy for the application sessions on this Farm. * AFTER: Pre-launched session is disconnected after specified number of minutes. * NEVER: Pre-launched session is never disconnected.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PreLaunchSessionTimeoutPolicyEnum
        {
            
            /// <summary>
            /// Enum AFTER for value: AFTER
            /// </summary>
            [EnumMember(Value = "AFTER")]
            AFTER = 1,
            
            /// <summary>
            /// Enum NEVER for value: NEVER
            /// </summary>
            [EnumMember(Value = "NEVER")]
            NEVER = 2
        }

        /// <summary>
        /// Pre-launch session timeout policy for the application sessions on this Farm. * AFTER: Pre-launched session is disconnected after specified number of minutes. * NEVER: Pre-launched session is never disconnected.
        /// </summary>
        /// <value>Pre-launch session timeout policy for the application sessions on this Farm. * AFTER: Pre-launched session is disconnected after specified number of minutes. * NEVER: Pre-launched session is never disconnected.</value>
        [DataMember(Name="pre_launch_session_timeout_policy", EmitDefaultValue=false)]
        public PreLaunchSessionTimeoutPolicyEnum? PreLaunchSessionTimeoutPolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FarmSessionSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FarmSessionSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FarmSessionSettings" /> class.
        /// </summary>
        /// <param name="disconnectedSessionTimeoutMinutes">Disconnected sessions timeout (in minutes).Will be set when disconnected_session_timeout_policy is set to AFTER..</param>
        /// <param name="disconnectedSessionTimeoutPolicy">Log-off policy after disconnected session. Default value is NEVER. * IMMEDIATELY: Immmediately Logoff after user disconnect. * AFTER: Logoff after the specified number of minutes after user disconnect. * NEVER: Do not logoff after user disconnect. (required).</param>
        /// <param name="emptySessionTimeoutMinutes">Application empty session timeout in minutes. An empty session that has no remote-ablewindow is disconnected after the timeout. Default value is 1.Will be set when the empty_session_timeout_policy set to AFTER..</param>
        /// <param name="emptySessionTimeoutPolicy">Application empty session timeout policy. Default value is AFTER. * IMMEDIATE: Empty session will be disconnected immediately. * NEVER: Empty session will never disconnected. * AFTER: Empty session will be disconnected after specified number of minutes. (required).</param>
        /// <param name="logoffAfterTimeout">After timeout, empty application sessions are logged off when set to true. Otherwise sessions are disconnected.Default value is false. (required).</param>
        /// <param name="preLaunchSessionTimeoutMinutes">Application pre-launch session timeout in minutes. A pre-launch session is disconnected after the timeout.Will be set only when pre_launch_timeout_policy is set to AFTER..</param>
        /// <param name="preLaunchSessionTimeoutPolicy">Pre-launch session timeout policy for the application sessions on this Farm. * AFTER: Pre-launched session is disconnected after specified number of minutes. * NEVER: Pre-launched session is never disconnected..</param>
        public FarmSessionSettings(int? disconnectedSessionTimeoutMinutes = default(int?), DisconnectedSessionTimeoutPolicyEnum disconnectedSessionTimeoutPolicy = default(DisconnectedSessionTimeoutPolicyEnum), int? emptySessionTimeoutMinutes = default(int?), EmptySessionTimeoutPolicyEnum emptySessionTimeoutPolicy = default(EmptySessionTimeoutPolicyEnum), bool? logoffAfterTimeout = default(bool?), int? preLaunchSessionTimeoutMinutes = default(int?), PreLaunchSessionTimeoutPolicyEnum? preLaunchSessionTimeoutPolicy = default(PreLaunchSessionTimeoutPolicyEnum?))
        {
            // to ensure "disconnectedSessionTimeoutPolicy" is required (not null)
            if (disconnectedSessionTimeoutPolicy == null)
            {
                throw new InvalidDataException("disconnectedSessionTimeoutPolicy is a required property for FarmSessionSettings and cannot be null");
            }
            else
            {
                this.DisconnectedSessionTimeoutPolicy = disconnectedSessionTimeoutPolicy;
            }
            // to ensure "emptySessionTimeoutPolicy" is required (not null)
            if (emptySessionTimeoutPolicy == null)
            {
                throw new InvalidDataException("emptySessionTimeoutPolicy is a required property for FarmSessionSettings and cannot be null");
            }
            else
            {
                this.EmptySessionTimeoutPolicy = emptySessionTimeoutPolicy;
            }
            // to ensure "logoffAfterTimeout" is required (not null)
            if (logoffAfterTimeout == null)
            {
                throw new InvalidDataException("logoffAfterTimeout is a required property for FarmSessionSettings and cannot be null");
            }
            else
            {
                this.LogoffAfterTimeout = logoffAfterTimeout;
            }
            this.DisconnectedSessionTimeoutMinutes = disconnectedSessionTimeoutMinutes;
            this.EmptySessionTimeoutMinutes = emptySessionTimeoutMinutes;
            this.PreLaunchSessionTimeoutMinutes = preLaunchSessionTimeoutMinutes;
            this.PreLaunchSessionTimeoutPolicy = preLaunchSessionTimeoutPolicy;
        }
        
        /// <summary>
        /// Disconnected sessions timeout (in minutes).Will be set when disconnected_session_timeout_policy is set to AFTER.
        /// </summary>
        /// <value>Disconnected sessions timeout (in minutes).Will be set when disconnected_session_timeout_policy is set to AFTER.</value>
        [DataMember(Name="disconnected_session_timeout_minutes", EmitDefaultValue=false)]
        public int? DisconnectedSessionTimeoutMinutes { get; set; }


        /// <summary>
        /// Application empty session timeout in minutes. An empty session that has no remote-ablewindow is disconnected after the timeout. Default value is 1.Will be set when the empty_session_timeout_policy set to AFTER.
        /// </summary>
        /// <value>Application empty session timeout in minutes. An empty session that has no remote-ablewindow is disconnected after the timeout. Default value is 1.Will be set when the empty_session_timeout_policy set to AFTER.</value>
        [DataMember(Name="empty_session_timeout_minutes", EmitDefaultValue=false)]
        public int? EmptySessionTimeoutMinutes { get; set; }


        /// <summary>
        /// After timeout, empty application sessions are logged off when set to true. Otherwise sessions are disconnected.Default value is false.
        /// </summary>
        /// <value>After timeout, empty application sessions are logged off when set to true. Otherwise sessions are disconnected.Default value is false.</value>
        [DataMember(Name="logoff_after_timeout", EmitDefaultValue=false)]
        public bool? LogoffAfterTimeout { get; set; }

        /// <summary>
        /// Application pre-launch session timeout in minutes. A pre-launch session is disconnected after the timeout.Will be set only when pre_launch_timeout_policy is set to AFTER.
        /// </summary>
        /// <value>Application pre-launch session timeout in minutes. A pre-launch session is disconnected after the timeout.Will be set only when pre_launch_timeout_policy is set to AFTER.</value>
        [DataMember(Name="pre_launch_session_timeout_minutes", EmitDefaultValue=false)]
        public int? PreLaunchSessionTimeoutMinutes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FarmSessionSettings {\n");
            sb.Append("  DisconnectedSessionTimeoutMinutes: ").Append(DisconnectedSessionTimeoutMinutes).Append("\n");
            sb.Append("  DisconnectedSessionTimeoutPolicy: ").Append(DisconnectedSessionTimeoutPolicy).Append("\n");
            sb.Append("  EmptySessionTimeoutMinutes: ").Append(EmptySessionTimeoutMinutes).Append("\n");
            sb.Append("  EmptySessionTimeoutPolicy: ").Append(EmptySessionTimeoutPolicy).Append("\n");
            sb.Append("  LogoffAfterTimeout: ").Append(LogoffAfterTimeout).Append("\n");
            sb.Append("  PreLaunchSessionTimeoutMinutes: ").Append(PreLaunchSessionTimeoutMinutes).Append("\n");
            sb.Append("  PreLaunchSessionTimeoutPolicy: ").Append(PreLaunchSessionTimeoutPolicy).Append("\n");
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
            return this.Equals(input as FarmSessionSettings);
        }

        /// <summary>
        /// Returns true if FarmSessionSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of FarmSessionSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FarmSessionSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisconnectedSessionTimeoutMinutes == input.DisconnectedSessionTimeoutMinutes ||
                    (this.DisconnectedSessionTimeoutMinutes != null &&
                    this.DisconnectedSessionTimeoutMinutes.Equals(input.DisconnectedSessionTimeoutMinutes))
                ) && 
                (
                    this.DisconnectedSessionTimeoutPolicy == input.DisconnectedSessionTimeoutPolicy ||
                    (this.DisconnectedSessionTimeoutPolicy != null &&
                    this.DisconnectedSessionTimeoutPolicy.Equals(input.DisconnectedSessionTimeoutPolicy))
                ) && 
                (
                    this.EmptySessionTimeoutMinutes == input.EmptySessionTimeoutMinutes ||
                    (this.EmptySessionTimeoutMinutes != null &&
                    this.EmptySessionTimeoutMinutes.Equals(input.EmptySessionTimeoutMinutes))
                ) && 
                (
                    this.EmptySessionTimeoutPolicy == input.EmptySessionTimeoutPolicy ||
                    (this.EmptySessionTimeoutPolicy != null &&
                    this.EmptySessionTimeoutPolicy.Equals(input.EmptySessionTimeoutPolicy))
                ) && 
                (
                    this.LogoffAfterTimeout == input.LogoffAfterTimeout ||
                    (this.LogoffAfterTimeout != null &&
                    this.LogoffAfterTimeout.Equals(input.LogoffAfterTimeout))
                ) && 
                (
                    this.PreLaunchSessionTimeoutMinutes == input.PreLaunchSessionTimeoutMinutes ||
                    (this.PreLaunchSessionTimeoutMinutes != null &&
                    this.PreLaunchSessionTimeoutMinutes.Equals(input.PreLaunchSessionTimeoutMinutes))
                ) && 
                (
                    this.PreLaunchSessionTimeoutPolicy == input.PreLaunchSessionTimeoutPolicy ||
                    (this.PreLaunchSessionTimeoutPolicy != null &&
                    this.PreLaunchSessionTimeoutPolicy.Equals(input.PreLaunchSessionTimeoutPolicy))
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
                if (this.DisconnectedSessionTimeoutMinutes != null)
                    hashCode = hashCode * 59 + this.DisconnectedSessionTimeoutMinutes.GetHashCode();
                if (this.DisconnectedSessionTimeoutPolicy != null)
                    hashCode = hashCode * 59 + this.DisconnectedSessionTimeoutPolicy.GetHashCode();
                if (this.EmptySessionTimeoutMinutes != null)
                    hashCode = hashCode * 59 + this.EmptySessionTimeoutMinutes.GetHashCode();
                if (this.EmptySessionTimeoutPolicy != null)
                    hashCode = hashCode * 59 + this.EmptySessionTimeoutPolicy.GetHashCode();
                if (this.LogoffAfterTimeout != null)
                    hashCode = hashCode * 59 + this.LogoffAfterTimeout.GetHashCode();
                if (this.PreLaunchSessionTimeoutMinutes != null)
                    hashCode = hashCode * 59 + this.PreLaunchSessionTimeoutMinutes.GetHashCode();
                if (this.PreLaunchSessionTimeoutPolicy != null)
                    hashCode = hashCode * 59 + this.PreLaunchSessionTimeoutPolicy.GetHashCode();
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
            // DisconnectedSessionTimeoutMinutes (int?) minimum
            if(this.DisconnectedSessionTimeoutMinutes < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisconnectedSessionTimeoutMinutes, must be a value greater than or equal to 1.", new [] { "DisconnectedSessionTimeoutMinutes" });
            }

            // EmptySessionTimeoutMinutes (int?) minimum
            if(this.EmptySessionTimeoutMinutes < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmptySessionTimeoutMinutes, must be a value greater than or equal to 1.", new [] { "EmptySessionTimeoutMinutes" });
            }

            // PreLaunchSessionTimeoutMinutes (int?) minimum
            if(this.PreLaunchSessionTimeoutMinutes < (int?)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PreLaunchSessionTimeoutMinutes, must be a value greater than or equal to 10.", new [] { "PreLaunchSessionTimeoutMinutes" });
            }

            yield break;
        }
    }

}