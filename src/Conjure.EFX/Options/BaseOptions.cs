using System.Runtime.CompilerServices;

namespace Conjure.EFX.Options
{
    public class BaseOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseOptions" /> class.
        /// </summary>
        /// <param name="variables">The shared variables dictionary.</param>
        /// <param name="prefix">The variable key prefix.</param>
        public BaseOptions(VariableDictionary variables, string prefix)
        {
            Variables = variables;
            Prefix = prefix;
        }

        protected VariableDictionary Variables { get; }

        protected string Prefix { get; }


        protected string GetProperty([CallerMemberName] string propertyName = null)
        {
            var name = AppendPrefix(Prefix, propertyName);
            return Variables.Get(name);
        }

        protected void SetProperty(string value, [CallerMemberName] string propertyName = null)
        {
            var name = AppendPrefix(Prefix, propertyName);
            Variables.Set(name, value);
        }


        protected static string AppendPrefix(string root, string prefix)
        {
            if (string.IsNullOrWhiteSpace(prefix))
                return root;

            return !string.IsNullOrEmpty(root)
                ? $"{root}.{prefix}"
                : prefix;
        }
    }
}