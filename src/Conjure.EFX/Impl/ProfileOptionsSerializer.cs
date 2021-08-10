using Conjure.EFX.Options;
using Conjure.EFX.Yaml;
using Microsoft.Extensions.Logging;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Conjure.EFX.Impl
{
    // This code is _*heavily*_ based on EFG:
    //    https://github.com/loresoft/EntityFrameworkCore.Generator/

    public class ProfileOptionsSerializer : IProfileOptionsSerializer
    {
        private readonly ILogger _logger;

        public ProfileOptionsSerializer(ILogger<ProfileOptionsSerializer> logger)
        {
            _logger = logger;
        }

        public ProfileOptions Load(ProfileInfo profile)
        {
            if (!File.Exists(profile.OptionsPath))
            {
                _logger.LogError("Profile [{0}] options file not found: {0}",
                    profile.Name, profile.OptionsPath);
                return null;
            }

            var factory = new ProfileOptionsFactory(profile);
            var yamlDeser = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .WithObjectFactory(factory)
                .Build();

            _logger.LogInformation("Loading profile [{0}] options file [{1}]",
                profile.Name, profile.OptionsPath);
            
            using var streamReader = File.OpenText(profile.OptionsPath);
            var options = yamlDeser.Deserialize<ProfileOptions>(streamReader);

            options.Variables.ShouldEvaluate = true;

            return options;
        }
    }
}