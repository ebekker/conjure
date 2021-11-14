// Conjure application framework.
// Copyright (C) Conjure.

using System.Reflection;
using Conjure.BlazorKit.Data;
using MudBlazor;
using SortDir = Conjure.BlazorKit.Data.SortDirection;

namespace Conjure.BlazorKit.Controls;

public partial class DataSortPicker<TDataItem>
{
    public static readonly IEnumerable<IDataSortKey<TDataItem>> EmptySortKeys =
        Enumerable.Empty<IDataSortKey<TDataItem>>();

    [CascadingParameter] public TableContext TableContext { get; set; } = default!;

    [Parameter] public IEnumerable<IDataSortKey<TDataItem>> SortKeys { get; set; } = EmptySortKeys;
    [Parameter] public string? Class { get; set; }
    [Parameter] public string? Style { get; set; }

    private MudTableBase Table => TableContext.Table;
    //private TableContext<TDataItem> ItemTableContext => (TableContext<TDataItem>)TableContext;

    public IDataSortKey<TDataItem>? SelectedSortKey { get; private set; }
    public SortDir SelectedSortDirection = SortDir.None;

    private string ToggleButtonLabel => SelectedSortDirection == SortDir.Descending ? "Z-A" : "A-Z";

    public async Task SortBy(IDataSortKey<TDataItem>? sk)
    {
        if (SelectedSortKey == sk)
            return;

        SelectedSortKey = sk;
        SelectedSortDirection = sk == null ? SortDir.None : SortDir.Ascending;
        await ResetTable();
    }

    public async Task ToggleDirection()
    {
        if (SelectedSortKey == null)
        {
            SelectedSortDirection = SortDir.None;
        }
        else if (SelectedSortDirection == SortDir.Ascending)
        {
            SelectedSortDirection = SortDir.Descending;
        }
        else
        {
            SelectedSortDirection = SortDir.Ascending;
        }
        await ResetTable();
    }

    private async Task ResetTable()
    {
        if (Table.CurrentPage != 0)
        {
            Table.NavigateTo(Page.First);
        }
        else
        {
            await InvokeServerLoadFunc();
        }
    }

    // We will cache this method the first time
    // we need for the rest of the app lifetime
    private static MethodInfo? _invokeServerLoadFunc;
    private Task InvokeServerLoadFunc()
    {
        MethodInfo? _invokeServerLoadFunc = null;

        // We need to get into the non-public bowels of the
        // MudTable component to force it to reload the data
        // As per:
        //  https://github.com/Garderoben/MudBlazor/blob/5b04f2510f850b78c83860bd1b5db2910fd66747/src/MudBlazor/Components/Table/MudTableSortLabel.razor.cs#L63
        if (_invokeServerLoadFunc == null)
        {
            _invokeServerLoadFunc = Table.GetType().GetMethod(nameof(InvokeServerLoadFunc),
                BindingFlags.Instance | BindingFlags.NonPublic);
            if (_invokeServerLoadFunc == null)
            {
                throw new InvalidOperationException(
                    "could not resolve MudTable internal server load func");
            }
        }
        return (Task)_invokeServerLoadFunc.Invoke(Table, null)!;
    }
}
