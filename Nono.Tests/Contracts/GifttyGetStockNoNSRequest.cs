using System.Xml.Serialization;

namespace Nono.Tests.Contracts;

[XmlRoot(ElementName = "Consulta", Namespace = "")]
public class GifttyGetStockNoNSRequest
{
    [XmlElement(ElementName = "chave", Namespace = "")]
    public string Key { get; set; }
    [XmlElement(ElementName = "Produto", Namespace = "")]
    public int? Product { get; set; }
    [XmlElement(ElementName = "Projeto", Namespace = "")]
    public string? Project { get; set; }
}