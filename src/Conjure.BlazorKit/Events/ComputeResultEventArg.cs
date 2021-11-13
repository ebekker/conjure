// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Events;

public class ComputeResultEventArg<TResult>
{
#pragma warning disable IDE1006 // Naming Styles
    private TResult? _Result;
#pragma warning restore IDE1006 // Naming Styles

    public TResult? Result
    {
        get => _Result;
        set
        {
            _Result = value;
            IsSet = true;
        }
    }

    public bool IsSet { get; private set; }
    public void Reset() => IsSet = false;
}
