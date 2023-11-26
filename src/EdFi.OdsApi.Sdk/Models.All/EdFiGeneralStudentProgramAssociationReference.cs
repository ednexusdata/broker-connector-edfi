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
    /// EdFiGeneralStudentProgramAssociationReference
    /// </summary>
    [DataContract(Name = "edFi_generalStudentProgramAssociationReference")]
    public partial class EdFiGeneralStudentProgramAssociationReference : IEquatable<EdFiGeneralStudentProgramAssociationReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGeneralStudentProgramAssociationReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGeneralStudentProgramAssociationReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGeneralStudentProgramAssociationReference" /> class.
        /// </summary>
        /// <param name="beginDate">The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program. (required).</param>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="programEducationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="programName">The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies. (required).</param>
        /// <param name="programTypeDescriptor">The type of program. (required).</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="link">link.</param>
        public EdFiGeneralStudentProgramAssociationReference(DateTime beginDate = default(DateTime), long educationOrganizationId = default(long), long programEducationOrganizationId = default(long), string programName = default(string), string programTypeDescriptor = default(string), string studentUniqueId = default(string), Link link = default(Link))
        {
            this.BeginDate = beginDate;
            this.EducationOrganizationId = educationOrganizationId;
            this.ProgramEducationOrganizationId = programEducationOrganizationId;
            // to ensure "programName" is required (not null)
            if (programName == null)
            {
                throw new ArgumentNullException("programName is a required property for EdFiGeneralStudentProgramAssociationReference and cannot be null");
            }
            this.ProgramName = programName;
            // to ensure "programTypeDescriptor" is required (not null)
            if (programTypeDescriptor == null)
            {
                throw new ArgumentNullException("programTypeDescriptor is a required property for EdFiGeneralStudentProgramAssociationReference and cannot be null");
            }
            this.ProgramTypeDescriptor = programTypeDescriptor;
            // to ensure "studentUniqueId" is required (not null)
            if (studentUniqueId == null)
            {
                throw new ArgumentNullException("studentUniqueId is a required property for EdFiGeneralStudentProgramAssociationReference and cannot be null");
            }
            this.StudentUniqueId = studentUniqueId;
            this.Link = link;
        }

        /// <summary>
        /// The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.
        /// </summary>
        /// <value>The earliest date the student is involved with the program. Typically, this is the date the student becomes eligible for the program.</value>
        [DataMember(Name = "beginDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime BeginDate { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "educationOrganizationId", IsRequired = true, EmitDefaultValue = true)]
        public long EducationOrganizationId { get; set; }

        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name = "programEducationOrganizationId", IsRequired = true, EmitDefaultValue = true)]
        public long ProgramEducationOrganizationId { get; set; }

        /// <summary>
        /// The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.
        /// </summary>
        /// <value>The formal name of the program of instruction, training, services, or benefits available through federal, state, or local agencies.</value>
        [DataMember(Name = "programName", IsRequired = true, EmitDefaultValue = true)]
        public string ProgramName { get; set; }

        /// <summary>
        /// The type of program.
        /// </summary>
        /// <value>The type of program.</value>
        [DataMember(Name = "programTypeDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string ProgramTypeDescriptor { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name = "studentUniqueId", IsRequired = true, EmitDefaultValue = true)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EdFiGeneralStudentProgramAssociationReference {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  ProgramEducationOrganizationId: ").Append(ProgramEducationOrganizationId).Append("\n");
            sb.Append("  ProgramName: ").Append(ProgramName).Append("\n");
            sb.Append("  ProgramTypeDescriptor: ").Append(ProgramTypeDescriptor).Append("\n");
            sb.Append("  StudentUniqueId: ").Append(StudentUniqueId).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
            return this.Equals(input as EdFiGeneralStudentProgramAssociationReference);
        }

        /// <summary>
        /// Returns true if EdFiGeneralStudentProgramAssociationReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGeneralStudentProgramAssociationReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGeneralStudentProgramAssociationReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId)
                ) && 
                (
                    this.ProgramEducationOrganizationId == input.ProgramEducationOrganizationId ||
                    this.ProgramEducationOrganizationId.Equals(input.ProgramEducationOrganizationId)
                ) && 
                (
                    this.ProgramName == input.ProgramName ||
                    (this.ProgramName != null &&
                    this.ProgramName.Equals(input.ProgramName))
                ) && 
                (
                    this.ProgramTypeDescriptor == input.ProgramTypeDescriptor ||
                    (this.ProgramTypeDescriptor != null &&
                    this.ProgramTypeDescriptor.Equals(input.ProgramTypeDescriptor))
                ) && 
                (
                    this.StudentUniqueId == input.StudentUniqueId ||
                    (this.StudentUniqueId != null &&
                    this.StudentUniqueId.Equals(input.StudentUniqueId))
                ) && 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
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
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EducationOrganizationId.GetHashCode();
                hashCode = (hashCode * 59) + this.ProgramEducationOrganizationId.GetHashCode();
                if (this.ProgramName != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramName.GetHashCode();
                }
                if (this.ProgramTypeDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.ProgramTypeDescriptor.GetHashCode();
                }
                if (this.StudentUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.StudentUniqueId.GetHashCode();
                }
                if (this.Link != null)
                {
                    hashCode = (hashCode * 59) + this.Link.GetHashCode();
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
            // ProgramName (string) maxLength
            if (this.ProgramName != null && this.ProgramName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramName, length must be less than 60.", new [] { "ProgramName" });
            }

            // ProgramName (string) minLength
            if (this.ProgramName != null && this.ProgramName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramName, length must be greater than 1.", new [] { "ProgramName" });
            }

            // ProgramTypeDescriptor (string) maxLength
            if (this.ProgramTypeDescriptor != null && this.ProgramTypeDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProgramTypeDescriptor, length must be less than 306.", new [] { "ProgramTypeDescriptor" });
            }

            // StudentUniqueId (string) maxLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length > 32)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be less than 32.", new [] { "StudentUniqueId" });
            }

            // StudentUniqueId (string) minLength
            if (this.StudentUniqueId != null && this.StudentUniqueId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StudentUniqueId, length must be greater than 1.", new [] { "StudentUniqueId" });
            }

            yield break;
        }
    }

}