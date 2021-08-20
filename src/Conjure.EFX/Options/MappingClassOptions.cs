namespace Conjure.EFX.Options
{
    /// <summary>
    /// EntityFramework mapping class generation options
    /// </summary>
    /// <seealso cref="BaseClassOptions" />
    public class MappingClassOptions : BaseClassOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingClassOptions"/> class.
        /// </summary>
        public MappingClassOptions(VariableDictionary variables, string prefix)
            : base(variables, AppendPrefix(prefix, "Mapping"))
        {
            Namespace = "{Project.Namespace}.Data.Mapping";
            Directory = @"{Project.Directory}\Data\Mapping";
        }
    }
}