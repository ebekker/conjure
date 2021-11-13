namespace Conjure.BlazorKit;

public class NavMenuGroup : NavMenuItem
{
    public static readonly IEnumerable<NavMenuItem> NoChildren = new NavMenuItem[0];

    public NavMenuGroup(string label) : base(label)
    { }

    public IEnumerable<NavMenuItem> Children { get; init; } = NoChildren;

    public bool IsEmpty => Children == NoChildren || !Children.Any();

    public override async Task InitAsync(IAppContext app)
    {
        var children = Children;
        if (children != null)
        {
            foreach (var child in children)
            {
                await child.InitAsync(app);
            }
        }
    }
}
