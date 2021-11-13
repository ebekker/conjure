// Conjure application framework.
// Copyright (C) Conjure.

using Conjure.BlazorKit.Events;

namespace Conjure.BlazorKit.Controls;

public partial class KitScreen : IScreenContext
{
    [Parameter] public ComponentBase? Screen { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public EventCallback<CanExecuteEventArgs> CanExecute { get; set; }
    [Parameter] public object? Model { get; set; }
    [Parameter] public RenderFragment? Actions { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }

    private bool _canExecute;

    public void ScreenStateHasChanged() => StateHasChanged();

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);

        if (Label == null && Screen != null)
        {
            Label = Screen.GetType().Name.Titleize();
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
        if (CanExecute.HasDelegate)
        {
            var ev = new CanExecuteEventArgs();
            await CanExecute.InvokeAsync(ev);
            _canExecute = ev.Result;
        }
        else
        {
            _canExecute = true;
        }
    }
}
