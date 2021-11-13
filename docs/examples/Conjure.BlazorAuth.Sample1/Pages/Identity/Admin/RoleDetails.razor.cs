using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity.Admin
{
    public partial class RoleDetails
    {
        [Parameter]
        public string? Id { get; set; }

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        [Inject]
        private RoleManager<IdentityRole> RoleManager { get; set; } = default!;

        private CustomValidator _customValidator = default!;

        private bool _editable = false;
        private IdentityRole? _role;
        private IList<Claim>? _claims;

        [Inject]
        private IEnumerable<IPermissionSet> PermissionSets { get; set; } = default!;

        private IEnumerable<string>? _allPerms;
        private IList<string>? _rolePerms;

        private InputModel? _input;

        public class InputModel
        {
            [Required]
            public string? RoleName { get; set; }
        }

        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(Id))
            {
                _role = await RoleManager.FindByIdAsync(Id);
                _input = new()
                {
                    RoleName = _role.Name,
                };

                await LoadClaims();
                await LoadPerms();
            }
        }

        Task LoadPerms()
        {
            _allPerms = PermissionSets.SelectMany(ps => ps.AllPermissions);
            _rolePerms = _claims!
                .Where(c => c.Type == IPermissionSet.PermissionClaimType)
                .Select(c => c.Value)
                .ToList();

            return Task.CompletedTask;
        }

        async Task LoadClaims()
        {
            _claims = await RoleManager.GetClaimsAsync(_role!);
        }

        void DoEdit()
        {
            _editable = true;
        }

        async Task DoAddPerm(string perm)
        {
            var claim = new Claim(IPermissionSet.PermissionClaimType, perm);
            await RoleManager.AddClaimAsync(_role!, claim);
            await LoadClaims ();
            await LoadPerms();
        }

        async Task DoRemovePerm(string perm)
        {
            var claim = new Claim(IPermissionSet.PermissionClaimType, perm);
            await RoleManager.RemoveClaimAsync(_role!, claim);
            await LoadClaims();
            await LoadPerms();
        }

        async Task DoSave()
        {
            if (_role == null || _input == null)
                return;

            if (_role.Name != _input.RoleName)
            {
                CheckResult(await RoleManager.SetRoleNameAsync(_role, _input.RoleName),
                    nameof(_role.Name));
                CheckResult(await RoleManager.UpdateAsync(_role),
                    nameof(_role.Name));
            }

            // Update the cached role instance
            _role = await RoleManager.FindByIdAsync(Id);

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
