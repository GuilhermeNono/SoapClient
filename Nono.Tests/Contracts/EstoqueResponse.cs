using System.Xml.Serialization;

namespace Nono.Tests.Contracts;

[XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class EstoqueResponse
{
    [XmlElement("Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public EstoqueBody Body { get; set; }
}