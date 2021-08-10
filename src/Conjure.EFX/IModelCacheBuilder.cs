using Conjure.EFX.Options;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace Conjure.EFX
{
    public interface IModelCacheBuilder
    {
        bool RefreshCache(ProfileOptions options);
        DatabaseModel LoadFromCache(ProfileOptions options);
    }
}