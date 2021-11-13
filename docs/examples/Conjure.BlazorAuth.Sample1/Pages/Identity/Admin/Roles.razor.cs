using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity.Admin
{
    public partial class Roles
    {
        [Parameter]
        [SupplyParameterFromQuery(Name = "skip")]
        public int? Skip { get; set; }

        [Parameter]
        [SupplyParameterFromQuery(Name = "take")]
        public int? Take { get; set; }

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        [Inject]
        private RoleManager<IdentityRole> RoleManager { get; set; } = default!;

        private CustomValidator _customValidator = default!;

        private int? _totalRoles;
        private int? _totalPages;
        private int _currentPage;
        private IList<IdentityRole>? _roles;

        bool _prevDisabled = true;
        bool _nextDisabled = true;

        private InputModel _input = new();

        public class InputModel
        {
            [Required]
            public string? RoleName { get; set; }
        }

        protected override async Task OnInitializedAsync()
        {
            Skip ??= 0;
            Take ??= 10;

            await LoadData();
        }

        async Task GoPrev()
        {
            if (Skip > 0)
            {
                Skip -= Take;
                if (Skip < 0)
                    Skip = 0;
                await LoadData();
            }
        }

        async Task GoNext()
        {
            if (_totalPages != null && _currentPage < _totalPages.Value)
            {
                Skip += Take;
                await LoadData();
            }
        }

        async Task GoPage(int page)
        {
            var skip = page * Take!.Value;
            if (_totalRoles != null && skip >= 0 && skip <= _totalRoles)
            {
                Skip = skip;
                await LoadData();
            }
        }

        private async Task LoadData()
        {
            if (RoleManager.SupportsQueryableRoles)
            {
                _totalRoles = await RoleManager.Roles.CountAsync();
                _roles = await RoleManager.Roles
                    .Skip(Skip!.Value)
                    .Take(Take!.Value)
                    .ToListAsync();
            }

            _prevDisabled = Skip < 1;
            if (_totalRoles != null)
            {
                _nextDisabled = Skip + Take > _totalRoles;
                _totalPages = _totalRoles / Take;
                if (_totalRoles % Take > 0)
                    ++_totalPages;
            }
            _currentPage = Skip!.Value / Take!.Value;
        }

        private async Task DoAdd()
        {
            if (await RoleManager.RoleExistsAsync(_input.RoleName))
            {
                _customValidator.Add("A role with that name already exists.");
                return;
            }

            var role = new IdentityRole
            {
                Name = _input.RoleName!,
            };

            var result = await RoleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                _input = new();
                _customValidator.Add("Role created.");
                await LoadData();
                return;
            }

            foreach (var error in result.Errors)
            {
                _customValidator.Add($"{error.Description} ({error.Code})");
            }
        }
    }
}
