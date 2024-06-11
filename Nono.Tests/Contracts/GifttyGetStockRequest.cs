using System.Xml.Serialization;

namespace Nono.Tests.Contracts;

[XmlRoot(ElementName = "Consulta", Namespace = "urn:Giftty")]
public class GifttyGetStockRequest
{
    [XmlElement(ElementName = "chave", Namespace = "urn:Giftty")]
    public string Key { get; set; }
    [XmlElement(ElementName = "Produto", Namespace = "urn:Giftty")]
    public int? Product { get; set; }
    [XmlElement(ElementName = "Projeto", Namespace = "urn:Giftty")]
    public string? Project { get; set; }
}