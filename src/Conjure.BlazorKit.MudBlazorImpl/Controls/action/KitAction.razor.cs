// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Binding;
using Conjure.BlazorKit.Events;

namespace Conjure.BlazorKit.Controls;

public partial class KitAction : IAction
{
    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [CascadingParameter] public IActionContainer ActionContainer { get; set; } = default!;
    [Parameter] public Expression<Func<Task>>? Binding { get; set; }

    [Parameter] public string? Label { get; set; }
    [Parameter] public string? Icon { get; set; }
    [Parameter] public string? Description { get; set; }
    [Parameter] public EventCallback<ComputeResultEventArg<bool>> CanInvoke { get; set; }
    [Parameter] public EventCallback OnInvoke { get; set; }

    private ValueBinder<Task>? _binder;

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        await base.SetParametersAsync(parameters);

        if (Binding != null)
        {
            _binder = ValueBinder.Create(Binding);
            if (Label == null)
            {
                Label = _binder.ValueLabel.Titleize();
            }
            if (!OnInvoke.HasDelegate)
            {
                OnInvoke = EventCallback.Factory.Create(this,
                    () => (_binder?.TryGetValue(out var val) ?? false) ? val : Task.CompletedTask);
            }
        }
    }

    protected override void OnInitialized()
    {
        ActionContainer?.Add(this);
    }

    async Task<bool> IAction.CanInvoke()
    {
        if (CanInvoke.HasDelegate)
        {
            var arg = new ComputeResultEventArg<bool>();
            await CanInvoke.InvokeAsync(arg);
            if (arg.IsSet)
            {
                return arg.Result;
            }
        }

        return true;
    }

    async Task IAction.OnInvoke()
    {
        if (OnInvoke.HasDelegate)
        {
            await OnInvoke.InvokeAsync();
        }
    }
}
