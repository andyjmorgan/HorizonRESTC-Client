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
    /// RDS Server Monitor Information.
    /// </summary>
    [DataContract]
    public partial class RDSServerMonitorInfo :  IEquatable<RDSServerMonitorInfo>, IValidatableObject
    {
        /// <summary>
        /// Based on the current load of this RDS Server, gives a measure of how preferential this server is to be chosen for new application sessions. * BLOCK: RDS Server is blocked and new sessions will not be accepted. * HEAVY: RDS Server is experiencing heavy load and should likely not be chosen for new sessions. * NORMAL: RDS Server is experiencing normal load and is okay to be chosen for new sessions. * LIGHT: RDS Server is experiencing light load and is okay to be chosen for new sessions. * UNKNOWN: RDS Server did not report a load preference. This is potentially a configuration issue if other RDS Servers in the same Farm do report load preferences.
        /// </summary>
        /// <value>Based on the current load of this RDS Server, gives a measure of how preferential this server is to be chosen for new application sessions. * BLOCK: RDS Server is blocked and new sessions will not be accepted. * HEAVY: RDS Server is experiencing heavy load and should likely not be chosen for new sessions. * NORMAL: RDS Server is experiencing normal load and is okay to be chosen for new sessions. * LIGHT: RDS Server is experiencing light load and is okay to be chosen for new sessions. * UNKNOWN: RDS Server did not report a load preference. This is potentially a configuration issue if other RDS Servers in the same Farm do report load preferences.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LoadPreferenceEnum
        {
            
            /// <summary>
            /// Enum BLOCK for value: BLOCK
            /// </summary>
            [EnumMember(Value = "BLOCK")]
            BLOCK = 1,
            
            /// <summary>
            /// Enum HEAVY for value: HEAVY
            /// </summary>
            [EnumMember(Value = "HEAVY")]
            HEAVY = 2,
            
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            [EnumMember(Value = "NORMAL")]
            NORMAL = 3,
            
            /// <summary>
            /// Enum LIGHT for value: LIGHT
            /// </summary>
            [EnumMember(Value = "LIGHT")]
            LIGHT = 4,
            
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 5
        }

        /// <summary>
        /// Based on the current load of this RDS Server, gives a measure of how preferential this server is to be chosen for new application sessions. * BLOCK: RDS Server is blocked and new sessions will not be accepted. * HEAVY: RDS Server is experiencing heavy load and should likely not be chosen for new sessions. * NORMAL: RDS Server is experiencing normal load and is okay to be chosen for new sessions. * LIGHT: RDS Server is experiencing light load and is okay to be chosen for new sessions. * UNKNOWN: RDS Server did not report a load preference. This is potentially a configuration issue if other RDS Servers in the same Farm do report load preferences.
        /// </summary>
        /// <value>Based on the current load of this RDS Server, gives a measure of how preferential this server is to be chosen for new application sessions. * BLOCK: RDS Server is blocked and new sessions will not be accepted. * HEAVY: RDS Server is experiencing heavy load and should likely not be chosen for new sessions. * NORMAL: RDS Server is experiencing normal load and is okay to be chosen for new sessions. * LIGHT: RDS Server is experiencing light load and is okay to be chosen for new sessions. * UNKNOWN: RDS Server did not report a load preference. This is potentially a configuration issue if other RDS Servers in the same Farm do report load preferences.</value>
        [DataMember(Name="load_preference", EmitDefaultValue=false)]
        public LoadPreferenceEnum? LoadPreference { get; set; }
        /// <summary>
        /// RDS server status. * OK: RDS Server is reachable. All applications (defined on its farm) are verified installed on the RDS Server. * WARNING: RDS Server is reachable. Some applications are detected as not installed on the RDS Server. * ERROR: RDS Server is unreachable, or, none of the applications are installed. * DISABLED: RDS Server is disabled.
        /// </summary>
        /// <value>RDS server status. * OK: RDS Server is reachable. All applications (defined on its farm) are verified installed on the RDS Server. * WARNING: RDS Server is reachable. Some applications are detected as not installed on the RDS Server. * ERROR: RDS Server is unreachable, or, none of the applications are installed. * DISABLED: RDS Server is disabled.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum OK for value: OK
            /// </summary>
            [EnumMember(Value = "OK")]
            OK = 1,
            
            /// <summary>
            /// Enum WARNING for value: WARNING
            /// </summary>
            [EnumMember(Value = "WARNING")]
            WARNING = 2,
            
            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR = 3,
            
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 4
        }

        /// <summary>
        /// RDS server status. * OK: RDS Server is reachable. All applications (defined on its farm) are verified installed on the RDS Server. * WARNING: RDS Server is reachable. Some applications are detected as not installed on the RDS Server. * ERROR: RDS Server is unreachable, or, none of the applications are installed. * DISABLED: RDS Server is disabled.
        /// </summary>
        /// <value>RDS server status. * OK: RDS Server is reachable. All applications (defined on its farm) are verified installed on the RDS Server. * WARNING: RDS Server is reachable. Some applications are detected as not installed on the RDS Server. * ERROR: RDS Server is unreachable, or, none of the applications are installed. * DISABLED: RDS Server is disabled.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RDSServerMonitorInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RDSServerMonitorInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RDSServerMonitorInfo" /> class.
        /// </summary>
        /// <param name="details">Server details of RDS Server. (required).</param>
        /// <param name="enabled">Indicates if RDS server is enabled. (required).</param>
        /// <param name="farmId">Indicates the Farm ID to which the RDS Server belongs to. (required).</param>
        /// <param name="id">Unique ID of the RDS server. (required).</param>
        /// <param name="loadIndex">This value is similar to load_preference and represents the load on RDS Server in the range of 0 to 100..</param>
        /// <param name="loadPreference">Based on the current load of this RDS Server, gives a measure of how preferential this server is to be chosen for new application sessions. * BLOCK: RDS Server is blocked and new sessions will not be accepted. * HEAVY: RDS Server is experiencing heavy load and should likely not be chosen for new sessions. * NORMAL: RDS Server is experiencing normal load and is okay to be chosen for new sessions. * LIGHT: RDS Server is experiencing light load and is okay to be chosen for new sessions. * UNKNOWN: RDS Server did not report a load preference. This is potentially a configuration issue if other RDS Servers in the same Farm do report load preferences..</param>
        /// <param name="name">RDS Server name. (required).</param>
        /// <param name="sessionCount">RDS server session count..</param>
        /// <param name="status">RDS server status. * OK: RDS Server is reachable. All applications (defined on its farm) are verified installed on the RDS Server. * WARNING: RDS Server is reachable. Some applications are detected as not installed on the RDS Server. * ERROR: RDS Server is unreachable, or, none of the applications are installed. * DISABLED: RDS Server is disabled. (required).</param>
        public RDSServerMonitorInfo(RDSServerMonitorDetails details = default(RDSServerMonitorDetails), bool? enabled = default(bool?), string farmId = default(string), string id = default(string), int? loadIndex = default(int?), LoadPreferenceEnum? loadPreference = default(LoadPreferenceEnum?), string name = default(string), int? sessionCount = default(int?), StatusEnum status = default(StatusEnum))
        {
            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for RDSServerMonitorInfo and cannot be null");
            }
            else
            {
                this.Details = details;
            }
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for RDSServerMonitorInfo and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "farmId" is required (not null)
            if (farmId == null)
            {
                throw new InvalidDataException("farmId is a required property for RDSServerMonitorInfo and cannot be null");
            }
            else
            {
                this.FarmId = farmId;
            }
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for RDSServerMonitorInfo and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for RDSServerMonitorInfo and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new InvalidDataException("status is a required property for RDSServerMonitorInfo and cannot be null");
            }
            else
            {
                this.Status = status;
            }
            this.LoadIndex = loadIndex;
            this.LoadPreference = loadPreference;
            this.SessionCount = sessionCount;
        }
        
        /// <summary>
        /// Server details of RDS Server.
        /// </summary>
        /// <value>Server details of RDS Server.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public RDSServerMonitorDetails Details { get; set; }

        /// <summary>
        /// Indicates if RDS server is enabled.
        /// </summary>
        /// <value>Indicates if RDS server is enabled.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Indicates the Farm ID to which the RDS Server belongs to.
        /// </summary>
        /// <value>Indicates the Farm ID to which the RDS Server belongs to.</value>
        [DataMember(Name="farm_id", EmitDefaultValue=false)]
        public string FarmId { get; set; }

        /// <summary>
        /// Unique ID of the RDS server.
        /// </summary>
        /// <value>Unique ID of the RDS server.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// This value is similar to load_preference and represents the load on RDS Server in the range of 0 to 100.
        /// </summary>
        /// <value>This value is similar to load_preference and represents the load on RDS Server in the range of 0 to 100.</value>
        [DataMember(Name="load_index", EmitDefaultValue=false)]
        public int? LoadIndex { get; set; }


        /// <summary>
        /// RDS Server name.
        /// </summary>
        /// <value>RDS Server name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// RDS server session count.
        /// </summary>
        /// <value>RDS server session count.</value>
        [DataMember(Name="session_count", EmitDefaultValue=false)]
        public int? SessionCount { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RDSServerMonitorInfo {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  FarmId: ").Append(FarmId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoadIndex: ").Append(LoadIndex).Append("\n");
            sb.Append("  LoadPreference: ").Append(LoadPreference).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SessionCount: ").Append(SessionCount).Append("\n");
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
            return this.Equals(input as RDSServerMonitorInfo);
        }

        /// <summary>
        /// Returns true if RDSServerMonitorInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RDSServerMonitorInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RDSServerMonitorInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.FarmId == input.FarmId ||
                    (this.FarmId != null &&
                    this.FarmId.Equals(input.FarmId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LoadIndex == input.LoadIndex ||
                    (this.LoadIndex != null &&
                    this.LoadIndex.Equals(input.LoadIndex))
                ) && 
                (
                    this.LoadPreference == input.LoadPreference ||
                    (this.LoadPreference != null &&
                    this.LoadPreference.Equals(input.LoadPreference))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SessionCount == input.SessionCount ||
                    (this.SessionCount != null &&
                    this.SessionCount.Equals(input.SessionCount))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.FarmId != null)
                    hashCode = hashCode * 59 + this.FarmId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LoadIndex != null)
                    hashCode = hashCode * 59 + this.LoadIndex.GetHashCode();
                if (this.LoadPreference != null)
                    hashCode = hashCode * 59 + this.LoadPreference.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SessionCount != null)
                    hashCode = hashCode * 59 + this.SessionCount.GetHashCode();
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
            // LoadIndex (int?) maximum
            if(this.LoadIndex > (int?)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LoadIndex, must be a value less than or equal to 100.", new [] { "LoadIndex" });
            }

            // LoadIndex (int?) minimum
            if(this.LoadIndex < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LoadIndex, must be a value greater than or equal to 0.", new [] { "LoadIndex" });
            }

            yield break;
        }
    }

}