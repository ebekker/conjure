// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Layouts;

public partial class NavMenuView
{
    [Parameter] public IEnumerable<NavMenuItem>? MenuItems { get; set; }

    [Inject] private NavigationManager Nav { get; set; } = default!;
    //[Inject]
    private IAppContext App { get; set; } = default!;
    private IEnumerable<NavMenuItem>? _menuItems;

    protected override void OnInitialized()
    {
        _menuItems = MenuItems?.Where(mi => mi == NavMenuItem.Separator);
    }

    private bool IsExpanded(NavMenuGroup group)
    {
        var currentUri = Nav.Uri;
        foreach (var cmi in group.Children)
        {
            if (cmi is NavMenuGroup childGroup)
            {
                return IsExpanded(childGroup);
            }
            else if (cmi.Href != null)
            {
                var cmiUri = Nav.ToAbsoluteUri(cmi.Href).AbsoluteUri;
                if (Util.UrlMatching.ShouldMatch(currentUri, cmiUri, cmi.PrefixMatch))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool IsActive(NavMenuItem item)
    {
        var currentUri = Nav.Uri;
        var itemUri = Nav.ToAbsoluteUri(item.Href!).ToString();
        return Util.UrlMatching.ShouldMatch(currentUri, itemUri, item.PrefixMatch);
    }

    private async Task HandleClick(NavMenuItem item)
    {
        //if (item.CanExecute == null || await item.CanExecute(App))
        //{

        //}
    }
}
