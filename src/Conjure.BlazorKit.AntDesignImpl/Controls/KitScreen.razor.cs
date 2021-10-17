using Conjure.BlazorKit.Events;

namespace Conjure.BlazorKit.Controls;

public partial class KitScreen : IScreenContext
{
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter] public EventCallback<CanExecuteEventArgs> CanExecute { get; set; }
    [Parameter] public object? Model { get; set; }

    private bool _canExecute;

    public void ScreenStateHasChanged() => StateHasChanged();

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
