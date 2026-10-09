using System.Net.Http.Json;

namespace RakibPortfolio.Services;

public class PortfolioService : IPortfolioService
{
    private readonly HttpClient _httpClient;
    private Models.PortfolioData? _cachedData;

    public PortfolioService(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    public async Task<Models.PortfolioData> GetPortfolioDataAsync()
    {
        if (_cachedData is not null)
        {
            return _cachedData;
        }

        _cachedData = await _httpClient
            .GetFromJsonAsync<Models.PortfolioData>("data/portfolio.json")
            ?? throw new InvalidOperationException("Unable to load portfolio data.");

        return _cachedData;
    }
}