using Microsoft.AspNetCore.Components;

namespace Conjure.BlazorKit;


public class ScreenMenuItem<TScreen> : NavMenuItem
    where TScreen : ScreenBase
{
    private static void InitFromComponent(out string? label, out string? href)
    {
        var t = typeof(TScreen);
        label = t.Name;

        var route = t.GetCustomAttributes(typeof(RouteAttribute), true).FirstOrDefault() as RouteAttribute;
        href = route?.Template;
    }

    public ScreenMenuItem()
    {
        InitFromComponent(out var label, out var href);
        base.Label = label;
        base.Href = href;
    }
}
