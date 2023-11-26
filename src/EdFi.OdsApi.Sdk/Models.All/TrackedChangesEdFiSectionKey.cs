/*
 * Ed-Fi Operational Data Store API
 *
 * The Ed-Fi ODS / API enables applications to read and write education data stored in an Ed-Fi ODS through a secure REST interface.  ***  > *Note: Consumers of ODS / API information should sanitize all data for display and storage. The ODS / API provides reasonable safeguards against cross-site scripting attacks and other malicious content, but the platform does not and cannot guarantee that the data it contains is free of all potentially harmful content.*  *** 
 *
 * The version of the OpenAPI document: 3
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
using OpenAPIDateConverter = EdFi.OdsApi.Sdk.Client.OpenAPIDateConverter;

namespace EdFi.OdsApi.Sdk.Models.All
{
    /// <summary>
    /// TrackedChangesEdFiSectionKey
    /// </summary>
    [DataContract(Name = "trackedChanges_edFi_sectionKey")]
    public partial class TrackedChangesEdFiSectionKey : IEquatable<TrackedChangesEdFiSectionKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedChangesEdFiSectionKey" /> class.
        /// </summary>
        /// <param name="sectionIdentifier">The local identifier assigned to a section..</param>
        /// <param name="localCourseCode">The local code assigned by the School that identifies the course offering provided for the instruction of students..</param>
        /// <param name="schoolId">The identifier assigned to a school..</param>
        /// <param name="schoolYear">The identifier for the school year..</param>
        /// <param name="sessionName">The identifier for the calendar for the academic session..</param>
        public TrackedChangesEdFiSectionKey(string sectionIdentifier = default(string), string localCourseCode = default(string), long schoolId = default(long), int schoolYear = default(int), string sessionName = default(string))
        {
            this.SectionIdentifier = sectionIdentifier;
            this.LocalCourseCode = localCourseCode;
            this.SchoolId = schoolId;
            this.SchoolYear = schoolYear;
            this.SessionName = sessionName;
        }

        /// <summary>
        /// The local identifier assigned to a section.
        /// </summary>
        /// <value>The local identifier assigned to a section.</value>
        [DataMember(Name = "sectionIdentifier", EmitDefaultValue = false)]
        public string SectionIdentifier { get; set; }

        /// <summary>
        /// The local code assigned by the School that identifies the course offering provided for the instruction of students.
        /// </summary>
        /// <value>The local code assigned by the School that identifies the course offering provided for the instruction of students.</value>
        [DataMember(Name = "localCourseCode", EmitDefaultValue = false)]
        public string LocalCourseCode { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name = "schoolId", EmitDefaultValue = false)]
        public long SchoolId { get; set; }

        /// <summary>
        /// The identifier for the school year.
        /// </summary>
        /// <value>The identifier for the school year.</value>
        [DataMember(Name = "schoolYear", EmitDefaultValue = false)]
        public int SchoolYear { get; set; }

        /// <summary>
        /// The identifier for the calendar for the academic session.
        /// </summary>
        /// <value>The identifier for the calendar for the academic session.</value>
        [DataMember(Name = "sessionName", EmitDefaultValue = false)]
        public string SessionName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedChangesEdFiSectionKey {\n");
            sb.Append("  SectionIdentifier: ").Append(SectionIdentifier).Append("\n");
            sb.Append("  LocalCourseCode: ").Append(LocalCourseCode).Append("\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  SchoolYear: ").Append(SchoolYear).Append("\n");
            sb.Append("  SessionName: ").Append(SessionName).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrackedChangesEdFiSectionKey);
        }

        /// <summary>
        /// Returns true if TrackedChangesEdFiSectionKey instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackedChangesEdFiSectionKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackedChangesEdFiSectionKey input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SectionIdentifier == input.SectionIdentifier ||
                    (this.SectionIdentifier != null &&
                    this.SectionIdentifier.Equals(input.SectionIdentifier))
                ) && 
                (
                    this.LocalCourseCode == input.LocalCourseCode ||
                    (this.LocalCourseCode != null &&
                    this.LocalCourseCode.Equals(input.LocalCourseCode))
                ) && 
                (
                    this.SchoolId == input.SchoolId ||
                    this.SchoolId.Equals(input.SchoolId)
                ) && 
                (
                    this.SchoolYear == input.SchoolYear ||
                    this.SchoolYear.Equals(input.SchoolYear)
                ) && 
                (
                    this.SessionName == input.SessionName ||
                    (this.SessionName != null &&
                    this.SessionName.Equals(input.SessionName))
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
                if (this.SectionIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.SectionIdentifier.GetHashCode();
                }
                if (this.LocalCourseCode != null)
                {
                    hashCode = (hashCode * 59) + this.LocalCourseCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SchoolId.GetHashCode();
                hashCode = (hashCode * 59) + this.SchoolYear.GetHashCode();
                if (this.SessionName != null)
                {
                    hashCode = (hashCode * 59) + this.SessionName.GetHashCode();
                }
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
            // SectionIdentifier (string) maxLength
            if (this.SectionIdentifier != null && this.SectionIdentifier.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionIdentifier, length must be less than 255.", new [] { "SectionIdentifier" });
            }

            // SectionIdentifier (string) minLength
            if (this.SectionIdentifier != null && this.SectionIdentifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SectionIdentifier, length must be greater than 1.", new [] { "SectionIdentifier" });
            }

            // LocalCourseCode (string) maxLength
            if (this.LocalCourseCode != null && this.LocalCourseCode.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalCourseCode, length must be less than 60.", new [] { "LocalCourseCode" });
            }

            // LocalCourseCode (string) minLength
            if (this.LocalCourseCode != null && this.LocalCourseCode.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LocalCourseCode, length must be greater than 1.", new [] { "LocalCourseCode" });
            }

            // SessionName (string) maxLength
            if (this.SessionName != null && this.SessionName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionName, length must be less than 60.", new [] { "SessionName" });
            }

            // SessionName (string) minLength
            if (this.SessionName != null && this.SessionName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SessionName, length must be greater than 1.", new [] { "SessionName" });
            }

            yield break;
        }
    }

}