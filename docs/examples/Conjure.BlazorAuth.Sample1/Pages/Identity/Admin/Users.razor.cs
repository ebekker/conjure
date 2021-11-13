using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Conjure.BlazorAuth.Sample1.Pages.Identity.Admin
{
    public partial class Users
    {
        [Parameter]
        [SupplyParameterFromQuery(Name = "skip")]
        public int? Skip { get; set; }

        [Parameter]
        [SupplyParameterFromQuery(Name = "take")]
        public int? Take { get; set; }

        //[Inject]
        //public AuthenticationStateProvider AuthStateProvider { get; set; } = default!;

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        private int? _totalUsers;
        private int? _totalPages;
        private int _currentPage;
        private IList<IdentityUser>? _users;

        bool _prevDisabled = true;
        bool _nextDisabled = true;

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
            if (_totalUsers != null && skip >= 0 && skip <= _totalUsers)
            {
                Skip = skip;
                await LoadData();
            }
        }

        private async Task LoadData()
        {
            if (UserManager.SupportsQueryableUsers)
            {
                _totalUsers = await UserManager.Users.CountAsync();
                _users = await UserManager.Users
                    .Skip(Skip!.Value)
                    .Take(Take!.Value)
                    .ToListAsync();
            }

            _prevDisabled = Skip < 1;
            if (_totalUsers != null)
            {
                _nextDisabled = Skip + Take > _totalUsers;
                _totalPages = _totalUsers / Take;
                if (_totalUsers % Take > 0)
                    ++_totalPages;
            }
            _currentPage = Skip!.Value / Take!.Value;
        }

        JsonSerializerOptions jsonOpts = new JsonSerializerOptions()
        {
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            WriteIndented = true,
        };

        string Ser<T>(T value)
        {
            return JsonSerializer.Serialize(value, jsonOpts);
        }
    }
}
