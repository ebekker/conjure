using Microsoft.AspNetCore.Authorization;

namespace Conjure.NScribe.PermissionsSample;

public class PermissionAuthorizationMiddleware
{
    ILogger<PermissionAuthorizationMiddleware> _logger;
    RequestDelegate _next;

    public PermissionAuthorizationMiddleware(
        ILogger<PermissionAuthorizationMiddleware> logger, RequestDelegate next)
    {
        _logger = logger;
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IAuthorizationService authorizationService)
    {
        if (context.User.Identity == null || !context.User.Identity.IsAuthenticated)
        {
            await _next(context);
            return;
        }

        var ep = context.GetEndpoint();
        Console.WriteLine("Current Endpoint:");
        Console.WriteLine($"  * {ep?.DisplayName}");
        Console.WriteLine($"  * {ep?.GetType().FullName}");
        Console.WriteLine($"  * {ep?.Metadata.Count}");
            

        var result = await authorizationService.AuthorizeAsync(context.User, "secure1");
        if (result.Succeeded || true)
        {
            await _next(context);
            return;
        }

        context.Response.StatusCode = 444;
        await context.Response.WriteAsync("Auth Service Didn't Approve");
        await context.Response.CompleteAsync();
    }
}
