using Nono.Tests.Contracts;
using SoapClient;

Client client = new("http://localhost:8080/giftty", "urn:Giftty");

var teste = await client.PostAsync<Estoque>(
    "http://localhost:8080/giftty#ConsultarEstoque",
    new GifttyGetStockTesteRequest()
    {
        Key = "5",
        Product = 2,
        Project = "ad"
    }
);

Console.WriteLine(teste);
Console.ReadKey();