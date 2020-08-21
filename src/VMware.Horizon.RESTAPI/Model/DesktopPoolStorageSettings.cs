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
    /// Virtual Center storage settings for the automated desktop pool.
    /// </summary>
    [DataContract]
    public partial class DesktopPoolStorageSettings :  IEquatable<DesktopPoolStorageSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopPoolStorageSettings" /> class.
        /// </summary>
        /// <param name="datastores">Datastores to store the machine (or the OS disk using other options for linked clone or instant clone machine storage).</param>
        /// <param name="nonPersistentDiskDriveLetter">Non persistent disk drive letter..</param>
        /// <param name="nonPersistentDiskSizeMb">Size of the non persistent disk in MB..</param>
        /// <param name="nonPersistentRedirectDisposableFiles">Redirect disposable files to a non-persistent disk that will be deleted automatically when a user&#39;s session ends..</param>
        /// <param name="persistentDiskDatastores">Datastores to store persistent disks for linked clone machines..</param>
        /// <param name="persistentDiskDriveLetter">Persistent disk drive letter..</param>
        /// <param name="persistentDiskSizeMb">Size of the persistent disk in MB..</param>
        /// <param name="reclaimVmDiskSpace">With vSphere 5.x, virtual machines can be configured to use a space efficient disk format that supports reclamation of unused disk space (such as deleted files). This option reclaims unused disk space on each virtual machine. The operation is initiated when an estimate of used disk space exceeds the specified threshold..</param>
        /// <param name="reclamationThresholdMb">Initiate reclamation when unused space on virtual machine exceeds the threshold in MB..</param>
        /// <param name="redirectWindowsProfile">Windows profiles will be redirected to persistent disks, which are not affected by View Composer operations such as refresh, recompose and rebalance..</param>
        /// <param name="replicaDiskDatastoreId">Datastore to store replica disks for linked clone and instant clone machines..</param>
        /// <param name="useNativeSnapshots">Applicable To: Linked/instant clone automated desktop pool.&lt;br&gt;Native NFS Snapshots (VAAI - vStorage API for Array Integration) is a hardware feature of certain storage arrays. It uses native snapshotting technology to provide linked clone functionality..</param>
        /// <param name="useSeparateDatastoresPersistentAndOsDisks">Whether to use separate datastores for persistent and OS disks..</param>
        /// <param name="useSeparateDatastoresReplicaAndOsDisks">Whether to use separate datastores for replica and OS disks..</param>
        /// <param name="useVsan">Whether to use vSphere vSAN..</param>
        public DesktopPoolStorageSettings(List<DesktopPoolDatastoreSettings> datastores = default(List<DesktopPoolDatastoreSettings>), string nonPersistentDiskDriveLetter = default(string), int? nonPersistentDiskSizeMb = default(int?), bool? nonPersistentRedirectDisposableFiles = default(bool?), List<DesktopPoolDatastoreSettings> persistentDiskDatastores = default(List<DesktopPoolDatastoreSettings>), string persistentDiskDriveLetter = default(string), int? persistentDiskSizeMb = default(int?), bool? reclaimVmDiskSpace = default(bool?), long? reclamationThresholdMb = default(long?), bool? redirectWindowsProfile = default(bool?), string replicaDiskDatastoreId = default(string), bool? useNativeSnapshots = default(bool?), bool? useSeparateDatastoresPersistentAndOsDisks = default(bool?), bool? useSeparateDatastoresReplicaAndOsDisks = default(bool?), bool? useVsan = default(bool?))
        {
            this.Datastores = datastores;
            this.NonPersistentDiskDriveLetter = nonPersistentDiskDriveLetter;
            this.NonPersistentDiskSizeMb = nonPersistentDiskSizeMb;
            this.NonPersistentRedirectDisposableFiles = nonPersistentRedirectDisposableFiles;
            this.PersistentDiskDatastores = persistentDiskDatastores;
            this.PersistentDiskDriveLetter = persistentDiskDriveLetter;
            this.PersistentDiskSizeMb = persistentDiskSizeMb;
            this.ReclaimVmDiskSpace = reclaimVmDiskSpace;
            this.ReclamationThresholdMb = reclamationThresholdMb;
            this.RedirectWindowsProfile = redirectWindowsProfile;
            this.ReplicaDiskDatastoreId = replicaDiskDatastoreId;
            this.UseNativeSnapshots = useNativeSnapshots;
            this.UseSeparateDatastoresPersistentAndOsDisks = useSeparateDatastoresPersistentAndOsDisks;
            this.UseSeparateDatastoresReplicaAndOsDisks = useSeparateDatastoresReplicaAndOsDisks;
            this.UseVsan = useVsan;
        }
        
        /// <summary>
        /// Datastores to store the machine (or the OS disk using other options for linked clone or instant clone machine storage)
        /// </summary>
        /// <value>Datastores to store the machine (or the OS disk using other options for linked clone or instant clone machine storage)</value>
        [DataMember(Name="datastores", EmitDefaultValue=false)]
        public List<DesktopPoolDatastoreSettings> Datastores { get; set; }

        /// <summary>
        /// Non persistent disk drive letter.
        /// </summary>
        /// <value>Non persistent disk drive letter.</value>
        [DataMember(Name="non_persistent_disk_drive_letter", EmitDefaultValue=false)]
        public string NonPersistentDiskDriveLetter { get; set; }

        /// <summary>
        /// Size of the non persistent disk in MB.
        /// </summary>
        /// <value>Size of the non persistent disk in MB.</value>
        [DataMember(Name="non_persistent_disk_size_mb", EmitDefaultValue=false)]
        public int? NonPersistentDiskSizeMb { get; set; }

        /// <summary>
        /// Redirect disposable files to a non-persistent disk that will be deleted automatically when a user&#39;s session ends.
        /// </summary>
        /// <value>Redirect disposable files to a non-persistent disk that will be deleted automatically when a user&#39;s session ends.</value>
        [DataMember(Name="non_persistent_redirect_disposable_files", EmitDefaultValue=false)]
        public bool? NonPersistentRedirectDisposableFiles { get; set; }

        /// <summary>
        /// Datastores to store persistent disks for linked clone machines.
        /// </summary>
        /// <value>Datastores to store persistent disks for linked clone machines.</value>
        [DataMember(Name="persistent_disk_datastores", EmitDefaultValue=false)]
        public List<DesktopPoolDatastoreSettings> PersistentDiskDatastores { get; set; }

        /// <summary>
        /// Persistent disk drive letter.
        /// </summary>
        /// <value>Persistent disk drive letter.</value>
        [DataMember(Name="persistent_disk_drive_letter", EmitDefaultValue=false)]
        public string PersistentDiskDriveLetter { get; set; }

        /// <summary>
        /// Size of the persistent disk in MB.
        /// </summary>
        /// <value>Size of the persistent disk in MB.</value>
        [DataMember(Name="persistent_disk_size_mb", EmitDefaultValue=false)]
        public int? PersistentDiskSizeMb { get; set; }

        /// <summary>
        /// With vSphere 5.x, virtual machines can be configured to use a space efficient disk format that supports reclamation of unused disk space (such as deleted files). This option reclaims unused disk space on each virtual machine. The operation is initiated when an estimate of used disk space exceeds the specified threshold.
        /// </summary>
        /// <value>With vSphere 5.x, virtual machines can be configured to use a space efficient disk format that supports reclamation of unused disk space (such as deleted files). This option reclaims unused disk space on each virtual machine. The operation is initiated when an estimate of used disk space exceeds the specified threshold.</value>
        [DataMember(Name="reclaim_vm_disk_space", EmitDefaultValue=false)]
        public bool? ReclaimVmDiskSpace { get; set; }

        /// <summary>
        /// Initiate reclamation when unused space on virtual machine exceeds the threshold in MB.
        /// </summary>
        /// <value>Initiate reclamation when unused space on virtual machine exceeds the threshold in MB.</value>
        [DataMember(Name="reclamation_threshold_mb", EmitDefaultValue=false)]
        public long? ReclamationThresholdMb { get; set; }

        /// <summary>
        /// Windows profiles will be redirected to persistent disks, which are not affected by View Composer operations such as refresh, recompose and rebalance.
        /// </summary>
        /// <value>Windows profiles will be redirected to persistent disks, which are not affected by View Composer operations such as refresh, recompose and rebalance.</value>
        [DataMember(Name="redirect_windows_profile", EmitDefaultValue=false)]
        public bool? RedirectWindowsProfile { get; set; }

        /// <summary>
        /// Datastore to store replica disks for linked clone and instant clone machines.
        /// </summary>
        /// <value>Datastore to store replica disks for linked clone and instant clone machines.</value>
        [DataMember(Name="replica_disk_datastore_id", EmitDefaultValue=false)]
        public string ReplicaDiskDatastoreId { get; set; }

        /// <summary>
        /// Applicable To: Linked/instant clone automated desktop pool.&lt;br&gt;Native NFS Snapshots (VAAI - vStorage API for Array Integration) is a hardware feature of certain storage arrays. It uses native snapshotting technology to provide linked clone functionality.
        /// </summary>
        /// <value>Applicable To: Linked/instant clone automated desktop pool.&lt;br&gt;Native NFS Snapshots (VAAI - vStorage API for Array Integration) is a hardware feature of certain storage arrays. It uses native snapshotting technology to provide linked clone functionality.</value>
        [DataMember(Name="use_native_snapshots", EmitDefaultValue=false)]
        public bool? UseNativeSnapshots { get; set; }

        /// <summary>
        /// Whether to use separate datastores for persistent and OS disks.
        /// </summary>
        /// <value>Whether to use separate datastores for persistent and OS disks.</value>
        [DataMember(Name="use_separate_datastores_persistent_and_os_disks", EmitDefaultValue=false)]
        public bool? UseSeparateDatastoresPersistentAndOsDisks { get; set; }

        /// <summary>
        /// Whether to use separate datastores for replica and OS disks.
        /// </summary>
        /// <value>Whether to use separate datastores for replica and OS disks.</value>
        [DataMember(Name="use_separate_datastores_replica_and_os_disks", EmitDefaultValue=false)]
        public bool? UseSeparateDatastoresReplicaAndOsDisks { get; set; }

        /// <summary>
        /// Whether to use vSphere vSAN.
        /// </summary>
        /// <value>Whether to use vSphere vSAN.</value>
        [DataMember(Name="use_vsan", EmitDefaultValue=false)]
        public bool? UseVsan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopPoolStorageSettings {\n");
            sb.Append("  Datastores: ").Append(Datastores).Append("\n");
            sb.Append("  NonPersistentDiskDriveLetter: ").Append(NonPersistentDiskDriveLetter).Append("\n");
            sb.Append("  NonPersistentDiskSizeMb: ").Append(NonPersistentDiskSizeMb).Append("\n");
            sb.Append("  NonPersistentRedirectDisposableFiles: ").Append(NonPersistentRedirectDisposableFiles).Append("\n");
            sb.Append("  PersistentDiskDatastores: ").Append(PersistentDiskDatastores).Append("\n");
            sb.Append("  PersistentDiskDriveLetter: ").Append(PersistentDiskDriveLetter).Append("\n");
            sb.Append("  PersistentDiskSizeMb: ").Append(PersistentDiskSizeMb).Append("\n");
            sb.Append("  ReclaimVmDiskSpace: ").Append(ReclaimVmDiskSpace).Append("\n");
            sb.Append("  ReclamationThresholdMb: ").Append(ReclamationThresholdMb).Append("\n");
            sb.Append("  RedirectWindowsProfile: ").Append(RedirectWindowsProfile).Append("\n");
            sb.Append("  ReplicaDiskDatastoreId: ").Append(ReplicaDiskDatastoreId).Append("\n");
            sb.Append("  UseNativeSnapshots: ").Append(UseNativeSnapshots).Append("\n");
            sb.Append("  UseSeparateDatastoresPersistentAndOsDisks: ").Append(UseSeparateDatastoresPersistentAndOsDisks).Append("\n");
            sb.Append("  UseSeparateDatastoresReplicaAndOsDisks: ").Append(UseSeparateDatastoresReplicaAndOsDisks).Append("\n");
            sb.Append("  UseVsan: ").Append(UseVsan).Append("\n");
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
            return this.Equals(input as DesktopPoolStorageSettings);
        }

        /// <summary>
        /// Returns true if DesktopPoolStorageSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DesktopPoolStorageSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesktopPoolStorageSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Datastores == input.Datastores ||
                    this.Datastores != null &&
                    this.Datastores.SequenceEqual(input.Datastores)
                ) && 
                (
                    this.NonPersistentDiskDriveLetter == input.NonPersistentDiskDriveLetter ||
                    (this.NonPersistentDiskDriveLetter != null &&
                    this.NonPersistentDiskDriveLetter.Equals(input.NonPersistentDiskDriveLetter))
                ) && 
                (
                    this.NonPersistentDiskSizeMb == input.NonPersistentDiskSizeMb ||
                    (this.NonPersistentDiskSizeMb != null &&
                    this.NonPersistentDiskSizeMb.Equals(input.NonPersistentDiskSizeMb))
                ) && 
                (
                    this.NonPersistentRedirectDisposableFiles == input.NonPersistentRedirectDisposableFiles ||
                    (this.NonPersistentRedirectDisposableFiles != null &&
                    this.NonPersistentRedirectDisposableFiles.Equals(input.NonPersistentRedirectDisposableFiles))
                ) && 
                (
                    this.PersistentDiskDatastores == input.PersistentDiskDatastores ||
                    this.PersistentDiskDatastores != null &&
                    this.PersistentDiskDatastores.SequenceEqual(input.PersistentDiskDatastores)
                ) && 
                (
                    this.PersistentDiskDriveLetter == input.PersistentDiskDriveLetter ||
                    (this.PersistentDiskDriveLetter != null &&
                    this.PersistentDiskDriveLetter.Equals(input.PersistentDiskDriveLetter))
                ) && 
                (
                    this.PersistentDiskSizeMb == input.PersistentDiskSizeMb ||
                    (this.PersistentDiskSizeMb != null &&
                    this.PersistentDiskSizeMb.Equals(input.PersistentDiskSizeMb))
                ) && 
                (
                    this.ReclaimVmDiskSpace == input.ReclaimVmDiskSpace ||
                    (this.ReclaimVmDiskSpace != null &&
                    this.ReclaimVmDiskSpace.Equals(input.ReclaimVmDiskSpace))
                ) && 
                (
                    this.ReclamationThresholdMb == input.ReclamationThresholdMb ||
                    (this.ReclamationThresholdMb != null &&
                    this.ReclamationThresholdMb.Equals(input.ReclamationThresholdMb))
                ) && 
                (
                    this.RedirectWindowsProfile == input.RedirectWindowsProfile ||
                    (this.RedirectWindowsProfile != null &&
                    this.RedirectWindowsProfile.Equals(input.RedirectWindowsProfile))
                ) && 
                (
                    this.ReplicaDiskDatastoreId == input.ReplicaDiskDatastoreId ||
                    (this.ReplicaDiskDatastoreId != null &&
                    this.ReplicaDiskDatastoreId.Equals(input.ReplicaDiskDatastoreId))
                ) && 
                (
                    this.UseNativeSnapshots == input.UseNativeSnapshots ||
                    (this.UseNativeSnapshots != null &&
                    this.UseNativeSnapshots.Equals(input.UseNativeSnapshots))
                ) && 
                (
                    this.UseSeparateDatastoresPersistentAndOsDisks == input.UseSeparateDatastoresPersistentAndOsDisks ||
                    (this.UseSeparateDatastoresPersistentAndOsDisks != null &&
                    this.UseSeparateDatastoresPersistentAndOsDisks.Equals(input.UseSeparateDatastoresPersistentAndOsDisks))
                ) && 
                (
                    this.UseSeparateDatastoresReplicaAndOsDisks == input.UseSeparateDatastoresReplicaAndOsDisks ||
                    (this.UseSeparateDatastoresReplicaAndOsDisks != null &&
                    this.UseSeparateDatastoresReplicaAndOsDisks.Equals(input.UseSeparateDatastoresReplicaAndOsDisks))
                ) && 
                (
                    this.UseVsan == input.UseVsan ||
                    (this.UseVsan != null &&
                    this.UseVsan.Equals(input.UseVsan))
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
                if (this.Datastores != null)
                    hashCode = hashCode * 59 + this.Datastores.GetHashCode();
                if (this.NonPersistentDiskDriveLetter != null)
                    hashCode = hashCode * 59 + this.NonPersistentDiskDriveLetter.GetHashCode();
                if (this.NonPersistentDiskSizeMb != null)
                    hashCode = hashCode * 59 + this.NonPersistentDiskSizeMb.GetHashCode();
                if (this.NonPersistentRedirectDisposableFiles != null)
                    hashCode = hashCode * 59 + this.NonPersistentRedirectDisposableFiles.GetHashCode();
                if (this.PersistentDiskDatastores != null)
                    hashCode = hashCode * 59 + this.PersistentDiskDatastores.GetHashCode();
                if (this.PersistentDiskDriveLetter != null)
                    hashCode = hashCode * 59 + this.PersistentDiskDriveLetter.GetHashCode();
                if (this.PersistentDiskSizeMb != null)
                    hashCode = hashCode * 59 + this.PersistentDiskSizeMb.GetHashCode();
                if (this.ReclaimVmDiskSpace != null)
                    hashCode = hashCode * 59 + this.ReclaimVmDiskSpace.GetHashCode();
                if (this.ReclamationThresholdMb != null)
                    hashCode = hashCode * 59 + this.ReclamationThresholdMb.GetHashCode();
                if (this.RedirectWindowsProfile != null)
                    hashCode = hashCode * 59 + this.RedirectWindowsProfile.GetHashCode();
                if (this.ReplicaDiskDatastoreId != null)
                    hashCode = hashCode * 59 + this.ReplicaDiskDatastoreId.GetHashCode();
                if (this.UseNativeSnapshots != null)
                    hashCode = hashCode * 59 + this.UseNativeSnapshots.GetHashCode();
                if (this.UseSeparateDatastoresPersistentAndOsDisks != null)
                    hashCode = hashCode * 59 + this.UseSeparateDatastoresPersistentAndOsDisks.GetHashCode();
                if (this.UseSeparateDatastoresReplicaAndOsDisks != null)
                    hashCode = hashCode * 59 + this.UseSeparateDatastoresReplicaAndOsDisks.GetHashCode();
                if (this.UseVsan != null)
                    hashCode = hashCode * 59 + this.UseVsan.GetHashCode();
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
