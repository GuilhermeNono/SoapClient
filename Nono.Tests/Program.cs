using Nono.Tests.Contracts;
using SoapClient;

Client client = new("http://localhost:8080/giftty", "urn:Giftty");

var teste = await client.PostAsync<Estoque>(
    "Consulta",
    new GifttyGetStockTesteRequest()
    {
        chave = "5",
        Produto = 2,
        Projeto = "ad"
    }
);

Console.WriteLine(teste);
Console.ReadKey();