
namespace Conjure.Configuration;

public static class ConfigurationBuilderExtensions
{
    /// <summary>
    /// This extension method adds support for YAML-based configuration following the similar
    /// pattern of the default configuration for JSON-based configuration files.  Namely, it
    /// supports an optional <c>appsettings.yaml</c> configuration file, as well as an optional
    /// environment-specific override file of <c>appsettings.ENVNAME.yaml</c>.  You can optionally
    /// request that the YAML configuration files processing is injected <i>before</i> the JSON
    /// file processing.
    /// </summary>
    /// <param name="beforeJson">if true, the YAML provider will be injected into the
    ///     existing list of configuration providers before the JSON provider</param>
    public static IConfigurationBuilder AddBaseYamlFiles(this IConfigurationBuilder builder,
        IHostEnvironment hostEnv, bool beforeJson = false)
    {
        // Based on the default configuration order:
        //    https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?view=aspnetcore-5.0#default-configuration
        // For reference:
        //    https://github.com/dotnet/aspnetcore/blob/52eff90fbcfca39b7eb58baad597df6a99a542b0/src/DefaultBuilder/src/WebHost.cs#L156

        var envName = hostEnv.EnvironmentName;

        // First add them in, they get appended to the end of the list, by default
        var sources = builder.Sources;

        int countBeforeYaml = sources.Count;
        builder.AddYamlFile("appsettings.yaml", optional: true, reloadOnChange: true);
        builder.AddYamlFile($"appsettings.{envName}.yaml", optional: true, reloadOnChange: true);
        int countAfterYaml = sources.Count;

        if (beforeJson)
        {
            // If for some reason, JSON config sources are missing, we
            // don't do this step and YAML sources are left at the end
            var jsonIndex = sources.ToList().FindIndex(cs =>
                cs is Microsoft.Extensions.Configuration.Json.JsonConfigurationSource);
            if (jsonIndex >= 0)
            {
                var lastIndex = countAfterYaml - 1;
                var yamlCount = countAfterYaml - countBeforeYaml;
                // Do this for each YAML source added
                for (var i = 0; i < yamlCount; ++i)
                {
                    var last = sources[lastIndex];
                    sources.RemoveAt(lastIndex);
                    sources.Insert(jsonIndex, last);
                }
            }
        }

        return builder;
    }
}
