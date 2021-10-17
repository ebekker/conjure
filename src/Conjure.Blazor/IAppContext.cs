using Conjure.Blazor.Events;

namespace Conjure.Blazor;
public interface IAppContext
{
    System.Security.Claims.ClaimsPrincipal User { get; }

    bool HasPermission(string perm);

    Task ShowMessage(string message);

    EventHandler<NavChangeEventArgs> NavChange { get; set; }
}
