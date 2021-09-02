using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Conjure.BlazorAuth.Models
{
    public class SignInInput
    {
        [Required]
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class SignInOutput
    {
        public bool Succeeded { get; set; }
        public bool IsLockedOut { get; set; }
        public bool IsNotAllowed { get; set; }
        public bool RequiresTwoFactor { get; set; }

        public SignInResult ToResult() => this switch
        {
            { Succeeded: true } => SignInResult.Success,
            { RequiresTwoFactor: true } => SignInResult.TwoFactorRequired,
            { IsLockedOut: true } => SignInResult.LockedOut,
            { IsNotAllowed: true } => SignInResult.NotAllowed,
            _ => SignInResult.Failed,
        };

        public static implicit operator SignInOutput(SignInResult result) =>
            new SignInOutput
            {
                Succeeded = result.Succeeded,
                RequiresTwoFactor = result.RequiresTwoFactor,
                IsLockedOut = result.IsLockedOut,
                IsNotAllowed = result.IsNotAllowed,
            };
    }
}
