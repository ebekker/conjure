using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Conjure.BlazorAuth.Sample1.Pages
{
    public partial class WhoAmI
    {
        [Inject]
        public AuthenticationStateProvider AuthStateProvider { get; set; } = default!;

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        private ClaimsPrincipal? user;
        private IdentityUser? _identityUser;
        private IList<string>? _userRoles;
        private IList<Claim>? _userClaims;

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthStateProvider.GetAuthenticationStateAsync();
            user = authState.User;

            _identityUser = await UserManager.GetUserAsync(user);
            _userRoles = await UserManager.GetRolesAsync(_identityUser);
            _userClaims = await UserManager.GetClaimsAsync(_identityUser);
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
