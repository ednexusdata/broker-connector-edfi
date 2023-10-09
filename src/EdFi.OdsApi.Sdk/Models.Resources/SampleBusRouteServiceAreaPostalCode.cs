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
    /// SampleBusRouteServiceAreaPostalCode
    /// </summary>
    [DataContract]
    public partial class SampleBusRouteServiceAreaPostalCode :  IEquatable<SampleBusRouteServiceAreaPostalCode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleBusRouteServiceAreaPostalCode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleBusRouteServiceAreaPostalCode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleBusRouteServiceAreaPostalCode" /> class.
        /// </summary>
        /// <param name="serviceAreaPostalCode">The postal codes served by the bus route. (required).</param>
        public SampleBusRouteServiceAreaPostalCode(string serviceAreaPostalCode = default(string))
        {
            // to ensure "serviceAreaPostalCode" is required (not null)
            if (serviceAreaPostalCode == null)
            {
                throw new InvalidDataException("serviceAreaPostalCode is a required property for SampleBusRouteServiceAreaPostalCode and cannot be null");
            }
            else
            {
                this.ServiceAreaPostalCode = serviceAreaPostalCode;
            }
        }
        
        /// <summary>
        /// The postal codes served by the bus route.
        /// </summary>
        /// <value>The postal codes served by the bus route.</value>
        [DataMember(Name="serviceAreaPostalCode", EmitDefaultValue=false)]
        public string ServiceAreaPostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleBusRouteServiceAreaPostalCode {\n");
            sb.Append("  ServiceAreaPostalCode: ").Append(ServiceAreaPostalCode).Append("\n");
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
            return this.Equals(input as SampleBusRouteServiceAreaPostalCode);
        }

        /// <summary>
        /// Returns true if SampleBusRouteServiceAreaPostalCode instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleBusRouteServiceAreaPostalCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleBusRouteServiceAreaPostalCode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ServiceAreaPostalCode == input.ServiceAreaPostalCode ||
                    (this.ServiceAreaPostalCode != null &&
                    this.ServiceAreaPostalCode.Equals(input.ServiceAreaPostalCode))
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
                if (this.ServiceAreaPostalCode != null)
                    hashCode = hashCode * 59 + this.ServiceAreaPostalCode.GetHashCode();
                return hashCode;
            }
        }
    }

}