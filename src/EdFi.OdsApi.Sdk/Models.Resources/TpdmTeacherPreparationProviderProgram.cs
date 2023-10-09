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
    /// TpdmTeacherPreparationProviderProgram
    /// </summary>
    [DataContract]
    public partial class TpdmTeacherPreparationProviderProgram :  IEquatable<TpdmTeacherPreparationProviderProgram>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherPreparationProviderProgram" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmTeacherPreparationProviderProgram() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherPreparationProviderProgram" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="programName">The name of the Teacher Preparation Program. (required).</param>
        /// <param name="programTypeDescriptor">The type of program. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference (required).</param>
        /// <param name="gradeLevels">An unordered collection of teacherPreparationProviderProgramGradeLevels. The grade levels served at the TPP Program..</param>
        /// <param name="majorSpecialization">The major area for a degree or area of specialization for a certificate..</param>
        /// <param name="minorSpecialization">The minor area for a degree or area of specialization for a certificate..</param>
        /// <param name="programId">A unique number or alphanumeric code assigned to a program by a school, school system, a state, or other agency or entity..</param>
        /// <param name="teacherPreparationProgramTypeDescriptor">The descriptor holds the type of teacher prep program (e.g., college, alternative, TFA, etc.)..</param>
        /// <param name="tppProgramPathwayDescriptor">A code for describing the program pathway, for example: Residency, Internship, Traditional.</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmTeacherPreparationProviderProgram(string id = default(string), string programName = default(string), string programTypeDescriptor = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), List<TpdmTeacherPreparationProviderProgramGradeLevel> gradeLevels = default(List<TpdmTeacherPreparationProviderProgramGradeLevel>), string majorSpecialization = default(string), string minorSpecialization = default(string), string programId = default(string), string teacherPreparationProgramTypeDescriptor = default(string), string tppProgramPathwayDescriptor = default(string), string etag = default(string))
        {
            // to ensure "programName" is required (not null)
            if (programName == null)
            {
                throw new InvalidDataException("programName is a required property for TpdmTeacherPreparationProviderProgram and cannot be null");
            }
            else
            {
                this.ProgramName = programName;
            }
            // to ensure "programTypeDescriptor" is required (not null)
            if (programTypeDescriptor == null)
            {
                throw new InvalidDataException("programTypeDescriptor is a required property for TpdmTeacherPreparationProviderProgram and cannot be null");
            }
            else
            {
                this.ProgramTypeDescriptor = programTypeDescriptor;
            }
            // to ensure "educationOrganizationReference" is required (not null)
            if (educationOrganizationReference == null)
            {
                throw new InvalidDataException("educationOrganizationReference is a required property for TpdmTeacherPreparationProviderProgram and cannot be null");
            }
            else
            {
                this.EducationOrganizationReference = educationOrganizationReference;
            }
            this.Id = id;
            this.GradeLevels = gradeLevels;
            this.MajorSpecialization = majorSpecialization;
            this.MinorSpecialization = minorSpecialization;
            this.ProgramId = programId;
            this.TeacherPreparationProgramTypeDescriptor = teacherPreparationProgramTypeDescriptor;
            this.TppProgramPathwayDescriptor = tppProgramPathwayDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the Teacher Preparation Program.
        /// </summary>
        /// <value>The name of the Teacher Preparation Program.</value>
        [DataMember(Name="programName", EmitDefaultValue=false)]
        public string ProgramName { get; set; }

        /// <summary>
        /// The type of program.
        /// </summary>
        /// <value>The type of program.</value>
        [DataMember(Name="programTypeDescriptor", EmitDefaultValue=false)]
        public string ProgramTypeDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// An unordered collection of teacherPreparationProviderProgramGradeLevels. The grade levels served at the TPP Program.
        /// </summary>
        /// <value>An unordered collection of teacherPreparationProviderProgramGradeLevels. The grade levels served at the TPP Program.</value>
        [DataMember(Name="gradeLevels", EmitDefaultValue=false)]
        public List<TpdmTeacherPreparationProviderProgramGradeLevel> GradeLevels { get; set; }

        /// <summary>
        /// The major area for a degree or area of specialization for a certificate.
        /// </summary>
        /// <value>The major area for a degree or area of specialization for a certificate.</value>
        [DataMember(Name="majorSpecialization", EmitDefaultValue=false)]
        public string MajorSpecialization { get; set; }

        /// <summary>
        /// The minor area for a degree or area of specialization for a certificate.
        /// </summary>
        /// <value>The minor area for a degree or area of specialization for a certificate.</value>
        [DataMember(Name="minorSpecialization", EmitDefaultValue=false)]
        public string MinorSpecialization { get; set; }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a program by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>A unique number or alphanumeric code assigned to a program by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name="programId", EmitDefaultValue=false)]
        public string ProgramId { get; set; }

        /// <summary>
        /// The descriptor holds the type of teacher prep program (e.g., college, alternative, TFA, etc.).
        /// </summary>
        /// <value>The descriptor holds the type of teacher prep program (e.g., college, alternative, TFA, etc.).</value>
        [DataMember(Name="teacherPreparationProgramTypeDescriptor", EmitDefaultValue=false)]
        public string TeacherPreparationProgramTypeDescriptor { get; set; }

        /// <summary>
        /// A code for describing the program pathway, for example: Residency, Internship, Traditional
        /// </summary>
        /// <value>A code for describing the program pathway, for example: Residency, Internship, Traditional</value>
        [DataMember(Name="tppProgramPathwayDescriptor", EmitDefaultValue=false)]
        public string TppProgramPathwayDescriptor { get; set; }

        /// <summary>
        /// A unique system-generated value that identifies the version of the resource.
        /// </summary>
        /// <value>A unique system-generated value that identifies the version of the resource.</value>
        [DataMember(Name="_etag", EmitDefaultValue=false)]
        public string Etag { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmTeacherPreparationProviderProgram {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProgramName: ").Append(ProgramName).Append("\n");
            sb.Append("  ProgramTypeDescriptor: ").Append(ProgramTypeDescriptor).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
            sb.Append("  MajorSpecialization: ").Append(MajorSpecialization).Append("\n");
            sb.Append("  MinorSpecialization: ").Append(MinorSpecialization).Append("\n");
            sb.Append("  ProgramId: ").Append(ProgramId).Append("\n");
            sb.Append("  TeacherPreparationProgramTypeDescriptor: ").Append(TeacherPreparationProgramTypeDescriptor).Append("\n");
            sb.Append("  TppProgramPathwayDescriptor: ").Append(TppProgramPathwayDescriptor).Append("\n");
            sb.Append("  Etag: ").Append(Etag).Append("\n");
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
            return this.Equals(input as TpdmTeacherPreparationProviderProgram);
        }

        /// <summary>
        /// Returns true if TpdmTeacherPreparationProviderProgram instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmTeacherPreparationProviderProgram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmTeacherPreparationProviderProgram input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.GradeLevels == input.GradeLevels ||
                    this.GradeLevels != null &&
                    this.GradeLevels.SequenceEqual(input.GradeLevels)
                ) && 
                (
                    this.MajorSpecialization == input.MajorSpecialization ||
                    (this.MajorSpecialization != null &&
                    this.MajorSpecialization.Equals(input.MajorSpecialization))
                ) && 
                (
                    this.MinorSpecialization == input.MinorSpecialization ||
                    (this.MinorSpecialization != null &&
                    this.MinorSpecialization.Equals(input.MinorSpecialization))
                ) && 
                (
                    this.ProgramId == input.ProgramId ||
                    (this.ProgramId != null &&
                    this.ProgramId.Equals(input.ProgramId))
                ) && 
                (
                    this.TeacherPreparationProgramTypeDescriptor == input.TeacherPreparationProgramTypeDescriptor ||
                    (this.TeacherPreparationProgramTypeDescriptor != null &&
                    this.TeacherPreparationProgramTypeDescriptor.Equals(input.TeacherPreparationProgramTypeDescriptor))
                ) && 
                (
                    this.TppProgramPathwayDescriptor == input.TppProgramPathwayDescriptor ||
                    (this.TppProgramPathwayDescriptor != null &&
                    this.TppProgramPathwayDescriptor.Equals(input.TppProgramPathwayDescriptor))
                ) && 
                (
                    this.Etag == input.Etag ||
                    (this.Etag != null &&
                    this.Etag.Equals(input.Etag))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProgramName != null)
                    hashCode = hashCode * 59 + this.ProgramName.GetHashCode();
                if (this.ProgramTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ProgramTypeDescriptor.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.GradeLevels != null)
                    hashCode = hashCode * 59 + this.GradeLevels.GetHashCode();
                if (this.MajorSpecialization != null)
                    hashCode = hashCode * 59 + this.MajorSpecialization.GetHashCode();
                if (this.MinorSpecialization != null)
                    hashCode = hashCode * 59 + this.MinorSpecialization.GetHashCode();
                if (this.ProgramId != null)
                    hashCode = hashCode * 59 + this.ProgramId.GetHashCode();
                if (this.TeacherPreparationProgramTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.TeacherPreparationProgramTypeDescriptor.GetHashCode();
                if (this.TppProgramPathwayDescriptor != null)
                    hashCode = hashCode * 59 + this.TppProgramPathwayDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}