namespace RakibPortfolio.Services;

public interface IThemeService
{
    bool IsDark { get; }

    Task ToggleThemeAsync();

    Task InitializeThemeAsync();
}