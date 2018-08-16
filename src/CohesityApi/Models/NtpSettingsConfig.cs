/* 
 * Cohesity REST API
 *
 * This API provides operations for interfacing with the Cohesity Cluster. NOTE: To view the documentation on the responses, click 'Model' next to 'Example Value' and keep clicking to expand the hierarchy.
 *
 * OpenAPI spec version: 1.0
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


namespace Cohesity.Models
{
    /// <summary>
    /// NtpSettingsConfig
    /// </summary>
    [DataContract]
    public partial class NtpSettingsConfig :  IEquatable<NtpSettingsConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NtpSettingsConfig" /> class.
        /// </summary>
        /// <param name="ntpServersInternal">ntpServersInternal.</param>
        public NtpSettingsConfig(bool? ntpServersInternal = default(bool?))
        {
            this.NtpServersInternal = ntpServersInternal;
        }
        
        /// <summary>
        /// Gets or Sets NtpServersInternal
        /// </summary>
        [DataMember(Name="ntpServersInternal", EmitDefaultValue=false)]
        public bool? NtpServersInternal { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NtpSettingsConfig {\n");
            sb.Append("  NtpServersInternal: ").Append(NtpServersInternal).Append("\n");
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
            return this.Equals(input as NtpSettingsConfig);
        }

        /// <summary>
        /// Returns true if NtpSettingsConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of NtpSettingsConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NtpSettingsConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NtpServersInternal == input.NtpServersInternal ||
                    (this.NtpServersInternal != null &&
                    this.NtpServersInternal.Equals(input.NtpServersInternal))
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
                if (this.NtpServersInternal != null)
                    hashCode = hashCode * 59 + this.NtpServersInternal.GetHashCode();
                return hashCode;
            }
        }

        
    }

}