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
    /// SampleStudentEducationOrganizationAssociationAddressExtension
    /// </summary>
    [DataContract]
    public partial class SampleStudentEducationOrganizationAssociationAddressExtension :  IEquatable<SampleStudentEducationOrganizationAssociationAddressExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentEducationOrganizationAssociationAddressExtension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleStudentEducationOrganizationAssociationAddressExtension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleStudentEducationOrganizationAssociationAddressExtension" /> class.
        /// </summary>
        /// <param name="complex">The apartment or housing complex name..</param>
        /// <param name="onBusRoute">An indicator if the address is on a bus route. (required).</param>
        /// <param name="schoolDistricts">An unordered collection of studentEducationOrganizationAssociationAddressSchoolDistricts. The school district in which the address is located..</param>
        /// <param name="terms">An unordered collection of studentEducationOrganizationAssociationAddressTerms. Terms applicable to this address..</param>
        public SampleStudentEducationOrganizationAssociationAddressExtension(string complex = default(string), bool? onBusRoute = default(bool?), List<SampleStudentEducationOrganizationAssociationAddressSchoolDistrict> schoolDistricts = default(List<SampleStudentEducationOrganizationAssociationAddressSchoolDistrict>), List<SampleStudentEducationOrganizationAssociationAddressTerm> terms = default(List<SampleStudentEducationOrganizationAssociationAddressTerm>))
        {
            // to ensure "onBusRoute" is required (not null)
            if (onBusRoute == null)
            {
                throw new InvalidDataException("onBusRoute is a required property for SampleStudentEducationOrganizationAssociationAddressExtension and cannot be null");
            }
            else
            {
                this.OnBusRoute = onBusRoute;
            }
            this.Complex = complex;
            this.SchoolDistricts = schoolDistricts;
            this.Terms = terms;
        }
        
        /// <summary>
        /// The apartment or housing complex name.
        /// </summary>
        /// <value>The apartment or housing complex name.</value>
        [DataMember(Name="complex", EmitDefaultValue=false)]
        public string Complex { get; set; }

        /// <summary>
        /// An indicator if the address is on a bus route.
        /// </summary>
        /// <value>An indicator if the address is on a bus route.</value>
        [DataMember(Name="onBusRoute", EmitDefaultValue=false)]
        public bool? OnBusRoute { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationAddressSchoolDistricts. The school district in which the address is located.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationAddressSchoolDistricts. The school district in which the address is located.</value>
        [DataMember(Name="schoolDistricts", EmitDefaultValue=false)]
        public List<SampleStudentEducationOrganizationAssociationAddressSchoolDistrict> SchoolDistricts { get; set; }

        /// <summary>
        /// An unordered collection of studentEducationOrganizationAssociationAddressTerms. Terms applicable to this address.
        /// </summary>
        /// <value>An unordered collection of studentEducationOrganizationAssociationAddressTerms. Terms applicable to this address.</value>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public List<SampleStudentEducationOrganizationAssociationAddressTerm> Terms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleStudentEducationOrganizationAssociationAddressExtension {\n");
            sb.Append("  Complex: ").Append(Complex).Append("\n");
            sb.Append("  OnBusRoute: ").Append(OnBusRoute).Append("\n");
            sb.Append("  SchoolDistricts: ").Append(SchoolDistricts).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
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
            return this.Equals(input as SampleStudentEducationOrganizationAssociationAddressExtension);
        }

        /// <summary>
        /// Returns true if SampleStudentEducationOrganizationAssociationAddressExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleStudentEducationOrganizationAssociationAddressExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleStudentEducationOrganizationAssociationAddressExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Complex == input.Complex ||
                    (this.Complex != null &&
                    this.Complex.Equals(input.Complex))
                ) && 
                (
                    this.OnBusRoute == input.OnBusRoute ||
                    (this.OnBusRoute != null &&
                    this.OnBusRoute.Equals(input.OnBusRoute))
                ) && 
                (
                    this.SchoolDistricts == input.SchoolDistricts ||
                    this.SchoolDistricts != null &&
                    this.SchoolDistricts.SequenceEqual(input.SchoolDistricts)
                ) && 
                (
                    this.Terms == input.Terms ||
                    this.Terms != null &&
                    this.Terms.SequenceEqual(input.Terms)
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
                if (this.Complex != null)
                    hashCode = hashCode * 59 + this.Complex.GetHashCode();
                if (this.OnBusRoute != null)
                    hashCode = hashCode * 59 + this.OnBusRoute.GetHashCode();
                if (this.SchoolDistricts != null)
                    hashCode = hashCode * 59 + this.SchoolDistricts.GetHashCode();
                if (this.Terms != null)
                    hashCode = hashCode * 59 + this.Terms.GetHashCode();
                return hashCode;
            }
        }
    }

}