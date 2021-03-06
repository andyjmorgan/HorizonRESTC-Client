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
    /// Application icon information.
    /// </summary>
    [DataContract]
    public partial class ApplicationIconInfo :  IEquatable<ApplicationIconInfo>
    {
        /// <summary>
        /// Source of the application icon. The icon can be from Machine/RDS Agent or custom icon. * HORIZON_AGENT: When the icon is from machine/RDS agent. * HORIZON_CONNECTION_SERVER: When the icon is uploaded by the administrator through connection server.
        /// </summary>
        /// <value>Source of the application icon. The icon can be from Machine/RDS Agent or custom icon. * HORIZON_AGENT: When the icon is from machine/RDS agent. * HORIZON_CONNECTION_SERVER: When the icon is uploaded by the administrator through connection server.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IconSourceEnum
        {
            
            /// <summary>
            /// Enum AGENT for value: HORIZON_AGENT
            /// </summary>
            [EnumMember(Value = "HORIZON_AGENT")]
            AGENT = 1,
            
            /// <summary>
            /// Enum CONNECTIONSERVER for value: HORIZON_CONNECTION_SERVER
            /// </summary>
            [EnumMember(Value = "HORIZON_CONNECTION_SERVER")]
            CONNECTIONSERVER = 2
        }

        /// <summary>
        /// Source of the application icon. The icon can be from Machine/RDS Agent or custom icon. * HORIZON_AGENT: When the icon is from machine/RDS agent. * HORIZON_CONNECTION_SERVER: When the icon is uploaded by the administrator through connection server.
        /// </summary>
        /// <value>Source of the application icon. The icon can be from Machine/RDS Agent or custom icon. * HORIZON_AGENT: When the icon is from machine/RDS agent. * HORIZON_CONNECTION_SERVER: When the icon is uploaded by the administrator through connection server.</value>
        [DataMember(Name="icon_source", EmitDefaultValue=false)]
        public IconSourceEnum? IconSource { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationIconInfo" /> class.
        /// </summary>
        /// <param name="applicationPoolIds">An application icon could be shared by multiple application pools. This is a set of application pool IDs this icon represents..</param>
        /// <param name="data">Icon image data in PNG format..</param>
        /// <param name="height">Icon height..</param>
        /// <param name="iconHash">MD5 hash of icon image data, to enable quick icon lookup..</param>
        /// <param name="iconSource">Source of the application icon. The icon can be from Machine/RDS Agent or custom icon. * HORIZON_AGENT: When the icon is from machine/RDS agent. * HORIZON_CONNECTION_SERVER: When the icon is uploaded by the administrator through connection server..</param>
        /// <param name="id">Unique ID representing application icon..</param>
        /// <param name="width">Icon width..</param>
        public ApplicationIconInfo(List<string> applicationPoolIds = default(List<string>), byte[] data = default(byte[]), int? height = default(int?), string iconHash = default(string), IconSourceEnum? iconSource = default(IconSourceEnum?), string id = default(string), int? width = default(int?))
        {
            this.ApplicationPoolIds = applicationPoolIds;
            this.Data = data;
            this.Height = height;
            this.IconHash = iconHash;
            this.IconSource = iconSource;
            this.Id = id;
            this.Width = width;
        }
        
        /// <summary>
        /// An application icon could be shared by multiple application pools. This is a set of application pool IDs this icon represents.
        /// </summary>
        /// <value>An application icon could be shared by multiple application pools. This is a set of application pool IDs this icon represents.</value>
        [DataMember(Name="application_pool_ids", EmitDefaultValue=false)]
        public List<string> ApplicationPoolIds { get; set; }

        /// <summary>
        /// Icon image data in PNG format.
        /// </summary>
        /// <value>Icon image data in PNG format.</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public byte[] Data { get; set; }

        /// <summary>
        /// Icon height.
        /// </summary>
        /// <value>Icon height.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }

        /// <summary>
        /// MD5 hash of icon image data, to enable quick icon lookup.
        /// </summary>
        /// <value>MD5 hash of icon image data, to enable quick icon lookup.</value>
        [DataMember(Name="icon_hash", EmitDefaultValue=false)]
        public string IconHash { get; set; }


        /// <summary>
        /// Unique ID representing application icon.
        /// </summary>
        /// <value>Unique ID representing application icon.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Icon width.
        /// </summary>
        /// <value>Icon width.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationIconInfo {\n");
            sb.Append("  ApplicationPoolIds: ").Append(ApplicationPoolIds).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  IconHash: ").Append(IconHash).Append("\n");
            sb.Append("  IconSource: ").Append(IconSource).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as ApplicationIconInfo);
        }

        /// <summary>
        /// Returns true if ApplicationIconInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationIconInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationIconInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationPoolIds == input.ApplicationPoolIds ||
                    this.ApplicationPoolIds != null &&
                    this.ApplicationPoolIds.SequenceEqual(input.ApplicationPoolIds)
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.IconHash == input.IconHash ||
                    (this.IconHash != null &&
                    this.IconHash.Equals(input.IconHash))
                ) && 
                (
                    this.IconSource == input.IconSource ||
                    (this.IconSource != null &&
                    this.IconSource.Equals(input.IconSource))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.ApplicationPoolIds != null)
                    hashCode = hashCode * 59 + this.ApplicationPoolIds.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.IconHash != null)
                    hashCode = hashCode * 59 + this.IconHash.GetHashCode();
                if (this.IconSource != null)
                    hashCode = hashCode * 59 + this.IconSource.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                return hashCode;
            }
        }
    }

}
