using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using OregonNexus.Broker.Connector.Configuration;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi;

public class Student : IStudent
{
    [DataType(DataType.Text)]
    [Description("Student USI in the Ed-Fi ODS database.")]
    public int? StudentUsi { get; set; }

    [DataType(DataType.Text)]
    [Description("Student Unique ID, usually specified from ODS data source.")]
    public string? StudentUniqueId { get; set; }
}