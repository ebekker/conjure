// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Layouts;

public partial class KitDefaultLayout
{
    [Inject] private NavigationManager Nav { get; set; } = default!;
    [Inject] private AppSettings Settings { get; set; } = default!;
    //[Inject]
    private IAppContext App { get; set; } = default!;

    private bool _drawerOpen = true;

    protected override async Task OnInitializedAsync()
    {
        var task = Settings.Menu?.InitAsync(App);
        if (task != null)
            await task;
    }

    void ToggleDrawerOpen()
    {
        _drawerOpen = !_drawerOpen;
    }
}
