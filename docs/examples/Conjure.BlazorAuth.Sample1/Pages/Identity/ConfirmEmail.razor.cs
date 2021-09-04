using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity
{
    [Route(IdentityConstants.ConfirmEmailRoute)]
    public partial class ConfirmEmail
    {
        [Parameter]
        [SupplyParameterFromQuery(Name = IdentityConstants.UserIdQueryParameter)]
        public string? UserId { get; set; }

        [Parameter]
        [SupplyParameterFromQuery(Name = IdentityConstants.CodeQueryParameter)]
        public string? Code { get; set; }

        [Inject]
        private ILogger<ConfirmEmail> Logger { get; set; } = default!;

        [Inject]
        private NavigationManager Nav { get; set; } = default!;

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        private IdentityUser? _user;
        private IdentityResult? _result;

        protected async override Task OnInitializedAsync()
        {
            if (string.IsNullOrEmpty(UserId) || string.IsNullOrEmpty(Code))
            {
                Nav.NavigateTo("/");
                return;
            }

            _user = await UserManager.FindByIdAsync(UserId);
            if (_user == null)
            {
                Logger.LogWarning("Unable to find user for ID {userId}", UserId);
                return;
            }

            var code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(Code));
            _result = await UserManager.ConfirmEmailAsync(_user, code);
            if (_result.Succeeded)
            {
                Logger.LogWarning("Error confirming email for user ID {userId}", UserId);
            }
        }
    }
}
