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
    /// EdFiGraduationPlanReference
    /// </summary>
    [DataContract]
    public partial class EdFiGraduationPlanReference :  IEquatable<EdFiGraduationPlanReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiGraduationPlanReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiGraduationPlanReference" /> class.
        /// </summary>
        /// <param name="educationOrganizationId">The identifier assigned to an education organization. (required).</param>
        /// <param name="graduationPlanTypeDescriptor">The type of academic plan the student is following for graduation: for example, Minimum, Recommended, Distinguished, or Standard. (required).</param>
        /// <param name="graduationSchoolYear">The school year the student is expected to graduate. (required).</param>
        /// <param name="link">link.</param>
        public EdFiGraduationPlanReference(int? educationOrganizationId = default(int?), string graduationPlanTypeDescriptor = default(string), int? graduationSchoolYear = default(int?), Link link = default(Link))
        {
            // to ensure "educationOrganizationId" is required (not null)
            if (educationOrganizationId == null)
            {
                throw new InvalidDataException("educationOrganizationId is a required property for EdFiGraduationPlanReference and cannot be null");
            }
            else
            {
                this.EducationOrganizationId = educationOrganizationId;
            }
            // to ensure "graduationPlanTypeDescriptor" is required (not null)
            if (graduationPlanTypeDescriptor == null)
            {
                throw new InvalidDataException("graduationPlanTypeDescriptor is a required property for EdFiGraduationPlanReference and cannot be null");
            }
            else
            {
                this.GraduationPlanTypeDescriptor = graduationPlanTypeDescriptor;
            }
            // to ensure "graduationSchoolYear" is required (not null)
            if (graduationSchoolYear == null)
            {
                throw new InvalidDataException("graduationSchoolYear is a required property for EdFiGraduationPlanReference and cannot be null");
            }
            else
            {
                this.GraduationSchoolYear = graduationSchoolYear;
            }
            this.Link = link;
        }
        
        /// <summary>
        /// The identifier assigned to an education organization.
        /// </summary>
        /// <value>The identifier assigned to an education organization.</value>
        [DataMember(Name="educationOrganizationId", EmitDefaultValue=false)]
        public int? EducationOrganizationId { get; set; }

        /// <summary>
        /// The type of academic plan the student is following for graduation: for example, Minimum, Recommended, Distinguished, or Standard.
        /// </summary>
        /// <value>The type of academic plan the student is following for graduation: for example, Minimum, Recommended, Distinguished, or Standard.</value>
        [DataMember(Name="graduationPlanTypeDescriptor", EmitDefaultValue=false)]
        public string GraduationPlanTypeDescriptor { get; set; }

        /// <summary>
        /// The school year the student is expected to graduate.
        /// </summary>
        /// <value>The school year the student is expected to graduate.</value>
        [DataMember(Name="graduationSchoolYear", EmitDefaultValue=false)]
        public int? GraduationSchoolYear { get; set; }

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
            sb.Append("class EdFiGraduationPlanReference {\n");
            sb.Append("  EducationOrganizationId: ").Append(EducationOrganizationId).Append("\n");
            sb.Append("  GraduationPlanTypeDescriptor: ").Append(GraduationPlanTypeDescriptor).Append("\n");
            sb.Append("  GraduationSchoolYear: ").Append(GraduationSchoolYear).Append("\n");
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
            return this.Equals(input as EdFiGraduationPlanReference);
        }

        /// <summary>
        /// Returns true if EdFiGraduationPlanReference instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiGraduationPlanReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiGraduationPlanReference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EducationOrganizationId == input.EducationOrganizationId ||
                    (this.EducationOrganizationId != null &&
                    this.EducationOrganizationId.Equals(input.EducationOrganizationId))
                ) && 
                (
                    this.GraduationPlanTypeDescriptor == input.GraduationPlanTypeDescriptor ||
                    (this.GraduationPlanTypeDescriptor != null &&
                    this.GraduationPlanTypeDescriptor.Equals(input.GraduationPlanTypeDescriptor))
                ) && 
                (
                    this.GraduationSchoolYear == input.GraduationSchoolYear ||
                    (this.GraduationSchoolYear != null &&
                    this.GraduationSchoolYear.Equals(input.GraduationSchoolYear))
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
                if (this.EducationOrganizationId != null)
                    hashCode = hashCode * 59 + this.EducationOrganizationId.GetHashCode();
                if (this.GraduationPlanTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.GraduationPlanTypeDescriptor.GetHashCode();
                if (this.GraduationSchoolYear != null)
                    hashCode = hashCode * 59 + this.GraduationSchoolYear.GetHashCode();
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                return hashCode;
            }
        }
    }

}