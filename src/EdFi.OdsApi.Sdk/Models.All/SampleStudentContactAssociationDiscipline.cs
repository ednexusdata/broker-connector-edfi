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
    /// SampleStudentContactAssociationDiscipline
    /// </summary>
    [DataContract(Name = "sample_studentContactAssociationDiscipline")]
    public partial class SampleStudentContactAssociationDiscipline : IEquatable<SampleStudentContactAssociationDiscipline>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentContactAssociationDiscipline" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentContactAssociationDiscipline() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentContactAssociationDiscipline" /> class.
        /// </summary>
        /// <param name="disciplineDescriptor">The type of action used to discipline the student preferred by the contact. (required).</param>
        public SampleStudentContactAssociationDiscipline(string disciplineDescriptor = default(string))
        {
            // to ensure "disciplineDescriptor" is required (not null)
            if (disciplineDescriptor == null)
            {
                throw new ArgumentNullException("disciplineDescriptor is a required property for SampleStudentContactAssociationDiscipline and cannot be null");
            }
            this.DisciplineDescriptor = disciplineDescriptor;
        }

        /// <summary>
        /// The type of action used to discipline the student preferred by the contact.
        /// </summary>
        /// <value>The type of action used to discipline the student preferred by the contact.</value>
        [DataMember(Name = "disciplineDescriptor", IsRequired = true, EmitDefaultValue = true)]
        public string DisciplineDescriptor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SampleStudentContactAssociationDiscipline {\n");
            sb.Append("  DisciplineDescriptor: ").Append(DisciplineDescriptor).Append("\n");
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
            return this.Equals(input as SampleStudentContactAssociationDiscipline);
        }

        /// <summary>
        /// Returns true if SampleStudentContactAssociationDiscipline instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentContactAssociationDiscipline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentContactAssociationDiscipline input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisciplineDescriptor == input.DisciplineDescriptor ||
                    (this.DisciplineDescriptor != null &&
                    this.DisciplineDescriptor.Equals(input.DisciplineDescriptor))
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
                if (this.DisciplineDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.DisciplineDescriptor.GetHashCode();
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
            // DisciplineDescriptor (string) maxLength
            if (this.DisciplineDescriptor != null && this.DisciplineDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisciplineDescriptor, length must be less than 306.", new [] { "DisciplineDescriptor" });
            }

            yield break;
        }
    }

}