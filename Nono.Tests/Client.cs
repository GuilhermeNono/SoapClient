using System.Xml.Linq;
using FluentAssertions;
using Nono.Client;
using Nono.Tests.Contracts;
using Xunit;

namespace Nono.Tests;

public sealed  class Client : IClassFixture<ClientFixture>
{
    private readonly ClientFixture _client;

    public Client(ClientFixture client)
    {
        _client = client;
    }

    [Fact]
    public async Task Do_Request_With_Request_And_Response()
    {
        const int responseItems = 1;

        var response = await _client.Client.PostAsync<Estoque>(
            "http://localhost:8080/giftty#ConsultarEstoque",
            new GifttyGetStockRequest()
            {
                Key = "5",
                Product = 2,
                Project = "ad"
            }
        );

        response.Should().NotBeNull();
        response.Should().BeOfType<Estoque>();
        response.Items.Should().NotBeEmpty().And.HaveCount(responseItems);
    }

    [Fact]
    public void Convert_Object_To_Serialized_Xml_No_Namespace()
    {
        var serializedXml = new GifttyGetStockNoNSRequest()
        {
            Key = "5",
            Product = 2,
            Project = "ad"
        }.ToXml();

        serializedXml.Should().NotBeNull();
        serializedXml.Should().BeOfType<XElement>();
        serializedXml?.Name.NamespaceName.Should().BeNullOrEmpty();
    }

    [Fact]
    public void Convert_Object_To_Serialized_Xml_With_Namespace()
    {
        const string xmlNamespace = "urn:Giftty";

        var serializedXml = new GifttyGetStockRequest()
        {
            Key = "5",
            Product = 2,
            Project = "ad"
        }.ToXml(xmlNamespace);

        serializedXml.Should().NotBeNull();
        serializedXml.Should().BeOfType<XElement>();
        serializedXml?.Name.NamespaceName.Should().NotBeNull();
        serializedXml!.Name.NamespaceName.Should().Be("urn:Giftty");
    }

    [Fact]
    public void Convert_Serialized_Xml_To_Deserialized_Object_No_Namespace()
    {
        // const string xmlNamespace = "urn:Giftty";

        var serializedXml = new GifttyGetStockNoNSRequest()
        {
            Key = "asd",
            Product = 2,
            Project = "ad"
        }.ToXml()?.ToString();

        var element = XElement.Parse(serializedXml!);

        var deserializedElement = element.ToObject<GifttyGetStockNoNSRequest>();

        deserializedElement.Should().NotBeNull();
        deserializedElement.Should().BeOfType<GifttyGetStockNoNSRequest>();

    }


    [Fact]
    public void Convert_Serialized_Xml_To_Deserialized_Object_With_Namespace()
    {
        // const string xmlNamespace = "urn:Giftty";

        var serializedXml = new GifttyGetStockRequest()
        {
            Key = "asd",
            Product = 2,
            Project = "ad"
        }.ToXml("urn:Giftty")?.ToString();

        var element = XElement.Parse(serializedXml!);

        var deserializedElement = element.ToObject<GifttyGetStockRequest>("urn:Giftty");

        deserializedElement.Should().NotBeNull();
        deserializedElement.Should().BeOfType<GifttyGetStockRequest>();

    }
}