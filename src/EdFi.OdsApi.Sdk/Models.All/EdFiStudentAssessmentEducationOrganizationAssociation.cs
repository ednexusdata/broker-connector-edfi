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
    /// EdFiStudentAssessmentEducationOrganizationAssociation
    /// </summary>
    [DataContract(Name = "edFi_studentAssessmentEducationOrganizationAssociation")]
    public partial class EdFiStudentAssessmentEducationOrganizationAssociation : IEquatable<EdFiStudentAssessmentEducationOrganizationAssociation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentEducationOrganizationAssociation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentAssessmentEducationOrganizationAssociation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentAssessmentEducationOrganizationAssociation" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="educationOrganizationAssociationTypeDescriptor">The type of association being represented. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference.</param>
        /// <param name="studentAssessmentReference">studentAssessmentReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiStudentAssessmentEducationOrganizationAssociation(string id = default(string), string educationOrganizationAssociationTypeDescriptor = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference), EdFiStudentAssessmentReference studentAssessmentReference = default(EdFiStudentAssessmentReference), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "educationOrganizationAssociationTypeDescriptor" is required (not null)
            if (educationOrganizationAssociationTypeDescriptor == null)
            {
                throw new ArgumentNullException("educationOrganizationAssociationTypeDescriptor is a required property for EdFiStudentAssessmentEducationOrganizationAssociation and cannot be null");
            }
            this.EducationOrganizationAssociationTypeDescriptor = educationOrganizationAssociationTypeDescriptor;
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new ArgumentNullException("educationOrganizationReference is a required property for EdFiStudentAssessmentEducationOrganizationAssociation and cannot be null");
            }
            this.EducationOrganizationReference = educationOrganizationReference;
            // to ensure "studentAssessmentReference" is required (not null)
            if (studentAssessmentReference == null)
            {
                throw new ArgumentNullException("studentAssessmentReference is a required property for EdFiStudentAssessmentEducationOrganizationAssociation and cannot be null");
            }
            this.StudentAssessmentReference = studentAssessmentReference;
            this.Id = id;
            this.SchoolYearTypeReference = schoolYearTypeReference;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The type of association being represented.
        /// </summary>
        /// <value>The type of association being represented.</value>
        [DataMember(Name = "educationOrganizationAssociationTypeDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string EducationOrganizationAssociationTypeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name = "educationOrganizationReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name = "schoolYearTypeReference", EmitDefaultValue = false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Gets or Sets StudentAssessmentReference
        /// </summary>
        [DataMember(Name = "studentAssessmentReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiStudentAssessmentReference StudentAssessmentReference { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name = "_etag", EmitDefaultValue = false)]
        public string Etag { get; set; }

        /// <summary>
        /// The date and time the resource was last modified.
        /// </summary>
        /// <value>The date and time the resource was last modified.</value>
        [DataMember(Name = "_lastModifiedDate", EmitDefaultValue = false)]
        public DateTime LastModifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiStudentAssessmentEducationOrganizationAssociation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EducationOrganizationAssociationTypeDescriptor: ").Append(EducationOrganizationAssociationTypeDescriptor).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  StudentAssessmentReference: ").Append(StudentAssessmentReference).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
            sb.Append("  LastModifiedDate: ").Append(LastModifiedDate).Append("\n");
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
            return this.Equals(input as EdFiStudentAssessmentEducationOrganizationAssociation);
        }

        /// <summary>
        /// Returns true if EdFiStudentAssessmentEducationOrganizationAssociation instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentAssessmentEducationOrganizationAssociation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentAssessmentEducationOrganizationAssociation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EducationOrganizationAssociationTypeDescriptor == input.EducationOrganizationAssociationTypeDescriptor ||
                    (this.EducationOrganizationAssociationTypeDescriptor != null &&
                    this.EducationOrganizationAssociationTypeDescriptor.Equals(input.EducationOrganizationAssociationTypeDescriptor))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
                ) && 
                (
                    this.StudentAssessmentReference == input.StudentAssessmentReference ||
                    (this.StudentAssessmentReference != null &&
                    this.StudentAssessmentReference.Equals(input.StudentAssessmentReference))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
                ) && 
                (
                    this.LastModifiedDate == input.LastModifiedDate ||
                    (this.LastModifiedDate != null &&
                    this.LastModifiedDate.Equals(input.LastModifiedDate))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.EducationOrganizationAssociationTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.EducationOrganizationAssociationTypeDescriptor.GetHashCode();
                }
                if (this.EducationOrganizationReference != null)
                {
                    hashCode = (hashCode * 59) + this.EducationOrganizationReference.GetHashCode();
                }
                if (this.SchoolYearTypeReference != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolYearTypeReference.GetHashCode();
                }
                if (this.StudentAssessmentReference != null)
                {
                    hashCode = (hashCode * 59) + this.StudentAssessmentReference.GetHashCode();
                }
                if (this.Etag != null)
                {
                    hashCode = (hashCode * 59) + this.Etag.GetHashCode();
                }
                if (this.LastModifiedDate != null)
                {
                    hashCode = (hashCode * 59) + this.LastModifiedDate.GetHashCode();
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
            // EducationOrganizationAssociationTypeDescriptor (string) maxLength
            if (this.EducationOrganizationAssociationTypeDescriptor != null && this.EducationOrganizationAssociationTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EducationOrganizationAssociationTypeDescriptor, length must be less than 306.", new [] { "EducationOrganizationAssociationTypeDescriptor" });
            }

            yield break;
        }
    }

}