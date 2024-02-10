using System.ComponentModel;
using System.Text.Json;
using OregonNexus.Broker.Connector.Attributes;
using OregonNexus.Broker.Connector.EdFiAlliance.EdFi.Jobs;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

[Job(typeof(StudentProgramAssociationsJob))]
[DisplayName("Student Programs")]
public class StudentProgramAssociationsPayloadContent : PayloadContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "application/json";
}
