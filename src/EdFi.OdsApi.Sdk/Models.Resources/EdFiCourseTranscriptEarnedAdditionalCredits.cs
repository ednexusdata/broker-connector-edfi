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
    /// EdFiCourseTranscriptEarnedAdditionalCredits
    /// </summary>
    [DataContract]
    public partial class EdFiCourseTranscriptEarnedAdditionalCredits :  IEquatable<EdFiCourseTranscriptEarnedAdditionalCredits>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseTranscriptEarnedAdditionalCredits" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCourseTranscriptEarnedAdditionalCredits() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCourseTranscriptEarnedAdditionalCredits" /> class.
        /// </summary>
        /// <param name="additionalCreditTypeDescriptor">The type of credits or units of value awarded for the completion of a course. (required).</param>
        /// <param name="credits">The value of credits or units of value awarded for the completion of a course (required).</param>
        public EdFiCourseTranscriptEarnedAdditionalCredits(string additionalCreditTypeDescriptor = default(string), double? credits = default(double?))
        {
            // to ensure "additionalCreditTypeDescriptor" is required (not null)
            if (additionalCreditTypeDescriptor == null)
            {
                throw new InvalidDataException("additionalCreditTypeDescriptor is a required property for EdFiCourseTranscriptEarnedAdditionalCredits and cannot be null");
            }
            else
            {
                this.AdditionalCreditTypeDescriptor = additionalCreditTypeDescriptor;
            }
            // to ensure "credits" is required (not null)
            if (credits == null)
            {
                throw new InvalidDataException("credits is a required property for EdFiCourseTranscriptEarnedAdditionalCredits and cannot be null");
            }
            else
            {
                this.Credits = credits;
            }
        }
        
        /// <summary>
        /// The type of credits or units of value awarded for the completion of a course.
        /// </summary>
        /// <value>The type of credits or units of value awarded for the completion of a course.</value>
        [DataMember(Name="additionalCreditTypeDescriptor", EmitDefaultValue=false)]
        public string AdditionalCreditTypeDescriptor { get; set; }

        /// <summary>
        /// The value of credits or units of value awarded for the completion of a course
        /// </summary>
        /// <value>The value of credits or units of value awarded for the completion of a course</value>
        [DataMember(Name="credits", EmitDefaultValue=false)]
        public double? Credits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiCourseTranscriptEarnedAdditionalCredits {\n");
            sb.Append("  AdditionalCreditTypeDescriptor: ").Append(AdditionalCreditTypeDescriptor).Append("\n");
            sb.Append("  Credits: ").Append(Credits).Append("\n");
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
            return this.Equals(input as EdFiCourseTranscriptEarnedAdditionalCredits);
        }

        /// <summary>
        /// Returns true if EdFiCourseTranscriptEarnedAdditionalCredits instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCourseTranscriptEarnedAdditionalCredits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCourseTranscriptEarnedAdditionalCredits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdditionalCreditTypeDescriptor == input.AdditionalCreditTypeDescriptor ||
                    (this.AdditionalCreditTypeDescriptor != null &&
                    this.AdditionalCreditTypeDescriptor.Equals(input.AdditionalCreditTypeDescriptor))
                ) && 
                (
                    this.Credits == input.Credits ||
                    (this.Credits != null &&
                    this.Credits.Equals(input.Credits))
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
                if (this.AdditionalCreditTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.AdditionalCreditTypeDescriptor.GetHashCode();
                if (this.Credits != null)
                    hashCode = hashCode * 59 + this.Credits.GetHashCode();
                return hashCode;
            }
        }
    }

}