using Nono.Client;

namespace Nono.Tests;

public sealed class ClientFixture : IDisposable
{
    private const string SoapUrl = "http://localhost:8080/giftty";
    private const string SoapNamespace = "urn:Giftty";
    public SoapClient Client;

    public ClientFixture()
    {
        Client = new SoapClient(SoapUrl, SoapNamespace);
    }

    public void Dispose() => Client.Dispose();
}