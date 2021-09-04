using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity
{
    [Route(IdentityConstants.ResendEmailConfirmationRoute)]
    public partial class ResendEmailConfirmation
    {
        [Parameter]
        [SupplyParameterFromQuery(Name = IdentityConstants.ReturnUrlQueryParameter)]
        public string? ReturnUrl { get; set; }

        [Inject]
        private ILogger<Register> Logger { get; set; } = default!;

        [Inject]
        private NavigationManager Nav { get; set; } = default!;

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        [Inject]
        private ISignInClient SignInClient{ get; set; } = default!;

        [Inject]
        private IEmailSender EmailSender { get; set; } = default!;

        private CustomValidator? _customValidator;

        private InputModel _model = new();

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string? Email { get; set; } = "jdoe1@mailinator.com";
        }

        private async Task DoResend()
        {
            _customValidator?.ClearErrors();

            var sentMessage = "If your email is registered with this system, a verification email has been sent."
                + " Please check your email.";

            var user = await UserManager.FindByEmailAsync(_model.Email);
            if (user == null)
            {
                Logger.LogWarning("User was not found by email {0}", _model.Email);
                _customValidator?.Add(sentMessage);
                return;
            }

            var userId = await UserManager.GetUserIdAsync(user);
            var code = await UserManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));

            // TODO: change up to Nav.GetUriWithQueryParameters(...)

            var confirmEmailRoute = IdentityConstants.ConfirmEmailRoute
                + $"?{IdentityConstants.UserIdQueryParameter}={userId}"
                + $"&{IdentityConstants.CodeQueryParameter}={code}";
            var callbackUrl = Nav.ToAbsoluteUri(confirmEmailRoute).ToString();

            await EmailSender.SendEmailAsync(_model.Email, "Confirm your email",
                $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

            if (SignInClient.Config.DisplayConfirmAccountLink)
            {
                var registerConfirmationRoute = IdentityConstants.RegisterConfirmationRoute
                    + $"?{IdentityConstants.EmailQueryParameter}={_model.Email}"
                    + $"&{IdentityConstants.ReturnUrlQueryParameter}={ReturnUrl}";

                Nav.NavigateTo(registerConfirmationRoute);
                return;
            }

            _customValidator?.Add("Verification email sent. Please check your email.");
        }
    }
}
