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
    /// Information required to send message to sessions.
    /// </summary>
    [DataContract]
    public partial class SessionSendMessageSpec :  IEquatable<SessionSendMessageSpec>, IValidatableObject
    {
        /// <summary>
        /// Type of message to be sent to session(s). * ERROR: Message is of error type. * WARNING: Message is of warning type. * INFO: Message is of information type.
        /// </summary>
        /// <value>Type of message to be sent to session(s). * ERROR: Message is of error type. * WARNING: Message is of warning type. * INFO: Message is of information type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MessageTypeEnum
        {
            
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 1,
            
            /// <summary>
            /// Enum WARNING for value: WARNING
            /// </summary>
            [EnumMember(Value = "WARNING")]
            WARNING = 2,
            
            /// <summary>
            /// Enum INFO for value: INFO
            /// </summary>
            [EnumMember(Value = "INFO")]
            INFO = 3
        }

        /// <summary>
        /// Type of message to be sent to session(s). * ERROR: Message is of error type. * WARNING: Message is of warning type. * INFO: Message is of information type.
        /// </summary>
        /// <value>Type of message to be sent to session(s). * ERROR: Message is of error type. * WARNING: Message is of warning type. * INFO: Message is of information type.</value>
        [DataMember(Name="message_type", EmitDefaultValue=false)]
        public MessageTypeEnum MessageType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSendMessageSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionSendMessageSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionSendMessageSpec" /> class.
        /// </summary>
        /// <param name="message">Message to be sent to session(s). (required).</param>
        /// <param name="messageType">Type of message to be sent to session(s). * ERROR: Message is of error type. * WARNING: Message is of warning type. * INFO: Message is of information type. (required).</param>
        /// <param name="sessionIds">List of session ids to which message is to be sent (required).</param>
        public SessionSendMessageSpec(string message = default(string), MessageTypeEnum messageType = default(MessageTypeEnum), List<string> sessionIds = default(List<string>))
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for SessionSendMessageSpec and cannot be null");
            }
            else
            {
                this.Message = message;
            }
            // to ensure "messageType" is required (not null)
            if (messageType == null)
            {
                throw new InvalidDataException("messageType is a required property for SessionSendMessageSpec and cannot be null");
            }
            else
            {
                this.MessageType = messageType;
            }
            // to ensure "sessionIds" is required (not null)
            if (sessionIds == null)
            {
                throw new InvalidDataException("sessionIds is a required property for SessionSendMessageSpec and cannot be null");
            }
            else
            {
                this.SessionIds = sessionIds;
            }
        }
        
        /// <summary>
        /// Message to be sent to session(s).
        /// </summary>
        /// <value>Message to be sent to session(s).</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// List of session ids to which message is to be sent
        /// </summary>
        /// <value>List of session ids to which message is to be sent</value>
        [DataMember(Name="session_ids", EmitDefaultValue=false)]
        public List<string> SessionIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionSendMessageSpec {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  SessionIds: ").Append(SessionIds).Append("\n");
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
            return this.Equals(input as SessionSendMessageSpec);
        }

        /// <summary>
        /// Returns true if SessionSendMessageSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of SessionSendMessageSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionSendMessageSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.SessionIds == input.SessionIds ||
                    this.SessionIds != null &&
                    this.SessionIds.SequenceEqual(input.SessionIds)
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.SessionIds != null)
                    hashCode = hashCode * 59 + this.SessionIds.GetHashCode();
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
