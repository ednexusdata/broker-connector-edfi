using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using OregonNexus.Broker.Connector.Payload;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Payloads;

[DisplayName("Student Cumulative Record")]
public class StudentCumulativeRecord
{
    [DisplayName("Students")]
    [Description("Indicates whether to use the Students resource.")]
    [DataType(DataType.Text)]
    public string Students { get; set; }

    [DisplayName("Student Assessments")]
    [Description("Indicates whether to use the Student Assessments resource.")]
    [DataType(DataType.Text)]
    public string StudentAssessments { get; set; }

    [DisplayName("Grades")]
    [Description("Indicates whether to use the Grades resource.")]
    [DataType(DataType.Text)]
    public string Grades { get; set; }

    [DisplayName("Course Transcripts")]
    [Description("Indicates whether to use the Course Transcripts resource.")]
    [DataType(DataType.Text)]
    public string CourseTranscripts { get; set; }

    [DisplayName("Program Associations")]
    [Description("Indicates whether to use the Program Associations resource.")]
    [DataType(DataType.Text)]
    public string ProgramAssociations { get; set; }

    [DisplayName("Student Section Associations")]
    [Description("Indicates whether to use the Student Section Associations resource.")]
    [DataType(DataType.Text)]
    public string StudentSectionAssociations { get; set; }

    [DisplayName("Discipline Actions")]
    [Description("Indicates whether to use the Discipline Actions resource.")]
    [DataType(DataType.Text)]
    public string DisciplineActions { get; set; }

    [DisplayName("Discipline Incidents")]
    [Description("Indicates whether to use the Discipline Incidents resource.")]
    [DataType(DataType.Text)]
    public string DisciplineIncidents { get; set; }
}