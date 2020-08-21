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
    /// Information related to image management stream.
    /// </summary>
    [DataContract]
    public partial class ImageManagementStreamInfo :  IEquatable<ImageManagementStreamInfo>, IValidatableObject
    {
        /// <summary>
        /// Operating system. * UNKNOWN: Unknown * WINDOWS_XP: Windows XP * WINDOWS_VISTA: Windows Vista * WINDOWS_7: Windows 7 * WINDOWS_8: Windows 8 * WINDOWS_10: Windows 10 * WINDOWS_SERVER_2003: Windows Server 2003 * WINDOWS_SERVER_2008: Windows Server 2008 * WINDOWS_SERVER_2008_R2: Windows Server 2008 R2 * WINDOWS_SERVER_2012: Windows Server 2012 * WINDOWS_SERVER_2012_R2: Windows Server 2012 R2 * WINDOWS_SERVER_2016_OR_ABOVE: Windows Server 2016 or above * LINUX_OTHER: Linux (other) * LINUX_SERVER_OTHER: Linux server (other) * LINUX_UBUNTU: Linux (Ubuntu) * LINUX_RHEL: Linux (Red Hat Enterprise) * LINUX_SUSE: Linux (Suse) * LINUX_CENTOS: Linux (CentOS)
        /// </summary>
        /// <value>Operating system. * UNKNOWN: Unknown * WINDOWS_XP: Windows XP * WINDOWS_VISTA: Windows Vista * WINDOWS_7: Windows 7 * WINDOWS_8: Windows 8 * WINDOWS_10: Windows 10 * WINDOWS_SERVER_2003: Windows Server 2003 * WINDOWS_SERVER_2008: Windows Server 2008 * WINDOWS_SERVER_2008_R2: Windows Server 2008 R2 * WINDOWS_SERVER_2012: Windows Server 2012 * WINDOWS_SERVER_2012_R2: Windows Server 2012 R2 * WINDOWS_SERVER_2016_OR_ABOVE: Windows Server 2016 or above * LINUX_OTHER: Linux (other) * LINUX_SERVER_OTHER: Linux server (other) * LINUX_UBUNTU: Linux (Ubuntu) * LINUX_RHEL: Linux (Red Hat Enterprise) * LINUX_SUSE: Linux (Suse) * LINUX_CENTOS: Linux (CentOS)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatingSystemEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 1,
            
            /// <summary>
            /// Enum WINDOWSXP for value: WINDOWS_XP
            /// </summary>
            [EnumMember(Value = "WINDOWS_XP")]
            WINDOWSXP = 2,
            
            /// <summary>
            /// Enum WINDOWSVISTA for value: WINDOWS_VISTA
            /// </summary>
            [EnumMember(Value = "WINDOWS_VISTA")]
            WINDOWSVISTA = 3,
            
            /// <summary>
            /// Enum WINDOWS7 for value: WINDOWS_7
            /// </summary>
            [EnumMember(Value = "WINDOWS_7")]
            WINDOWS7 = 4,
            
            /// <summary>
            /// Enum WINDOWS8 for value: WINDOWS_8
            /// </summary>
            [EnumMember(Value = "WINDOWS_8")]
            WINDOWS8 = 5,
            
            /// <summary>
            /// Enum WINDOWS10 for value: WINDOWS_10
            /// </summary>
            [EnumMember(Value = "WINDOWS_10")]
            WINDOWS10 = 6,
            
            /// <summary>
            /// Enum WINDOWSSERVER2003 for value: WINDOWS_SERVER_2003
            /// </summary>
            [EnumMember(Value = "WINDOWS_SERVER_2003")]
            WINDOWSSERVER2003 = 7,
            
            /// <summary>
            /// Enum WINDOWSSERVER2008 for value: WINDOWS_SERVER_2008
            /// </summary>
            [EnumMember(Value = "WINDOWS_SERVER_2008")]
            WINDOWSSERVER2008 = 8,
            
            /// <summary>
            /// Enum WINDOWSSERVER2008R2 for value: WINDOWS_SERVER_2008_R2
            /// </summary>
            [EnumMember(Value = "WINDOWS_SERVER_2008_R2")]
            WINDOWSSERVER2008R2 = 9,
            
            /// <summary>
            /// Enum WINDOWSSERVER2012 for value: WINDOWS_SERVER_2012
            /// </summary>
            [EnumMember(Value = "WINDOWS_SERVER_2012")]
            WINDOWSSERVER2012 = 10,
            
            /// <summary>
            /// Enum WINDOWSSERVER2012R2 for value: WINDOWS_SERVER_2012_R2
            /// </summary>
            [EnumMember(Value = "WINDOWS_SERVER_2012_R2")]
            WINDOWSSERVER2012R2 = 11,
            
            /// <summary>
            /// Enum WINDOWSSERVER2016ORABOVE for value: WINDOWS_SERVER_2016_OR_ABOVE
            /// </summary>
            [EnumMember(Value = "WINDOWS_SERVER_2016_OR_ABOVE")]
            WINDOWSSERVER2016ORABOVE = 12,
            
            /// <summary>
            /// Enum LINUXOTHER for value: LINUX_OTHER
            /// </summary>
            [EnumMember(Value = "LINUX_OTHER")]
            LINUXOTHER = 13,
            
            /// <summary>
            /// Enum LINUXSERVEROTHER for value: LINUX_SERVER_OTHER
            /// </summary>
            [EnumMember(Value = "LINUX_SERVER_OTHER")]
            LINUXSERVEROTHER = 14,
            
            /// <summary>
            /// Enum LINUXUBUNTU for value: LINUX_UBUNTU
            /// </summary>
            [EnumMember(Value = "LINUX_UBUNTU")]
            LINUXUBUNTU = 15,
            
            /// <summary>
            /// Enum LINUXRHEL for value: LINUX_RHEL
            /// </summary>
            [EnumMember(Value = "LINUX_RHEL")]
            LINUXRHEL = 16,
            
            /// <summary>
            /// Enum LINUXSUSE for value: LINUX_SUSE
            /// </summary>
            [EnumMember(Value = "LINUX_SUSE")]
            LINUXSUSE = 17,
            
            /// <summary>
            /// Enum LINUXCENTOS for value: LINUX_CENTOS
            /// </summary>
            [EnumMember(Value = "LINUX_CENTOS")]
            LINUXCENTOS = 18
        }

        /// <summary>
        /// Operating system. * UNKNOWN: Unknown * WINDOWS_XP: Windows XP * WINDOWS_VISTA: Windows Vista * WINDOWS_7: Windows 7 * WINDOWS_8: Windows 8 * WINDOWS_10: Windows 10 * WINDOWS_SERVER_2003: Windows Server 2003 * WINDOWS_SERVER_2008: Windows Server 2008 * WINDOWS_SERVER_2008_R2: Windows Server 2008 R2 * WINDOWS_SERVER_2012: Windows Server 2012 * WINDOWS_SERVER_2012_R2: Windows Server 2012 R2 * WINDOWS_SERVER_2016_OR_ABOVE: Windows Server 2016 or above * LINUX_OTHER: Linux (other) * LINUX_SERVER_OTHER: Linux server (other) * LINUX_UBUNTU: Linux (Ubuntu) * LINUX_RHEL: Linux (Red Hat Enterprise) * LINUX_SUSE: Linux (Suse) * LINUX_CENTOS: Linux (CentOS)
        /// </summary>
        /// <value>Operating system. * UNKNOWN: Unknown * WINDOWS_XP: Windows XP * WINDOWS_VISTA: Windows Vista * WINDOWS_7: Windows 7 * WINDOWS_8: Windows 8 * WINDOWS_10: Windows 10 * WINDOWS_SERVER_2003: Windows Server 2003 * WINDOWS_SERVER_2008: Windows Server 2008 * WINDOWS_SERVER_2008_R2: Windows Server 2008 R2 * WINDOWS_SERVER_2012: Windows Server 2012 * WINDOWS_SERVER_2012_R2: Windows Server 2012 R2 * WINDOWS_SERVER_2016_OR_ABOVE: Windows Server 2016 or above * LINUX_OTHER: Linux (other) * LINUX_SERVER_OTHER: Linux server (other) * LINUX_UBUNTU: Linux (Ubuntu) * LINUX_RHEL: Linux (Red Hat Enterprise) * LINUX_SUSE: Linux (Suse) * LINUX_CENTOS: Linux (CentOS)</value>
        [DataMember(Name="operating_system", EmitDefaultValue=false)]
        public OperatingSystemEnum OperatingSystem { get; set; }
        /// <summary>
        /// Image management stream source. * MARKET_PLACE: Image management stream is from market place. * UPLOADED: Image management stream is uploaded. * COPIED_FROM_STREAM: Image management stream is copied from another stream. * COPIED_FROM_VERSION: Image management stream is copied from a version.
        /// </summary>
        /// <value>Image management stream source. * MARKET_PLACE: Image management stream is from market place. * UPLOADED: Image management stream is uploaded. * COPIED_FROM_STREAM: Image management stream is copied from another stream. * COPIED_FROM_VERSION: Image management stream is copied from a version.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            
            /// <summary>
            /// Enum MARKETPLACE for value: MARKET_PLACE
            /// </summary>
            [EnumMember(Value = "MARKET_PLACE")]
            MARKETPLACE = 1,
            
            /// <summary>
            /// Enum UPLOADED for value: UPLOADED
            /// </summary>
            [EnumMember(Value = "UPLOADED")]
            UPLOADED = 2,
            
            /// <summary>
            /// Enum COPIEDFROMSTREAM for value: COPIED_FROM_STREAM
            /// </summary>
            [EnumMember(Value = "COPIED_FROM_STREAM")]
            COPIEDFROMSTREAM = 3,
            
            /// <summary>
            /// Enum COPIEDFROMVERSION for value: COPIED_FROM_VERSION
            /// </summary>
            [EnumMember(Value = "COPIED_FROM_VERSION")]
            COPIEDFROMVERSION = 4
        }

        /// <summary>
        /// Image management stream source. * MARKET_PLACE: Image management stream is from market place. * UPLOADED: Image management stream is uploaded. * COPIED_FROM_STREAM: Image management stream is copied from another stream. * COPIED_FROM_VERSION: Image management stream is copied from a version.
        /// </summary>
        /// <value>Image management stream source. * MARKET_PLACE: Image management stream is from market place. * UPLOADED: Image management stream is uploaded. * COPIED_FROM_STREAM: Image management stream is copied from another stream. * COPIED_FROM_VERSION: Image management stream is copied from a version.</value>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public SourceEnum Source { get; set; }
        /// <summary>
        /// Image management stream status. * AVAILABLE: Image management stream is available for desktop pools/farms to be created. * DELETED: Image management stream is deleted. * DISABLED: Image management stream is disabled and no further desktop pools/farms can be created using the same. * FAILED: Image management stream creation has failed. * IN_PROGRESS: Image management stream creation is in progress. * PARTIALLY_AVAILABLE: Image management version for this stream could not be created in one or more environments. * PENDING: Image management stream is in pending state.
        /// </summary>
        /// <value>Image management stream status. * AVAILABLE: Image management stream is available for desktop pools/farms to be created. * DELETED: Image management stream is deleted. * DISABLED: Image management stream is disabled and no further desktop pools/farms can be created using the same. * FAILED: Image management stream creation has failed. * IN_PROGRESS: Image management stream creation is in progress. * PARTIALLY_AVAILABLE: Image management version for this stream could not be created in one or more environments. * PENDING: Image management stream is in pending state.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum AVAILABLE for value: AVAILABLE
            /// </summary>
            [EnumMember(Value = "AVAILABLE")]
            AVAILABLE = 1,
            
            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 2,
            
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 3,
            
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 4,
            
            /// <summary>
            /// Enum INPROGRESS for value: IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            INPROGRESS = 5,
            
            /// <summary>
            /// Enum PARTIALLYAVAILABLE for value: PARTIALLY_AVAILABLE
            /// </summary>
            [EnumMember(Value = "PARTIALLY_AVAILABLE")]
            PARTIALLYAVAILABLE = 6,
            
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 7
        }

        /// <summary>
        /// Image management stream status. * AVAILABLE: Image management stream is available for desktop pools/farms to be created. * DELETED: Image management stream is deleted. * DISABLED: Image management stream is disabled and no further desktop pools/farms can be created using the same. * FAILED: Image management stream creation has failed. * IN_PROGRESS: Image management stream creation is in progress. * PARTIALLY_AVAILABLE: Image management version for this stream could not be created in one or more environments. * PENDING: Image management stream is in pending state.
        /// </summary>
        /// <value>Image management stream status. * AVAILABLE: Image management stream is available for desktop pools/farms to be created. * DELETED: Image management stream is deleted. * DISABLED: Image management stream is disabled and no further desktop pools/farms can be created using the same. * FAILED: Image management stream creation has failed. * IN_PROGRESS: Image management stream creation is in progress. * PARTIALLY_AVAILABLE: Image management version for this stream could not be created in one or more environments. * PENDING: Image management stream is in pending state.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageManagementStreamInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImageManagementStreamInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageManagementStreamInfo" /> class.
        /// </summary>
        /// <param name="additionalDetails">Additional details about image management stream..</param>
        /// <param name="description">Image management stream description..</param>
        /// <param name="id">Unique ID representing image management stream. (required).</param>
        /// <param name="name">Image management stream name. (required).</param>
        /// <param name="operatingSystem">Operating system. * UNKNOWN: Unknown * WINDOWS_XP: Windows XP * WINDOWS_VISTA: Windows Vista * WINDOWS_7: Windows 7 * WINDOWS_8: Windows 8 * WINDOWS_10: Windows 10 * WINDOWS_SERVER_2003: Windows Server 2003 * WINDOWS_SERVER_2008: Windows Server 2008 * WINDOWS_SERVER_2008_R2: Windows Server 2008 R2 * WINDOWS_SERVER_2012: Windows Server 2012 * WINDOWS_SERVER_2012_R2: Windows Server 2012 R2 * WINDOWS_SERVER_2016_OR_ABOVE: Windows Server 2016 or above * LINUX_OTHER: Linux (other) * LINUX_SERVER_OTHER: Linux server (other) * LINUX_UBUNTU: Linux (Ubuntu) * LINUX_RHEL: Linux (Red Hat Enterprise) * LINUX_SUSE: Linux (Suse) * LINUX_CENTOS: Linux (CentOS) (required).</param>
        /// <param name="publisher">Image management stream publisher.</param>
        /// <param name="source">Image management stream source. * MARKET_PLACE: Image management stream is from market place. * UPLOADED: Image management stream is uploaded. * COPIED_FROM_STREAM: Image management stream is copied from another stream. * COPIED_FROM_VERSION: Image management stream is copied from a version. (required).</param>
        /// <param name="status">Image management stream status. * AVAILABLE: Image management stream is available for desktop pools/farms to be created. * DELETED: Image management stream is deleted. * DISABLED: Image management stream is disabled and no further desktop pools/farms can be created using the same. * FAILED: Image management stream creation has failed. * IN_PROGRESS: Image management stream creation is in progress. * PARTIALLY_AVAILABLE: Image management version for this stream could not be created in one or more environments. * PENDING: Image management stream is in pending state. (required).</param>
        /// <param name="usable">Specifies whether the image management stream can be used in desktop pool or farm. This will be set to true when: &lt;ul&gt;&lt;li&gt;Image management stream is in AVAILABLE or PARTIALLY_AVAILABLE state. &lt;/li&gt;&lt;li&gt;There is at least one image management version in AVAILABLE or PARTIALLY_AVAILABLE state for this stream. &lt;/li&gt;&lt;li&gt;There is at least one image management tag associated with the image management version.&lt;/li&gt; &lt;/ul&gt;For a specific virtual center, image management tag information will be retrieved..</param>
        public ImageManagementStreamInfo(Dictionary<string, string> additionalDetails = default(Dictionary<string, string>), string description = default(string), string id = default(string), string name = default(string), OperatingSystemEnum operatingSystem = default(OperatingSystemEnum), string publisher = default(string), SourceEnum source = default(SourceEnum), StatusEnum status = default(StatusEnum), bool? usable = default(bool?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for ImageManagementStreamInfo and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ImageManagementStreamInfo and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "operatingSystem" is required (not null)
            if (operatingSystem == null)
            {
                throw new InvalidDataException("operatingSystem is a required property for ImageManagementStreamInfo and cannot be null");
            }
            else
            {
                this.OperatingSystem = operatingSystem;
            }
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for ImageManagementStreamInfo and cannot be null");
            }
            else
            {
                this.Source = source;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for ImageManagementStreamInfo and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.AdditionalDetails = additionalDetails;
            this.Description = description;
            this.Publisher = publisher;
            this.Usable = usable;
        }
        
        /// <summary>
        /// Additional details about image management stream.
        /// </summary>
        /// <value>Additional details about image management stream.</value>
        [DataMember(Name="additional_details", EmitDefaultValue=false)]
        public Dictionary<string, string> AdditionalDetails { get; set; }

        /// <summary>
        /// Image management stream description.
        /// </summary>
        /// <value>Image management stream description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Unique ID representing image management stream.
        /// </summary>
        /// <value>Unique ID representing image management stream.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Image management stream name.
        /// </summary>
        /// <value>Image management stream name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Image management stream publisher
        /// </summary>
        /// <value>Image management stream publisher</value>
        [DataMember(Name="publisher", EmitDefaultValue=false)]
        public string Publisher { get; set; }



        /// <summary>
        /// Specifies whether the image management stream can be used in desktop pool or farm. This will be set to true when: &lt;ul&gt;&lt;li&gt;Image management stream is in AVAILABLE or PARTIALLY_AVAILABLE state. &lt;/li&gt;&lt;li&gt;There is at least one image management version in AVAILABLE or PARTIALLY_AVAILABLE state for this stream. &lt;/li&gt;&lt;li&gt;There is at least one image management tag associated with the image management version.&lt;/li&gt; &lt;/ul&gt;For a specific virtual center, image management tag information will be retrieved.
        /// </summary>
        /// <value>Specifies whether the image management stream can be used in desktop pool or farm. This will be set to true when: &lt;ul&gt;&lt;li&gt;Image management stream is in AVAILABLE or PARTIALLY_AVAILABLE state. &lt;/li&gt;&lt;li&gt;There is at least one image management version in AVAILABLE or PARTIALLY_AVAILABLE state for this stream. &lt;/li&gt;&lt;li&gt;There is at least one image management tag associated with the image management version.&lt;/li&gt; &lt;/ul&gt;For a specific virtual center, image management tag information will be retrieved.</value>
        [DataMember(Name="usable", EmitDefaultValue=false)]
        public bool? Usable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImageManagementStreamInfo {\n");
            sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OperatingSystem: ").Append(OperatingSystem).Append("\n");
            sb.Append("  Publisher: ").Append(Publisher).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Usable: ").Append(Usable).Append("\n");
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
            return this.Equals(input as ImageManagementStreamInfo);
        }

        /// <summary>
        /// Returns true if ImageManagementStreamInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ImageManagementStreamInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImageManagementStreamInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalDetails == input.AdditionalDetails ||
                    this.AdditionalDetails != null &&
                    this.AdditionalDetails.SequenceEqual(input.AdditionalDetails)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OperatingSystem == input.OperatingSystem ||
                    (this.OperatingSystem != null &&
                    this.OperatingSystem.Equals(input.OperatingSystem))
                ) && 
                (
                    this.Publisher == input.Publisher ||
                    (this.Publisher != null &&
                    this.Publisher.Equals(input.Publisher))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Usable == input.Usable ||
                    (this.Usable != null &&
                    this.Usable.Equals(input.Usable))
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
                if (this.AdditionalDetails != null)
                    hashCode = hashCode * 59 + this.AdditionalDetails.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OperatingSystem != null)
                    hashCode = hashCode * 59 + this.OperatingSystem.GetHashCode();
                if (this.Publisher != null)
                    hashCode = hashCode * 59 + this.Publisher.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Usable != null)
                    hashCode = hashCode * 59 + this.Usable.GetHashCode();
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
