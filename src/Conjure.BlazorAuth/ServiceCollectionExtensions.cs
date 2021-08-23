using Conjure.BlazorAuth;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBlazorAuth(this IServiceCollection services)
        {
            services.AddScoped<ISignInClient, SignInClient>();

            return services;
        }

        public static IServiceCollection AddBlazorAuthServices(this IServiceCollection services)
        {
            // This does nothing for now
            return services;
        }
    }
}
