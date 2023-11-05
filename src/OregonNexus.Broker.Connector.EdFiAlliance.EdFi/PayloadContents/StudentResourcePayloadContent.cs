using System;
using EdFi.OdsApi.Sdk.Api.Resources;
using Microsoft.Extensions.Logging;
using OregonNexus.Broker.Connector.PayloadContents;
using OregonNexus.Broker.Connector.PayloadContentTypes;

namespace OregonNexus.Broker.Connector.EdFiAlliance.EdFi.PayloadContents;

public class StudentResourcePayloadContent : DataContentType
{
    public override string Schema => "EdFi";
    public override string SchemaVersion => "3";
    public override string ContentType => "text/json";

    public override string Content { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}