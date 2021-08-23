using Conjure.BlazorAuth.Controllers;

namespace Microsoft.AspNetCore.Builder
{
    public static class EndpointRouteBuilderExtensions
    {
        public static void MapBlazorAuthController(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapControllerRoute($"__signinmanager", "api/account/{action}",
                defaults: new { controller = "SignIn" });
        }
    }
}
