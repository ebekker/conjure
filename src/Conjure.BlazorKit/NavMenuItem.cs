using Microsoft.AspNetCore.Components;

namespace Conjure.BlazorKit;

public class NavMenuItem
{
    public static readonly NavMenuItem Separator = new NavMenuItem();

    public NavMenuItem(string label)
    {
        ArgumentNullException.ThrowIfNull(Label);
        Label = label;
    }

    protected NavMenuItem()
    { }

    public ComponentBase? Screen { get; }

    public string Key { get; init; } = Guid.NewGuid().ToString();

    public string? Label { get; init; }

    public string? Href { get; init; }

    public string? Icon { get; init; }

    public bool PrefixMatch { get; init; }

    public Func<IAppContext, Task<bool>>? CanExecute { get; init; }

    public Func<IAppContext, Task>? OnExecute { get; init; }
}
