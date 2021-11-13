// Conjure application framework.
// Copyright (C) Conjure.

namespace Conjure.BlazorKit.Data;

public class LoadDataPage<TDataItem>
{
    // TODO: add caching?
    public static LoadDataPage<TDataItem> Empty() => new()
    {
        TotalItems = 0,
        Items = Enumerable.Empty<TDataItem>(),
    };

    public IEnumerable<TDataItem>? Items { get; set; }

    public int TotalItems { get; set; }
}
