/*
 * virusapi
 *
 * The Cloudmersive Virus Scan API lets you scan files and content for viruses and identify security issues with content.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Cloudmersive.APIClient.NETCore.VirusScan.Client.OpenAPIDateConverter;

namespace Cloudmersive.APIClient.NETCore.VirusScan.Model
{
    /// <summary>
    /// Request to scan a website for malicious content
    /// </summary>
    [DataContract(Name = "WebsiteScanRequest")]
    public partial class WebsiteScanRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteScanRequest" /> class.
        /// </summary>
        /// <param name="url">URL of the website to scan; should begin with http:// or https://.</param>
        public WebsiteScanRequest(string url = default(string))
        {
            this.Url = url;
        }

        /// <summary>
        /// URL of the website to scan; should begin with http:// or https://
        /// </summary>
        /// <value>URL of the website to scan; should begin with http:// or https://</value>
        [DataMember(Name = "Url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebsiteScanRequest {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
