namespace ConjureApp
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
        private IEnumerable<string> _allPermissions = Enumerable.Empty<string>();

        //public const string MyPermission1 = nameof(MyPermission1);

        public ApplicationPermissions()
        {
            _allPermissions = ComputeAllPermissions();
        }

        public virtual IEnumerable<string> AllPermissions => _allPermissions;

        protected partial IEnumerable<string> ComputeAllPermissions();
    }

}
