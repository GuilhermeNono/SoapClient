using System.Xml.Serialization;

namespace Nono.Tests.Contracts;

[XmlRoot("Item", Namespace = "urn:Giftty")]
public class Item
{
    [XmlElement("quantidade", Namespace = "urn:Giftty")]
    public int Quantidade { get; set; }

    [XmlElement("Produto", Namespace = "urn:Giftty")]
    public long Produto { get; set; }

    [XmlElement("preco", Namespace = "urn:Giftty")]
    public decimal Preco { get; set; }
}