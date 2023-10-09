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
    /// TpdmTeacherCandidateIndicator
    /// </summary>
    [DataContract]
    public partial class TpdmTeacherCandidateIndicator :  IEquatable<TpdmTeacherCandidateIndicator>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherCandidateIndicator" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmTeacherCandidateIndicator() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmTeacherCandidateIndicator" /> class.
        /// </summary>
        /// <param name="indicatorName">The name of the indicator or metric. (required).</param>
        /// <param name="beginDate">The date when the indicator was assigned or computed..</param>
        /// <param name="designatedBy">The person, organization, or department that designated the program association..</param>
        /// <param name="endDate">The date the indicator or metric was sunset or removed..</param>
        /// <param name="indicator">The value of the indicator or metric. (required).</param>
        /// <param name="indicatorGroup">The name for a group of indicators..</param>
        public TpdmTeacherCandidateIndicator(string indicatorName = default(string), DateTime? beginDate = default(DateTime?), string designatedBy = default(string), DateTime? endDate = default(DateTime?), string indicator = default(string), string indicatorGroup = default(string))
        {
            // to ensure "indicatorName" is required (not null)
            if (indicatorName == null)
            {
                throw new InvalidDataException("indicatorName is a required property for TpdmTeacherCandidateIndicator and cannot be null");
            }
            else
            {
                this.IndicatorName = indicatorName;
            }
            // to ensure "indicator" is required (not null)
            if (indicator == null)
            {
                throw new InvalidDataException("indicator is a required property for TpdmTeacherCandidateIndicator and cannot be null");
            }
            else
            {
                this.Indicator = indicator;
            }
            this.BeginDate = beginDate;
            this.DesignatedBy = designatedBy;
            this.EndDate = endDate;
            this.IndicatorGroup = indicatorGroup;
        }
        
        /// <summary>
        /// The name of the indicator or metric.
        /// </summary>
        /// <value>The name of the indicator or metric.</value>
        [DataMember(Name="indicatorName", EmitDefaultValue=false)]
        public string IndicatorName { get; set; }

        /// <summary>
        /// The date when the indicator was assigned or computed.
        /// </summary>
        /// <value>The date when the indicator was assigned or computed.</value>
        [DataMember(Name="beginDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? BeginDate { get; set; }

        /// <summary>
        /// The person, organization, or department that designated the program association.
        /// </summary>
        /// <value>The person, organization, or department that designated the program association.</value>
        [DataMember(Name="designatedBy", EmitDefaultValue=false)]
        public string DesignatedBy { get; set; }

        /// <summary>
        /// The date the indicator or metric was sunset or removed.
        /// </summary>
        /// <value>The date the indicator or metric was sunset or removed.</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The value of the indicator or metric.
        /// </summary>
        /// <value>The value of the indicator or metric.</value>
        [DataMember(Name="indicator", EmitDefaultValue=false)]
        public string Indicator { get; set; }

        /// <summary>
        /// The name for a group of indicators.
        /// </summary>
        /// <value>The name for a group of indicators.</value>
        [DataMember(Name="indicatorGroup", EmitDefaultValue=false)]
        public string IndicatorGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TpdmTeacherCandidateIndicator {\n");
            sb.Append("  IndicatorName: ").Append(IndicatorName).Append("\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  DesignatedBy: ").Append(DesignatedBy).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Indicator: ").Append(Indicator).Append("\n");
            sb.Append("  IndicatorGroup: ").Append(IndicatorGroup).Append("\n");
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
            return this.Equals(input as TpdmTeacherCandidateIndicator);
        }

        /// <summary>
        /// Returns true if TpdmTeacherCandidateIndicator instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmTeacherCandidateIndicator to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmTeacherCandidateIndicator input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IndicatorName == input.IndicatorName ||
                    (this.IndicatorName != null &&
                    this.IndicatorName.Equals(input.IndicatorName))
                ) && 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.DesignatedBy == input.DesignatedBy ||
                    (this.DesignatedBy != null &&
                    this.DesignatedBy.Equals(input.DesignatedBy))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Indicator == input.Indicator ||
                    (this.Indicator != null &&
                    this.Indicator.Equals(input.Indicator))
                ) && 
                (
                    this.IndicatorGroup == input.IndicatorGroup ||
                    (this.IndicatorGroup != null &&
                    this.IndicatorGroup.Equals(input.IndicatorGroup))
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
                if (this.IndicatorName != null)
                    hashCode = hashCode * 59 + this.IndicatorName.GetHashCode();
                if (this.BeginDate != null)
                    hashCode = hashCode * 59 + this.BeginDate.GetHashCode();
                if (this.DesignatedBy != null)
                    hashCode = hashCode * 59 + this.DesignatedBy.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Indicator != null)
                    hashCode = hashCode * 59 + this.Indicator.GetHashCode();
                if (this.IndicatorGroup != null)
                    hashCode = hashCode * 59 + this.IndicatorGroup.GetHashCode();
                return hashCode;
            }
        }
    }

}