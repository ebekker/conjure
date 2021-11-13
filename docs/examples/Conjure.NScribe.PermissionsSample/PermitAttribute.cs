namespace Conjure.NScribe.PermissionsSample
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class PermitAttribute : Attribute
    {
        public PermitAttribute(string permission)
        {
            Permissions = new[] { permission };
        }

        public PermitAttribute(params string[] permissions)
        {
            Permissions = permissions;
        }

        public IEnumerable<string> Permissions { get; }
    }
}
