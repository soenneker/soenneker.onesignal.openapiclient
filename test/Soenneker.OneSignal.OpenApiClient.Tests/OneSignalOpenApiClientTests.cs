using Soenneker.Tests.HostedUnit;

namespace Soenneker.OneSignal.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OneSignalOpenApiClientTests : HostedUnitTest
{
    public OneSignalOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
