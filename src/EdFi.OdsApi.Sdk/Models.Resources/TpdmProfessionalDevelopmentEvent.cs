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
    /// TpdmProfessionalDevelopmentEvent
    /// </summary>
    [DataContract]
    public partial class TpdmProfessionalDevelopmentEvent :  IEquatable<TpdmProfessionalDevelopmentEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmProfessionalDevelopmentEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmProfessionalDevelopmentEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmProfessionalDevelopmentEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="_namespace">Namespace for the event, typically associated with the issuing authority. (required).</param>
        /// <param name="professionalDevelopmentTitle">The title or name for a professional development. (required).</param>
        /// <param name="multipleSession">An indication of whether or not a professional development event is comprised of multiple sessions or not..</param>
        /// <param name="professionalDevelopmentOfferedByDescriptor">A code describing an organization that is offering a specific professional development. (required).</param>
        /// <param name="professionalDevelopmentReason">The reported reason for a teacher candidate&#39;s professional development..</param>
        /// <param name="required">An indication of whether a teacher candidate is active in a professional development..</param>
        /// <param name="totalHours">The number of total hours the professional development contains..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmProfessionalDevelopmentEvent(string id = default(string), string _namespace = default(string), string professionalDevelopmentTitle = default(string), bool? multipleSession = default(bool?), string professionalDevelopmentOfferedByDescriptor = default(string), string professionalDevelopmentReason = default(string), bool? required = default(bool?), int? totalHours = default(int?), string etag = default(string))
        {
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for TpdmProfessionalDevelopmentEvent and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }
            // to ensure "professionalDevelopmentTitle" is required (not null)
            if (professionalDevelopmentTitle == null)
            {
                throw new InvalidDataException("professionalDevelopmentTitle is a required property for TpdmProfessionalDevelopmentEvent and cannot be null");
            }
            else
            {
                this.ProfessionalDevelopmentTitle = professionalDevelopmentTitle;
            }
            // to ensure "professionalDevelopmentOfferedByDescriptor" is required (not null)
            if (professionalDevelopmentOfferedByDescriptor == null)
            {
                throw new InvalidDataException("professionalDevelopmentOfferedByDescriptor is a required property for TpdmProfessionalDevelopmentEvent and cannot be null");
            }
            else
            {
                this.ProfessionalDevelopmentOfferedByDescriptor = professionalDevelopmentOfferedByDescriptor;
            }
            this.Id = id;
            this.MultipleSession = multipleSession;
            this.ProfessionalDevelopmentReason = professionalDevelopmentReason;
            this.Required = required;
            this.TotalHours = totalHours;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Namespace for the event, typically associated with the issuing authority.
        /// </summary>
        /// <value>Namespace for the event, typically associated with the issuing authority.</value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The title or name for a professional development.
        /// </summary>
        /// <value>The title or name for a professional development.</value>
        [DataMember(Name="professionalDevelopmentTitle", EmitDefaultValue=false)]
        public string ProfessionalDevelopmentTitle { get; set; }

        /// <summary>
        /// An indication of whether or not a professional development event is comprised of multiple sessions or not.
        /// </summary>
        /// <value>An indication of whether or not a professional development event is comprised of multiple sessions or not.</value>
        [DataMember(Name="multipleSession", EmitDefaultValue=false)]
        public bool? MultipleSession { get; set; }

        /// <summary>
        /// A code describing an organization that is offering a specific professional development.
        /// </summary>
        /// <value>A code describing an organization that is offering a specific professional development.</value>
        [DataMember(Name="professionalDevelopmentOfferedByDescriptor", EmitDefaultValue=false)]
        public string ProfessionalDevelopmentOfferedByDescriptor { get; set; }

        /// <summary>
        /// The reported reason for a teacher candidate&#39;s professional development.
        /// </summary>
        /// <value>The reported reason for a teacher candidate&#39;s professional development.</value>
        [DataMember(Name="professionalDevelopmentReason", EmitDefaultValue=false)]
        public string ProfessionalDevelopmentReason { get; set; }

        /// <summary>
        /// An indication of whether a teacher candidate is active in a professional development.
        /// </summary>
        /// <value>An indication of whether a teacher candidate is active in a professional development.</value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// The number of total hours the professional development contains.
        /// </summary>
        /// <value>The number of total hours the professional development contains.</value>
        [DataMember(Name="totalHours", EmitDefaultValue=false)]
        public int? TotalHours { get; set; }

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
            sb.Append("class TpdmProfessionalDevelopmentEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  ProfessionalDevelopmentTitle: ").Append(ProfessionalDevelopmentTitle).Append("\n");
            sb.Append("  MultipleSession: ").Append(MultipleSession).Append("\n");
            sb.Append("  ProfessionalDevelopmentOfferedByDescriptor: ").Append(ProfessionalDevelopmentOfferedByDescriptor).Append("\n");
            sb.Append("  ProfessionalDevelopmentReason: ").Append(ProfessionalDevelopmentReason).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  TotalHours: ").Append(TotalHours).Append("\n");
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
            return this.Equals(input as TpdmProfessionalDevelopmentEvent);
        }

        /// <summary>
        /// Returns true if TpdmProfessionalDevelopmentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmProfessionalDevelopmentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmProfessionalDevelopmentEvent input)
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
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.ProfessionalDevelopmentTitle == input.ProfessionalDevelopmentTitle ||
                    (this.ProfessionalDevelopmentTitle != null &&
                    this.ProfessionalDevelopmentTitle.Equals(input.ProfessionalDevelopmentTitle))
                ) && 
                (
                    this.MultipleSession == input.MultipleSession ||
                    (this.MultipleSession != null &&
                    this.MultipleSession.Equals(input.MultipleSession))
                ) && 
                (
                    this.ProfessionalDevelopmentOfferedByDescriptor == input.ProfessionalDevelopmentOfferedByDescriptor ||
                    (this.ProfessionalDevelopmentOfferedByDescriptor != null &&
                    this.ProfessionalDevelopmentOfferedByDescriptor.Equals(input.ProfessionalDevelopmentOfferedByDescriptor))
                ) && 
                (
                    this.ProfessionalDevelopmentReason == input.ProfessionalDevelopmentReason ||
                    (this.ProfessionalDevelopmentReason != null &&
                    this.ProfessionalDevelopmentReason.Equals(input.ProfessionalDevelopmentReason))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.TotalHours == input.TotalHours ||
                    (this.TotalHours != null &&
                    this.TotalHours.Equals(input.TotalHours))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ProfessionalDevelopmentTitle != null)
                    hashCode = hashCode * 59 + this.ProfessionalDevelopmentTitle.GetHashCode();
                if (this.MultipleSession != null)
                    hashCode = hashCode * 59 + this.MultipleSession.GetHashCode();
                if (this.ProfessionalDevelopmentOfferedByDescriptor != null)
                    hashCode = hashCode * 59 + this.ProfessionalDevelopmentOfferedByDescriptor.GetHashCode();
                if (this.ProfessionalDevelopmentReason != null)
                    hashCode = hashCode * 59 + this.ProfessionalDevelopmentReason.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.TotalHours != null)
                    hashCode = hashCode * 59 + this.TotalHours.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}