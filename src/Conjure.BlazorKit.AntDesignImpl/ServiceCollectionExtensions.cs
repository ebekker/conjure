using Microsoft.Extensions.DependencyInjection;

namespace Conjure.BlazorKit;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlazorKit(this IServiceCollection services, AppSettings settings)
    {
        services.AddSingleton<AppSettings>(settings);
        return services;
    }
}
