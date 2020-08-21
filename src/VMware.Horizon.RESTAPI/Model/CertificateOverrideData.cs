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
    /// Certificate details and type information, which can be used to override thumbprint details.
    /// </summary>
    [DataContract]
    public partial class CertificateOverrideData :  IEquatable<CertificateOverrideData>, IValidatableObject
    {
        /// <summary>
        /// Type of Certificate. * PEM: PEM encoded certificate type
        /// </summary>
        /// <value>Type of Certificate. * PEM: PEM encoded certificate type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum PEM for value: PEM
            /// </summary>
            [EnumMember(Value = "PEM")]
            PEM = 1
        }

        /// <summary>
        /// Type of Certificate. * PEM: PEM encoded certificate type
        /// </summary>
        /// <value>Type of Certificate. * PEM: PEM encoded certificate type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CertificateOverrideData" /> class.
        /// </summary>
        /// <param name="certificate">Virtual Center certificate.</param>
        /// <param name="type">Type of Certificate. * PEM: PEM encoded certificate type.</param>
        public CertificateOverrideData(string certificate = default(string), TypeEnum? type = default(TypeEnum?))
        {
            this.Certificate = certificate;
            this.Type = type;
        }
        
        /// <summary>
        /// Virtual Center certificate
        /// </summary>
        /// <value>Virtual Center certificate</value>
        [DataMember(Name="certificate", EmitDefaultValue=false)]
        public string Certificate { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertificateOverrideData {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
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
            return this.Equals(input as CertificateOverrideData);
        }

        /// <summary>
        /// Returns true if CertificateOverrideData instances are equal
        /// </summary>
        /// <param name="input">Instance of CertificateOverrideData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CertificateOverrideData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
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
                if (this.Certificate != null)
                    hashCode = hashCode * 59 + this.Certificate.GetHashCode();
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
