using ConjureApp;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Conjure.NScribe.PermissionsSample.Pages
{
    public partial class Index
    {
        [Inject]
        private AuthenticationStateProvider AuthStateProvider { get; set; } = default!;

        [Inject]
        private UserManager<IdentityUser> UserManager { get; set; } = default!;

        ClaimsPrincipal? _claimsPrincipal;
        IdentityUser? _identityUser;
        IList<Claim>? _userClaims;
        Claim? _permClaim;
        bool _hasPermClaim;

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthStateProvider.GetAuthenticationStateAsync();
            _claimsPrincipal = authState.User;
            _identityUser = await UserManager.GetUserAsync(_claimsPrincipal);
            if (_identityUser != null)
            {
                _permClaim = new Claim(IPermissionSet.PermissionClaimType, ApplicationPermissions.MyPermission1);
                await RefreshClaims();
            }
        }

        async Task RefreshClaims()
        {
            _userClaims = await UserManager.GetClaimsAsync(_identityUser!);
            _hasPermClaim = _userClaims!.FirstOrDefault(c =>
                c.Type == _permClaim!.Type && c.Value == _permClaim!.Value) != null;
        }

        async Task DoAddPerm()
        {
            var result = await UserManager.AddClaimAsync(_identityUser!, _permClaim!);
            await RefreshClaims();
        }

        async Task DoRemovePerm()
        {
            var result = await UserManager.RemoveClaimAsync(_identityUser!, _permClaim!);
            await RefreshClaims();
        }
    }
}
