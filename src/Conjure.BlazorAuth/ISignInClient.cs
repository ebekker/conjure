using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Conjure.BlazorAuth
{
    public interface ISignInClient
    {
        SignInConfig Config { get; }

        ValueTask<ClaimsPrincipal> CreateClaimsPrincipal();

        Task<ClaimsPrincipal> CreateClaimsPrincipal(string username);

        //Task<IdentityResult> RegisterAsync(string userName, string password, string? email = null,
        //    bool signInIfConfirmedAccountNotRequired = false);

        Task<SignInResult?> SignInAsync(string username, string password, bool rememberMe = false);

        //Task<SignInResult> SignIn2faAsync(string twoFactorCode, bool rememberMe = false);

        //Task<SignInResult> SignInRecoverAsync(string recoveryCode);

        Task<bool> SignOutAsync();
    }
}
