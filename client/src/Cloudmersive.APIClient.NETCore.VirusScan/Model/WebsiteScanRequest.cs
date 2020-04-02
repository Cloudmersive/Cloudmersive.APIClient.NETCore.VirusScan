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
    /// Request to scan a website for malicious content
    /// </summary>
    [DataContract]
    public partial class WebsiteScanRequest :  IEquatable<WebsiteScanRequest>
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
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as WebsiteScanRequest);
        }

        /// <summary>
        /// Returns true if WebsiteScanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebsiteScanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebsiteScanRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }

}
