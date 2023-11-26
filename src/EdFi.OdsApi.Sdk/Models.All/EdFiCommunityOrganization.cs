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
    /// EdFiCommunityOrganization
    /// </summary>
    [DataContract(Name = "edFi_communityOrganization")]
    public partial class EdFiCommunityOrganization : IEquatable<EdFiCommunityOrganization>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCommunityOrganization" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCommunityOrganization() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCommunityOrganization" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="categories">An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state. (required).</param>
        /// <param name="communityOrganizationId">The identifier assigned to a community organization. (required).</param>
        /// <param name="addresses">An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4..</param>
        /// <param name="identificationCodes">An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity..</param>
        /// <param name="indicators">An unordered collection of educationOrganizationIndicators. An indicator or metric of an education organization..</param>
        /// <param name="institutionTelephones">An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity..</param>
        /// <param name="internationalAddresses">An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity..</param>
        /// <param name="nameOfInstitution">The full, legally accepted name of the institution. (required).</param>
        /// <param name="operationalStatusDescriptor">The current operational status of the education organization (e.g., active, inactive)..</param>
        /// <param name="shortNameOfInstitution">A short name for the institution..</param>
        /// <param name="webSite">The public web site address (URL) for the education organization..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiCommunityOrganization(string id = default(string), List<EdFiEducationOrganizationCategory> categories = default(List<EdFiEducationOrganizationCategory>), long communityOrganizationId = default(long), List<EdFiEducationOrganizationAddress> addresses = default(List<EdFiEducationOrganizationAddress>), List<EdFiEducationOrganizationIdentificationCode> identificationCodes = default(List<EdFiEducationOrganizationIdentificationCode>), List<EdFiEducationOrganizationIndicator> indicators = default(List<EdFiEducationOrganizationIndicator>), List<EdFiEducationOrganizationInstitutionTelephone> institutionTelephones = default(List<EdFiEducationOrganizationInstitutionTelephone>), List<EdFiEducationOrganizationInternationalAddress> internationalAddresses = default(List<EdFiEducationOrganizationInternationalAddress>), string nameOfInstitution = default(string), string operationalStatusDescriptor = default(string), string shortNameOfInstitution = default(string), string webSite = default(string), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "categories" is required (not null)
            if (categories == null)
            {
                throw new ArgumentNullException("categories is a required property for EdFiCommunityOrganization and cannot be null");
            }
            this.Categories = categories;
            this.CommunityOrganizationId = communityOrganizationId;
            // to ensure "nameOfInstitution" is required (not null)
            if (nameOfInstitution == null)
            {
                throw new ArgumentNullException("nameOfInstitution is a required property for EdFiCommunityOrganization and cannot be null");
            }
            this.NameOfInstitution = nameOfInstitution;
            this.Id = id;
            this.Addresses = addresses;
            this.IdentificationCodes = identificationCodes;
            this.Indicators = indicators;
            this.InstitutionTelephones = institutionTelephones;
            this.InternationalAddresses = internationalAddresses;
            this.OperationalStatusDescriptor = operationalStatusDescriptor;
            this.ShortNameOfInstitution = shortNameOfInstitution;
            this.WebSite = webSite;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationCategories. The classification of the education agency within the geographic boundaries of a state according to the level of administrative and operational control granted by the state.</value>
        [DataMember(Name = "categories", IsRequired = true, EmitDefaultValue = true)]
        public List<EdFiEducationOrganizationCategory> Categories { get; set; }

        /// <summary>
        /// The identifier assigned to a community organization.
        /// </summary>
        /// <value>The identifier assigned to a community organization.</value>
        [DataMember(Name = "communityOrganizationId", IsRequired = true, EmitDefaultValue = true)]
        public long CommunityOrganizationId { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationAddresses. The set of elements that describes an address for the education entity, including the street address, city, state, ZIP code, and ZIP code + 4.</value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<EdFiEducationOrganizationAddress> Addresses { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIdentificationCodes. A unique number or alphanumeric code assigned to an education organization by a school, school system, a state, or other agency or entity.</value>
        [DataMember(Name = "identificationCodes", EmitDefaultValue = false)]
        public List<EdFiEducationOrganizationIdentificationCode> IdentificationCodes { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationIndicators. An indicator or metric of an education organization.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationIndicators. An indicator or metric of an education organization.</value>
        [DataMember(Name = "indicators", EmitDefaultValue = false)]
        public List<EdFiEducationOrganizationIndicator> Indicators { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationInstitutionTelephones. The 10-digit telephone number, including the area code, for the education entity.</value>
        [DataMember(Name = "institutionTelephones", EmitDefaultValue = false)]
        public List<EdFiEducationOrganizationInstitutionTelephone> InstitutionTelephones { get; set; }

        /// <summary>
        /// An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity.
        /// </summary>
        /// <value>An unordered collection of educationOrganizationInternationalAddresses. The set of elements that describes the international physical location of the education entity.</value>
        [DataMember(Name = "internationalAddresses", EmitDefaultValue = false)]
        public List<EdFiEducationOrganizationInternationalAddress> InternationalAddresses { get; set; }

        /// <summary>
        /// The full, legally accepted name of the institution.
        /// </summary>
        /// <value>The full, legally accepted name of the institution.</value>
        [DataMember(Name = "nameOfInstitution", IsRequired = true, EmitDefaultValue = true)]
        public string NameOfInstitution { get; set; }

        /// <summary>
        /// The current operational status of the education organization (e.g., active, inactive).
        /// </summary>
        /// <value>The current operational status of the education organization (e.g., active, inactive).</value>
        [DataMember(Name = "operationalStatusDescriptor", EmitDefaultValue = true)]
        public string OperationalStatusDescriptor { get; set; }

        /// <summary>
        /// A short name for the institution.
        /// </summary>
        /// <value>A short name for the institution.</value>
        [DataMember(Name = "shortNameOfInstitution", EmitDefaultValue = true)]
        public string ShortNameOfInstitution { get; set; }

        /// <summary>
        /// The public web site address (URL) for the education organization.
        /// </summary>
        /// <value>The public web site address (URL) for the education organization.</value>
        [DataMember(Name = "webSite", EmitDefaultValue = true)]
        public string WebSite { get; set; }

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
            sb.Append("class EdFiCommunityOrganization {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  CommunityOrganizationId: ").Append(CommunityOrganizationId).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  IdentificationCodes: ").Append(IdentificationCodes).Append("\n");
            sb.Append("  Indicators: ").Append(Indicators).Append("\n");
            sb.Append("  InstitutionTelephones: ").Append(InstitutionTelephones).Append("\n");
            sb.Append("  InternationalAddresses: ").Append(InternationalAddresses).Append("\n");
            sb.Append("  NameOfInstitution: ").Append(NameOfInstitution).Append("\n");
            sb.Append("  OperationalStatusDescriptor: ").Append(OperationalStatusDescriptor).Append("\n");
            sb.Append("  ShortNameOfInstitution: ").Append(ShortNameOfInstitution).Append("\n");
            sb.Append("  WebSite: ").Append(WebSite).Append("\n");
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
            return this.Equals(input as EdFiCommunityOrganization);
        }

        /// <summary>
        /// Returns true if EdFiCommunityOrganization instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCommunityOrganization to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCommunityOrganization input)
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
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.CommunityOrganizationId == input.CommunityOrganizationId ||
                    this.CommunityOrganizationId.Equals(input.CommunityOrganizationId)
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.IdentificationCodes == input.IdentificationCodes ||
                    this.IdentificationCodes != null &&
                    input.IdentificationCodes != null &&
                    this.IdentificationCodes.SequenceEqual(input.IdentificationCodes)
                ) && 
                (
                    this.Indicators == input.Indicators ||
                    this.Indicators != null &&
                    input.Indicators != null &&
                    this.Indicators.SequenceEqual(input.Indicators)
                ) && 
                (
                    this.InstitutionTelephones == input.InstitutionTelephones ||
                    this.InstitutionTelephones != null &&
                    input.InstitutionTelephones != null &&
                    this.InstitutionTelephones.SequenceEqual(input.InstitutionTelephones)
                ) && 
                (
                    this.InternationalAddresses == input.InternationalAddresses ||
                    this.InternationalAddresses != null &&
                    input.InternationalAddresses != null &&
                    this.InternationalAddresses.SequenceEqual(input.InternationalAddresses)
                ) && 
                (
                    this.NameOfInstitution == input.NameOfInstitution ||
                    (this.NameOfInstitution != null &&
                    this.NameOfInstitution.Equals(input.NameOfInstitution))
                ) && 
                (
                    this.OperationalStatusDescriptor == input.OperationalStatusDescriptor ||
                    (this.OperationalStatusDescriptor != null &&
                    this.OperationalStatusDescriptor.Equals(input.OperationalStatusDescriptor))
                ) && 
                (
                    this.ShortNameOfInstitution == input.ShortNameOfInstitution ||
                    (this.ShortNameOfInstitution != null &&
                    this.ShortNameOfInstitution.Equals(input.ShortNameOfInstitution))
                ) && 
                (
                    this.WebSite == input.WebSite ||
                    (this.WebSite != null &&
                    this.WebSite.Equals(input.WebSite))
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
                if (this.Categories != null)
                {
                    hashCode = (hashCode * 59) + this.Categories.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CommunityOrganizationId.GetHashCode();
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
                }
                if (this.IdentificationCodes != null)
                {
                    hashCode = (hashCode * 59) + this.IdentificationCodes.GetHashCode();
                }
                if (this.Indicators != null)
                {
                    hashCode = (hashCode * 59) + this.Indicators.GetHashCode();
                }
                if (this.InstitutionTelephones != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionTelephones.GetHashCode();
                }
                if (this.InternationalAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.InternationalAddresses.GetHashCode();
                }
                if (this.NameOfInstitution != null)
                {
                    hashCode = (hashCode * 59) + this.NameOfInstitution.GetHashCode();
                }
                if (this.OperationalStatusDescriptor != null)
                {
                    hashCode = (hashCode * 59) + this.OperationalStatusDescriptor.GetHashCode();
                }
                if (this.ShortNameOfInstitution != null)
                {
                    hashCode = (hashCode * 59) + this.ShortNameOfInstitution.GetHashCode();
                }
                if (this.WebSite != null)
                {
                    hashCode = (hashCode * 59) + this.WebSite.GetHashCode();
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
            // NameOfInstitution (string) maxLength
            if (this.NameOfInstitution != null && this.NameOfInstitution.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NameOfInstitution, length must be less than 75.", new [] { "NameOfInstitution" });
            }

            // NameOfInstitution (string) minLength
            if (this.NameOfInstitution != null && this.NameOfInstitution.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for NameOfInstitution, length must be greater than 1.", new [] { "NameOfInstitution" });
            }

            // OperationalStatusDescriptor (string) maxLength
            if (this.OperationalStatusDescriptor != null && this.OperationalStatusDescriptor.Length > 306)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationalStatusDescriptor, length must be less than 306.", new [] { "OperationalStatusDescriptor" });
            }

            // ShortNameOfInstitution (string) maxLength
            if (this.ShortNameOfInstitution != null && this.ShortNameOfInstitution.Length > 75)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortNameOfInstitution, length must be less than 75.", new [] { "ShortNameOfInstitution" });
            }

            // ShortNameOfInstitution (string) minLength
            if (this.ShortNameOfInstitution != null && this.ShortNameOfInstitution.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortNameOfInstitution, length must be greater than 1.", new [] { "ShortNameOfInstitution" });
            }

            // WebSite (string) maxLength
            if (this.WebSite != null && this.WebSite.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebSite, length must be less than 255.", new [] { "WebSite" });
            }

            // WebSite (string) minLength
            if (this.WebSite != null && this.WebSite.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WebSite, length must be greater than 5.", new [] { "WebSite" });
            }

            yield break;
        }
    }

}