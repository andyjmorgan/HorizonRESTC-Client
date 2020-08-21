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
    /// Details of connected session count for each session protocol.
    /// </summary>
    [DataContract]
    public partial class ConnectionServerSessionProtocolData :  IEquatable<ConnectionServerSessionProtocolData>, IValidatableObject
    {
        /// <summary>
        /// Protocol used in launching the session. * PCOIP: Display protocol is PCoIP. * RDP: Display protocol is RDP. * BLAST: Display protocol is BLAST. * CONSOLE: Display protocol is console. * UNKNOWN: Display protocol is unknown.
        /// </summary>
        /// <value>Protocol used in launching the session. * PCOIP: Display protocol is PCoIP. * RDP: Display protocol is RDP. * BLAST: Display protocol is BLAST. * CONSOLE: Display protocol is console. * UNKNOWN: Display protocol is unknown.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SessionProtocolEnum
        {
            
            /// <summary>
            /// Enum PCOIP for value: PCOIP
            /// </summary>
            [EnumMember(Value = "PCOIP")]
            PCOIP = 1,
            
            /// <summary>
            /// Enum RDP for value: RDP
            /// </summary>
            [EnumMember(Value = "RDP")]
            RDP = 2,
            
            /// <summary>
            /// Enum BLAST for value: BLAST
            /// </summary>
            [EnumMember(Value = "BLAST")]
            BLAST = 3,
            
            /// <summary>
            /// Enum CONSOLE for value: CONSOLE
            /// </summary>
            [EnumMember(Value = "CONSOLE")]
            CONSOLE = 4,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 5
        }

        /// <summary>
        /// Protocol used in launching the session. * PCOIP: Display protocol is PCoIP. * RDP: Display protocol is RDP. * BLAST: Display protocol is BLAST. * CONSOLE: Display protocol is console. * UNKNOWN: Display protocol is unknown.
        /// </summary>
        /// <value>Protocol used in launching the session. * PCOIP: Display protocol is PCoIP. * RDP: Display protocol is RDP. * BLAST: Display protocol is BLAST. * CONSOLE: Display protocol is console. * UNKNOWN: Display protocol is unknown.</value>
        [DataMember(Name="session_protocol", EmitDefaultValue=false)]
        public SessionProtocolEnum SessionProtocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionServerSessionProtocolData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectionServerSessionProtocolData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionServerSessionProtocolData" /> class.
        /// </summary>
        /// <param name="sessionCount">Number of active sessions launched using the protocol. (required).</param>
        /// <param name="sessionProtocol">Protocol used in launching the session. * PCOIP: Display protocol is PCoIP. * RDP: Display protocol is RDP. * BLAST: Display protocol is BLAST. * CONSOLE: Display protocol is console. * UNKNOWN: Display protocol is unknown. (required).</param>
        public ConnectionServerSessionProtocolData(int? sessionCount = default(int?), SessionProtocolEnum sessionProtocol = default(SessionProtocolEnum))
        {
            // to ensure "sessionCount" is required (not null)
            if (sessionCount == null)
            {
                throw new InvalidDataException("sessionCount is a required property for ConnectionServerSessionProtocolData and cannot be null");
            }
            else
            {
                this.SessionCount = sessionCount;
            }
            // to ensure "sessionProtocol" is required (not null)
            if (sessionProtocol == null)
            {
                throw new InvalidDataException("sessionProtocol is a required property for ConnectionServerSessionProtocolData and cannot be null");
            }
            else
            {
                this.SessionProtocol = sessionProtocol;
            }
        }
        
        /// <summary>
        /// Number of active sessions launched using the protocol.
        /// </summary>
        /// <value>Number of active sessions launched using the protocol.</value>
        [DataMember(Name="session_count", EmitDefaultValue=false)]
        public int? SessionCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionServerSessionProtocolData {\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
            sb.Append("  SessionProtocol: ").Append(SessionProtocol).Append("\n");
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
            return this.Equals(input as ConnectionServerSessionProtocolData);
        }

        /// <summary>
        /// Returns true if ConnectionServerSessionProtocolData instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionServerSessionProtocolData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionServerSessionProtocolData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SessionCount == input.SessionCount ||
                    (this.SessionCount != null &&
                    this.SessionCount.Equals(input.SessionCount))
                ) && 
                (
                    this.SessionProtocol == input.SessionProtocol ||
                    (this.SessionProtocol != null &&
                    this.SessionProtocol.Equals(input.SessionProtocol))
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
                if (this.SessionCount != null)
                    hashCode = hashCode * 59 + this.SessionCount.GetHashCode();
                if (this.SessionProtocol != null)
                    hashCode = hashCode * 59 + this.SessionProtocol.GetHashCode();
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
