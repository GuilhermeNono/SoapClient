using System.Xml.Serialization;

namespace Nono.Tests.Contracts;

[XmlRoot("Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
public class EstoqueBody
{
    [XmlElement("Estoque", Namespace = "urn:Giftty")]
    public Estoque Stock { get; set; }
}