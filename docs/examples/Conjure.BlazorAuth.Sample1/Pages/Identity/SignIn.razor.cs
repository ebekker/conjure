using Conjure.Blazor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity
{
    [Route(IdentityConstants.SignInRoute)]
    public partial class SignIn
    {
        [Parameter]
        [SupplyParameterFromQuery(Name = IdentityConstants.ReturnUrlQueryParameter)]
        public string? ReturnUrl { get; set; }

        [Inject]
        private ILogger<SignIn> Logger { get; set; } = default!;

        [Inject]
        private NavigationManager Nav { get; set; } = default!;

        [Inject]
        private ISignInClient SignInClient { get; set; } = default!;

        [Inject]
        private ConjureInterop CI { get; set; } = default!;

        [Inject]
        private AuthenticationStateProvider AuthStateProvider { get; set; } = default!;

        private CustomValidator _customValidator = default!;

        private AuthenticationState? _authState;
        private InputModel _input = new();

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string? Email { get; set; } = "jdoe1@mailinator.com";

            [Required]
            [DataType(DataType.Password)]
            public string? Password { get; set; } = "P@$$w0rd";

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

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
            ReturnUrl ??= "/";
            
            var result = await SignInClient.SignInAsync(_input!.Email!, _input!.Password!, _input.RememberMe);
            await CI.ConLog("Got result: {0}", JsonSerializer.Serialize(result));

            if (result == null)
            {
                _customValidator.Add("No response.");
                return;
            }

            if (result.Succeeded)
            {
                _authState = await AuthStateProvider.GetAuthenticationStateAsync();
                StateHasChanged();

                if (AuthStateProvider is IHostEnvironmentAuthenticationStateProvider heasp)
                {
                    _authState = new AuthenticationState(await SignInClient.CreateClaimsPrincipal(_input!.Email!));
                    heasp.SetAuthenticationState(Task.FromResult(_authState));
                }
                Logger.LogInformation("User [{email}] signed in.", _input.Email);
                Nav.NavigateTo(ReturnUrl);
                return;
            }

            if (result.RequiresTwoFactor)
            {
                // TODO: switch to Nav.GetUrlWithParameters in RC1

                var signInWith2faRoute = IdentityConstants.SignInRoute
                    + $"?{IdentityConstants.ReturnUrlQueryParameter}={ReturnUrl}"
                    + $"&{IdentityConstants.RememberMeQueryParameter}={_input!.RememberMe}";
                Nav.NavigateTo(signInWith2faRoute);
                return;
            }

            if (result.IsLockedOut)
            {
                Logger.LogWarning("User account [{email}] locked out.", _input.Email);
                Nav.NavigateTo(IdentityConstants.LockoutRoute);
                return;
            }

            Logger.LogWarning("User account [{email}] failed to sign in.", _input.Email);
            _customValidator.Add("Invalid attempt to sign in.");
        }
    }
}
