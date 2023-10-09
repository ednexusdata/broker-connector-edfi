/* 
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * OpenAPI spec version: 3
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
using SwaggerDateConverter = EdFi.OdsApi.Sdk.Client.SwaggerDateConverter;

namespace EdFi.OdsApi.Sdk.Models.Resources
{
    /// <summary>
    /// TpdmApplicantLanguage
    /// </summary>
    [DataContract]
    public partial class TpdmApplicantLanguage :  IEquatable<TpdmApplicantLanguage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicantLanguage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmApplicantLanguage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicantLanguage" /> class.
        /// </summary>
        /// <param name="languageDescriptor">A specification of which written or spoken communication is being used. (required).</param>
        /// <param name="uses">An unordered collection of applicantLanguageUses. A description of how the language is used (e.g. Home Language, Native Language, Spoken Language)..</param>
        public TpdmApplicantLanguage(string languageDescriptor = default(string), List<TpdmApplicantLanguageUse> uses = default(List<TpdmApplicantLanguageUse>))
        {
            // to ensure "languageDescriptor" is required (not null)
            if (languageDescriptor == null)
            {
                throw new InvalidDataException("languageDescriptor is a required property for TpdmApplicantLanguage and cannot be null");
            }
            else
            {
                this.LanguageDescriptor = languageDescriptor;
            }
            this.Uses = uses;
        }
        
        /// <summary>
        /// A specification of which written or spoken communication is being used.
        /// </summary>
        /// <value>A specification of which written or spoken communication is being used.</value>
        [DataMember(Name="languageDescriptor", EmitDefaultValue=false)]
        public string LanguageDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of applicantLanguageUses. A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).
        /// </summary>
        /// <value>An unordered collection of applicantLanguageUses. A description of how the language is used (e.g. Home Language, Native Language, Spoken Language).</value>
        [DataMember(Name="uses", EmitDefaultValue=false)]
        public List<TpdmApplicantLanguageUse> Uses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmApplicantLanguage {\n");
            sb.Append("  LanguageDescriptor: ").Append(LanguageDescriptor).Append("\n");
            sb.Append("  Uses: ").Append(Uses).Append("\n");
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
            return this.Equals(input as TpdmApplicantLanguage);
        }

        /// <summary>
        /// Returns true if TpdmApplicantLanguage instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmApplicantLanguage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmApplicantLanguage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LanguageDescriptor == input.LanguageDescriptor ||
                    (this.LanguageDescriptor != null &&
                    this.LanguageDescriptor.Equals(input.LanguageDescriptor))
                ) && 
                (
                    this.Uses == input.Uses ||
                    this.Uses != null &&
                    this.Uses.SequenceEqual(input.Uses)
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
                if (this.LanguageDescriptor != null)
                    hashCode = hashCode * 59 + this.LanguageDescriptor.GetHashCode();
                if (this.Uses != null)
                    hashCode = hashCode * 59 + this.Uses.GetHashCode();
                return hashCode;
            }
        }
    }

}