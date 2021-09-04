using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity
{
    [Route(IdentityConstants.RegisterConfirmationRoute)]
    public partial class RegisterConfirmation
    {
        [Parameter]
        [SupplyParameterFromQuery(Name = IdentityConstants.EmailQueryParameter)]
        public string? Email { get; set; }

        [Parameter]
        [SupplyParameterFromQuery(Name = IdentityConstants.ReturnUrlQueryParameter)]
        public string? ReturnUrl { get; set; }

        [Inject]
        private ILogger<Register> Logger { get; set; } = default!;

        [Inject]
        private NavigationManager Nav { get; set; } = default!;

        [Inject]
        private ISignInClient SignInClient { get; set; } = default!;

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        [Inject]
        private IEmailSender EmailSender { get; set; } = default!;

        private IdentityUser? _user;
        private bool _displayConfirmAccountLink;
        private string? _emailConfirmationLink;

        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrEmpty(Email))
            {
                Nav.NavigateTo("/");
                return;
            }

            _user = await UserManager.FindByEmailAsync(Email);
            if (_user == null)
            {
                Logger.LogWarning("unable to resolve user for email {0}", Email);
                return;
            }

            _displayConfirmAccountLink = SignInClient.Config.DisplayConfirmAccountLink;
            if (_displayConfirmAccountLink)
            {
                var userId = await UserManager.GetUserIdAsync(_user);
                var code = await UserManager.GenerateEmailConfirmationTokenAsync(_user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var confirmEmailRoute = IdentityConstants.ConfirmEmailRoute
                    + $"?{IdentityConstants.UserIdQueryParameter}={userId}"
                    + $"&{IdentityConstants.CodeQueryParameter}={code}"
                    + $"&{IdentityConstants.ReturnUrlQueryParameter}={ReturnUrl}";
                _emailConfirmationLink = confirmEmailRoute;
            }
        }
    }
}
