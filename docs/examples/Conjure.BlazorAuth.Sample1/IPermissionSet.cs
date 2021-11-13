namespace Conjure.BlazorAuth.Sample1
{
    public interface IPermissionSet
    {
        // e.g. http://schemas.microsoft.com/ws/2008/06/identity/claims/role
        public const string PermissionClaimType = "conjure:sys:permission";
        public const string PermissionClaimValueType = "http://www.w3.org/2001/XMLSchema#string";

        IEnumerable<string> AllPermissions { get; }
    }

    public partial class SystemPermissions : IPermissionSet
    {
        public const string SecurityAdministrator = nameof(SecurityAdministrator);

        public const string SecurityAuditor = nameof(SecurityAuditor);

        public IEnumerable<string> AllPermissions
        {
            get
            {
                yield return SecurityAdministrator;
                yield return SecurityAuditor;
            }
        }
    }

    public partial class ApplicationPermissions : IPermissionSet
    {
        public const string MyPermissions1 = nameof(MyPermissions1);

        public IEnumerable<string> AllPermissions
        {
            get
            {
                yield return MyPermissions1;
            }
        }
    }
}
