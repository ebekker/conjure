// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Util;

public class BoolConverter<TValue> : IConverter<TValue, bool?>
{
    public static readonly BoolConverter<TValue> Instance = new();

    public bool? Get(TValue value)
    {
        bool? result = value switch
        {
            null => null,
            bool b => b,
            int i => i > 0,
            long l => l > 0L,
            string s => bool.TryParse(s, out bool sb) ? sb : null,
            _ => default,
        };

        return result;
    }

    public TValue Set(bool? target)
    {
        var tt = typeof(TValue);
        object? result;

        if (target == null && !tt.IsValueType)
            result = default(TValue);
        else if (tt == typeof(bool) || tt == typeof(bool?))
            result = target;
        else if (tt == typeof(int) || tt == typeof(int?)
            || tt == typeof(long) || tt == typeof(long?))
            result = target ?? false ? 1 : 0;
        else if (tt == typeof(string))
            result = target?.ToString();
        else
            result = default(TValue)!;

        return (TValue)result!;
    }
}
