namespace Conjure.EFX.Options
{
    /// <summary>
    /// Update model options
    /// </summary>
    /// <seealso cref="BaseModelOptions" />
    public class UpdateModelOptions : BaseModelOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateModelOptions"/> class.
        /// </summary>
        public UpdateModelOptions(VariableDictionary variables, string prefix)
            : base(variables, AppendPrefix(prefix, "Update"))
        {
            Name = "{Entity.Name}UpdateModel";
        }
    }
}