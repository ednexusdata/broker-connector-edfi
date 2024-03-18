using System.ComponentModel;

namespace EdNexusData.Broker.Connector.EdFiAlliance.EdFi.Payloads;

[DisplayName("Student Cumulative Record")]
public class StudentCumulativeRecord
{
    public List<string> PayloadContents { get; set;} = new List<string>();
}
