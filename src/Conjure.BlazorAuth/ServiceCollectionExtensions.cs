using Conjure.Blazor;
using Conjure.BlazorAuth;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorAuth(this IServiceCollection services)
        {
            services.AddOptions();

            services.AddHttpContextAccessor();

            services.TryAdd(ServiceDescriptor.Singleton<IConfigureOptions<SignInConfig>>(
                new ConfigureNamedOptions<SignInConfig>(SignInConfig.DefaultConfigName, config => { })));
            
            services.TryAdd(ServiceDescriptor.Scoped<ConjureInterop, ConjureInterop>());
            services.TryAdd(ServiceDescriptor.Scoped<ISignInClient, SignInClient>());

            return services;
        }

        public static IServiceCollection AddBlazorAuthServices(this IServiceCollection services)
        {
            // This does nothing for now
            return services;
        }
    }
}
