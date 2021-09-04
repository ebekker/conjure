using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity
{
    [Route(IdentityConstants.SignInWith2faRoute)]
    public partial class SignInWith2fa
    {
        [Parameter]
        [SupplyParameterFromQuery(Name = IdentityConstants.ReturnUrlQueryParameter)]
        public string? ReturnUrl { get; set; }

        [Parameter]
        [SupplyParameterFromQuery(Name = IdentityConstants.RememberMeQueryParameter)]
        public bool RememberMe { get; set; }

        [Inject]
        private ILogger<SignInWith2fa> Logger { get; set; } = default!;

        [Inject]
        private NavigationManager Nav { get; set; } = default!;

        [Inject]
        private SignInManager<IdentityUser> SignInManager { get; set; } = default!;

        [Inject]
        private ISignInClient SignInClient { get; set; } = default!;

        [Inject]
        private AuthenticationStateProvider AuthStateProvider { get; set; } = default!;

        private CustomValidator? _customValidator;

        private InputModel _input = new();
        private IdentityUser? _user;
        private AuthenticationState? _authState;
        private string? _result;

        public class InputModel
        {
            [Required]
            [StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Text)]
            [Display(Name = "Authenticator code")]
            public string? TwoFactorCode { get; set; }

            [Display(Name = "Remember this machine")]
            public bool RememberMachine { get; set; }
        }

        protected async override Task OnInitializedAsync()
        {
            // Ensure the user has gone through the username & password screen first
            _user = await SignInManager.GetTwoFactorAuthenticationUserAsync();
            if (_user == null)
            {
                _customValidator?.Add("Unable to load two-factor authentication user.");
                return;
            }
        }

        private async Task DoSignIn()
        {
            ReturnUrl ??= "/";

            _input.TwoFactorCode = _input.TwoFactorCode!
                .Replace(" ", string.Empty)
                .Replace("-", string.Empty);

            var result = await SignInManager.TwoFactorAuthenticatorSignInAsync(_input.TwoFactorCode,
                RememberMe, _input.RememberMachine);

            if (result.Succeeded)
            {
                Logger.LogInformation("User with ID [{userId}]] logged in with 2fa.", _user!.Id);
                Nav.NavigateTo(ReturnUrl);
                return;
            }

            if (result.IsLockedOut)
            {
                Logger.LogWarning("User with ID [{userId}]] account locked out.", _user!.Id);
                Nav.NavigateTo(IdentityConstants.LockoutRoute);
                return;
            }

            Logger.LogWarning("Invalid authenticator code entered for user with ID [{UserId}].", _user!.Id);
            _customValidator.Add("Invalid authenticator code.");
        }
    }
}
