// Conjure application framework.
// Copyright (C) Conjure.

using MudBlazor;

namespace Conjure.BlazorKit.Controls;

public partial class ActionWrapper
{
    [Parameter] public IAction? Action { get; set; }

    private bool _iconButton;
    private string _label = default!;
    private string _description = default!;
    private string _icon = default!;
    private bool _disabled;

    protected override async Task OnInitializedAsync()
    {
        if (Action == null)
            return;

        var ka = Action as KitAction;

        _iconButton = ka?.Label == null;
        _label = ka?.Label ?? "Action";
        _description = ka?.Description ?? _label;
        _icon = ka?.Icon ?? Icons.Filled.RunCircle;

        _disabled = !(await Action.CanInvoke());
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        // After each render (which gets called after the screen state has changed)
        // we can check to see if the disabled state of the action has changed and
        // if so, we need to signal our own state has changed for another re-redner

        if (Action == null)
            return;

        var disabled = !(await Action.CanInvoke());
        if (_disabled != disabled)
        {
            _disabled = disabled;
            StateHasChanged();
        }
    }

    private Task Invoke()
    {
        return Action?.OnInvoke() ?? Task.CompletedTask;
    }
}
