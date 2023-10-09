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
    /// EdFiAssessmentItemPossibleResponse
    /// </summary>
    [DataContract]
    public partial class EdFiAssessmentItemPossibleResponse :  IEquatable<EdFiAssessmentItemPossibleResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentItemPossibleResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiAssessmentItemPossibleResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiAssessmentItemPossibleResponse" /> class.
        /// </summary>
        /// <param name="responseValue">The response value, often an option number or code value (e.g., 1, 2, A, B, true, false). (required).</param>
        /// <param name="correctResponse">Indicates the response is correct..</param>
        /// <param name="responseDescription">Additional text provided to define the response value..</param>
        public EdFiAssessmentItemPossibleResponse(string responseValue = default(string), bool? correctResponse = default(bool?), string responseDescription = default(string))
        {
            // to ensure "responseValue" is required (not null)
            if (responseValue == null)
            {
                throw new InvalidDataException("responseValue is a required property for EdFiAssessmentItemPossibleResponse and cannot be null");
            }
            else
            {
                this.ResponseValue = responseValue;
            }
            this.CorrectResponse = correctResponse;
            this.ResponseDescription = responseDescription;
        }
        
        /// <summary>
        /// The response value, often an option number or code value (e.g., 1, 2, A, B, true, false).
        /// </summary>
        /// <value>The response value, often an option number or code value (e.g., 1, 2, A, B, true, false).</value>
        [DataMember(Name="responseValue", EmitDefaultValue=false)]
        public string ResponseValue { get; set; }

        /// <summary>
        /// Indicates the response is correct.
        /// </summary>
        /// <value>Indicates the response is correct.</value>
        [DataMember(Name="correctResponse", EmitDefaultValue=false)]
        public bool? CorrectResponse { get; set; }

        /// <summary>
        /// Additional text provided to define the response value.
        /// </summary>
        /// <value>Additional text provided to define the response value.</value>
        [DataMember(Name="responseDescription", EmitDefaultValue=false)]
        public string ResponseDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiAssessmentItemPossibleResponse {\n");
            sb.Append("  ResponseValue: ").Append(ResponseValue).Append("\n");
            sb.Append("  CorrectResponse: ").Append(CorrectResponse).Append("\n");
            sb.Append("  ResponseDescription: ").Append(ResponseDescription).Append("\n");
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
            return this.Equals(input as EdFiAssessmentItemPossibleResponse);
        }

        /// <summary>
        /// Returns true if EdFiAssessmentItemPossibleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiAssessmentItemPossibleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiAssessmentItemPossibleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseValue == input.ResponseValue ||
                    (this.ResponseValue != null &&
                    this.ResponseValue.Equals(input.ResponseValue))
                ) && 
                (
                    this.CorrectResponse == input.CorrectResponse ||
                    (this.CorrectResponse != null &&
                    this.CorrectResponse.Equals(input.CorrectResponse))
                ) && 
                (
                    this.ResponseDescription == input.ResponseDescription ||
                    (this.ResponseDescription != null &&
                    this.ResponseDescription.Equals(input.ResponseDescription))
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
                if (this.ResponseValue != null)
                    hashCode = hashCode * 59 + this.ResponseValue.GetHashCode();
                if (this.CorrectResponse != null)
                    hashCode = hashCode * 59 + this.CorrectResponse.GetHashCode();
                if (this.ResponseDescription != null)
                    hashCode = hashCode * 59 + this.ResponseDescription.GetHashCode();
                return hashCode;
            }
        }
    }

}