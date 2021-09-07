using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity.Admin
{
    public partial class UserDetails
    {
        [Parameter]
        public string? Id { get; set; }

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        private CustomValidator _customValidator = default!;

        private bool _editable = false;
        private IdentityUser? _user;

        public class InputModel
        {
            public string? UserName { get; set; }
            public string? Email { get; set; }
            public string? PHoneNumber { get; set; }
            public string? TwoFactorEnabled{ get; set; }
        }

        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                _user = await UserManager.FindByIdAsync(Id);
            }
        }

        private void DoEdit()
        {
            _editable = true;
        }

        private async Task DoSave()
        {
            if (_user == null)
                return;

            var orig = await UserManager.FindByIdAsync(Id);

            if (_user.UserName != orig.UserName)
            {
                CheckResult(await UserManager.SetUserNameAsync(_user, _user.UserName));
            }

            if (_user.Email != orig.Email)
            {
                CheckResult(await UserManager.SetEmailAsync(_user, _user.Email));
            }

            if (_user.PhoneNumber != orig.PhoneNumber)
            {
                CheckResult(await UserManager.SetPhoneNumberAsync(_user, _user.PhoneNumber));
            }

            if (_user.TwoFactorEnabled != orig.TwoFactorEnabled)
            {
                CheckResult(await UserManager.SetTwoFactorEnabledAsync(_user, _user.TwoFactorEnabled));
            }

            //_editable = false;
        }

        private void CheckResult(IdentityResult? result, string? field = null)
        {
            if (string.IsNullOrEmpty(field))
            {
                field = $"'{field}'";
            }

            Console.WriteLine("Checking Result for " + field + ": " + JsonSerializer.Serialize(result));

            if (result == null)
            {
                _customValidator.Add($"missing result for updating field {field}");
            }
            else if (!result.Succeeded)
            {
                foreach (var err in result.Errors)
                {
                    _customValidator.Add($"({err.Code}) {err.Description}");
                }
            }
            else
            {
                _customValidator.Add($"updated field {field}");
            }
        }
    }
}
