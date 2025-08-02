using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace DataHandler.NhlApiClient.Test;

public abstract class NhlApiClientTestBase
{
    protected AnonymousAuthenticationProvider authProvider;
    protected HttpClientRequestAdapter adapter;
    protected NhlApiClient apiClient;

    [OneTimeSetUp]
    public void Setup()
    {
        authProvider = new AnonymousAuthenticationProvider();
        adapter = new HttpClientRequestAdapter(authProvider);
        apiClient = new NhlApiClient(adapter);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        adapter.Dispose();
    }
}
