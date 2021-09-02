namespace Conjure.BlazorAuth
{
    public class SignInConfig
    {
        public const string DefaultConfigName = "BlazorAuth";

        /// Controls whether the user account should be locked if the sign in fails.
        public bool LockoutOnFailure { get; set; }

        /// Controls whether the confirm account link is displayed immediately after
        /// registration, such as when a real email provider is not available.
        public bool DisplayConfirmAccountLink { get; set; }
    }
}
