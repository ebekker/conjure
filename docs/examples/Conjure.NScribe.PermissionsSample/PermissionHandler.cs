using ConjureApp;
using Microsoft.AspNetCore.Authorization;

namespace Conjure.NScribe.PermissionsSample
{
    public class PermissionHandler : AuthorizationHandler<PermissionRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissionRequirement requirement)
        {
            //Microsoft.AspNetCore.Authorization.IAuthorizationService x;
            //Microsoft.AspNetCore.Authorization.AuthorizationOptions y;
            //Microsoft.AspNetCore.Authorization.AuthorizationMiddleware z;

            var claims = context.User.Claims;
            var claim = claims.FirstOrDefault(c =>
                c.Type == IPermissionSet.PermissionClaimType && c.Value == ApplicationPermissions.MyPermission1);

            Console.WriteLine("Evaluating requirement against: " + (context.Resource?.GetType()?.FullName ?? "(NOTHING)"));

            if (claim != null)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
