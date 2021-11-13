using System.Reflection;
using Conjure.BlazorKit.Attributes;
using Microsoft.AspNetCore.Components;

namespace Conjure.BlazorKit;

public class ScreenMenuItem<TScreen> : NavMenuItem
    where TScreen : ScreenBase, new()
{
    ComponentBase cb1;

    public ScreenMenuItem()
    {
    }

    public override Task InitAsync(IAppContext app)
    {
        var screenType = typeof(TScreen);

        if (Label == null)
        {
            Label = screenType.Name.Titleize();
        }

        if (Href == null)
        {
            var route = screenType.GetCustomAttributes(typeof(RouteAttribute), true)
                .FirstOrDefault() as RouteAttribute;
            Href = route?.Template;
        }

        return Task.CompletedTask;
    }

    public virtual Func<IAppContext, bool> ComputeCanExecute { get; set; }
    public virtual Action<IAppContext> ComputeOnExecute { get; set; }

    public override bool CanExecute(IAppContext app)
    {
        return ComputeCanExecute?.Invoke(app) ?? true;
    }

    public override void OnExecute(IAppContext app)
    { }
}
