using System.Xml.Serialization;

namespace Nono.Tests.Contracts;

[XmlRoot("Estoque", Namespace = "urn:Giftty")]
public class Estoque
{
    [XmlElement("Item", Namespace = "urn:Giftty")]
    public List<Item> Items { get; set; }
}