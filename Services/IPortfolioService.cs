namespace RakibPortfolio.Services;

public interface IPortfolioService
{
    Task<Models.PortfolioData> GetPortfolioDataAsync();
}