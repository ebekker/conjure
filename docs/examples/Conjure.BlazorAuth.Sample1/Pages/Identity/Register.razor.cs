using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Encodings.Web;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity
{
    [Route(IdentityConstants.RegisterRoute)]
    public partial class Register
    {
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

        private CustomValidator _customValidator = default!;

        private InputModel _input = new();

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string? Email { get; set; } = "jdoe1@mailinator.com";

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string? Password { get; set; } = "P@$$w0rd";

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string? ConfirmPassword { get; set; } = "P@$$w0rd";
        }


        private async Task DoRegister()
        {
            _customValidator?.ClearErrors();

            ReturnUrl ??= "/";

            var user = new IdentityUser
            {
                UserName = _input.Email,
                Email = _input.Email,
            };

            var createResult = await UserManager.CreateAsync(user, _input.Password);
            if (createResult.Succeeded)
            {
                Logger.LogInformation("User created a new account [{email}] with password.", _input.Email);

                var code = await UserManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                var confirmEmailRoute = IdentityConstants.ConfirmEmailRoute
                    + $"?{IdentityConstants.UserIdQueryParameter}={user.Id}"
                    + $"&{IdentityConstants.CodeQueryParameter}={code}"
                    + $"&{IdentityConstants.ReturnUrlQueryParameter}={ReturnUrl}";
                var callbackUrl = Nav.ToAbsoluteUri(confirmEmailRoute).ToString();

                await EmailSender.SendEmailAsync(_input.Email, "Confirm your email",
                    $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                if (UserManager.Options.SignIn.RequireConfirmedAccount)
                {
                    var registerConfirmationRoute = IdentityConstants.RegisterConfirmationRoute
                        + $"?{IdentityConstants.EmailQueryParameter}={_input.Email}"
                        + $"&{IdentityConstants.ReturnUrlQueryParameter}={ReturnUrl}";
                    Nav.NavigateTo(registerConfirmationRoute);
                    return;
                }
                else
                {
                    var signInResult = await SignInClient.SignInAsync(_input.Email!, _input.Password!);
                    if (signInResult?.Succeeded ?? false)
                    {
                        Nav.NavigateTo(ReturnUrl);
                        return;
                    }
                    else
                    {
                        _customValidator!.Add("Failed to sign in new user account.");
                    }
                }
            }
            else
            {
                foreach (var error in createResult.Errors)
                {
                    _customValidator!.Add(error.Description);
                }
            }
        }
    }
}
