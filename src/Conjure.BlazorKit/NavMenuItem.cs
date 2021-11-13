using Microsoft.AspNetCore.Components;

namespace Conjure.BlazorKit;

public class NavMenuItem
{
    public static readonly NavMenuItem Separator = new NavMenuItem();

    public NavMenuItem(string label)
    {
        ArgumentNullException.ThrowIfNull(label);
        Label = label;
    }

    protected NavMenuItem()
    { }

    public string Key { get; set; } = Guid.NewGuid().ToString();

    public string? Label { get; set; }

    public string? Href { get; set; }

    public string? Icon { get; set; }

    public bool PrefixMatch { get; set; }

    public virtual Task InitAsync(IAppContext app) => Task.CompletedTask;

    public virtual bool CanExecute(IAppContext app) => true;

    public virtual void OnExecute(IAppContext app)
    { }
}
