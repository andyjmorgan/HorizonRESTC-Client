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
    /// Display protocol settings for the Farm.
    /// </summary>
    [DataContract]
    public partial class FarmDisplayProtocolSettings :  IEquatable<FarmDisplayProtocolSettings>
    {
        /// <summary>
        /// The default server display protocol. Default value is PCOIP. * RDP: Microsoft Remote Desktop Protocol. * PCOIP: PCoIP protocol. * BLAST: BLAST protocol.
        /// </summary>
        /// <value>The default server display protocol. Default value is PCOIP. * RDP: Microsoft Remote Desktop Protocol. * PCOIP: PCoIP protocol. * BLAST: BLAST protocol.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DefaultDisplayProtocolEnum
        {
            
            /// <summary>
            /// Enum RDP for value: RDP
            /// </summary>
            [EnumMember(Value = "RDP")]
            RDP = 1,
            
            /// <summary>
            /// Enum PCOIP for value: PCOIP
            /// </summary>
            [EnumMember(Value = "PCOIP")]
            PCOIP = 2,
            
            /// <summary>
            /// Enum BLAST for value: BLAST
            /// </summary>
            [EnumMember(Value = "BLAST")]
            BLAST = 3
        }

        /// <summary>
        /// The default server display protocol. Default value is PCOIP. * RDP: Microsoft Remote Desktop Protocol. * PCOIP: PCoIP protocol. * BLAST: BLAST protocol.
        /// </summary>
        /// <value>The default server display protocol. Default value is PCOIP. * RDP: Microsoft Remote Desktop Protocol. * PCOIP: PCoIP protocol. * BLAST: BLAST protocol.</value>
        [DataMember(Name="default_display_protocol", EmitDefaultValue=false)]
        public DefaultDisplayProtocolEnum DefaultDisplayProtocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FarmDisplayProtocolSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FarmDisplayProtocolSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FarmDisplayProtocolSettings" /> class.
        /// </summary>
        /// <param name="allowDisplayProtocolOverride">Indicates whether the display protocol settings could be overridden.If set to false, then default_display_protocol is used.Default value is true. (required).</param>
        /// <param name="defaultDisplayProtocol">The default server display protocol. Default value is PCOIP. * RDP: Microsoft Remote Desktop Protocol. * PCOIP: PCoIP protocol. * BLAST: BLAST protocol. (required).</param>
        /// <param name="gridVgpusEnabled">If this is true, the host or cluster associated with the farm must support NVIDIA GRID andvGPU types required by the RDSH desktop virtualMachines, VmTemplate, or BaseImageSnapshot.If this is false, RDSH instant clone farm must not support NVIDIA GRID vGPUs.Default value is false..</param>
        /// <param name="htmlAccessEnabled">This property is no longer in use for Horizon Components. It is always set to true. HTML Access, enabled by VMware Blast technology, allows users to connect to Horizon machines from Web browsers. Horizon Client software does not have to be installed on the client devices. To enable HTML Access, you must install the HTML Machine Access feature pack. (required).</param>
        /// <param name="sessionCollaborationEnabled">Enable session collaboration feature. Session collaborationallows a user to share their remote session with other users.BLAST must be configured as a supported protocol in supported_display_protocols.Default value is false. (required).</param>
        /// <param name="vgpuGridProfile">NVIDIA GRID vGPUs might have multiple profiles and any one of the available profiles can beapplied to newly created instant clone RDSH server. The profile specified in this field will beused in the newly created instant clone RDSH server. Will be set if enable_grid_vgpus set to true..</param>
        public FarmDisplayProtocolSettings(bool? allowDisplayProtocolOverride = default(bool?), DefaultDisplayProtocolEnum defaultDisplayProtocol = default(DefaultDisplayProtocolEnum), bool? gridVgpusEnabled = default(bool?), bool? htmlAccessEnabled = default(bool?), bool? sessionCollaborationEnabled = default(bool?), string vgpuGridProfile = default(string))
        {
            // to ensure "allowDisplayProtocolOverride" is required (not null)
            if (allowDisplayProtocolOverride == null)
            {
                throw new InvalidDataException("allowDisplayProtocolOverride is a required property for FarmDisplayProtocolSettings and cannot be null");
            }
            else
            {
                this.AllowDisplayProtocolOverride = allowDisplayProtocolOverride;
            }
            // to ensure "defaultDisplayProtocol" is required (not null)
            if (defaultDisplayProtocol == null)
            {
                throw new InvalidDataException("defaultDisplayProtocol is a required property for FarmDisplayProtocolSettings and cannot be null");
            }
            else
            {
                this.DefaultDisplayProtocol = defaultDisplayProtocol;
            }
            // to ensure "htmlAccessEnabled" is required (not null)
            if (htmlAccessEnabled == null)
            {
                throw new InvalidDataException("htmlAccessEnabled is a required property for FarmDisplayProtocolSettings and cannot be null");
            }
            else
            {
                this.HtmlAccessEnabled = htmlAccessEnabled;
            }
            // to ensure "sessionCollaborationEnabled" is required (not null)
            if (sessionCollaborationEnabled == null)
            {
                throw new InvalidDataException("sessionCollaborationEnabled is a required property for FarmDisplayProtocolSettings and cannot be null");
            }
            else
            {
                this.SessionCollaborationEnabled = sessionCollaborationEnabled;
            }
            this.GridVgpusEnabled = gridVgpusEnabled;
            this.VgpuGridProfile = vgpuGridProfile;
        }
        
        /// <summary>
        /// Indicates whether the display protocol settings could be overridden.If set to false, then default_display_protocol is used.Default value is true.
        /// </summary>
        /// <value>Indicates whether the display protocol settings could be overridden.If set to false, then default_display_protocol is used.Default value is true.</value>
        [DataMember(Name="allow_display_protocol_override", EmitDefaultValue=false)]
        public bool? AllowDisplayProtocolOverride { get; set; }


        /// <summary>
        /// If this is true, the host or cluster associated with the farm must support NVIDIA GRID andvGPU types required by the RDSH desktop virtualMachines, VmTemplate, or BaseImageSnapshot.If this is false, RDSH instant clone farm must not support NVIDIA GRID vGPUs.Default value is false.
        /// </summary>
        /// <value>If this is true, the host or cluster associated with the farm must support NVIDIA GRID andvGPU types required by the RDSH desktop virtualMachines, VmTemplate, or BaseImageSnapshot.If this is false, RDSH instant clone farm must not support NVIDIA GRID vGPUs.Default value is false.</value>
        [DataMember(Name="grid_vgpus_enabled", EmitDefaultValue=false)]
        public bool? GridVgpusEnabled { get; set; }

        /// <summary>
        /// This property is no longer in use for Horizon Components. It is always set to true. HTML Access, enabled by VMware Blast technology, allows users to connect to Horizon machines from Web browsers. Horizon Client software does not have to be installed on the client devices. To enable HTML Access, you must install the HTML Machine Access feature pack.
        /// </summary>
        /// <value>This property is no longer in use for Horizon Components. It is always set to true. HTML Access, enabled by VMware Blast technology, allows users to connect to Horizon machines from Web browsers. Horizon Client software does not have to be installed on the client devices. To enable HTML Access, you must install the HTML Machine Access feature pack.</value>
        [DataMember(Name="html_access_enabled", EmitDefaultValue=false)]
        public bool? HtmlAccessEnabled { get; set; }

        /// <summary>
        /// Enable session collaboration feature. Session collaborationallows a user to share their remote session with other users.BLAST must be configured as a supported protocol in supported_display_protocols.Default value is false.
        /// </summary>
        /// <value>Enable session collaboration feature. Session collaborationallows a user to share their remote session with other users.BLAST must be configured as a supported protocol in supported_display_protocols.Default value is false.</value>
        [DataMember(Name="session_collaboration_enabled", EmitDefaultValue=false)]
        public bool? SessionCollaborationEnabled { get; set; }

        /// <summary>
        /// NVIDIA GRID vGPUs might have multiple profiles and any one of the available profiles can beapplied to newly created instant clone RDSH server. The profile specified in this field will beused in the newly created instant clone RDSH server. Will be set if enable_grid_vgpus set to true.
        /// </summary>
        /// <value>NVIDIA GRID vGPUs might have multiple profiles and any one of the available profiles can beapplied to newly created instant clone RDSH server. The profile specified in this field will beused in the newly created instant clone RDSH server. Will be set if enable_grid_vgpus set to true.</value>
        [DataMember(Name="vgpu_grid_profile", EmitDefaultValue=false)]
        public string VgpuGridProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FarmDisplayProtocolSettings {\n");
            sb.Append("  AllowDisplayProtocolOverride: ").Append(AllowDisplayProtocolOverride).Append("\n");
            sb.Append("  DefaultDisplayProtocol: ").Append(DefaultDisplayProtocol).Append("\n");
            sb.Append("  GridVgpusEnabled: ").Append(GridVgpusEnabled).Append("\n");
            sb.Append("  HtmlAccessEnabled: ").Append(HtmlAccessEnabled).Append("\n");
            sb.Append("  SessionCollaborationEnabled: ").Append(SessionCollaborationEnabled).Append("\n");
            sb.Append("  VgpuGridProfile: ").Append(VgpuGridProfile).Append("\n");
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
            return this.Equals(input as FarmDisplayProtocolSettings);
        }

        /// <summary>
        /// Returns true if FarmDisplayProtocolSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of FarmDisplayProtocolSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FarmDisplayProtocolSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowDisplayProtocolOverride == input.AllowDisplayProtocolOverride ||
                    (this.AllowDisplayProtocolOverride != null &&
                    this.AllowDisplayProtocolOverride.Equals(input.AllowDisplayProtocolOverride))
                ) && 
                (
                    this.DefaultDisplayProtocol == input.DefaultDisplayProtocol ||
                    (this.DefaultDisplayProtocol != null &&
                    this.DefaultDisplayProtocol.Equals(input.DefaultDisplayProtocol))
                ) && 
                (
                    this.GridVgpusEnabled == input.GridVgpusEnabled ||
                    (this.GridVgpusEnabled != null &&
                    this.GridVgpusEnabled.Equals(input.GridVgpusEnabled))
                ) && 
                (
                    this.HtmlAccessEnabled == input.HtmlAccessEnabled ||
                    (this.HtmlAccessEnabled != null &&
                    this.HtmlAccessEnabled.Equals(input.HtmlAccessEnabled))
                ) && 
                (
                    this.SessionCollaborationEnabled == input.SessionCollaborationEnabled ||
                    (this.SessionCollaborationEnabled != null &&
                    this.SessionCollaborationEnabled.Equals(input.SessionCollaborationEnabled))
                ) && 
                (
                    this.VgpuGridProfile == input.VgpuGridProfile ||
                    (this.VgpuGridProfile != null &&
                    this.VgpuGridProfile.Equals(input.VgpuGridProfile))
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
                if (this.AllowDisplayProtocolOverride != null)
                    hashCode = hashCode * 59 + this.AllowDisplayProtocolOverride.GetHashCode();
                if (this.DefaultDisplayProtocol != null)
                    hashCode = hashCode * 59 + this.DefaultDisplayProtocol.GetHashCode();
                if (this.GridVgpusEnabled != null)
                    hashCode = hashCode * 59 + this.GridVgpusEnabled.GetHashCode();
                if (this.HtmlAccessEnabled != null)
                    hashCode = hashCode * 59 + this.HtmlAccessEnabled.GetHashCode();
                if (this.SessionCollaborationEnabled != null)
                    hashCode = hashCode * 59 + this.SessionCollaborationEnabled.GetHashCode();
                if (this.VgpuGridProfile != null)
                    hashCode = hashCode * 59 + this.VgpuGridProfile.GetHashCode();
                return hashCode;
            }
        }
    }

}
