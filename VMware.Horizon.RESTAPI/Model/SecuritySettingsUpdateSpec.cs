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
    /// Information related to Security Settings.
    /// </summary>
    [DataContract]
    public partial class SecuritySettingsUpdateSpec :  IEquatable<SecuritySettingsUpdateSpec>
    {
        /// <summary>
        /// Determines if signing and verification of the JMS messages passed between Horizon components takes place. * DISABLED: Message security mode is disabled. * MIXED: Message security mode is enabled but not enforced. * ENABLED: Message security mode is enabled. Unsigned messages are rejected by Horizon components. * ENHANCED: Message Security mode is Enhanced. Message signing and validation is performed based on the current Security Level and desktop Message Security mode.
        /// </summary>
        /// <value>Determines if signing and verification of the JMS messages passed between Horizon components takes place. * DISABLED: Message security mode is disabled. * MIXED: Message security mode is enabled but not enforced. * ENABLED: Message security mode is enabled. Unsigned messages are rejected by Horizon components. * ENHANCED: Message Security mode is Enhanced. Message signing and validation is performed based on the current Security Level and desktop Message Security mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageSecurityModeEnum
        {
            
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 1,
            
            /// <summary>
            /// Enum MIXED for value: MIXED
            /// </summary>
            [EnumMember(Value = "MIXED")]
            MIXED = 2,
            
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            [EnumMember(Value = "ENABLED")]
            ENABLED = 3,
            
            /// <summary>
            /// Enum ENHANCED for value: ENHANCED
            /// </summary>
            [EnumMember(Value = "ENHANCED")]
            ENHANCED = 4
        }

        /// <summary>
        /// Determines if signing and verification of the JMS messages passed between Horizon components takes place. * DISABLED: Message security mode is disabled. * MIXED: Message security mode is enabled but not enforced. * ENABLED: Message security mode is enabled. Unsigned messages are rejected by Horizon components. * ENHANCED: Message Security mode is Enhanced. Message signing and validation is performed based on the current Security Level and desktop Message Security mode.
        /// </summary>
        /// <value>Determines if signing and verification of the JMS messages passed between Horizon components takes place. * DISABLED: Message security mode is disabled. * MIXED: Message security mode is enabled but not enforced. * ENABLED: Message security mode is enabled. Unsigned messages are rejected by Horizon components. * ENHANCED: Message Security mode is Enhanced. Message signing and validation is performed based on the current Security Level and desktop Message Security mode.</value>
        [DataMember(Name="message_security_mode", EmitDefaultValue=false)]
        public MessageSecurityModeEnum MessageSecurityMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySettingsUpdateSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecuritySettingsUpdateSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SecuritySettingsUpdateSpec" /> class.
        /// </summary>
        /// <param name="dataRecoveryPasswordHash">The SHA-256 hash of the (UTF-8) data recovery password..</param>
        /// <param name="dataRecoveryPasswordHint">The data recovery password hint. This property has a maximum length of 128 characters..</param>
        /// <param name="messageSecurityMode">Determines if signing and verification of the JMS messages passed between Horizon components takes place. * DISABLED: Message security mode is disabled. * MIXED: Message security mode is enabled but not enforced. * ENABLED: Message security mode is enabled. Unsigned messages are rejected by Horizon components. * ENHANCED: Message Security mode is Enhanced. Message signing and validation is performed based on the current Security Level and desktop Message Security mode. (required).</param>
        /// <param name="reAuthSecureTunnelAfterInterruption">Determines if user credentials must be re-authenticated after a network interruption when Horizon clients use secure tunnel connections to Horizon resources. When you select this setting, if a secure tunnel connection ends during a session, Horizon Client requires the user to re-authenticate before reconnecting..</param>
        public SecuritySettingsUpdateSpec(List<string> dataRecoveryPasswordHash = default(List<string>), string dataRecoveryPasswordHint = default(string), MessageSecurityModeEnum messageSecurityMode = default(MessageSecurityModeEnum), bool? reAuthSecureTunnelAfterInterruption = default(bool?))
        {
            // to ensure "messageSecurityMode" is required (not null)
            if (messageSecurityMode == null)
            {
                throw new InvalidDataException("messageSecurityMode is a required property for SecuritySettingsUpdateSpec and cannot be null");
            }
            else
            {
                this.MessageSecurityMode = messageSecurityMode;
            }
            this.DataRecoveryPasswordHash = dataRecoveryPasswordHash;
            this.DataRecoveryPasswordHint = dataRecoveryPasswordHint;
            this.ReAuthSecureTunnelAfterInterruption = reAuthSecureTunnelAfterInterruption;
        }
        
        /// <summary>
        /// The SHA-256 hash of the (UTF-8) data recovery password.
        /// </summary>
        /// <value>The SHA-256 hash of the (UTF-8) data recovery password.</value>
        [DataMember(Name="data_recovery_password_hash", EmitDefaultValue=false)]
        public List<string> DataRecoveryPasswordHash { get; set; }

        /// <summary>
        /// The data recovery password hint. This property has a maximum length of 128 characters.
        /// </summary>
        /// <value>The data recovery password hint. This property has a maximum length of 128 characters.</value>
        [DataMember(Name="data_recovery_password_hint", EmitDefaultValue=false)]
        public string DataRecoveryPasswordHint { get; set; }


        /// <summary>
        /// Determines if user credentials must be re-authenticated after a network interruption when Horizon clients use secure tunnel connections to Horizon resources. When you select this setting, if a secure tunnel connection ends during a session, Horizon Client requires the user to re-authenticate before reconnecting.
        /// </summary>
        /// <value>Determines if user credentials must be re-authenticated after a network interruption when Horizon clients use secure tunnel connections to Horizon resources. When you select this setting, if a secure tunnel connection ends during a session, Horizon Client requires the user to re-authenticate before reconnecting.</value>
        [DataMember(Name="re_auth_secure_tunnel_after_interruption", EmitDefaultValue=false)]
        public bool? ReAuthSecureTunnelAfterInterruption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecuritySettingsUpdateSpec {\n");
            sb.Append("  DataRecoveryPasswordHash: ").Append(DataRecoveryPasswordHash).Append("\n");
            sb.Append("  DataRecoveryPasswordHint: ").Append(DataRecoveryPasswordHint).Append("\n");
            sb.Append("  MessageSecurityMode: ").Append(MessageSecurityMode).Append("\n");
            sb.Append("  ReAuthSecureTunnelAfterInterruption: ").Append(ReAuthSecureTunnelAfterInterruption).Append("\n");
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
            return this.Equals(input as SecuritySettingsUpdateSpec);
        }

        /// <summary>
        /// Returns true if SecuritySettingsUpdateSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of SecuritySettingsUpdateSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecuritySettingsUpdateSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DataRecoveryPasswordHash == input.DataRecoveryPasswordHash ||
                    this.DataRecoveryPasswordHash != null &&
                    this.DataRecoveryPasswordHash.SequenceEqual(input.DataRecoveryPasswordHash)
                ) && 
                (
                    this.DataRecoveryPasswordHint == input.DataRecoveryPasswordHint ||
                    (this.DataRecoveryPasswordHint != null &&
                    this.DataRecoveryPasswordHint.Equals(input.DataRecoveryPasswordHint))
                ) && 
                (
                    this.MessageSecurityMode == input.MessageSecurityMode ||
                    (this.MessageSecurityMode != null &&
                    this.MessageSecurityMode.Equals(input.MessageSecurityMode))
                ) && 
                (
                    this.ReAuthSecureTunnelAfterInterruption == input.ReAuthSecureTunnelAfterInterruption ||
                    (this.ReAuthSecureTunnelAfterInterruption != null &&
                    this.ReAuthSecureTunnelAfterInterruption.Equals(input.ReAuthSecureTunnelAfterInterruption))
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
                if (this.DataRecoveryPasswordHash != null)
                    hashCode = hashCode * 59 + this.DataRecoveryPasswordHash.GetHashCode();
                if (this.DataRecoveryPasswordHint != null)
                    hashCode = hashCode * 59 + this.DataRecoveryPasswordHint.GetHashCode();
                if (this.MessageSecurityMode != null)
                    hashCode = hashCode * 59 + this.MessageSecurityMode.GetHashCode();
                if (this.ReAuthSecureTunnelAfterInterruption != null)
                    hashCode = hashCode * 59 + this.ReAuthSecureTunnelAfterInterruption.GetHashCode();
                return hashCode;
            }
        }
    }

}
