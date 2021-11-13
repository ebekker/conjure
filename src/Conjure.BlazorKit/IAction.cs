// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit;

public interface IAction
{
    Task<bool> CanInvoke();

    Task OnInvoke();
}
