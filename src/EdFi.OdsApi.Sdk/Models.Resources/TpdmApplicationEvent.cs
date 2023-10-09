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
    /// TpdmApplicationEvent
    /// </summary>
    [DataContract]
    public partial class TpdmApplicationEvent :  IEquatable<TpdmApplicationEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicationEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TpdmApplicationEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TpdmApplicationEvent" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="applicationEventTypeDescriptor">Description of application event (e.g., added to pool, phone screen, interview, sample lesson). (required).</param>
        /// <param name="eventDate">The date of the application event, or begin date if an interval. (required).</param>
        /// <param name="sequenceNumber">The sequence number of the application events. This is used to discriminate between mutiple events of the same type in the same day. (required).</param>
        /// <param name="applicationReference">applicationReference (required).</param>
        /// <param name="schoolYearTypeReference">schoolYearTypeReference (required).</param>
        /// <param name="applicationEvaluationScore">Application evaluation score, if applicable..</param>
        /// <param name="applicationEventResultDescriptor">The recommendation, result or conclusion of the application event (e.g., Continue, exit, recommend for hire)..</param>
        /// <param name="eventEndDate">The end date of the event, if an interval..</param>
        /// <param name="termDescriptor">This descriptor defines the term of a session during the school year (e.g., Fall Semester)..</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        public TpdmApplicationEvent(string id = default(string), string applicationEventTypeDescriptor = default(string), DateTime? eventDate = default(DateTime?), int? sequenceNumber = default(int?), TpdmApplicationReference applicationReference = default(TpdmApplicationReference), EdFiSchoolYearTypeReference schoolYearTypeReference = default(EdFiSchoolYearTypeReference), double? applicationEvaluationScore = default(double?), string applicationEventResultDescriptor = default(string), DateTime? eventEndDate = default(DateTime?), string termDescriptor = default(string), string etag = default(string))
        {
            // to ensure "applicationEventTypeDescriptor" is required (not null)
            if (applicationEventTypeDescriptor == null)
            {
                throw new InvalidDataException("applicationEventTypeDescriptor is a required property for TpdmApplicationEvent and cannot be null");
            }
            else
            {
                this.ApplicationEventTypeDescriptor = applicationEventTypeDescriptor;
            }
            // to ensure "eventDate" is required (not null)
            if (eventDate == null)
            {
                throw new InvalidDataException("eventDate is a required property for TpdmApplicationEvent and cannot be null");
            }
            else
            {
                this.EventDate = eventDate;
            }
            // to ensure "sequenceNumber" is required (not null)
            if (sequenceNumber == null)
            {
                throw new InvalidDataException("sequenceNumber is a required property for TpdmApplicationEvent and cannot be null");
            }
            else
            {
                this.SequenceNumber = sequenceNumber;
            }
            // to ensure "applicationReference" is required (not null)
            if (applicationReference == null)
            {
                throw new InvalidDataException("applicationReference is a required property for TpdmApplicationEvent and cannot be null");
            }
            else
            {
                this.ApplicationReference = applicationReference;
            }
            // to ensure "schoolYearTypeReference" is required (not null)
            if (schoolYearTypeReference == null)
            {
                throw new InvalidDataException("schoolYearTypeReference is a required property for TpdmApplicationEvent and cannot be null");
            }
            else
            {
                this.SchoolYearTypeReference = schoolYearTypeReference;
            }
            this.Id = id;
            this.ApplicationEvaluationScore = applicationEvaluationScore;
            this.ApplicationEventResultDescriptor = applicationEventResultDescriptor;
            this.EventEndDate = eventEndDate;
            this.TermDescriptor = termDescriptor;
            this.Etag = etag;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Description of application event (e.g., added to pool, phone screen, interview, sample lesson).
        /// </summary>
        /// <value>Description of application event (e.g., added to pool, phone screen, interview, sample lesson).</value>
        [DataMember(Name="applicationEventTypeDescriptor", EmitDefaultValue=false)]
        public string ApplicationEventTypeDescriptor { get; set; }

        /// <summary>
        /// The date of the application event, or begin date if an interval.
        /// </summary>
        /// <value>The date of the application event, or begin date if an interval.</value>
        [DataMember(Name="eventDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// The sequence number of the application events. This is used to discriminate between mutiple events of the same type in the same day.
        /// </summary>
        /// <value>The sequence number of the application events. This is used to discriminate between mutiple events of the same type in the same day.</value>
        [DataMember(Name="sequenceNumber", EmitDefaultValue=false)]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationReference
        /// </summary>
        [DataMember(Name="applicationReference", EmitDefaultValue=false)]
        public TpdmApplicationReference ApplicationReference { get; set; }

        /// <summary>
        /// Gets or Sets SchoolYearTypeReference
        /// </summary>
        [DataMember(Name="schoolYearTypeReference", EmitDefaultValue=false)]
        public EdFiSchoolYearTypeReference SchoolYearTypeReference { get; set; }

        /// <summary>
        /// Application evaluation score, if applicable.
        /// </summary>
        /// <value>Application evaluation score, if applicable.</value>
        [DataMember(Name="applicationEvaluationScore", EmitDefaultValue=false)]
        public double? ApplicationEvaluationScore { get; set; }

        /// <summary>
        /// The recommendation, result or conclusion of the application event (e.g., Continue, exit, recommend for hire).
        /// </summary>
        /// <value>The recommendation, result or conclusion of the application event (e.g., Continue, exit, recommend for hire).</value>
        [DataMember(Name="applicationEventResultDescriptor", EmitDefaultValue=false)]
        public string ApplicationEventResultDescriptor { get; set; }

        /// <summary>
        /// The end date of the event, if an interval.
        /// </summary>
        /// <value>The end date of the event, if an interval.</value>
        [DataMember(Name="eventEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? EventEndDate { get; set; }

        /// <summary>
        /// This descriptor defines the term of a session during the school year (e.g., Fall Semester).
        /// </summary>
        /// <value>This descriptor defines the term of a session during the school year (e.g., Fall Semester).</value>
        [DataMember(Name="termDescriptor", EmitDefaultValue=false)]
        public string TermDescriptor { get; set; }

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
            sb.Append("class TpdmApplicationEvent {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ApplicationEventTypeDescriptor: ").Append(ApplicationEventTypeDescriptor).Append("\n");
            sb.Append("  EventDate: ").Append(EventDate).Append("\n");
            sb.Append("  SequenceNumber: ").Append(SequenceNumber).Append("\n");
            sb.Append("  ApplicationReference: ").Append(ApplicationReference).Append("\n");
            sb.Append("  SchoolYearTypeReference: ").Append(SchoolYearTypeReference).Append("\n");
            sb.Append("  ApplicationEvaluationScore: ").Append(ApplicationEvaluationScore).Append("\n");
            sb.Append("  ApplicationEventResultDescriptor: ").Append(ApplicationEventResultDescriptor).Append("\n");
            sb.Append("  EventEndDate: ").Append(EventEndDate).Append("\n");
            sb.Append("  TermDescriptor: ").Append(TermDescriptor).Append("\n");
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
            return this.Equals(input as TpdmApplicationEvent);
        }

        /// <summary>
        /// Returns true if TpdmApplicationEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of TpdmApplicationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TpdmApplicationEvent input)
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
                    this.ApplicationEventTypeDescriptor == input.ApplicationEventTypeDescriptor ||
                    (this.ApplicationEventTypeDescriptor != null &&
                    this.ApplicationEventTypeDescriptor.Equals(input.ApplicationEventTypeDescriptor))
                ) && 
                (
                    this.EventDate == input.EventDate ||
                    (this.EventDate != null &&
                    this.EventDate.Equals(input.EventDate))
                ) && 
                (
                    this.SequenceNumber == input.SequenceNumber ||
                    (this.SequenceNumber != null &&
                    this.SequenceNumber.Equals(input.SequenceNumber))
                ) && 
                (
                    this.ApplicationReference == input.ApplicationReference ||
                    (this.ApplicationReference != null &&
                    this.ApplicationReference.Equals(input.ApplicationReference))
                ) && 
                (
                    this.SchoolYearTypeReference == input.SchoolYearTypeReference ||
                    (this.SchoolYearTypeReference != null &&
                    this.SchoolYearTypeReference.Equals(input.SchoolYearTypeReference))
                ) && 
                (
                    this.ApplicationEvaluationScore == input.ApplicationEvaluationScore ||
                    (this.ApplicationEvaluationScore != null &&
                    this.ApplicationEvaluationScore.Equals(input.ApplicationEvaluationScore))
                ) && 
                (
                    this.ApplicationEventResultDescriptor == input.ApplicationEventResultDescriptor ||
                    (this.ApplicationEventResultDescriptor != null &&
                    this.ApplicationEventResultDescriptor.Equals(input.ApplicationEventResultDescriptor))
                ) && 
                (
                    this.EventEndDate == input.EventEndDate ||
                    (this.EventEndDate != null &&
                    this.EventEndDate.Equals(input.EventEndDate))
                ) && 
                (
                    this.TermDescriptor == input.TermDescriptor ||
                    (this.TermDescriptor != null &&
                    this.TermDescriptor.Equals(input.TermDescriptor))
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
                if (this.ApplicationEventTypeDescriptor != null)
                    hashCode = hashCode * 59 + this.ApplicationEventTypeDescriptor.GetHashCode();
                if (this.EventDate != null)
                    hashCode = hashCode * 59 + this.EventDate.GetHashCode();
                if (this.SequenceNumber != null)
                    hashCode = hashCode * 59 + this.SequenceNumber.GetHashCode();
                if (this.ApplicationReference != null)
                    hashCode = hashCode * 59 + this.ApplicationReference.GetHashCode();
                if (this.SchoolYearTypeReference != null)
                    hashCode = hashCode * 59 + this.SchoolYearTypeReference.GetHashCode();
                if (this.ApplicationEvaluationScore != null)
                    hashCode = hashCode * 59 + this.ApplicationEvaluationScore.GetHashCode();
                if (this.ApplicationEventResultDescriptor != null)
                    hashCode = hashCode * 59 + this.ApplicationEventResultDescriptor.GetHashCode();
                if (this.EventEndDate != null)
                    hashCode = hashCode * 59 + this.EventEndDate.GetHashCode();
                if (this.TermDescriptor != null)
                    hashCode = hashCode * 59 + this.TermDescriptor.GetHashCode();
                if (this.Etag != null)
                    hashCode = hashCode * 59 + this.Etag.GetHashCode();
                return hashCode;
            }
        }
    }

}