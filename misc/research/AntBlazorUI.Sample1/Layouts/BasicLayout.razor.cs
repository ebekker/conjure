// Conjure application framework.
// Copyright (C) Conjure.

using System.Collections.Generic;
using System.Linq;
using AntDesign.ProLayout;
using Conjure.BlazorKit;
using Microsoft.AspNetCore.Components.Routing;

namespace AntBlazorUI.Sample1;

public partial class BasicLayout
{
    private MenuDataItem[] _menuData =
    {
        new MenuDataItem
        {
            Path = "/",
            Name = "welcome",
            Key = "welcome",
            Icon = "smile",
        },
    };

    private LinkItem[] Links { get; set; } =
    {
        new LinkItem
        {
            Key = "Ant Design Blazor",
            Title = "Ant Design Blazor",
            Href = "https://antblazor.com",
            BlankTarget = true,
        },
        new LinkItem
        {
            Key = "github",
            Title = GitHubTitle,
            Href = "https://github.com/ant-design-blazor/ant-design-pro-blazor",
            BlankTarget = true,
        },
        new LinkItem
        {
            Key = "Blazor",
            Title = "Blazor",
            Href = "https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor?WT.mc_id=DT-MVP-5003987",
            BlankTarget = true,
        }
    };

    protected override void OnInitialized()
    {
        _menuData = _menuData.Concat(ComputeDynMenuData(App.Menu)).ToArray();
    }

    private IEnumerable<MenuDataItem> ComputeDynMenuData(NavMenuGroup group) => group.Children.Select(mi =>
    {
        if (mi is NavMenuGroup childGroup)
        {
            return new MenuDataItem
            {
                Key = mi.Key,
                Name = mi.Label,
                Children = ComputeDynMenuData(childGroup).ToArray(),
            };
        }
        else
        {
            return new MenuDataItem
            {
                Key = mi.Key,
                Path = mi.Href,
                Match = mi.PrefixMatch ? NavLinkMatch.Prefix : NavLinkMatch.All,
                Icon = mi.Icon,
                Name = mi.Label,
            };
        }
    });
}
