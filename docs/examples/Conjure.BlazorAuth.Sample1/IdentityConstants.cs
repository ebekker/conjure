namespace Conjure.BlazorAuth.Sample1
{
    public static class IdentityConstants
    {
        public const string LockoutRoute = "/Account/Lockout";
        public const string SignOutRoute = "/Account/SignOut";
        public const string SignInRoute = "/Account/SignIn";
        public const string SignInWith2faRoute = "/Account/SignInWith2fa";
        public const string RegisterRoute = "/Account/Register";
        public const string RegisterConfirmationRoute = "/Account/RegisterConfirmation";
        public const string ResendEmailConfirmationRoute = "/Account/ResendEmailConfirmation";
        public const string ConfirmEmailRoute = "/Account/ConfirmEmail";

        public const string ReturnUrlQueryParameter = "returnUrl";
        public const string RememberMeQueryParameter = "rememberMe";
        public const string EmailQueryParameter = "email";
        public const string UserIdQueryParameter = "userId";
        public const string CodeQueryParameter = "code";
    }
}
