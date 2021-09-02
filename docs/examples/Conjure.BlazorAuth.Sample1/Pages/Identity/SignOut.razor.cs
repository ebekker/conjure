using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity
{
    public partial class SignOut
    {
        [Inject]
        private NavigationManager Nav { get; set; } = default!;

        [Inject]
        private ISignInClient SignInClient { get; set; } = default!;

        [Inject]
        private IJSRuntime JS { get; set; } = default!;

        [Inject]
        private AuthenticationStateProvider AuthStateProvider { get; set; } = default!;

        private AuthenticationState? _authState;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                _authState = await AuthStateProvider.GetAuthenticationStateAsync();
                StateHasChanged();
            }
        }

        private async Task DoSignOut()
        {
            if (await SignInClient.SignOutAsync())
            {
                _authState = await AuthStateProvider.GetAuthenticationStateAsync();
                StateHasChanged();

                if (AuthStateProvider is IHostEnvironmentAuthenticationStateProvider heasp)
                {
                    _authState = new AuthenticationState(await SignInClient.CreateClaimsPrincipal());
                    heasp.SetAuthenticationState(Task.FromResult(_authState));
                }

                //Nav.NavigateTo("/", forceLoad: false, replace: false);
                return;
            }
            await JS.InvokeVoidAsync("alert", "Unable to sign out.");
        }

        private Task DoCancel()
        {
            Nav.NavigateTo("/", forceLoad: false, replace: false);
            return Task.CompletedTask;
        }
    }
}
