/* 
 * virusapi
 *
 * The Cloudmersive Virus Scan API lets you scan files and content for viruses and identify security issues with content.
 *
 * OpenAPI spec version: v1
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
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.VirusScan.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.VirusScan.Model
{
    /// <summary>
    /// Virus positively identified
    /// </summary>
    [DataContract]
    public partial class VirusFound :  IEquatable<VirusFound>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirusFound" /> class.
        /// </summary>
        /// <param name="fileName">Name of the file containing the virus.</param>
        /// <param name="virusName">Name of the virus that was found.</param>
        public VirusFound(string fileName = default(string), string virusName = default(string))
        {
            this.FileName = fileName;
            this.VirusName = virusName;
        }
        
        /// <summary>
        /// Name of the file containing the virus
        /// </summary>
        /// <value>Name of the file containing the virus</value>
        [DataMember(Name="FileName", EmitDefaultValue=false)]
        public string FileName { get; set; }

        /// <summary>
        /// Name of the virus that was found
        /// </summary>
        /// <value>Name of the virus that was found</value>
        [DataMember(Name="VirusName", EmitDefaultValue=false)]
        public string VirusName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirusFound {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  VirusName: ").Append(VirusName).Append("\n");
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
            return this.Equals(input as VirusFound);
        }

        /// <summary>
        /// Returns true if VirusFound instances are equal
        /// </summary>
        /// <param name="input">Instance of VirusFound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirusFound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.VirusName == input.VirusName ||
                    (this.VirusName != null &&
                    this.VirusName.Equals(input.VirusName))
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
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.VirusName != null)
                    hashCode = hashCode * 59 + this.VirusName.GetHashCode();
                return hashCode;
            }
        }
    }

}
