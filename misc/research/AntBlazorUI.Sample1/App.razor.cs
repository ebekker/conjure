using Conjure.BlazorKit;

namespace AntBlazorUI.Sample1;

public partial class App
{
    public static NavMenuGroup Menu =>
        new()
        {
            Children = new NavMenuItem[]
            {
                new ScreenMenuItem<Pages.Test1>
                {
                    Icon = "Layout",
                },

                new NavMenuGroup
                {
                    Icon = "layout",
                    Label = "Bunch of Pages",
                    Children = new NavMenuItem[]
                    {
                        new ScreenMenuItem<Pages.DummyPages.Page1>(),
                        new ScreenMenuItem<Pages.DummyPages.Page2>(),
                    },
                },

                new NavMenuGroup
                {
                    Icon = "idcard",
                    Label = "Bunch More",
                    Children = new NavMenuItem[]
                    {
                        new ScreenMenuItem<Pages.DummyPages.Page3>(),
                        new ScreenMenuItem<Pages.DummyPages.Page4>(),
                    },
                },
            },
        };
}
