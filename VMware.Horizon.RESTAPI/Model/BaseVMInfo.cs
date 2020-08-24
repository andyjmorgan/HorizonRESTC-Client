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
    /// Information related to base VM.
    /// </summary>
    [DataContract]
    public partial class BaseVMInfo :  IEquatable<BaseVMInfo>
    {
        /// <summary>
        /// Defines IncompatibleReasons
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IncompatibleReasonsEnum
        {
            
            /// <summary>
            /// Enum INUSEBYDESKTOPPOOL for value: IN_USE_BY_DESKTOP_POOL
            /// </summary>
            [EnumMember(Value = "IN_USE_BY_DESKTOP_POOL")]
            INUSEBYDESKTOPPOOL = 1,
            
            /// <summary>
            /// Enum INUSEBYLINKEDCLONEDESKTOPPOOL for value: IN_USE_BY_LINKED_CLONE_DESKTOP_POOL
            /// </summary>
            [EnumMember(Value = "IN_USE_BY_LINKED_CLONE_DESKTOP_POOL")]
            INUSEBYLINKEDCLONEDESKTOPPOOL = 2,
            
            /// <summary>
            /// Enum VIEWCOMPOSERREPLICA for value: VIEW_COMPOSER_REPLICA
            /// </summary>
            [EnumMember(Value = "VIEW_COMPOSER_REPLICA")]
            VIEWCOMPOSERREPLICA = 3,
            
            /// <summary>
            /// Enum UNSUPPORTEDOSFORFARM for value: UNSUPPORTED_OS_FOR_FARM
            /// </summary>
            [EnumMember(Value = "UNSUPPORTED_OS_FOR_FARM")]
            UNSUPPORTEDOSFORFARM = 4,
            
            /// <summary>
            /// Enum UNSUPPORTEDOS for value: UNSUPPORTED_OS
            /// </summary>
            [EnumMember(Value = "UNSUPPORTED_OS")]
            UNSUPPORTEDOS = 5,
            
            /// <summary>
            /// Enum NOSNAPSHOTS for value: NO_SNAPSHOTS
            /// </summary>
            [EnumMember(Value = "NO_SNAPSHOTS")]
            NOSNAPSHOTS = 6,
            
            /// <summary>
            /// Enum INSTANTINTERNAL for value: INSTANT_INTERNAL
            /// </summary>
            [EnumMember(Value = "INSTANT_INTERNAL")]
            INSTANTINTERNAL = 7,
            
            /// <summary>
            /// Enum INUSEBYINSTANTCLONEDESKTOPPOOL for value: IN_USE_BY_INSTANT_CLONE_DESKTOP_POOL
            /// </summary>
            [EnumMember(Value = "IN_USE_BY_INSTANT_CLONE_DESKTOP_POOL")]
            INUSEBYINSTANTCLONEDESKTOPPOOL = 8
        }


        /// <summary>
        /// Reasons that may preclude this BaseVM from having its snapshots used in linked or instant clone desktop or farm creation.
        /// </summary>
        /// <value>Reasons that may preclude this BaseVM from having its snapshots used in linked or instant clone desktop or farm creation.</value>
        [DataMember(Name="incompatible_reasons", EmitDefaultValue=false)]
        public List<IncompatibleReasonsEnum> IncompatibleReasons { get; set; }
        /// <summary>
        /// Type of network base VM belongs to. * STANDARD_NETWORK: Standard network. * OPAQUE_NETWORK: Opaque network. * DISTRUBUTED_VIRTUAL_PORT_GROUP: DVS port group.
        /// </summary>
        /// <value>Type of network base VM belongs to. * STANDARD_NETWORK: Standard network. * OPAQUE_NETWORK: Opaque network. * DISTRUBUTED_VIRTUAL_PORT_GROUP: DVS port group.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetworkTypeEnum
        {
            
            /// <summary>
            /// Enum STANDARDNETWORK for value: STANDARD_NETWORK
            /// </summary>
            [EnumMember(Value = "STANDARD_NETWORK")]
            STANDARDNETWORK = 1,
            
            /// <summary>
            /// Enum OPAQUENETWORK for value: OPAQUE_NETWORK
            /// </summary>
            [EnumMember(Value = "OPAQUE_NETWORK")]
            OPAQUENETWORK = 2,
            
            /// <summary>
            /// Enum DISTRUBUTEDVIRTUALPORTGROUP for value: DISTRUBUTED_VIRTUAL_PORT_GROUP
            /// </summary>
            [EnumMember(Value = "DISTRUBUTED_VIRTUAL_PORT_GROUP")]
            DISTRUBUTEDVIRTUALPORTGROUP = 3
        }

        /// <summary>
        /// Type of network base VM belongs to. * STANDARD_NETWORK: Standard network. * OPAQUE_NETWORK: Opaque network. * DISTRUBUTED_VIRTUAL_PORT_GROUP: DVS port group.
        /// </summary>
        /// <value>Type of network base VM belongs to. * STANDARD_NETWORK: Standard network. * OPAQUE_NETWORK: Opaque network. * DISTRUBUTED_VIRTUAL_PORT_GROUP: DVS port group.</value>
        [DataMember(Name="network_type", EmitDefaultValue=false)]
        public NetworkTypeEnum NetworkType { get; set; }
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
        /// Initializes a new instance of the <see cref="BaseVMInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BaseVMInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseVMInfo" /> class.
        /// </summary>
        /// <param name="datacenterId">Datacenter id for this VM. (required).</param>
        /// <param name="id">Unique ID representing a VM. (required).</param>
        /// <param name="incompatibleReasons">Reasons that may preclude this BaseVM from having its snapshots used in linked or instant clone desktop or farm creation..</param>
        /// <param name="name">VM name. (required).</param>
        /// <param name="networkType">Type of network base VM belongs to. * STANDARD_NETWORK: Standard network. * OPAQUE_NETWORK: Opaque network. * DISTRUBUTED_VIRTUAL_PORT_GROUP: DVS port group. (required).</param>
        /// <param name="operatingSystem">Operating system. * UNKNOWN: Unknown * WINDOWS_XP: Windows XP * WINDOWS_VISTA: Windows Vista * WINDOWS_7: Windows 7 * WINDOWS_8: Windows 8 * WINDOWS_10: Windows 10 * WINDOWS_SERVER_2003: Windows Server 2003 * WINDOWS_SERVER_2008: Windows Server 2008 * WINDOWS_SERVER_2008_R2: Windows Server 2008 R2 * WINDOWS_SERVER_2012: Windows Server 2012 * WINDOWS_SERVER_2012_R2: Windows Server 2012 R2 * WINDOWS_SERVER_2016_OR_ABOVE: Windows Server 2016 or above * LINUX_OTHER: Linux (other) * LINUX_SERVER_OTHER: Linux server (other) * LINUX_UBUNTU: Linux (Ubuntu) * LINUX_RHEL: Linux (Red Hat Enterprise) * LINUX_SUSE: Linux (Suse) * LINUX_CENTOS: Linux (CentOS) (required).</param>
        /// <param name="operatingSystemDisplayName">Operating system display name from Virtual Center. (required).</param>
        /// <param name="path">VM path. (required).</param>
        /// <param name="vcenterId">Virtual Center id for this VM. (required).</param>
        public BaseVMInfo(string datacenterId = default(string), string id = default(string), List<IncompatibleReasonsEnum> incompatibleReasons = default(List<IncompatibleReasonsEnum>), string name = default(string), NetworkTypeEnum networkType = default(NetworkTypeEnum), OperatingSystemEnum operatingSystem = default(OperatingSystemEnum), string operatingSystemDisplayName = default(string), string path = default(string), string vcenterId = default(string))
        {
            // to ensure "datacenterId" is required (not null)
            if (datacenterId == null)
            {
                throw new InvalidDataException("datacenterId is a required property for BaseVMInfo and cannot be null");
            }
            else
            {
                this.DatacenterId = datacenterId;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for BaseVMInfo and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for BaseVMInfo and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "networkType" is required (not null)
            if (networkType == null)
            {
                throw new InvalidDataException("networkType is a required property for BaseVMInfo and cannot be null");
            }
            else
            {
                this.NetworkType = networkType;
            }
            // to ensure "operatingSystem" is required (not null)
            if (operatingSystem == null)
            {
                throw new InvalidDataException("operatingSystem is a required property for BaseVMInfo and cannot be null");
            }
            else
            {
                this.OperatingSystem = operatingSystem;
            }
            // to ensure "operatingSystemDisplayName" is required (not null)
            if (operatingSystemDisplayName == null)
            {
                throw new InvalidDataException("operatingSystemDisplayName is a required property for BaseVMInfo and cannot be null");
            }
            else
            {
                this.OperatingSystemDisplayName = operatingSystemDisplayName;
            }
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new InvalidDataException("path is a required property for BaseVMInfo and cannot be null");
            }
            else
            {
                this.Path = path;
            }
            // to ensure "vcenterId" is required (not null)
            if (vcenterId == null)
            {
                throw new InvalidDataException("vcenterId is a required property for BaseVMInfo and cannot be null");
            }
            else
            {
                this.VcenterId = vcenterId;
            }
            this.IncompatibleReasons = incompatibleReasons;
        }
        
        /// <summary>
        /// Datacenter id for this VM.
        /// </summary>
        /// <value>Datacenter id for this VM.</value>
        [DataMember(Name="datacenter_id", EmitDefaultValue=false)]
        public string DatacenterId { get; set; }

        /// <summary>
        /// Unique ID representing a VM.
        /// </summary>
        /// <value>Unique ID representing a VM.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// VM name.
        /// </summary>
        /// <value>VM name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }



        /// <summary>
        /// Operating system display name from Virtual Center.
        /// </summary>
        /// <value>Operating system display name from Virtual Center.</value>
        [DataMember(Name="operating_system_display_name", EmitDefaultValue=false)]
        public string OperatingSystemDisplayName { get; set; }

        /// <summary>
        /// VM path.
        /// </summary>
        /// <value>VM path.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Virtual Center id for this VM.
        /// </summary>
        /// <value>Virtual Center id for this VM.</value>
        [DataMember(Name="vcenter_id", EmitDefaultValue=false)]
        public string VcenterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseVMInfo {\n");
            sb.Append("  DatacenterId: ").Append(DatacenterId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IncompatibleReasons: ").Append(IncompatibleReasons).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NetworkType: ").Append(NetworkType).Append("\n");
            sb.Append("  OperatingSystem: ").Append(OperatingSystem).Append("\n");
            sb.Append("  OperatingSystemDisplayName: ").Append(OperatingSystemDisplayName).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  VcenterId: ").Append(VcenterId).Append("\n");
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
            return this.Equals(input as BaseVMInfo);
        }

        /// <summary>
        /// Returns true if BaseVMInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BaseVMInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BaseVMInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DatacenterId == input.DatacenterId ||
                    (this.DatacenterId != null &&
                    this.DatacenterId.Equals(input.DatacenterId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IncompatibleReasons == input.IncompatibleReasons ||
                    this.IncompatibleReasons != null &&
                    this.IncompatibleReasons.SequenceEqual(input.IncompatibleReasons)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NetworkType == input.NetworkType ||
                    (this.NetworkType != null &&
                    this.NetworkType.Equals(input.NetworkType))
                ) && 
                (
                    this.OperatingSystem == input.OperatingSystem ||
                    (this.OperatingSystem != null &&
                    this.OperatingSystem.Equals(input.OperatingSystem))
                ) && 
                (
                    this.OperatingSystemDisplayName == input.OperatingSystemDisplayName ||
                    (this.OperatingSystemDisplayName != null &&
                    this.OperatingSystemDisplayName.Equals(input.OperatingSystemDisplayName))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.VcenterId == input.VcenterId ||
                    (this.VcenterId != null &&
                    this.VcenterId.Equals(input.VcenterId))
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
                if (this.DatacenterId != null)
                    hashCode = hashCode * 59 + this.DatacenterId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncompatibleReasons != null)
                    hashCode = hashCode * 59 + this.IncompatibleReasons.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NetworkType != null)
                    hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.OperatingSystem != null)
                    hashCode = hashCode * 59 + this.OperatingSystem.GetHashCode();
                if (this.OperatingSystemDisplayName != null)
                    hashCode = hashCode * 59 + this.OperatingSystemDisplayName.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.VcenterId != null)
                    hashCode = hashCode * 59 + this.VcenterId.GetHashCode();
                return hashCode;
            }
        }
    }

}