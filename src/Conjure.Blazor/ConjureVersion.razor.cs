namespace Conjure.Blazor
{
    public partial class ConjureVersion
    {
        public static readonly string Version = typeof(ConjureVersion).Assembly?.GetName()?.Version?.ToString() ?? "(N/A)";
    }
}
