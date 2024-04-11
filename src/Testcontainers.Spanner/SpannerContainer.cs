namespace Testcontainers.Spanner;

/// <inheritdoc cref="DockerContainer" />
[PublicAPI]
public sealed class SpannerContainer : DockerContainer
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SpannerContainer" /> class.
    /// </summary>
    /// <param name="configuration">The container configuration.</param>
    public SpannerContainer(SpannerConfiguration configuration)
        : base(configuration)
    {
    }

    /// <summary>
    /// Gets the BigQuery emulator endpoint.
    /// </summary>
    /// <returns>The BigQuery emulator endpoint.</returns>
    public string GetEmulatorEndpoint()
    {
        return new UriBuilder(Uri.UriSchemeHttp, Hostname, GetMappedPublicPort(SpannerBuilder.RestSpannerPort)).ToString();
    }

    
    public string GetEmulatorgRpcEndpoint()
    {
        return new UriBuilder(Uri.UriSchemeHttp, Hostname, GetMappedPublicPort(SpannerBuilder.gRpcSpannerPort)).ToString();
    }
}