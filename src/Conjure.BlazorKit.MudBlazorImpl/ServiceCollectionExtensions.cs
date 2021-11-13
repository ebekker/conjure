using Microsoft.Extensions.DependencyInjection;

namespace Conjure.BlazorKit;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlazorKit(this IServiceCollection services,
        Func<AppSettings> settingsBuilder)
    {
        services.AddScoped<AppSettings>(services => settingsBuilder());
        return services;
    }
}
