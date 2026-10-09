using Microsoft.JSInterop;

namespace RakibPortfolio.Services;

public class ThemeService : IThemeService
{
    private readonly IJSRuntime _jsRuntime;
    private bool _isDark;

    public ThemeService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public bool IsDark => _isDark;

    public async Task ToggleThemeAsync()
    {
        _isDark = !_isDark;
        await _jsRuntime.InvokeVoidAsync("setTheme", _isDark ? "dark" : "light");
        await _jsRuntime.InvokeVoidAsync("saveTheme", _isDark ? "dark" : "light");
    }

    public async Task InitializeThemeAsync()
    {
        var theme = await _jsRuntime.InvokeAsync<string>("getTheme");
        if (theme is null or "light")
        {
            _isDark = false;
            await _jsRuntime.InvokeVoidAsync("setTheme", "light");
        }
        else
        {
            _isDark = true;
            await _jsRuntime.InvokeVoidAsync("setTheme", "dark");
        }

        await _jsRuntime.InvokeVoidAsync("saveTheme", _isDark ? "dark" : "light");
    }
}