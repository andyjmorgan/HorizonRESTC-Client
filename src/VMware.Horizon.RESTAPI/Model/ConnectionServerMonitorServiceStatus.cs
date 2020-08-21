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
    /// Status of Connection Server related Windows service.
    /// </summary>
    [DataContract]
    public partial class ConnectionServerMonitorServiceStatus :  IEquatable<ConnectionServerMonitorServiceStatus>, IValidatableObject
    {
        /// <summary>
        /// Service name of the Connection Server. * PCOIP_SECURE_GATEWAY: PCoIP Secure Gateway service. * BLAST_SECURE_GATEWAY: BLAST Secure Gateway service. * SECURITY_GATEWAY_COMPONENT: Security Gateway Component service.
        /// </summary>
        /// <value>Service name of the Connection Server. * PCOIP_SECURE_GATEWAY: PCoIP Secure Gateway service. * BLAST_SECURE_GATEWAY: BLAST Secure Gateway service. * SECURITY_GATEWAY_COMPONENT: Security Gateway Component service.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceNameEnum
        {
            
            /// <summary>
            /// Enum PCOIPSECUREGATEWAY for value: PCOIP_SECURE_GATEWAY
            /// </summary>
            [EnumMember(Value = "PCOIP_SECURE_GATEWAY")]
            PCOIPSECUREGATEWAY = 1,
            
            /// <summary>
            /// Enum BLASTSECUREGATEWAY for value: BLAST_SECURE_GATEWAY
            /// </summary>
            [EnumMember(Value = "BLAST_SECURE_GATEWAY")]
            BLASTSECUREGATEWAY = 2,
            
            /// <summary>
            /// Enum SECURITYGATEWAYCOMPONENT for value: SECURITY_GATEWAY_COMPONENT
            /// </summary>
            [EnumMember(Value = "SECURITY_GATEWAY_COMPONENT")]
            SECURITYGATEWAYCOMPONENT = 3
        }

        /// <summary>
        /// Service name of the Connection Server. * PCOIP_SECURE_GATEWAY: PCoIP Secure Gateway service. * BLAST_SECURE_GATEWAY: BLAST Secure Gateway service. * SECURITY_GATEWAY_COMPONENT: Security Gateway Component service.
        /// </summary>
        /// <value>Service name of the Connection Server. * PCOIP_SECURE_GATEWAY: PCoIP Secure Gateway service. * BLAST_SECURE_GATEWAY: BLAST Secure Gateway service. * SECURITY_GATEWAY_COMPONENT: Security Gateway Component service.</value>
        [DataMember(Name="service_name", EmitDefaultValue=false)]
        public ServiceNameEnum ServiceName { get; set; }
        /// <summary>
        /// Status of the service. * UP: The Windows service is UP and running. * DOWN: The Windows service is not UP. * UNKNOWN: The Windows service state is Unknown.
        /// </summary>
        /// <value>Status of the service. * UP: The Windows service is UP and running. * DOWN: The Windows service is not UP. * UNKNOWN: The Windows service state is Unknown.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum UP for value: UP
            /// </summary>
            [EnumMember(Value = "UP")]
            UP = 1,
            
            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            [EnumMember(Value = "DOWN")]
            DOWN = 2,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 3
        }

        /// <summary>
        /// Status of the service. * UP: The Windows service is UP and running. * DOWN: The Windows service is not UP. * UNKNOWN: The Windows service state is Unknown.
        /// </summary>
        /// <value>Status of the service. * UP: The Windows service is UP and running. * DOWN: The Windows service is not UP. * UNKNOWN: The Windows service state is Unknown.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionServerMonitorServiceStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectionServerMonitorServiceStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionServerMonitorServiceStatus" /> class.
        /// </summary>
        /// <param name="serviceName">Service name of the Connection Server. * PCOIP_SECURE_GATEWAY: PCoIP Secure Gateway service. * BLAST_SECURE_GATEWAY: BLAST Secure Gateway service. * SECURITY_GATEWAY_COMPONENT: Security Gateway Component service. (required).</param>
        /// <param name="status">Status of the service. * UP: The Windows service is UP and running. * DOWN: The Windows service is not UP. * UNKNOWN: The Windows service state is Unknown. (required).</param>
        public ConnectionServerMonitorServiceStatus(ServiceNameEnum serviceName = default(ServiceNameEnum), StatusEnum status = default(StatusEnum))
        {
            // to ensure "serviceName" is required (not null)
            if (serviceName == null)
            {
                throw new InvalidDataException("serviceName is a required property for ConnectionServerMonitorServiceStatus and cannot be null");
            }
            else
            {
                this.ServiceName = serviceName;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for ConnectionServerMonitorServiceStatus and cannot be null");
            }
            else
            {
                this.Status = status;
            }
        }
        


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionServerMonitorServiceStatus {\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as ConnectionServerMonitorServiceStatus);
        }

        /// <summary>
        /// Returns true if ConnectionServerMonitorServiceStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionServerMonitorServiceStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionServerMonitorServiceStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ServiceName != null)
                    hashCode = hashCode * 59 + this.ServiceName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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