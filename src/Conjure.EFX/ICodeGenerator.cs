using Conjure.EFX.Impl;
using Conjure.EFX.Options;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Conjure.EFX
{
    public delegate void CodeGeneratorWriter(string path, string content);

    public interface ICodeGenerator
    {
        void Generate(ProfileOptions options, DatabaseModel model, CodeGeneratorWriter writer);
    }
}