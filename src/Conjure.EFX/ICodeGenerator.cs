using Conjure.EFX.Options;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Conjure.EFX
{
    public interface ICodeGenerator
    {
        void Generate(ProfileOptions options, DatabaseModel model);
    }
}