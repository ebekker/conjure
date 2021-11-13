// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit;

public abstract class ScreenMeta
{
    public abstract string ComputeLabel();

    public abstract bool ComputeCanExecute();
}
