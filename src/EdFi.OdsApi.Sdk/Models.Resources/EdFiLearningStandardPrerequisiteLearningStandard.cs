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
    /// EdFiLearningStandardPrerequisiteLearningStandard
    /// </summary>
    [DataContract]
    public partial class EdFiLearningStandardPrerequisiteLearningStandard :  IEquatable<EdFiLearningStandardPrerequisiteLearningStandard>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardPrerequisiteLearningStandard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiLearningStandardPrerequisiteLearningStandard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiLearningStandardPrerequisiteLearningStandard" /> class.
        /// </summary>
        /// <param name="prerequisiteLearningStandardReference">prerequisiteLearningStandardReference (required).</param>
        public EdFiLearningStandardPrerequisiteLearningStandard(EdFiLearningStandardReference prerequisiteLearningStandardReference = default(EdFiLearningStandardReference))
        {
            // to ensure "prerequisiteLearningStandardReference" is required (not null)
            if (prerequisiteLearningStandardReference == null)
            {
                throw new InvalidDataException("prerequisiteLearningStandardReference is a required property for EdFiLearningStandardPrerequisiteLearningStandard and cannot be null");
            }
            else
            {
                this.PrerequisiteLearningStandardReference = prerequisiteLearningStandardReference;
            }
        }
        
        /// <summary>
        /// Gets or Sets PrerequisiteLearningStandardReference
        /// </summary>
        [DataMember(Name="prerequisiteLearningStandardReference", EmitDefaultValue=false)]
        public EdFiLearningStandardReference PrerequisiteLearningStandardReference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdFiLearningStandardPrerequisiteLearningStandard {\n");
            sb.Append("  PrerequisiteLearningStandardReference: ").Append(PrerequisiteLearningStandardReference).Append("\n");
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
            return this.Equals(input as EdFiLearningStandardPrerequisiteLearningStandard);
        }

        /// <summary>
        /// Returns true if EdFiLearningStandardPrerequisiteLearningStandard instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiLearningStandardPrerequisiteLearningStandard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiLearningStandardPrerequisiteLearningStandard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PrerequisiteLearningStandardReference == input.PrerequisiteLearningStandardReference ||
                    (this.PrerequisiteLearningStandardReference != null &&
                    this.PrerequisiteLearningStandardReference.Equals(input.PrerequisiteLearningStandardReference))
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
                if (this.PrerequisiteLearningStandardReference != null)
                    hashCode = hashCode * 59 + this.PrerequisiteLearningStandardReference.GetHashCode();
                return hashCode;
            }
        }
    }

}