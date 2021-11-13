using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity.Admin
{
    public partial class UserDetails
    {
        [Parameter]
        public string? Id { get; set; }

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        [Inject]
        private RoleManager<IdentityRole> RoleManager { get; set; } = default!;

        private CustomValidator _customValidator = default!;

        private bool _editable = false;
        private IdentityUser? _user;
        private IList<IdentityRole>? _allRoles;
        private IList<string>? _userRoles;
        private IList<Claim>? _claims;
        private InputModel? _input;

        public class InputModel
        {
            [Required]
            public string? UserName { get; set; }
            [Required]
            public string? Email { get; set; }
            public string? PhoneNumber { get; set; }
            public bool TwoFactorEnabled{ get; set; }
        }

        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                _user = await UserManager.FindByIdAsync(Id);
                _input = new()
                {
                    UserName = _user.UserName,
                    Email = _user.Email,
                    PhoneNumber = _user.PhoneNumber,
                    TwoFactorEnabled = _user.TwoFactorEnabled,
                };

                await LoadRoles();
                await LoadClaims();
            }
        }

        async Task LoadRoles()
        {
            _allRoles = await RoleManager.Roles.ToListAsync();
            _userRoles = await UserManager.GetRolesAsync(_user!);
        }

        async Task LoadClaims()
        {
            _claims = await UserManager.GetClaimsAsync(_user!);
        }

        void DoEdit()
        {
            _editable = true;
        }

        async Task DoAddRole(IdentityRole role)
        {
            await UserManager.AddToRoleAsync(_user!, role.Name);
            await LoadRoles();
        }

        async Task DoRemoveRole(IdentityRole role)
        {
            await UserManager.RemoveFromRoleAsync(_user!, role.Name);
            await LoadRoles();
        }

        async Task DoSave()
        {
            if (_user == null || _input == null)
                return;

            if (_user.UserName != _input.UserName)
            {
                CheckResult(await UserManager.SetUserNameAsync(_user, _input.UserName),
                    nameof(_user.UserName));
            }

            if (_user.Email != _input.Email)
            {
                CheckResult(await UserManager.SetEmailAsync(_user, _input.Email),
                    nameof(_user.Email));
            }

            if (_user.PhoneNumber != _input.PhoneNumber)
            {
                CheckResult(await UserManager.SetPhoneNumberAsync(_user, _input.PhoneNumber),
                    nameof(_user.PhoneNumber));
            }

            if (_user.TwoFactorEnabled != _input.TwoFactorEnabled)
            {
                CheckResult(await UserManager.SetTwoFactorEnabledAsync(_user, _input.TwoFactorEnabled),
                    nameof(_user.TwoFactorEnabled));
            }

            // Update the cached user instance
            _user = await UserManager.FindByIdAsync(Id);

            _editable = false;
        }

        void CheckResult(IdentityResult? result, string? field = null)
        {
            if (string.IsNullOrEmpty(field))
            {
                field = $"'{field}'";
            }

            if (result == null)
            {
                _customValidator.Add($"missing result for updating field {field}");
            }
            else if (result.Succeeded)
            {
                _customValidator.Add($"updated field {field}");
            }
            else
            {
                foreach (var err in result.Errors)
                {
                    _customValidator.Add($"({err.Code}) {err.Description}");
                }
            }
        }
    }
}
