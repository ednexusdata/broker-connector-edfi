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
    /// TpdmCertification
    /// </summary>
    [DataContract]
    public partial class TpdmCertification :  IEquatable<TpdmCertification>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCertification" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmCertification() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmCertification" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="certificationIdentifier">Identifier or serial number assigned to the Certification. (required).</param>
        /// <param name="_namespace">Namespace for the Certification, typically associated with the issuing authority. (required).</param>
        /// <param name="educationOrganizationReference">educationOrganizationReference.</param>
        /// <param name="certificationExams">An unordered collection of certificationCertificationExams. The Certification Eams required for the Certification..</param>
        /// <param name="certificationFieldDescriptor">The field of certification (e.g., Mathematics, Music)..</param>
        /// <param name="certificationLevelDescriptor">The level (e.g., Elementary, Secondary) or category (administrative, specialist) of the Certification..</param>
        /// <param name="certificationStandardDescriptor">The standard, law or policy defining the certification..</param>
        /// <param name="certificationTitle">The title of the Certification. (required).</param>
        /// <param name="educatorRoleDescriptor">The role authorized by the Certification (e.g., Principal, Reading Specialist), typically associated with service and administrative certifications..</param>
        /// <param name="effectiveDate">The year, month and day on which the Certification is offered..</param>
        /// <param name="endDate">The month, day, and year on which the Certification offering is expected to end..</param>
        /// <param name="gradeLevels">An unordered collection of certificationGradeLevels. The grade level(s) certified for teaching..</param>
        /// <param name="instructionalSettingDescriptor">The setting authorized by the Certification in which a child receives education and related services; for example: Classroom, Virtual, Vocational..</param>
        /// <param name="minimumDegreeDescriptor">The minimum level of degree, if any, required for Certification..</param>
        /// <param name="populationServedDescriptor">The type of students the Section is offered and tailored to; for example: Bilingual students, Remedial education students, Gifted and talented students, Career and Technical Education students, Special education students..</param>
        /// <param name="routes">An unordered collection of certificationRoutes. The process, program ,or pathway used to obtain certification..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmCertification(string id = default(string), string certificationIdentifier = default(string), string _namespace = default(string), EdFiEducationOrganizationReference educationOrganizationReference = default(EdFiEducationOrganizationReference), List<TpdmCertificationCertificationExam> certificationExams = default(List<TpdmCertificationCertificationExam>), string certificationFieldDescriptor = default(string), string certificationLevelDescriptor = default(string), string certificationStandardDescriptor = default(string), string certificationTitle = default(string), string educatorRoleDescriptor = default(string), DateTime? effectiveDate = default(DateTime?), DateTime? endDate = default(DateTime?), List<TpdmCertificationGradeLevel> gradeLevels = default(List<TpdmCertificationGradeLevel>), string instructionalSettingDescriptor = default(string), string minimumDegreeDescriptor = default(string), string populationServedDescriptor = default(string), List<TpdmCertificationRoute> routes = default(List<TpdmCertificationRoute>), string etag = default(string))
        {
            // to ensure "certificationIdentifier" is required (not null)
            if (certificationIdentifier == null)
            {
                throw new InvalidDataException("certificationIdentifier is a required property for TpdmCertification and cannot be null");
            }
            else
            {
                this.CertificationIdentifier = certificationIdentifier;
            }
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for TpdmCertification and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }
            // to ensure "certificationTitle" is required (not null)
            if (certificationTitle == null)
            {
                throw new InvalidDataException("certificationTitle is a required property for TpdmCertification and cannot be null");
            }
            else
            {
                this.CertificationTitle = certificationTitle;
            }
            this.Id = id;
            this.EducationOrganizationReference = educationOrganizationReference;
            this.CertificationExams = certificationExams;
            this.CertificationFieldDescriptor = certificationFieldDescriptor;
            this.CertificationLevelDescriptor = certificationLevelDescriptor;
            this.CertificationStandardDescriptor = certificationStandardDescriptor;
            this.EducatorRoleDescriptor = educatorRoleDescriptor;
            this.EffectiveDate = effectiveDate;
            this.EndDate = endDate;
            this.GradeLevels = gradeLevels;
            this.InstructionalSettingDescriptor = instructionalSettingDescriptor;
            this.MinimumDegreeDescriptor = minimumDegreeDescriptor;
            this.PopulationServedDescriptor = populationServedDescriptor;
            this.Routes = routes;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Identifier or serial number assigned to the Certification.
        /// </summary>
        /// <value>Identifier or serial number assigned to the Certification.</value>
        [DataMember(Name="certificationIdentifier", EmitDefaultValue=false)]
        public string CertificationIdentifier { get; set; }

        /// <summary>
        /// Namespace for the Certification, typically associated with the issuing authority.
        /// </summary>
        /// <value>Namespace for the Certification, typically associated with the issuing authority.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or Sets EducationOrganizationReference
        /// </summary>
        [DataMember(Name="educationOrganizationReference", EmitDefaultValue=false)]
        public EdFiEducationOrganizationReference EducationOrganizationReference { get; set; }

        /// <summary>
        /// An unordered collection of certificationCertificationExams. The Certification Eams required for the Certification.
        /// </summary>
        /// <value>An unordered collection of certificationCertificationExams. The Certification Eams required for the Certification.</value>
        [DataMember(Name="certificationExams", EmitDefaultValue=false)]
        public List<TpdmCertificationCertificationExam> CertificationExams { get; set; }

        /// <summary>
        /// The field of certification (e.g., Mathematics, Music).
        /// </summary>
        /// <value>The field of certification (e.g., Mathematics, Music).</value>
        [DataMember(Name="certificationFieldDescriptor", EmitDefaultValue=false)]
        public string CertificationFieldDescriptor { get; set; }

        /// <summary>
        /// The level (e.g., Elementary, Secondary) or category (administrative, specialist) of the Certification.
        /// </summary>
        /// <value>The level (e.g., Elementary, Secondary) or category (administrative, specialist) of the Certification.</value>
        [DataMember(Name="certificationLevelDescriptor", EmitDefaultValue=false)]
        public string CertificationLevelDescriptor { get; set; }

        /// <summary>
        /// The standard, law or policy defining the certification.
        /// </summary>
        /// <value>The standard, law or policy defining the certification.</value>
        [DataMember(Name="certificationStandardDescriptor", EmitDefaultValue=false)]
        public string CertificationStandardDescriptor { get; set; }

        /// <summary>
        /// The title of the Certification.
        /// </summary>
        /// <value>The title of the Certification.</value>
        [DataMember(Name="certificationTitle", EmitDefaultValue=false)]
        public string CertificationTitle { get; set; }

        /// <summary>
        /// The role authorized by the Certification (e.g., Principal, Reading Specialist), typically associated with service and administrative certifications.
        /// </summary>
        /// <value>The role authorized by the Certification (e.g., Principal, Reading Specialist), typically associated with service and administrative certifications.</value>
        [DataMember(Name="educatorRoleDescriptor", EmitDefaultValue=false)]
        public string EducatorRoleDescriptor { get; set; }

        /// <summary>
        /// The year, month and day on which the Certification is offered.
        /// </summary>
        /// <value>The year, month and day on which the Certification is offered.</value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// The month, day, and year on which the Certification offering is expected to end.
        /// </summary>
        /// <value>The month, day, and year on which the Certification offering is expected to end.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// An unordered collection of certificationGradeLevels. The grade level(s) certified for teaching.
        /// </summary>
        /// <value>An unordered collection of certificationGradeLevels. The grade level(s) certified for teaching.</value>
        [DataMember(Name="gradeLevels", EmitDefaultValue=false)]
        public List<TpdmCertificationGradeLevel> GradeLevels { get; set; }

        /// <summary>
        /// The setting authorized by the Certification in which a child receives education and related services; for example: Classroom, Virtual, Vocational.
        /// </summary>
        /// <value>The setting authorized by the Certification in which a child receives education and related services; for example: Classroom, Virtual, Vocational.</value>
        [DataMember(Name="instructionalSettingDescriptor", EmitDefaultValue=false)]
        public string InstructionalSettingDescriptor { get; set; }

        /// <summary>
        /// The minimum level of degree, if any, required for Certification.
        /// </summary>
        /// <value>The minimum level of degree, if any, required for Certification.</value>
        [DataMember(Name="minimumDegreeDescriptor", EmitDefaultValue=false)]
        public string MinimumDegreeDescriptor { get; set; }

        /// <summary>
        /// The type of students the Section is offered and tailored to; for example: Bilingual students, Remedial education students, Gifted and talented students, Career and Technical Education students, Special education students.
        /// </summary>
        /// <value>The type of students the Section is offered and tailored to; for example: Bilingual students, Remedial education students, Gifted and talented students, Career and Technical Education students, Special education students.</value>
        [DataMember(Name="populationServedDescriptor", EmitDefaultValue=false)]
        public string PopulationServedDescriptor { get; set; }

        /// <summary>
        /// An unordered collection of certificationRoutes. The process, program ,or pathway used to obtain certification.
        /// </summary>
        /// <value>An unordered collection of certificationRoutes. The process, program ,or pathway used to obtain certification.</value>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public List<TpdmCertificationRoute> Routes { get; set; }

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
            sb.Append("class TpdmCertification {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CertificationIdentifier: ").Append(CertificationIdentifier).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  EducationOrganizationReference: ").Append(EducationOrganizationReference).Append("\n");
            sb.Append("  CertificationExams: ").Append(CertificationExams).Append("\n");
            sb.Append("  CertificationFieldDescriptor: ").Append(CertificationFieldDescriptor).Append("\n");
            sb.Append("  CertificationLevelDescriptor: ").Append(CertificationLevelDescriptor).Append("\n");
            sb.Append("  CertificationStandardDescriptor: ").Append(CertificationStandardDescriptor).Append("\n");
            sb.Append("  CertificationTitle: ").Append(CertificationTitle).Append("\n");
            sb.Append("  EducatorRoleDescriptor: ").Append(EducatorRoleDescriptor).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  GradeLevels: ").Append(GradeLevels).Append("\n");
            sb.Append("  InstructionalSettingDescriptor: ").Append(InstructionalSettingDescriptor).Append("\n");
            sb.Append("  MinimumDegreeDescriptor: ").Append(MinimumDegreeDescriptor).Append("\n");
            sb.Append("  PopulationServedDescriptor: ").Append(PopulationServedDescriptor).Append("\n");
            sb.Append("  Routes: ").Append(Routes).Append("\n");
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
            return this.Equals(input as TpdmCertification);
        }

        /// <summary>
        /// Returns true if TpdmCertification instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmCertification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmCertification input)
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
                    this.CertificationIdentifier == input.CertificationIdentifier ||
                    (this.CertificationIdentifier != null &&
                    this.CertificationIdentifier.Equals(input.CertificationIdentifier))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.EducationOrganizationReference == input.EducationOrganizationReference ||
                    (this.EducationOrganizationReference != null &&
                    this.EducationOrganizationReference.Equals(input.EducationOrganizationReference))
                ) && 
                (
                    this.CertificationExams == input.CertificationExams ||
                    this.CertificationExams != null &&
                    this.CertificationExams.SequenceEqual(input.CertificationExams)
                ) && 
                (
                    this.CertificationFieldDescriptor == input.CertificationFieldDescriptor ||
                    (this.CertificationFieldDescriptor != null &&
                    this.CertificationFieldDescriptor.Equals(input.CertificationFieldDescriptor))
                ) && 
                (
                    this.CertificationLevelDescriptor == input.CertificationLevelDescriptor ||
                    (this.CertificationLevelDescriptor != null &&
                    this.CertificationLevelDescriptor.Equals(input.CertificationLevelDescriptor))
                ) && 
                (
                    this.CertificationStandardDescriptor == input.CertificationStandardDescriptor ||
                    (this.CertificationStandardDescriptor != null &&
                    this.CertificationStandardDescriptor.Equals(input.CertificationStandardDescriptor))
                ) && 
                (
                    this.CertificationTitle == input.CertificationTitle ||
                    (this.CertificationTitle != null &&
                    this.CertificationTitle.Equals(input.CertificationTitle))
                ) && 
                (
                    this.EducatorRoleDescriptor == input.EducatorRoleDescriptor ||
                    (this.EducatorRoleDescriptor != null &&
                    this.EducatorRoleDescriptor.Equals(input.EducatorRoleDescriptor))
                ) && 
                (
                    this.EffectiveDate == input.EffectiveDate ||
                    (this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(input.EffectiveDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.GradeLevels == input.GradeLevels ||
                    this.GradeLevels != null &&
                    this.GradeLevels.SequenceEqual(input.GradeLevels)
                ) && 
                (
                    this.InstructionalSettingDescriptor == input.InstructionalSettingDescriptor ||
                    (this.InstructionalSettingDescriptor != null &&
                    this.InstructionalSettingDescriptor.Equals(input.InstructionalSettingDescriptor))
                ) && 
                (
                    this.MinimumDegreeDescriptor == input.MinimumDegreeDescriptor ||
                    (this.MinimumDegreeDescriptor != null &&
                    this.MinimumDegreeDescriptor.Equals(input.MinimumDegreeDescriptor))
                ) && 
                (
                    this.PopulationServedDescriptor == input.PopulationServedDescriptor ||
                    (this.PopulationServedDescriptor != null &&
                    this.PopulationServedDescriptor.Equals(input.PopulationServedDescriptor))
                ) && 
                (
                    this.Routes == input.Routes ||
                    this.Routes != null &&
                    this.Routes.SequenceEqual(input.Routes)
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
                if (this.CertificationIdentifier != null)
                    hashCode = hashCode * 59 + this.CertificationIdentifier.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.EducationOrganizationReference != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationReference.GetHashCode();
                if (this.CertificationExams != null)
                    hashCode = hashCode * 59 + this.CertificationExams.GetHashCode();
                if (this.CertificationFieldDescriptor != null)
                    hashCode = hashCode * 59 + this.CertificationFieldDescriptor.GetHashCode();
                if (this.CertificationLevelDescriptor != null)
                    hashCode = hashCode * 59 + this.CertificationLevelDescriptor.GetHashCode();
                if (this.CertificationStandardDescriptor != null)
                    hashCode = hashCode * 59 + this.CertificationStandardDescriptor.GetHashCode();
                if (this.CertificationTitle != null)
                    hashCode = hashCode * 59 + this.CertificationTitle.GetHashCode();
                if (this.EducatorRoleDescriptor != null)
                    hashCode = hashCode * 59 + this.EducatorRoleDescriptor.GetHashCode();
                if (this.EffectiveDate != null)
                    hashCode = hashCode * 59 + this.EffectiveDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.GradeLevels != null)
                    hashCode = hashCode * 59 + this.GradeLevels.GetHashCode();
                if (this.InstructionalSettingDescriptor != null)
                    hashCode = hashCode * 59 + this.InstructionalSettingDescriptor.GetHashCode();
                if (this.MinimumDegreeDescriptor != null)
                    hashCode = hashCode * 59 + this.MinimumDegreeDescriptor.GetHashCode();
                if (this.PopulationServedDescriptor != null)
                    hashCode = hashCode * 59 + this.PopulationServedDescriptor.GetHashCode();
                if (this.Routes != null)
                    hashCode = hashCode * 59 + this.Routes.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}