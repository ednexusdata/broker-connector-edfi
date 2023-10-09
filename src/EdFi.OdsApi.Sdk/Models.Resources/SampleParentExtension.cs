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
    /// SampleParentExtension
    /// </summary>
    [DataContract]
    public partial class SampleParentExtension :  IEquatable<SampleParentExtension>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleParentExtension" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SampleParentExtension() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleParentExtension" /> class.
        /// </summary>
        /// <param name="credentialFieldDescriptor">The field in which the parent holds a credential..</param>
        /// <param name="averageCarLineWait">The time spent per day waiting in the car line..</param>
        /// <param name="becameParent">The year in which the parent first became a parent..</param>
        /// <param name="coffeeSpend">How much the parent spends on coffee in a week..</param>
        /// <param name="duration">The amount of time the parent spends reading to his/her children at bedtime..</param>
        /// <param name="gpa">The parent&#39;s high school GPA..</param>
        /// <param name="graduationDate">The date the parent graduated high school..</param>
        /// <param name="isSportsFan">An indication as to whether the parent is a sports fan. (required).</param>
        /// <param name="luckyNumber">The parent&#39;s lucky number..</param>
        /// <param name="preferredWakeUpTime">The time the parent would prefer to wake up in the morning..</param>
        /// <param name="rainCertainty">The percent likelihood that it will rain when the parent volunteers to chaperone a field trip..</param>
        /// <param name="authors">An unordered collection of parentAuthors. The parent&#39;s favorite authors..</param>
        /// <param name="ceilingHeights">An unordered collection of parentCeilingHeights. The height of the ceiling in the rooms of the parent&#39;s home..</param>
        /// <param name="educationContents">An unordered collection of parentEducationContents. Education content to which the parent has been referred..</param>
        /// <param name="favoriteBookTitles">An unordered collection of parentFavoriteBookTitles. The title of the parent&#39;s favorite book. (required).</param>
        /// <param name="studentProgramAssociations">An unordered collection of parentStudentProgramAssociations. Programs the parent&#39;s child or children are enrolled in for which the parent provides volunteer services..</param>
        /// <param name="cteProgram">cteProgram.</param>
        /// <param name="teacherConference">teacherConference.</param>
        public SampleParentExtension(string credentialFieldDescriptor = default(string), string averageCarLineWait = default(string), int? becameParent = default(int?), double? coffeeSpend = default(double?), int? duration = default(int?), double? gpa = default(double?), DateTime? graduationDate = default(DateTime?), bool? isSportsFan = default(bool?), int? luckyNumber = default(int?), string preferredWakeUpTime = default(string), double? rainCertainty = default(double?), List<SampleParentAuthor> authors = default(List<SampleParentAuthor>), List<SampleParentCeilingHeight> ceilingHeights = default(List<SampleParentCeilingHeight>), List<SampleParentEducationContent> educationContents = default(List<SampleParentEducationContent>), List<SampleParentFavoriteBookTitle> favoriteBookTitles = default(List<SampleParentFavoriteBookTitle>), List<SampleParentStudentProgramAssociation> studentProgramAssociations = default(List<SampleParentStudentProgramAssociation>), SampleParentCTEProgram cteProgram = default(SampleParentCTEProgram), SampleParentTeacherConference teacherConference = default(SampleParentTeacherConference))
        {
            // to ensure "isSportsFan" is required (not null)
            if (isSportsFan == null)
            {
                throw new InvalidDataException("isSportsFan is a required property for SampleParentExtension and cannot be null");
            }
            else
            {
                this.IsSportsFan = isSportsFan;
            }
            // to ensure "favoriteBookTitles" is required (not null)
            if (favoriteBookTitles == null)
            {
                throw new InvalidDataException("favoriteBookTitles is a required property for SampleParentExtension and cannot be null");
            }
            else
            {
                this.FavoriteBookTitles = favoriteBookTitles;
            }
            this.CredentialFieldDescriptor = credentialFieldDescriptor;
            this.AverageCarLineWait = averageCarLineWait;
            this.BecameParent = becameParent;
            this.CoffeeSpend = coffeeSpend;
            this.Duration = duration;
            this.Gpa = gpa;
            this.GraduationDate = graduationDate;
            this.LuckyNumber = luckyNumber;
            this.PreferredWakeUpTime = preferredWakeUpTime;
            this.RainCertainty = rainCertainty;
            this.Authors = authors;
            this.CeilingHeights = ceilingHeights;
            this.EducationContents = educationContents;
            this.StudentProgramAssociations = studentProgramAssociations;
            this.CteProgram = cteProgram;
            this.TeacherConference = teacherConference;
        }
        
        /// <summary>
        /// The field in which the parent holds a credential.
        /// </summary>
        /// <value>The field in which the parent holds a credential.</value>
        [DataMember(Name="credentialFieldDescriptor", EmitDefaultValue=false)]
        public string CredentialFieldDescriptor { get; set; }

        /// <summary>
        /// The time spent per day waiting in the car line.
        /// </summary>
        /// <value>The time spent per day waiting in the car line.</value>
        [DataMember(Name="averageCarLineWait", EmitDefaultValue=false)]
        public string AverageCarLineWait { get; set; }

        /// <summary>
        /// The year in which the parent first became a parent.
        /// </summary>
        /// <value>The year in which the parent first became a parent.</value>
        [DataMember(Name="becameParent", EmitDefaultValue=false)]
        public int? BecameParent { get; set; }

        /// <summary>
        /// How much the parent spends on coffee in a week.
        /// </summary>
        /// <value>How much the parent spends on coffee in a week.</value>
        [DataMember(Name="coffeeSpend", EmitDefaultValue=false)]
        public double? CoffeeSpend { get; set; }

        /// <summary>
        /// The amount of time the parent spends reading to his/her children at bedtime.
        /// </summary>
        /// <value>The amount of time the parent spends reading to his/her children at bedtime.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The parent&#39;s high school GPA.
        /// </summary>
        /// <value>The parent&#39;s high school GPA.</value>
        [DataMember(Name="gpa", EmitDefaultValue=false)]
        public double? Gpa { get; set; }

        /// <summary>
        /// The date the parent graduated high school.
        /// </summary>
        /// <value>The date the parent graduated high school.</value>
        [DataMember(Name="graduationDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? GraduationDate { get; set; }

        /// <summary>
        /// An indication as to whether the parent is a sports fan.
        /// </summary>
        /// <value>An indication as to whether the parent is a sports fan.</value>
        [DataMember(Name="isSportsFan", EmitDefaultValue=false)]
        public bool? IsSportsFan { get; set; }

        /// <summary>
        /// The parent&#39;s lucky number.
        /// </summary>
        /// <value>The parent&#39;s lucky number.</value>
        [DataMember(Name="luckyNumber", EmitDefaultValue=false)]
        public int? LuckyNumber { get; set; }

        /// <summary>
        /// The time the parent would prefer to wake up in the morning.
        /// </summary>
        /// <value>The time the parent would prefer to wake up in the morning.</value>
        [DataMember(Name="preferredWakeUpTime", EmitDefaultValue=false)]
        public string PreferredWakeUpTime { get; set; }

        /// <summary>
        /// The percent likelihood that it will rain when the parent volunteers to chaperone a field trip.
        /// </summary>
        /// <value>The percent likelihood that it will rain when the parent volunteers to chaperone a field trip.</value>
        [DataMember(Name="rainCertainty", EmitDefaultValue=false)]
        public double? RainCertainty { get; set; }

        /// <summary>
        /// An unordered collection of parentAuthors. The parent&#39;s favorite authors.
        /// </summary>
        /// <value>An unordered collection of parentAuthors. The parent&#39;s favorite authors.</value>
        [DataMember(Name="authors", EmitDefaultValue=false)]
        public List<SampleParentAuthor> Authors { get; set; }

        /// <summary>
        /// An unordered collection of parentCeilingHeights. The height of the ceiling in the rooms of the parent&#39;s home.
        /// </summary>
        /// <value>An unordered collection of parentCeilingHeights. The height of the ceiling in the rooms of the parent&#39;s home.</value>
        [DataMember(Name="ceilingHeights", EmitDefaultValue=false)]
        public List<SampleParentCeilingHeight> CeilingHeights { get; set; }

        /// <summary>
        /// An unordered collection of parentEducationContents. Education content to which the parent has been referred.
        /// </summary>
        /// <value>An unordered collection of parentEducationContents. Education content to which the parent has been referred.</value>
        [DataMember(Name="educationContents", EmitDefaultValue=false)]
        public List<SampleParentEducationContent> EducationContents { get; set; }

        /// <summary>
        /// An unordered collection of parentFavoriteBookTitles. The title of the parent&#39;s favorite book.
        /// </summary>
        /// <value>An unordered collection of parentFavoriteBookTitles. The title of the parent&#39;s favorite book.</value>
        [DataMember(Name="favoriteBookTitles", EmitDefaultValue=false)]
        public List<SampleParentFavoriteBookTitle> FavoriteBookTitles { get; set; }

        /// <summary>
        /// An unordered collection of parentStudentProgramAssociations. Programs the parent&#39;s child or children are enrolled in for which the parent provides volunteer services.
        /// </summary>
        /// <value>An unordered collection of parentStudentProgramAssociations. Programs the parent&#39;s child or children are enrolled in for which the parent provides volunteer services.</value>
        [DataMember(Name="studentProgramAssociations", EmitDefaultValue=false)]
        public List<SampleParentStudentProgramAssociation> StudentProgramAssociations { get; set; }

        /// <summary>
        /// Gets or Sets CteProgram
        /// </summary>
        [DataMember(Name="cteProgram", EmitDefaultValue=false)]
        public SampleParentCTEProgram CteProgram { get; set; }

        /// <summary>
        /// Gets or Sets TeacherConference
        /// </summary>
        [DataMember(Name="teacherConference", EmitDefaultValue=false)]
        public SampleParentTeacherConference TeacherConference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SampleParentExtension {\n");
            sb.Append("  CredentialFieldDescriptor: ").Append(CredentialFieldDescriptor).Append("\n");
            sb.Append("  AverageCarLineWait: ").Append(AverageCarLineWait).Append("\n");
            sb.Append("  BecameParent: ").Append(BecameParent).Append("\n");
            sb.Append("  CoffeeSpend: ").Append(CoffeeSpend).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Gpa: ").Append(Gpa).Append("\n");
            sb.Append("  GraduationDate: ").Append(GraduationDate).Append("\n");
            sb.Append("  IsSportsFan: ").Append(IsSportsFan).Append("\n");
            sb.Append("  LuckyNumber: ").Append(LuckyNumber).Append("\n");
            sb.Append("  PreferredWakeUpTime: ").Append(PreferredWakeUpTime).Append("\n");
            sb.Append("  RainCertainty: ").Append(RainCertainty).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("  CeilingHeights: ").Append(CeilingHeights).Append("\n");
            sb.Append("  EducationContents: ").Append(EducationContents).Append("\n");
            sb.Append("  FavoriteBookTitles: ").Append(FavoriteBookTitles).Append("\n");
            sb.Append("  StudentProgramAssociations: ").Append(StudentProgramAssociations).Append("\n");
            sb.Append("  CteProgram: ").Append(CteProgram).Append("\n");
            sb.Append("  TeacherConference: ").Append(TeacherConference).Append("\n");
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
            return this.Equals(input as SampleParentExtension);
        }

        /// <summary>
        /// Returns true if SampleParentExtension instances are equal
        /// </summary>
        /// <param name="input">Instance of SampleParentExtension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SampleParentExtension input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CredentialFieldDescriptor == input.CredentialFieldDescriptor ||
                    (this.CredentialFieldDescriptor != null &&
                    this.CredentialFieldDescriptor.Equals(input.CredentialFieldDescriptor))
                ) && 
                (
                    this.AverageCarLineWait == input.AverageCarLineWait ||
                    (this.AverageCarLineWait != null &&
                    this.AverageCarLineWait.Equals(input.AverageCarLineWait))
                ) && 
                (
                    this.BecameParent == input.BecameParent ||
                    (this.BecameParent != null &&
                    this.BecameParent.Equals(input.BecameParent))
                ) && 
                (
                    this.CoffeeSpend == input.CoffeeSpend ||
                    (this.CoffeeSpend != null &&
                    this.CoffeeSpend.Equals(input.CoffeeSpend))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Gpa == input.Gpa ||
                    (this.Gpa != null &&
                    this.Gpa.Equals(input.Gpa))
                ) && 
                (
                    this.GraduationDate == input.GraduationDate ||
                    (this.GraduationDate != null &&
                    this.GraduationDate.Equals(input.GraduationDate))
                ) && 
                (
                    this.IsSportsFan == input.IsSportsFan ||
                    (this.IsSportsFan != null &&
                    this.IsSportsFan.Equals(input.IsSportsFan))
                ) && 
                (
                    this.LuckyNumber == input.LuckyNumber ||
                    (this.LuckyNumber != null &&
                    this.LuckyNumber.Equals(input.LuckyNumber))
                ) && 
                (
                    this.PreferredWakeUpTime == input.PreferredWakeUpTime ||
                    (this.PreferredWakeUpTime != null &&
                    this.PreferredWakeUpTime.Equals(input.PreferredWakeUpTime))
                ) && 
                (
                    this.RainCertainty == input.RainCertainty ||
                    (this.RainCertainty != null &&
                    this.RainCertainty.Equals(input.RainCertainty))
                ) && 
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
                ) && 
                (
                    this.CeilingHeights == input.CeilingHeights ||
                    this.CeilingHeights != null &&
                    this.CeilingHeights.SequenceEqual(input.CeilingHeights)
                ) && 
                (
                    this.EducationContents == input.EducationContents ||
                    this.EducationContents != null &&
                    this.EducationContents.SequenceEqual(input.EducationContents)
                ) && 
                (
                    this.FavoriteBookTitles == input.FavoriteBookTitles ||
                    this.FavoriteBookTitles != null &&
                    this.FavoriteBookTitles.SequenceEqual(input.FavoriteBookTitles)
                ) && 
                (
                    this.StudentProgramAssociations == input.StudentProgramAssociations ||
                    this.StudentProgramAssociations != null &&
                    this.StudentProgramAssociations.SequenceEqual(input.StudentProgramAssociations)
                ) && 
                (
                    this.CteProgram == input.CteProgram ||
                    (this.CteProgram != null &&
                    this.CteProgram.Equals(input.CteProgram))
                ) && 
                (
                    this.TeacherConference == input.TeacherConference ||
                    (this.TeacherConference != null &&
                    this.TeacherConference.Equals(input.TeacherConference))
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
                if (this.CredentialFieldDescriptor != null)
                    hashCode = hashCode * 59 + this.CredentialFieldDescriptor.GetHashCode();
                if (this.AverageCarLineWait != null)
                    hashCode = hashCode * 59 + this.AverageCarLineWait.GetHashCode();
                if (this.BecameParent != null)
                    hashCode = hashCode * 59 + this.BecameParent.GetHashCode();
                if (this.CoffeeSpend != null)
                    hashCode = hashCode * 59 + this.CoffeeSpend.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Gpa != null)
                    hashCode = hashCode * 59 + this.Gpa.GetHashCode();
                if (this.GraduationDate != null)
                    hashCode = hashCode * 59 + this.GraduationDate.GetHashCode();
                if (this.IsSportsFan != null)
                    hashCode = hashCode * 59 + this.IsSportsFan.GetHashCode();
                if (this.LuckyNumber != null)
                    hashCode = hashCode * 59 + this.LuckyNumber.GetHashCode();
                if (this.PreferredWakeUpTime != null)
                    hashCode = hashCode * 59 + this.PreferredWakeUpTime.GetHashCode();
                if (this.RainCertainty != null)
                    hashCode = hashCode * 59 + this.RainCertainty.GetHashCode();
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
                if (this.CeilingHeights != null)
                    hashCode = hashCode * 59 + this.CeilingHeights.GetHashCode();
                if (this.EducationContents != null)
                    hashCode = hashCode * 59 + this.EducationContents.GetHashCode();
                if (this.FavoriteBookTitles != null)
                    hashCode = hashCode * 59 + this.FavoriteBookTitles.GetHashCode();
                if (this.StudentProgramAssociations != null)
                    hashCode = hashCode * 59 + this.StudentProgramAssociations.GetHashCode();
                if (this.CteProgram != null)
                    hashCode = hashCode * 59 + this.CteProgram.GetHashCode();
                if (this.TeacherConference != null)
                    hashCode = hashCode * 59 + this.TeacherConference.GetHashCode();
                return hashCode;
            }
        }
    }

}