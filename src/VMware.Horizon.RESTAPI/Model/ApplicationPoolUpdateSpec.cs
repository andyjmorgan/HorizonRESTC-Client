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
    /// Information required to update an application pool.
    /// </summary>
    [DataContract]
    public partial class ApplicationPoolUpdateSpec :  IEquatable<ApplicationPoolUpdateSpec>, IValidatableObject
    {
        /// <summary>
        /// Multi-session mode for the application pool. An application launched in multi-session mode does not support reconnect behavior when user logs in from a different client instance. Multi-session mode should be disabled when pre-launch is enabled.Default value is \&quot;DISABLED\&quot; * DISABLED: Multi-session is not supported for this application. * ENABLED_DEFAULT_OFF: Multi-session is supported for this application but is disabled by default. The client would need to explicitly request multi-session launch, if wanted. If a legacy client is used, this will always result in a single-session application launch. * ENABLED_DEFAULT_ON: Multi-session mode is supported for this application and is enabled by default. The client can request explicitly for single-session launch, if wanted. If a legacy client is used, this will always result in a multi-session application launch. * ENABLED_ENFORCED: Multi-session is supported for this application and it is enforced. The client can not select to launch this application as a single-session application.
        /// </summary>
        /// <value>Multi-session mode for the application pool. An application launched in multi-session mode does not support reconnect behavior when user logs in from a different client instance. Multi-session mode should be disabled when pre-launch is enabled.Default value is \&quot;DISABLED\&quot; * DISABLED: Multi-session is not supported for this application. * ENABLED_DEFAULT_OFF: Multi-session is supported for this application but is disabled by default. The client would need to explicitly request multi-session launch, if wanted. If a legacy client is used, this will always result in a single-session application launch. * ENABLED_DEFAULT_ON: Multi-session mode is supported for this application and is enabled by default. The client can request explicitly for single-session launch, if wanted. If a legacy client is used, this will always result in a multi-session application launch. * ENABLED_ENFORCED: Multi-session is supported for this application and it is enforced. The client can not select to launch this application as a single-session application.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MultiSessionModeEnum
        {
            
            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            DISABLED = 1,
            
            /// <summary>
            /// Enum ENABLEDDEFAULTOFF for value: ENABLED_DEFAULT_OFF
            /// </summary>
            [EnumMember(Value = "ENABLED_DEFAULT_OFF")]
            ENABLEDDEFAULTOFF = 2,
            
            /// <summary>
            /// Enum ENABLEDDEFAULTON for value: ENABLED_DEFAULT_ON
            /// </summary>
            [EnumMember(Value = "ENABLED_DEFAULT_ON")]
            ENABLEDDEFAULTON = 3,
            
            /// <summary>
            /// Enum ENABLEDENFORCED for value: ENABLED_ENFORCED
            /// </summary>
            [EnumMember(Value = "ENABLED_ENFORCED")]
            ENABLEDENFORCED = 4
        }

        /// <summary>
        /// Multi-session mode for the application pool. An application launched in multi-session mode does not support reconnect behavior when user logs in from a different client instance. Multi-session mode should be disabled when pre-launch is enabled.Default value is \&quot;DISABLED\&quot; * DISABLED: Multi-session is not supported for this application. * ENABLED_DEFAULT_OFF: Multi-session is supported for this application but is disabled by default. The client would need to explicitly request multi-session launch, if wanted. If a legacy client is used, this will always result in a single-session application launch. * ENABLED_DEFAULT_ON: Multi-session mode is supported for this application and is enabled by default. The client can request explicitly for single-session launch, if wanted. If a legacy client is used, this will always result in a multi-session application launch. * ENABLED_ENFORCED: Multi-session is supported for this application and it is enforced. The client can not select to launch this application as a single-session application.
        /// </summary>
        /// <value>Multi-session mode for the application pool. An application launched in multi-session mode does not support reconnect behavior when user logs in from a different client instance. Multi-session mode should be disabled when pre-launch is enabled.Default value is \&quot;DISABLED\&quot; * DISABLED: Multi-session is not supported for this application. * ENABLED_DEFAULT_OFF: Multi-session is supported for this application but is disabled by default. The client would need to explicitly request multi-session launch, if wanted. If a legacy client is used, this will always result in a single-session application launch. * ENABLED_DEFAULT_ON: Multi-session mode is supported for this application and is enabled by default. The client can request explicitly for single-session launch, if wanted. If a legacy client is used, this will always result in a multi-session application launch. * ENABLED_ENFORCED: Multi-session is supported for this application and it is enforced. The client can not select to launch this application as a single-session application.</value>
        [DataMember(Name="multi_session_mode", EmitDefaultValue=false)]
        public MultiSessionModeEnum? MultiSessionMode { get; set; }
        /// <summary>
        /// Defines ShortcutLocations
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShortcutLocationsEnum
        {
            
            /// <summary>
            /// Enum STARTMENU for value: START_MENU
            /// </summary>
            [EnumMember(Value = "START_MENU")]
            STARTMENU = 1,
            
            /// <summary>
            /// Enum DESKTOP for value: DESKTOP
            /// </summary>
            [EnumMember(Value = "DESKTOP")]
            DESKTOP = 2
        }


        /// <summary>
        /// Locations of the category folder in the user&#39;s OS containing a shortcut to the application. The value must be set if category folder name is provided.
        /// </summary>
        /// <value>Locations of the category folder in the user&#39;s OS containing a shortcut to the application. The value must be set if category folder name is provided.</value>
        [DataMember(Name="shortcut_locations", EmitDefaultValue=false)]
        public List<ShortcutLocationsEnum> ShortcutLocations { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationPoolUpdateSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicationPoolUpdateSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationPoolUpdateSpec" /> class.
        /// </summary>
        /// <param name="antiAffinityData">Configure to enable anti-affinity rules. When an anti-affinity rule is configured for an application pool, Horizon Connection Server attempts to launch the application only on RDS servers that have sufficient resources to run the application. This feature can be useful for controlling applications that consume large amounts of CPU or memory resources.&lt;br&gt;An anti-affinity rule consists of an application matching pattern and a maximum count. For example, the application matching pattern might be autocad.exe and the maximum count might be 2..</param>
        /// <param name="categoryFolderName">Name of the category folder in the user&#39;s OS containing a shortcut to the application. Unset if the application does not belong to a category..</param>
        /// <param name="csRestrictionTags">Connection server restrictions. Application pool can be accessed from only those connection server instances that have a matching tag in this list. Null or empty list means that the application pool can be accessed from any connection server..</param>
        /// <param name="description">Notes about the application pool..</param>
        /// <param name="displayName">The display name is the name that users will see in Horizon client. If the display name is left blank, it defaults to name..</param>
        /// <param name="enableClientRestrictions">Indicates whether client restrictions are to be applied to application pool. Currently it is valid for application pool created from farm. Default value is false..</param>
        /// <param name="enablePreLaunch">Whether to pre-launch the application. Default value is false..</param>
        /// <param name="enabled">Indicates whether the application pool is enabled. Default value is true (required).</param>
        /// <param name="executablePath">Path to application executable. (required).</param>
        /// <param name="maxMultiSessions">Maximum number of multi-sessions a user can have in this application pool. This property is required if multi-session mode is set to \&quot;ENABLED_DEFAULT_OFF\&quot;, \&quot;ENABLED_DEFAULT_ON\&quot;, or \&quot;ENABLED_ENFORCED\&quot;Default value is 1..</param>
        /// <param name="multiSessionMode">Multi-session mode for the application pool. An application launched in multi-session mode does not support reconnect behavior when user logs in from a different client instance. Multi-session mode should be disabled when pre-launch is enabled.Default value is \&quot;DISABLED\&quot; * DISABLED: Multi-session is not supported for this application. * ENABLED_DEFAULT_OFF: Multi-session is supported for this application but is disabled by default. The client would need to explicitly request multi-session launch, if wanted. If a legacy client is used, this will always result in a single-session application launch. * ENABLED_DEFAULT_ON: Multi-session mode is supported for this application and is enabled by default. The client can request explicitly for single-session launch, if wanted. If a legacy client is used, this will always result in a multi-session application launch. * ENABLED_ENFORCED: Multi-session is supported for this application and it is enforced. The client can not select to launch this application as a single-session application..</param>
        /// <param name="parameters">Parameters to pass to application when launching..</param>
        /// <param name="publisher">Application publisher.</param>
        /// <param name="shortcutLocations">Locations of the category folder in the user&#39;s OS containing a shortcut to the application. The value must be set if category folder name is provided..</param>
        /// <param name="startFolder">Starting folder for application.</param>
        /// <param name="supportedFileTypesData">Supported file types details..</param>
        /// <param name="version">Application version..</param>
        public ApplicationPoolUpdateSpec(ApplicationAntiAffinityData antiAffinityData = default(ApplicationAntiAffinityData), string categoryFolderName = default(string), List<string> csRestrictionTags = default(List<string>), string description = default(string), string displayName = default(string), bool? enableClientRestrictions = default(bool?), bool? enablePreLaunch = default(bool?), bool? enabled = default(bool?), string executablePath = default(string), int? maxMultiSessions = default(int?), MultiSessionModeEnum? multiSessionMode = default(MultiSessionModeEnum?), string parameters = default(string), string publisher = default(string), List<ShortcutLocationsEnum> shortcutLocations = default(List<ShortcutLocationsEnum>), string startFolder = default(string), ApplicationSupportedFileTypesData supportedFileTypesData = default(ApplicationSupportedFileTypesData), string version = default(string))
        {
            // to ensure "enabled" is required (not null)
            if (enabled == null)
            {
                throw new InvalidDataException("enabled is a required property for ApplicationPoolUpdateSpec and cannot be null");
            }
            else
            {
                this.Enabled = enabled;
            }
            // to ensure "executablePath" is required (not null)
            if (executablePath == null)
            {
                throw new InvalidDataException("executablePath is a required property for ApplicationPoolUpdateSpec and cannot be null");
            }
            else
            {
                this.ExecutablePath = executablePath;
            }
            this.AntiAffinityData = antiAffinityData;
            this.CategoryFolderName = categoryFolderName;
            this.CsRestrictionTags = csRestrictionTags;
            this.Description = description;
            this.DisplayName = displayName;
            this.EnableClientRestrictions = enableClientRestrictions;
            this.EnablePreLaunch = enablePreLaunch;
            this.MaxMultiSessions = maxMultiSessions;
            this.MultiSessionMode = multiSessionMode;
            this.Parameters = parameters;
            this.Publisher = publisher;
            this.ShortcutLocations = shortcutLocations;
            this.StartFolder = startFolder;
            this.SupportedFileTypesData = supportedFileTypesData;
            this.Version = version;
        }
        
        /// <summary>
        /// Configure to enable anti-affinity rules. When an anti-affinity rule is configured for an application pool, Horizon Connection Server attempts to launch the application only on RDS servers that have sufficient resources to run the application. This feature can be useful for controlling applications that consume large amounts of CPU or memory resources.&lt;br&gt;An anti-affinity rule consists of an application matching pattern and a maximum count. For example, the application matching pattern might be autocad.exe and the maximum count might be 2.
        /// </summary>
        /// <value>Configure to enable anti-affinity rules. When an anti-affinity rule is configured for an application pool, Horizon Connection Server attempts to launch the application only on RDS servers that have sufficient resources to run the application. This feature can be useful for controlling applications that consume large amounts of CPU or memory resources.&lt;br&gt;An anti-affinity rule consists of an application matching pattern and a maximum count. For example, the application matching pattern might be autocad.exe and the maximum count might be 2.</value>
        [DataMember(Name="anti_affinity_data", EmitDefaultValue=false)]
        public ApplicationAntiAffinityData AntiAffinityData { get; set; }

        /// <summary>
        /// Name of the category folder in the user&#39;s OS containing a shortcut to the application. Unset if the application does not belong to a category.
        /// </summary>
        /// <value>Name of the category folder in the user&#39;s OS containing a shortcut to the application. Unset if the application does not belong to a category.</value>
        [DataMember(Name="category_folder_name", EmitDefaultValue=false)]
        public string CategoryFolderName { get; set; }

        /// <summary>
        /// Connection server restrictions. Application pool can be accessed from only those connection server instances that have a matching tag in this list. Null or empty list means that the application pool can be accessed from any connection server.
        /// </summary>
        /// <value>Connection server restrictions. Application pool can be accessed from only those connection server instances that have a matching tag in this list. Null or empty list means that the application pool can be accessed from any connection server.</value>
        [DataMember(Name="cs_restriction_tags", EmitDefaultValue=false)]
        public List<string> CsRestrictionTags { get; set; }

        /// <summary>
        /// Notes about the application pool.
        /// </summary>
        /// <value>Notes about the application pool.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The display name is the name that users will see in Horizon client. If the display name is left blank, it defaults to name.
        /// </summary>
        /// <value>The display name is the name that users will see in Horizon client. If the display name is left blank, it defaults to name.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Indicates whether client restrictions are to be applied to application pool. Currently it is valid for application pool created from farm. Default value is false.
        /// </summary>
        /// <value>Indicates whether client restrictions are to be applied to application pool. Currently it is valid for application pool created from farm. Default value is false.</value>
        [DataMember(Name="enable_client_restrictions", EmitDefaultValue=false)]
        public bool? EnableClientRestrictions { get; set; }

        /// <summary>
        /// Whether to pre-launch the application. Default value is false.
        /// </summary>
        /// <value>Whether to pre-launch the application. Default value is false.</value>
        [DataMember(Name="enable_pre_launch", EmitDefaultValue=false)]
        public bool? EnablePreLaunch { get; set; }

        /// <summary>
        /// Indicates whether the application pool is enabled. Default value is true
        /// </summary>
        /// <value>Indicates whether the application pool is enabled. Default value is true</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Path to application executable.
        /// </summary>
        /// <value>Path to application executable.</value>
        [DataMember(Name="executable_path", EmitDefaultValue=false)]
        public string ExecutablePath { get; set; }

        /// <summary>
        /// Maximum number of multi-sessions a user can have in this application pool. This property is required if multi-session mode is set to \&quot;ENABLED_DEFAULT_OFF\&quot;, \&quot;ENABLED_DEFAULT_ON\&quot;, or \&quot;ENABLED_ENFORCED\&quot;Default value is 1.
        /// </summary>
        /// <value>Maximum number of multi-sessions a user can have in this application pool. This property is required if multi-session mode is set to \&quot;ENABLED_DEFAULT_OFF\&quot;, \&quot;ENABLED_DEFAULT_ON\&quot;, or \&quot;ENABLED_ENFORCED\&quot;Default value is 1.</value>
        [DataMember(Name="max_multi_sessions", EmitDefaultValue=false)]
        public int? MaxMultiSessions { get; set; }


        /// <summary>
        /// Parameters to pass to application when launching.
        /// </summary>
        /// <value>Parameters to pass to application when launching.</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// Application publisher
        /// </summary>
        /// <value>Application publisher</value>
        [DataMember(Name="publisher", EmitDefaultValue=false)]
        public string Publisher { get; set; }


        /// <summary>
        /// Starting folder for application
        /// </summary>
        /// <value>Starting folder for application</value>
        [DataMember(Name="start_folder", EmitDefaultValue=false)]
        public string StartFolder { get; set; }

        /// <summary>
        /// Supported file types details.
        /// </summary>
        /// <value>Supported file types details.</value>
        [DataMember(Name="supported_file_types_data", EmitDefaultValue=false)]
        public ApplicationSupportedFileTypesData SupportedFileTypesData { get; set; }

        /// <summary>
        /// Application version.
        /// </summary>
        /// <value>Application version.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplicationPoolUpdateSpec {\n");
            sb.Append("  AntiAffinityData: ").Append(AntiAffinityData).Append("\n");
            sb.Append("  CategoryFolderName: ").Append(CategoryFolderName).Append("\n");
            sb.Append("  CsRestrictionTags: ").Append(CsRestrictionTags).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  EnableClientRestrictions: ").Append(EnableClientRestrictions).Append("\n");
            sb.Append("  EnablePreLaunch: ").Append(EnablePreLaunch).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ExecutablePath: ").Append(ExecutablePath).Append("\n");
            sb.Append("  MaxMultiSessions: ").Append(MaxMultiSessions).Append("\n");
            sb.Append("  MultiSessionMode: ").Append(MultiSessionMode).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Publisher: ").Append(Publisher).Append("\n");
            sb.Append("  ShortcutLocations: ").Append(ShortcutLocations).Append("\n");
            sb.Append("  StartFolder: ").Append(StartFolder).Append("\n");
            sb.Append("  SupportedFileTypesData: ").Append(SupportedFileTypesData).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as ApplicationPoolUpdateSpec);
        }

        /// <summary>
        /// Returns true if ApplicationPoolUpdateSpec instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationPoolUpdateSpec to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationPoolUpdateSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AntiAffinityData == input.AntiAffinityData ||
                    (this.AntiAffinityData != null &&
                    this.AntiAffinityData.Equals(input.AntiAffinityData))
                ) && 
                (
                    this.CategoryFolderName == input.CategoryFolderName ||
                    (this.CategoryFolderName != null &&
                    this.CategoryFolderName.Equals(input.CategoryFolderName))
                ) && 
                (
                    this.CsRestrictionTags == input.CsRestrictionTags ||
                    this.CsRestrictionTags != null &&
                    this.CsRestrictionTags.SequenceEqual(input.CsRestrictionTags)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.EnableClientRestrictions == input.EnableClientRestrictions ||
                    (this.EnableClientRestrictions != null &&
                    this.EnableClientRestrictions.Equals(input.EnableClientRestrictions))
                ) && 
                (
                    this.EnablePreLaunch == input.EnablePreLaunch ||
                    (this.EnablePreLaunch != null &&
                    this.EnablePreLaunch.Equals(input.EnablePreLaunch))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.ExecutablePath == input.ExecutablePath ||
                    (this.ExecutablePath != null &&
                    this.ExecutablePath.Equals(input.ExecutablePath))
                ) && 
                (
                    this.MaxMultiSessions == input.MaxMultiSessions ||
                    (this.MaxMultiSessions != null &&
                    this.MaxMultiSessions.Equals(input.MaxMultiSessions))
                ) && 
                (
                    this.MultiSessionMode == input.MultiSessionMode ||
                    (this.MultiSessionMode != null &&
                    this.MultiSessionMode.Equals(input.MultiSessionMode))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    (this.Parameters != null &&
                    this.Parameters.Equals(input.Parameters))
                ) && 
                (
                    this.Publisher == input.Publisher ||
                    (this.Publisher != null &&
                    this.Publisher.Equals(input.Publisher))
                ) && 
                (
                    this.ShortcutLocations == input.ShortcutLocations ||
                    this.ShortcutLocations != null &&
                    this.ShortcutLocations.SequenceEqual(input.ShortcutLocations)
                ) && 
                (
                    this.StartFolder == input.StartFolder ||
                    (this.StartFolder != null &&
                    this.StartFolder.Equals(input.StartFolder))
                ) && 
                (
                    this.SupportedFileTypesData == input.SupportedFileTypesData ||
                    (this.SupportedFileTypesData != null &&
                    this.SupportedFileTypesData.Equals(input.SupportedFileTypesData))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.AntiAffinityData != null)
                    hashCode = hashCode * 59 + this.AntiAffinityData.GetHashCode();
                if (this.CategoryFolderName != null)
                    hashCode = hashCode * 59 + this.CategoryFolderName.GetHashCode();
                if (this.CsRestrictionTags != null)
                    hashCode = hashCode * 59 + this.CsRestrictionTags.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.EnableClientRestrictions != null)
                    hashCode = hashCode * 59 + this.EnableClientRestrictions.GetHashCode();
                if (this.EnablePreLaunch != null)
                    hashCode = hashCode * 59 + this.EnablePreLaunch.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ExecutablePath != null)
                    hashCode = hashCode * 59 + this.ExecutablePath.GetHashCode();
                if (this.MaxMultiSessions != null)
                    hashCode = hashCode * 59 + this.MaxMultiSessions.GetHashCode();
                if (this.MultiSessionMode != null)
                    hashCode = hashCode * 59 + this.MultiSessionMode.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
                if (this.Publisher != null)
                    hashCode = hashCode * 59 + this.Publisher.GetHashCode();
                if (this.ShortcutLocations != null)
                    hashCode = hashCode * 59 + this.ShortcutLocations.GetHashCode();
                if (this.StartFolder != null)
                    hashCode = hashCode * 59 + this.StartFolder.GetHashCode();
                if (this.SupportedFileTypesData != null)
                    hashCode = hashCode * 59 + this.SupportedFileTypesData.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
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
