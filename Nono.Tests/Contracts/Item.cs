using System.Xml.Serialization;

namespace Nono.Tests.Contracts;

[XmlRoot("Item", Namespace = "urn:Giftty")]
public class Item
{
    [XmlElement("quantidade", Namespace = "urn:Giftty")]
    public int Quantity { get; set; }

    [XmlElement("Produto", Namespace = "urn:Giftty")]
    public long Product { get; set; }

    [XmlElement("preco", Namespace = "urn:Giftty")]
    public decimal Price { get; set; }
}