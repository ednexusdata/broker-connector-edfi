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
    /// EdFiStudentLearningObjectiveReference
    /// </summary>
    [DataContract]
    public partial class EdFiStudentLearningObjectiveReference :  IEquatable<EdFiStudentLearningObjectiveReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLearningObjectiveReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiStudentLearningObjectiveReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiStudentLearningObjectiveReference" /> class.
        /// </summary>
        /// <param name="gradingPeriodDescriptor">The name of the period for which grades are reported. (required).</param>
        /// <param name="gradingPeriodSchoolId">The identifier assigned to a school. (required).</param>
        /// <param name="gradingPeriodSchoolYear">The identifier for the grading period school year. (required).</param>
        /// <param name="gradingPeriodSequence">The sequential order of this period relative to other periods. (required).</param>
        /// <param name="learningObjectiveId">The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A). (required).</param>
        /// <param name="_namespace">Namespace for the LearningObjective. (required).</param>
        /// <param name="studentUniqueId">A unique alphanumeric code assigned to a student. (required).</param>
        /// <param name="link">link.</param>
        public EdFiStudentLearningObjectiveReference(string gradingPeriodDescriptor = default(string), int? gradingPeriodSchoolId = default(int?), int? gradingPeriodSchoolYear = default(int?), int? gradingPeriodSequence = default(int?), string learningObjectiveId = default(string), string _namespace = default(string), string studentUniqueId = default(string), Link link = default(Link))
        {
            // to ensure "gradingPeriodDescriptor" is required (not null)
            if (gradingPeriodDescriptor == null)
            {
                throw new InvalidDataException("gradingPeriodDescriptor is a required property for EdFiStudentLearningObjectiveReference and cannot be null");
            }
            else
            {
                this.GradingPeriodDescriptor = gradingPeriodDescriptor;
            }
            // to ensure "gradingPeriodSchoolId" is required (not null)
            if (gradingPeriodSchoolId == null)
            {
                throw new InvalidDataException("gradingPeriodSchoolId is a required property for EdFiStudentLearningObjectiveReference and cannot be null");
            }
            else
            {
                this.GradingPeriodSchoolId = gradingPeriodSchoolId;
            }
            // to ensure "gradingPeriodSchoolYear" is required (not null)
            if (gradingPeriodSchoolYear == null)
            {
                throw new InvalidDataException("gradingPeriodSchoolYear is a required property for EdFiStudentLearningObjectiveReference and cannot be null");
            }
            else
            {
                this.GradingPeriodSchoolYear = gradingPeriodSchoolYear;
            }
            // to ensure "gradingPeriodSequence" is required (not null)
            if (gradingPeriodSequence == null)
            {
                throw new InvalidDataException("gradingPeriodSequence is a required property for EdFiStudentLearningObjectiveReference and cannot be null");
            }
            else
            {
                this.GradingPeriodSequence = gradingPeriodSequence;
            }
            // to ensure "learningObjectiveId" is required (not null)
            if (learningObjectiveId == null)
            {
                throw new InvalidDataException("learningObjectiveId is a required property for EdFiStudentLearningObjectiveReference and cannot be null");
            }
            else
            {
                this.LearningObjectiveId = learningObjectiveId;
            }
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for EdFiStudentLearningObjectiveReference and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }
            // to ensure "studentUniqueId" is required (not null)
            if (studentUniqueId == null)
            {
                throw new InvalidDataException("studentUniqueId is a required property for EdFiStudentLearningObjectiveReference and cannot be null");
            }
            else
            {
                this.StudentUniqueId = studentUniqueId;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The name of the period for which grades are reported.
        /// </summary>
        /// <value>The name of the period for which grades are reported.</value>
        [DataMember(Name="gradingPeriodDescriptor", EmitDefaultValue=false)]
        public string GradingPeriodDescriptor { get; set; }

        /// <summary>
        /// The identifier assigned to a school.
        /// </summary>
        /// <value>The identifier assigned to a school.</value>
        [DataMember(Name="gradingPeriodSchoolId", EmitDefaultValue=false)]
        public int? GradingPeriodSchoolId { get; set; }

        /// <summary>
        /// The identifier for the grading period school year.
        /// </summary>
        /// <value>The identifier for the grading period school year.</value>
        [DataMember(Name="gradingPeriodSchoolYear", EmitDefaultValue=false)]
        public int? GradingPeriodSchoolYear { get; set; }

        /// <summary>
        /// The sequential order of this period relative to other periods.
        /// </summary>
        /// <value>The sequential order of this period relative to other periods.</value>
        [DataMember(Name="gradingPeriodSequence", EmitDefaultValue=false)]
        public int? GradingPeriodSequence { get; set; }

        /// <summary>
        /// The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A).
        /// </summary>
        /// <value>The identifier for the specific learning objective in the context of a standard (e.g., 111.15.3.1.A).</value>
        [DataMember(Name="learningObjectiveId", EmitDefaultValue=false)]
        public string LearningObjectiveId { get; set; }

        /// <summary>
        /// Namespace for the LearningObjective.
        /// </summary>
        /// <value>Namespace for the LearningObjective.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// A unique alphanumeric code assigned to a student.
        /// </summary>
        /// <value>A unique alphanumeric code assigned to a student.</value>
        [DataMember(Name="studentUniqueId", EmitDefaultValue=false)]
        public string StudentUniqueId { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=false)]
        public Link Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiStudentLearningObjectiveReference {\n");
            sb.Append("  GradingPeriodDescriptor: ").Append(GradingPeriodDescriptor).Append("\n");
            sb.Append("  GradingPeriodSchoolId: ").Append(GradingPeriodSchoolId).Append("\n");
            sb.Append("  GradingPeriodSchoolYear: ").Append(GradingPeriodSchoolYear).Append("\n");
            sb.Append("  GradingPeriodSequence: ").Append(GradingPeriodSequence).Append("\n");
            sb.Append("  LearningObjectiveId: ").Append(LearningObjectiveId).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EdFiStudentLearningObjectiveReference);
        }

        /// <summary>
        /// Returns true if EdFiStudentLearningObjectiveReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiStudentLearningObjectiveReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiStudentLearningObjectiveReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GradingPeriodDescriptor == input.GradingPeriodDescriptor ||
                    (this.GradingPeriodDescriptor != null &&
                    this.GradingPeriodDescriptor.Equals(input.GradingPeriodDescriptor))
                ) && 
                (
                    this.GradingPeriodSchoolId == input.GradingPeriodSchoolId ||
                    (this.GradingPeriodSchoolId != null &&
                    this.GradingPeriodSchoolId.Equals(input.GradingPeriodSchoolId))
                ) && 
                (
                    this.GradingPeriodSchoolYear == input.GradingPeriodSchoolYear ||
                    (this.GradingPeriodSchoolYear != null &&
                    this.GradingPeriodSchoolYear.Equals(input.GradingPeriodSchoolYear))
                ) && 
                (
                    this.GradingPeriodSequence == input.GradingPeriodSequence ||
                    (this.GradingPeriodSequence != null &&
                    this.GradingPeriodSequence.Equals(input.GradingPeriodSequence))
                ) && 
                (
                    this.LearningObjectiveId == input.LearningObjectiveId ||
                    (this.LearningObjectiveId != null &&
                    this.LearningObjectiveId.Equals(input.LearningObjectiveId))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
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
                if (this.GradingPeriodDescriptor != null)
                    hashCode = hashCode * 59 + this.GradingPeriodDescriptor.GetHashCode();
                if (this.GradingPeriodSchoolId != null)
                    hashCode = hashCode * 59 + this.GradingPeriodSchoolId.GetHashCode();
                if (this.GradingPeriodSchoolYear != null)
                    hashCode = hashCode * 59 + this.GradingPeriodSchoolYear.GetHashCode();
                if (this.GradingPeriodSequence != null)
                    hashCode = hashCode * 59 + this.GradingPeriodSequence.GetHashCode();
                if (this.LearningObjectiveId != null)
                    hashCode = hashCode * 59 + this.LearningObjectiveId.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.StudentUniqueId != null)
                    hashCode = hashCode * 59 + this.StudentUniqueId.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}