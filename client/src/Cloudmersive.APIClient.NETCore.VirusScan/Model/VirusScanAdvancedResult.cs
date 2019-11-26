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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.VirusScan.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.VirusScan.Model
{
    /// <summary>
    /// Result of running an advanced virus scan
    /// </summary>
    [DataContract]
    public partial class VirusScanAdvancedResult :  IEquatable<VirusScanAdvancedResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VirusScanAdvancedResult" /> class.
        /// </summary>
        /// <param name="CleanResult">True if the scan contained no viruses, false otherwise.</param>
        /// <param name="ContainsExecutable">True if the scan contained an executable (application code), which can be a significant risk factor.</param>
        /// <param name="ContainsInvalidFile">True if the scan contained an invalid file (such as a PDF that is not a valid PDF, Word Document that is not a valid Word Document, etc.), which can be a significant risk factor.</param>
        /// <param name="ContainsScript">True if the scan contained a script (such as a PHP script, Python script, etc.) which can be a significant risk factor.</param>
        /// <param name="ContainsRestrictedFileFormat">True if the uploaded file is of a type that is not allowed based on the optional restrictFileTypes parameter, false otherwise; if restrictFileTypes is not set, this will always be false.</param>
        /// <param name="VerifiedFileFormat">For file format verification-supported file formats, the contents-verified file format of the file.  Null indicates that the file format is not supported for contents verification.  If a Virus or Malware is found, this field will always be set to Null..</param>
        /// <param name="FoundViruses">Array of viruses found, if any.</param>
        public VirusScanAdvancedResult(bool? CleanResult = default(bool?), bool? ContainsExecutable = default(bool?), bool? ContainsInvalidFile = default(bool?), bool? ContainsScript = default(bool?), bool? ContainsRestrictedFileFormat = default(bool?), string VerifiedFileFormat = default(string), List<VirusFound> FoundViruses = default(List<VirusFound>))
        {
            this.CleanResult = CleanResult;
            this.ContainsExecutable = ContainsExecutable;
            this.ContainsInvalidFile = ContainsInvalidFile;
            this.ContainsScript = ContainsScript;
            this.ContainsRestrictedFileFormat = ContainsRestrictedFileFormat;
            this.VerifiedFileFormat = VerifiedFileFormat;
            this.FoundViruses = FoundViruses;
        }
        
        /// <summary>
        /// True if the scan contained no viruses, false otherwise
        /// </summary>
        /// <value>True if the scan contained no viruses, false otherwise</value>
        [DataMember(Name="CleanResult", EmitDefaultValue=false)]
        public bool? CleanResult { get; set; }

        /// <summary>
        /// True if the scan contained an executable (application code), which can be a significant risk factor
        /// </summary>
        /// <value>True if the scan contained an executable (application code), which can be a significant risk factor</value>
        [DataMember(Name="ContainsExecutable", EmitDefaultValue=false)]
        public bool? ContainsExecutable { get; set; }

        /// <summary>
        /// True if the scan contained an invalid file (such as a PDF that is not a valid PDF, Word Document that is not a valid Word Document, etc.), which can be a significant risk factor
        /// </summary>
        /// <value>True if the scan contained an invalid file (such as a PDF that is not a valid PDF, Word Document that is not a valid Word Document, etc.), which can be a significant risk factor</value>
        [DataMember(Name="ContainsInvalidFile", EmitDefaultValue=false)]
        public bool? ContainsInvalidFile { get; set; }

        /// <summary>
        /// True if the scan contained a script (such as a PHP script, Python script, etc.) which can be a significant risk factor
        /// </summary>
        /// <value>True if the scan contained a script (such as a PHP script, Python script, etc.) which can be a significant risk factor</value>
        [DataMember(Name="ContainsScript", EmitDefaultValue=false)]
        public bool? ContainsScript { get; set; }

        /// <summary>
        /// True if the uploaded file is of a type that is not allowed based on the optional restrictFileTypes parameter, false otherwise; if restrictFileTypes is not set, this will always be false
        /// </summary>
        /// <value>True if the uploaded file is of a type that is not allowed based on the optional restrictFileTypes parameter, false otherwise; if restrictFileTypes is not set, this will always be false</value>
        [DataMember(Name="ContainsRestrictedFileFormat", EmitDefaultValue=false)]
        public bool? ContainsRestrictedFileFormat { get; set; }

        /// <summary>
        /// For file format verification-supported file formats, the contents-verified file format of the file.  Null indicates that the file format is not supported for contents verification.  If a Virus or Malware is found, this field will always be set to Null.
        /// </summary>
        /// <value>For file format verification-supported file formats, the contents-verified file format of the file.  Null indicates that the file format is not supported for contents verification.  If a Virus or Malware is found, this field will always be set to Null.</value>
        [DataMember(Name="VerifiedFileFormat", EmitDefaultValue=false)]
        public string VerifiedFileFormat { get; set; }

        /// <summary>
        /// Array of viruses found, if any
        /// </summary>
        /// <value>Array of viruses found, if any</value>
        [DataMember(Name="FoundViruses", EmitDefaultValue=false)]
        public List<VirusFound> FoundViruses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirusScanAdvancedResult {\n");
            sb.Append("  CleanResult: ").Append(CleanResult).Append("\n");
            sb.Append("  ContainsExecutable: ").Append(ContainsExecutable).Append("\n");
            sb.Append("  ContainsInvalidFile: ").Append(ContainsInvalidFile).Append("\n");
            sb.Append("  ContainsScript: ").Append(ContainsScript).Append("\n");
            sb.Append("  ContainsRestrictedFileFormat: ").Append(ContainsRestrictedFileFormat).Append("\n");
            sb.Append("  VerifiedFileFormat: ").Append(VerifiedFileFormat).Append("\n");
            sb.Append("  FoundViruses: ").Append(FoundViruses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as VirusScanAdvancedResult);
        }

        /// <summary>
        /// Returns true if VirusScanAdvancedResult instances are equal
        /// </summary>
        /// <param name="input">Instance of VirusScanAdvancedResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VirusScanAdvancedResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CleanResult == input.CleanResult ||
                    (this.CleanResult != null &&
                    this.CleanResult.Equals(input.CleanResult))
                ) && 
                (
                    this.ContainsExecutable == input.ContainsExecutable ||
                    (this.ContainsExecutable != null &&
                    this.ContainsExecutable.Equals(input.ContainsExecutable))
                ) && 
                (
                    this.ContainsInvalidFile == input.ContainsInvalidFile ||
                    (this.ContainsInvalidFile != null &&
                    this.ContainsInvalidFile.Equals(input.ContainsInvalidFile))
                ) && 
                (
                    this.ContainsScript == input.ContainsScript ||
                    (this.ContainsScript != null &&
                    this.ContainsScript.Equals(input.ContainsScript))
                ) && 
                (
                    this.ContainsRestrictedFileFormat == input.ContainsRestrictedFileFormat ||
                    (this.ContainsRestrictedFileFormat != null &&
                    this.ContainsRestrictedFileFormat.Equals(input.ContainsRestrictedFileFormat))
                ) && 
                (
                    this.VerifiedFileFormat == input.VerifiedFileFormat ||
                    (this.VerifiedFileFormat != null &&
                    this.VerifiedFileFormat.Equals(input.VerifiedFileFormat))
                ) && 
                (
                    this.FoundViruses == input.FoundViruses ||
                    this.FoundViruses != null &&
                    this.FoundViruses.SequenceEqual(input.FoundViruses)
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
                if (this.CleanResult != null)
                    hashCode = hashCode * 59 + this.CleanResult.GetHashCode();
                if (this.ContainsExecutable != null)
                    hashCode = hashCode * 59 + this.ContainsExecutable.GetHashCode();
                if (this.ContainsInvalidFile != null)
                    hashCode = hashCode * 59 + this.ContainsInvalidFile.GetHashCode();
                if (this.ContainsScript != null)
                    hashCode = hashCode * 59 + this.ContainsScript.GetHashCode();
                if (this.ContainsRestrictedFileFormat != null)
                    hashCode = hashCode * 59 + this.ContainsRestrictedFileFormat.GetHashCode();
                if (this.VerifiedFileFormat != null)
                    hashCode = hashCode * 59 + this.VerifiedFileFormat.GetHashCode();
                if (this.FoundViruses != null)
                    hashCode = hashCode * 59 + this.FoundViruses.GetHashCode();
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