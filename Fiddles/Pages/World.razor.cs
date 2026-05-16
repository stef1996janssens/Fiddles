using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Fiddles.Pages;

public partial class World
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;
    [Inject] private NavigationManager NavigationManager { get; set; } = default!;

    private IJSObjectReference? _jsModule;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var baseUri = NavigationManager.BaseUri.TrimEnd('/');
            var scriptPath = $"{baseUri}/js/world.js?v={DateTime.Now.Ticks}";
            _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", scriptPath);
            await _jsModule.InvokeVoidAsync("createScene", "three-canvas");
        }
    }
}


//protected override async Task OnAfterRenderAsync(bool firstRender)
//    {
//        if (firstRender)
//        {
//            var baseUri = NavigationManager.BaseUri.TrimEnd('/');
//            var scriptPath = $"{baseUri}/_content/SoftFlare.Blazor/js/softflare-toggle-theme-button.js";
//            _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", scriptPath);
//            await _jsModule.InvokeVoidAsync("initTheme");
//        }
//    }


//    private async Task ToggleTheme()
//    {
//        currentTheme = currentTheme == "dark" ? "light" : "dark";
//        if (_jsModule is not null)
//        {
//            await _jsModule.InvokeVoidAsync("setTheme", currentTheme);
//        }
//    }