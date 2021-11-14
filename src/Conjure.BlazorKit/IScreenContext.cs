// Conjure application framework.
// Copyright (C) Conjure.

using Microsoft.EntityFrameworkCore;

namespace Conjure.BlazorKit;

public interface IScreenContext
{
    event EventHandler<SavedChangesEventArgs>? SavedChanges;

    void ScreenStateHasChanged();
}
