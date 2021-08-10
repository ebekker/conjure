using Conjure.EFX.Options;

namespace Conjure.EFX
{
    public interface IProfileOptionsSerializer
    {
        ProfileOptions Load(ProfileInfo profile);
    }
}