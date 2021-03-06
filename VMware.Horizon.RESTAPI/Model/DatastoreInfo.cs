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
    /// Information related to datastore.
    /// </summary>
    [DataContract]
    public partial class DatastoreInfo :  IEquatable<DatastoreInfo>
    {
        /// <summary>
        /// Disk type of the datastore. * SSD: Solid State Drive disk type. * NON_SSD: NON-Solid State Drive disk type. * UNKNOWN: Unknown disk type. * NON_VMFS: NON-VMFS disk type.
        /// </summary>
        /// <value>Disk type of the datastore. * SSD: Solid State Drive disk type. * NON_SSD: NON-Solid State Drive disk type. * UNKNOWN: Unknown disk type. * NON_VMFS: NON-VMFS disk type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiskTypeEnum
        {
            
            /// <summary>
            /// Enum SSD for value: SSD
            /// </summary>
            [EnumMember(Value = "SSD")]
            SSD = 1,
            
            /// <summary>
            /// Enum NONSSD for value: NON_SSD
            /// </summary>
            [EnumMember(Value = "NON_SSD")]
            NONSSD = 2,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 3,
            
            /// <summary>
            /// Enum NONVMFS for value: NON_VMFS
            /// </summary>
            [EnumMember(Value = "NON_VMFS")]
            NONVMFS = 4
        }

        /// <summary>
        /// Disk type of the datastore. * SSD: Solid State Drive disk type. * NON_SSD: NON-Solid State Drive disk type. * UNKNOWN: Unknown disk type. * NON_VMFS: NON-VMFS disk type.
        /// </summary>
        /// <value>Disk type of the datastore. * SSD: Solid State Drive disk type. * NON_SSD: NON-Solid State Drive disk type. * UNKNOWN: Unknown disk type. * NON_VMFS: NON-VMFS disk type.</value>
        [DataMember(Name="disk_type", EmitDefaultValue=false)]
        public DiskTypeEnum? DiskType { get; set; }
        /// <summary>
        /// File system type of the datastore. * VMFS: Virtual Machine File System. * NFS: Network File System. * VSAN: vSAN File System. * VVOL: Virtual Volumes.
        /// </summary>
        /// <value>File system type of the datastore. * VMFS: Virtual Machine File System. * NFS: Network File System. * VSAN: vSAN File System. * VVOL: Virtual Volumes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FileSystemTypeEnum
        {
            
            /// <summary>
            /// Enum VMFS for value: VMFS
            /// </summary>
            [EnumMember(Value = "VMFS")]
            VMFS = 1,
            
            /// <summary>
            /// Enum NFS for value: NFS
            /// </summary>
            [EnumMember(Value = "NFS")]
            NFS = 2,
            
            /// <summary>
            /// Enum VSAN for value: VSAN
            /// </summary>
            [EnumMember(Value = "VSAN")]
            VSAN = 3,
            
            /// <summary>
            /// Enum VVOL for value: VVOL
            /// </summary>
            [EnumMember(Value = "VVOL")]
            VVOL = 4
        }

        /// <summary>
        /// File system type of the datastore. * VMFS: Virtual Machine File System. * NFS: Network File System. * VSAN: vSAN File System. * VVOL: Virtual Volumes.
        /// </summary>
        /// <value>File system type of the datastore. * VMFS: Virtual Machine File System. * NFS: Network File System. * VSAN: vSAN File System. * VVOL: Virtual Volumes.</value>
        [DataMember(Name="file_system_type", EmitDefaultValue=false)]
        public FileSystemTypeEnum? FileSystemType { get; set; }
        /// <summary>
        /// Defines IncompatibleReasons
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IncompatibleReasonsEnum
        {
            
            /// <summary>
            /// Enum INACCESSIBLETOSOMEHOSTS for value: INACCESSIBLE_TO_SOME_HOSTS
            /// </summary>
            [EnumMember(Value = "INACCESSIBLE_TO_SOME_HOSTS")]
            INACCESSIBLETOSOMEHOSTS = 1,
            
            /// <summary>
            /// Enum VMFS5ANDMORETHAN32HOSTS for value: VMFS5_AND_MORE_THAN_32_HOSTS
            /// </summary>
            [EnumMember(Value = "VMFS5_AND_MORE_THAN_32_HOSTS")]
            VMFS5ANDMORETHAN32HOSTS = 2,
            
            /// <summary>
            /// Enum NOTVMFS5ANDMORETHAN8HOSTS for value: NOT_VMFS5_AND_MORE_THAN_8_HOSTS
            /// </summary>
            [EnumMember(Value = "NOT_VMFS5_AND_MORE_THAN_8_HOSTS")]
            NOTVMFS5ANDMORETHAN8HOSTS = 3,
            
            /// <summary>
            /// Enum ESX51ANDMORETHAN32HOSTS for value: ESX51_AND_MORE_THAN_32_HOSTS
            /// </summary>
            [EnumMember(Value = "ESX51_AND_MORE_THAN_32_HOSTS")]
            ESX51ANDMORETHAN32HOSTS = 4,
            
            /// <summary>
            /// Enum NOTESX51ANDMORETHAN8HOSTS for value: NOT_ESX51_AND_MORE_THAN_8_HOSTS
            /// </summary>
            [EnumMember(Value = "NOT_ESX51_AND_MORE_THAN_8_HOSTS")]
            NOTESX51ANDMORETHAN8HOSTS = 5,
            
            /// <summary>
            /// Enum INCOMPATIBLENATIVESNAPSHOTS for value: INCOMPATIBLE_NATIVE_SNAPSHOTS
            /// </summary>
            [EnumMember(Value = "INCOMPATIBLE_NATIVE_SNAPSHOTS")]
            INCOMPATIBLENATIVESNAPSHOTS = 6
        }


        /// <summary>
        /// Reasons that may preclude this Datastore from being used in desktop pool/farm.
        /// </summary>
        /// <value>Reasons that may preclude this Datastore from being used in desktop pool/farm.</value>
        [DataMember(Name="incompatible_reasons", EmitDefaultValue=false)]
        public List<IncompatibleReasonsEnum> IncompatibleReasons { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DatastoreInfo" /> class.
        /// </summary>
        /// <param name="capacityMb">Maximum capacity of this datastore, in MB..</param>
        /// <param name="datacenterId">Datacenter id for this datastore..</param>
        /// <param name="diskType">Disk type of the datastore. * SSD: Solid State Drive disk type. * NON_SSD: NON-Solid State Drive disk type. * UNKNOWN: Unknown disk type. * NON_VMFS: NON-VMFS disk type..</param>
        /// <param name="fileSystemType">File system type of the datastore. * VMFS: Virtual Machine File System. * NFS: Network File System. * VSAN: vSAN File System. * VVOL: Virtual Volumes..</param>
        /// <param name="freeSpaceMb">Available capacity of this datastore, in MB..</param>
        /// <param name="hostOrClusterId">Host or Cluster id for this datastore..</param>
        /// <param name="id">Unique ID representing the datastore..</param>
        /// <param name="incompatibleReasons">Reasons that may preclude this Datastore from being used in desktop pool/farm..</param>
        /// <param name="localDatastore">Indicates if this datastore is local to a single host..</param>
        /// <param name="name">Datastore name..</param>
        /// <param name="numberOfVms">Indicates the number of virtual machines the datastore has for desktop pool/farm when applicable.</param>
        /// <param name="path">Datastore path..</param>
        /// <param name="vcenterId">Virtual Center id for this datastore..</param>
        /// <param name="vmfsMajorVersion">The VMFS major version number..</param>
        public DatastoreInfo(long? capacityMb = default(long?), string datacenterId = default(string), DiskTypeEnum? diskType = default(DiskTypeEnum?), FileSystemTypeEnum? fileSystemType = default(FileSystemTypeEnum?), long? freeSpaceMb = default(long?), string hostOrClusterId = default(string), string id = default(string), List<IncompatibleReasonsEnum> incompatibleReasons = default(List<IncompatibleReasonsEnum>), bool? localDatastore = default(bool?), string name = default(string), int? numberOfVms = default(int?), string path = default(string), string vcenterId = default(string), string vmfsMajorVersion = default(string))
        {
            this.CapacityMb = capacityMb;
            this.DatacenterId = datacenterId;
            this.DiskType = diskType;
            this.FileSystemType = fileSystemType;
            this.FreeSpaceMb = freeSpaceMb;
            this.HostOrClusterId = hostOrClusterId;
            this.Id = id;
            this.IncompatibleReasons = incompatibleReasons;
            this.LocalDatastore = localDatastore;
            this.Name = name;
            this.NumberOfVms = numberOfVms;
            this.Path = path;
            this.VcenterId = vcenterId;
            this.VmfsMajorVersion = vmfsMajorVersion;
        }
        
        /// <summary>
        /// Maximum capacity of this datastore, in MB.
        /// </summary>
        /// <value>Maximum capacity of this datastore, in MB.</value>
        [DataMember(Name="capacity_mb", EmitDefaultValue=false)]
        public long? CapacityMb { get; set; }

        /// <summary>
        /// Datacenter id for this datastore.
        /// </summary>
        /// <value>Datacenter id for this datastore.</value>
        [DataMember(Name="datacenter_id", EmitDefaultValue=false)]
        public string DatacenterId { get; set; }



        /// <summary>
        /// Available capacity of this datastore, in MB.
        /// </summary>
        /// <value>Available capacity of this datastore, in MB.</value>
        [DataMember(Name="free_space_mb", EmitDefaultValue=false)]
        public long? FreeSpaceMb { get; set; }

        /// <summary>
        /// Host or Cluster id for this datastore.
        /// </summary>
        /// <value>Host or Cluster id for this datastore.</value>
        [DataMember(Name="host_or_cluster_id", EmitDefaultValue=false)]
        public string HostOrClusterId { get; set; }

        /// <summary>
        /// Unique ID representing the datastore.
        /// </summary>
        /// <value>Unique ID representing the datastore.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }


        /// <summary>
        /// Indicates if this datastore is local to a single host.
        /// </summary>
        /// <value>Indicates if this datastore is local to a single host.</value>
        [DataMember(Name="local_datastore", EmitDefaultValue=false)]
        public bool? LocalDatastore { get; set; }

        /// <summary>
        /// Datastore name.
        /// </summary>
        /// <value>Datastore name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates the number of virtual machines the datastore has for desktop pool/farm when applicable
        /// </summary>
        /// <value>Indicates the number of virtual machines the datastore has for desktop pool/farm when applicable</value>
        [DataMember(Name="number_of_vms", EmitDefaultValue=false)]
        public int? NumberOfVms { get; set; }

        /// <summary>
        /// Datastore path.
        /// </summary>
        /// <value>Datastore path.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Virtual Center id for this datastore.
        /// </summary>
        /// <value>Virtual Center id for this datastore.</value>
        [DataMember(Name="vcenter_id", EmitDefaultValue=false)]
        public string VcenterId { get; set; }

        /// <summary>
        /// The VMFS major version number.
        /// </summary>
        /// <value>The VMFS major version number.</value>
        [DataMember(Name="vmfs_major_version", EmitDefaultValue=false)]
        public string VmfsMajorVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DatastoreInfo {\n");
            sb.Append("  CapacityMb: ").Append(CapacityMb).Append("\n");
            sb.Append("  DatacenterId: ").Append(DatacenterId).Append("\n");
            sb.Append("  DiskType: ").Append(DiskType).Append("\n");
            sb.Append("  FileSystemType: ").Append(FileSystemType).Append("\n");
            sb.Append("  FreeSpaceMb: ").Append(FreeSpaceMb).Append("\n");
            sb.Append("  HostOrClusterId: ").Append(HostOrClusterId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IncompatibleReasons: ").Append(IncompatibleReasons).Append("\n");
            sb.Append("  LocalDatastore: ").Append(LocalDatastore).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumberOfVms: ").Append(NumberOfVms).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  VcenterId: ").Append(VcenterId).Append("\n");
            sb.Append("  VmfsMajorVersion: ").Append(VmfsMajorVersion).Append("\n");
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
            return this.Equals(input as DatastoreInfo);
        }

        /// <summary>
        /// Returns true if DatastoreInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DatastoreInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatastoreInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CapacityMb == input.CapacityMb ||
                    (this.CapacityMb != null &&
                    this.CapacityMb.Equals(input.CapacityMb))
                ) && 
                (
                    this.DatacenterId == input.DatacenterId ||
                    (this.DatacenterId != null &&
                    this.DatacenterId.Equals(input.DatacenterId))
                ) && 
                (
                    this.DiskType == input.DiskType ||
                    (this.DiskType != null &&
                    this.DiskType.Equals(input.DiskType))
                ) && 
                (
                    this.FileSystemType == input.FileSystemType ||
                    (this.FileSystemType != null &&
                    this.FileSystemType.Equals(input.FileSystemType))
                ) && 
                (
                    this.FreeSpaceMb == input.FreeSpaceMb ||
                    (this.FreeSpaceMb != null &&
                    this.FreeSpaceMb.Equals(input.FreeSpaceMb))
                ) && 
                (
                    this.HostOrClusterId == input.HostOrClusterId ||
                    (this.HostOrClusterId != null &&
                    this.HostOrClusterId.Equals(input.HostOrClusterId))
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
                    this.LocalDatastore == input.LocalDatastore ||
                    (this.LocalDatastore != null &&
                    this.LocalDatastore.Equals(input.LocalDatastore))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NumberOfVms == input.NumberOfVms ||
                    (this.NumberOfVms != null &&
                    this.NumberOfVms.Equals(input.NumberOfVms))
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
                ) && 
                (
                    this.VmfsMajorVersion == input.VmfsMajorVersion ||
                    (this.VmfsMajorVersion != null &&
                    this.VmfsMajorVersion.Equals(input.VmfsMajorVersion))
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
                if (this.CapacityMb != null)
                    hashCode = hashCode * 59 + this.CapacityMb.GetHashCode();
                if (this.DatacenterId != null)
                    hashCode = hashCode * 59 + this.DatacenterId.GetHashCode();
                if (this.DiskType != null)
                    hashCode = hashCode * 59 + this.DiskType.GetHashCode();
                if (this.FileSystemType != null)
                    hashCode = hashCode * 59 + this.FileSystemType.GetHashCode();
                if (this.FreeSpaceMb != null)
                    hashCode = hashCode * 59 + this.FreeSpaceMb.GetHashCode();
                if (this.HostOrClusterId != null)
                    hashCode = hashCode * 59 + this.HostOrClusterId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IncompatibleReasons != null)
                    hashCode = hashCode * 59 + this.IncompatibleReasons.GetHashCode();
                if (this.LocalDatastore != null)
                    hashCode = hashCode * 59 + this.LocalDatastore.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NumberOfVms != null)
                    hashCode = hashCode * 59 + this.NumberOfVms.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.VcenterId != null)
                    hashCode = hashCode * 59 + this.VcenterId.GetHashCode();
                if (this.VmfsMajorVersion != null)
                    hashCode = hashCode * 59 + this.VmfsMajorVersion.GetHashCode();
                return hashCode;
            }
        }
    }

}
