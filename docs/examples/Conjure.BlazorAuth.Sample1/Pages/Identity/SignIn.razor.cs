using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.JSInterop;
using System.Text.Json;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity
{
    public partial class SignIn
    {
        [Inject]
        private IHttpContextAccessor HttpContextAccessor { get; set; } = default!;

        [Inject]
        private NavigationManager Nav { get; set; } = default!;

        [Inject]
        private ISignInClient SignInClient { get; set; } = default!;

        [Inject]
        private IJSRuntime JS { get; set; } = default!;

        [Inject]
        private AuthenticationStateProvider AuthStateProvider { get; set; } = default!;

        [Inject]
        private SignInManager<IdentityUser> SIM { get; set; } = default!;

        private AuthenticationState? _authState;

        private string? _result;

        public string? UserName { get; set; } = "jdoe1@mailinator.com";
        public string? Password { get; set; } = "P@$$w0rd";

        public bool RememberMe { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await base.OnAfterRenderAsync(firstRender);
            if (firstRender)
            {
                _authState = await AuthStateProvider.GetAuthenticationStateAsync();
                StateHasChanged();
            }
        }

        private async Task DoSignIn()
        {
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
            {
                _result = "You must specify a username + password";
                return;
            }

            var result = await SignInClient.SignInAsync(UserName, Password);

            if (result == null)
            {
                _result = "No response";
            }
            else
            {
                _result = JsonSerializer.Serialize(result);
            }

            if (result?.Succeeded ?? false)
            {
                _authState = await AuthStateProvider.GetAuthenticationStateAsync();
                StateHasChanged();

                if (AuthStateProvider is IHostEnvironmentAuthenticationStateProvider heasp)
                {
                    _authState = new AuthenticationState(await SignInClient.CreateClaimsPrincipal(UserName));
                    heasp.SetAuthenticationState(Task.FromResult(_authState));
                }
            }
        }
    }
}
