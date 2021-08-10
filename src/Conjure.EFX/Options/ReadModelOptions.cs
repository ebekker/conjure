namespace Conjure.EFX.Options
{
    /// <summary>
    /// Read model options
    /// </summary>
    /// <seealso cref="BaseModelOptions" />
    public class ReadModelOptions : BaseModelOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadModelOptions"/> class.
        /// </summary>
        public ReadModelOptions(VariableDictionary variables, string prefix)
            : base(variables, AppendPrefix(prefix, "Read"))
        {
            Name = "{Entity.Name}ReadModel";
        }
    }
}