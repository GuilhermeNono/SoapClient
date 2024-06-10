using System.Xml.Serialization;

namespace Nono.Tests.Contracts;

[XmlRoot(ElementName = "Consulta", Namespace = "urn:Giftty")]
public class GifttyGetStockTesteRequest
{
    [XmlElement(Namespace = "urn:Giftty")]
    public string chave { get; set; }
    [XmlElement(Namespace = "urn:Giftty")]
    public int? Produto { get; set; }
    [XmlElement(Namespace = "urn:Giftty")]
    public string? Projeto { get; set; }
}