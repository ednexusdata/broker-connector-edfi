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
    /// EdFiCalendarDate
    /// </summary>
    [DataContract(Name = "edFi_calendarDate")]
    public partial class EdFiCalendarDate : IEquatable<EdFiCalendarDate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendarDate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdFiCalendarDate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdFiCalendarDate" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="calendarEvents">An unordered collection of calendarDateCalendarEvents. The type of scheduled or unscheduled event for the day. (required).</param>
        /// <param name="date">The month, day, and year of the calendar event. (required).</param>
        /// <param name="calendarReference">calendarReference (required).</param>
        /// <param name="etag">A unique system-generated value that identifies the version of the resource..</param>
        /// <param name="lastModifiedDate">The date and time the resource was last modified..</param>
        public EdFiCalendarDate(string id = default(string), List<EdFiCalendarDateCalendarEvent> calendarEvents = default(List<EdFiCalendarDateCalendarEvent>), DateTime date = default(DateTime), EdFiCalendarReference calendarReference = default(EdFiCalendarReference), string etag = default(string), DateTime lastModifiedDate = default(DateTime))
        {
            // to ensure "calendarEvents" is required (not null)
            if (calendarEvents == null)
            {
                throw new ArgumentNullException("calendarEvents is a required property for EdFiCalendarDate and cannot be null");
            }
            this.CalendarEvents = calendarEvents;
            this.Date = date;
            // to ensure "calendarReference" is required (not null)
            if (calendarReference == null)
            {
                throw new ArgumentNullException("calendarReference is a required property for EdFiCalendarDate and cannot be null");
            }
            this.CalendarReference = calendarReference;
            this.Id = id;
            this.Etag = etag;
            this.LastModifiedDate = lastModifiedDate;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// An unordered collection of calendarDateCalendarEvents. The type of scheduled or unscheduled event for the day.
        /// </summary>
        /// <value>An unordered collection of calendarDateCalendarEvents. The type of scheduled or unscheduled event for the day.</value>
        [DataMember(Name = "calendarEvents", IsRequired = true, EmitDefaultValue = true)]
        public List<EdFiCalendarDateCalendarEvent> CalendarEvents { get; set; }

        /// <summary>
        /// The month, day, and year of the calendar event.
        /// </summary>
        /// <value>The month, day, and year of the calendar event.</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets CalendarReference
        /// </summary>
        [DataMember(Name = "calendarReference", IsRequired = true, EmitDefaultValue = true)]
        public EdFiCalendarReference CalendarReference { get; set; }

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
            sb.Append("class EdFiCalendarDate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CalendarEvents: ").Append(CalendarEvents).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CalendarReference: ").Append(CalendarReference).Append("\n");
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
            return this.Equals(input as EdFiCalendarDate);
        }

        /// <summary>
        /// Returns true if EdFiCalendarDate instances are equal
        /// </summary>
        /// <param name="input">Instance of EdFiCalendarDate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdFiCalendarDate input)
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
                    this.CalendarEvents == input.CalendarEvents ||
                    this.CalendarEvents != null &&
                    input.CalendarEvents != null &&
                    this.CalendarEvents.SequenceEqual(input.CalendarEvents)
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.CalendarReference == input.CalendarReference ||
                    (this.CalendarReference != null &&
                    this.CalendarReference.Equals(input.CalendarReference))
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
                if (this.CalendarEvents != null)
                {
                    hashCode = (hashCode * 59) + this.CalendarEvents.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.CalendarReference != null)
                {
                    hashCode = (hashCode * 59) + this.CalendarReference.GetHashCode();
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
            yield break;
        }
    }

}