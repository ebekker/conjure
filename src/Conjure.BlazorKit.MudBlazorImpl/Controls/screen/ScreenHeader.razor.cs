// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Controls;

public partial class ScreenHeader : IActionContainer
{
    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [Parameter] public RenderFragment? TitleContent { get; set; }
    [Parameter] public RenderFragment? Actions { get; set; }

    private readonly List<IAction> _actions = new();

    void IActionContainer.Add(IAction action)
    {
        _actions.Add(action);
    }
}
