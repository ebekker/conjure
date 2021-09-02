using Conjure.BlazorAuth;
using Conjure.BlazorAuth.Controllers;

namespace Microsoft.AspNetCore.Builder
{
    public static class EndpointRouteBuilderExtensions
    {
        public static void MapBlazorAuthController(this IEndpointRouteBuilder endpoints)
        {
            var pathPrefix = SignInClient.DefaultControllerPathPrefix;
            endpoints.MapControllerRoute($"__signinmanager", $"{pathPrefix}/{{action}}",
                defaults: new { controller = "SignIn" });
        }
    }
}
