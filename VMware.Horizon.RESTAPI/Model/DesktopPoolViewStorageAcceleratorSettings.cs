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
    /// Settings related to the View Storage Accelerator feature.
    /// </summary>
    [DataContract]
    public partial class DesktopPoolViewStorageAcceleratorSettings :  IEquatable<DesktopPoolViewStorageAcceleratorSettings>
    {
        /// <summary>
        /// Disk types to enable for the View Storage Accelerator feature. This is only applicable to linked clone desktop pools. * OS_DISKS: OS disks. * OS_AND_PERSISTENT_DISKS: OS and persistent disks.
        /// </summary>
        /// <value>Disk types to enable for the View Storage Accelerator feature. This is only applicable to linked clone desktop pools. * OS_DISKS: OS disks. * OS_AND_PERSISTENT_DISKS: OS and persistent disks.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ViewStorageAcceleratorDiskTypesEnum
        {
            
            /// <summary>
            /// Enum DISKS for value: OS_DISKS
            /// </summary>
            [EnumMember(Value = "OS_DISKS")]
            DISKS = 1,
            
            /// <summary>
            /// Enum ANDPERSISTENTDISKS for value: OS_AND_PERSISTENT_DISKS
            /// </summary>
            [EnumMember(Value = "OS_AND_PERSISTENT_DISKS")]
            ANDPERSISTENTDISKS = 2
        }

        /// <summary>
        /// Disk types to enable for the View Storage Accelerator feature. This is only applicable to linked clone desktop pools. * OS_DISKS: OS disks. * OS_AND_PERSISTENT_DISKS: OS and persistent disks.
        /// </summary>
        /// <value>Disk types to enable for the View Storage Accelerator feature. This is only applicable to linked clone desktop pools. * OS_DISKS: OS disks. * OS_AND_PERSISTENT_DISKS: OS and persistent disks.</value>
        [DataMember(Name="view_storage_accelerator_disk_types", EmitDefaultValue=false)]
        public ViewStorageAcceleratorDiskTypesEnum? ViewStorageAcceleratorDiskTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DesktopPoolViewStorageAcceleratorSettings" /> class.
        /// </summary>
        /// <param name="blackoutTimes">A list of blackout times. Storage accelerator regeneration and machine disk space reclamation do not occur during blackout times. The same blackout policy applies to both operations. If unset, no blackout times are used..</param>
        /// <param name="regenerateViewStorageAcceleratorDays">How often to regenerate the View Storage Accelerator cache. Measured in Days..</param>
        /// <param name="useViewStorageAccelerator">Whether to use View Storage Accelerator..</param>
        /// <param name="viewStorageAcceleratorDiskTypes">Disk types to enable for the View Storage Accelerator feature. This is only applicable to linked clone desktop pools. * OS_DISKS: OS disks. * OS_AND_PERSISTENT_DISKS: OS and persistent disks..</param>
        public DesktopPoolViewStorageAcceleratorSettings(List<ViewStorageAcceleratorBlackoutTimeSettings> blackoutTimes = default(List<ViewStorageAcceleratorBlackoutTimeSettings>), int? regenerateViewStorageAcceleratorDays = default(int?), bool? useViewStorageAccelerator = default(bool?), ViewStorageAcceleratorDiskTypesEnum? viewStorageAcceleratorDiskTypes = default(ViewStorageAcceleratorDiskTypesEnum?))
        {
            this.BlackoutTimes = blackoutTimes;
            this.RegenerateViewStorageAcceleratorDays = regenerateViewStorageAcceleratorDays;
            this.UseViewStorageAccelerator = useViewStorageAccelerator;
            this.ViewStorageAcceleratorDiskTypes = viewStorageAcceleratorDiskTypes;
        }
        
        /// <summary>
        /// A list of blackout times. Storage accelerator regeneration and machine disk space reclamation do not occur during blackout times. The same blackout policy applies to both operations. If unset, no blackout times are used.
        /// </summary>
        /// <value>A list of blackout times. Storage accelerator regeneration and machine disk space reclamation do not occur during blackout times. The same blackout policy applies to both operations. If unset, no blackout times are used.</value>
        [DataMember(Name="blackout_times", EmitDefaultValue=false)]
        public List<ViewStorageAcceleratorBlackoutTimeSettings> BlackoutTimes { get; set; }

        /// <summary>
        /// How often to regenerate the View Storage Accelerator cache. Measured in Days.
        /// </summary>
        /// <value>How often to regenerate the View Storage Accelerator cache. Measured in Days.</value>
        [DataMember(Name="regenerate_view_storage_accelerator_days", EmitDefaultValue=false)]
        public int? RegenerateViewStorageAcceleratorDays { get; set; }

        /// <summary>
        /// Whether to use View Storage Accelerator.
        /// </summary>
        /// <value>Whether to use View Storage Accelerator.</value>
        [DataMember(Name="use_view_storage_accelerator", EmitDefaultValue=false)]
        public bool? UseViewStorageAccelerator { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopPoolViewStorageAcceleratorSettings {\n");
            sb.Append("  BlackoutTimes: ").Append(BlackoutTimes).Append("\n");
            sb.Append("  RegenerateViewStorageAcceleratorDays: ").Append(RegenerateViewStorageAcceleratorDays).Append("\n");
            sb.Append("  UseViewStorageAccelerator: ").Append(UseViewStorageAccelerator).Append("\n");
            sb.Append("  ViewStorageAcceleratorDiskTypes: ").Append(ViewStorageAcceleratorDiskTypes).Append("\n");
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
            return this.Equals(input as DesktopPoolViewStorageAcceleratorSettings);
        }

        /// <summary>
        /// Returns true if DesktopPoolViewStorageAcceleratorSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of DesktopPoolViewStorageAcceleratorSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DesktopPoolViewStorageAcceleratorSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlackoutTimes == input.BlackoutTimes ||
                    this.BlackoutTimes != null &&
                    this.BlackoutTimes.SequenceEqual(input.BlackoutTimes)
                ) && 
                (
                    this.RegenerateViewStorageAcceleratorDays == input.RegenerateViewStorageAcceleratorDays ||
                    (this.RegenerateViewStorageAcceleratorDays != null &&
                    this.RegenerateViewStorageAcceleratorDays.Equals(input.RegenerateViewStorageAcceleratorDays))
                ) && 
                (
                    this.UseViewStorageAccelerator == input.UseViewStorageAccelerator ||
                    (this.UseViewStorageAccelerator != null &&
                    this.UseViewStorageAccelerator.Equals(input.UseViewStorageAccelerator))
                ) && 
                (
                    this.ViewStorageAcceleratorDiskTypes == input.ViewStorageAcceleratorDiskTypes ||
                    (this.ViewStorageAcceleratorDiskTypes != null &&
                    this.ViewStorageAcceleratorDiskTypes.Equals(input.ViewStorageAcceleratorDiskTypes))
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
                if (this.BlackoutTimes != null)
                    hashCode = hashCode * 59 + this.BlackoutTimes.GetHashCode();
                if (this.RegenerateViewStorageAcceleratorDays != null)
                    hashCode = hashCode * 59 + this.RegenerateViewStorageAcceleratorDays.GetHashCode();
                if (this.UseViewStorageAccelerator != null)
                    hashCode = hashCode * 59 + this.UseViewStorageAccelerator.GetHashCode();
                if (this.ViewStorageAcceleratorDiskTypes != null)
                    hashCode = hashCode * 59 + this.ViewStorageAcceleratorDiskTypes.GetHashCode();
                return hashCode;
            }
        }
    }

}
