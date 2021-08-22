// In order to support `init` accessor for properties, as per:
//    https://stackoverflow.com/a/62656145/5428506
namespace System.Runtime.CompilerServices
{
    using System.ComponentModel;
    
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class IsExternalInit{}
}
