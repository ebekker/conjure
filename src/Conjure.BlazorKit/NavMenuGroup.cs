namespace Conjure.BlazorKit;

public class NavMenuGroup : NavMenuItem
{
    public static readonly IEnumerable<NavMenuItem> NoChildren = new NavMenuItem[0];

    public IEnumerable<NavMenuItem> Children { get; init; } = NoChildren;

    public bool IsEmpty => Children == NoChildren || !Children.Any();
}
