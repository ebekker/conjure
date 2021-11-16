﻿// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using Conjure.Binding;
using Conjure.BlazorKit.Data;
using Microsoft.AspNetCore.Components.Rendering;
using MudBlazor;

using SortDir = Conjure.BlazorKit.Data.SortDirection;
using MudSortDir = MudBlazor.SortDirection;
using Microsoft.EntityFrameworkCore;

namespace Conjure.BlazorKit.Controls;

[CascadingTypeParameter(nameof(TDataItem))]
public partial class KitDataGrid<TDataItem> : IActionContainer,
    IDataSorter<TDataItem>, IDataSearcher<TDataItem>, IDisposable
    where TDataItem : class
{
    private static readonly RenderFragment<TDataItem> DefaultItemTemplate = (item) => delegate (RenderTreeBuilder builder)
    {
        builder.AddContent(4, item);
    };

    [CascadingParameter] public IScreenContext Screen { get; set; } = default!;
    [Parameter] public string? Label { get; set; }
    [Parameter] public LoadDataHandler<TDataItem>? DataLoader { get; set; }
    [Parameter] public bool AllowSearch { get; set; }
    [Parameter] public RenderFragment? Fields { get; set; }
    //[Parameter] public RenderFragment? SortBy { get; set; }
    //[Parameter] public RenderFragment? SearchBy { get; set; }
    [Parameter] public bool ShowSortPicker { get; set; }
    [Parameter] public RenderFragment? Actions { get; set; }
    //[Parameter] public RenderFragment<TDataItem> ItemTemplate { get; set; } = DefaultItemTemplate;

    [Parameter] public Expression<Func<IEnumerable<TDataItem>>>? Binding { get; set; }

    [Parameter] public TDataItem? SelectedItem { get; set; }
    [Parameter] public EventCallback<TDataItem> SelectedItemChanged { get; set; }

    TDataItem? SelectedItemBound
    {
        get => SelectedItem;
        set => _ = InvokeAsync(async () => await SelectedItemChanged.InvokeAsync(value));
    }

    protected MudTable<TDataItem>? _table;
    protected DataSortPicker<TDataItem>? _dataSortPicker;
    protected bool _isLoading = true;
    protected string? _searchValue;

    protected ValueBinder<IEnumerable<TDataItem>>? _binder;
    protected readonly List<KitField<TDataItem>> _fields = new();
    protected readonly List<IAction> _actions = new();
    protected readonly List<IDataSortKey<TDataItem>> _sortKeys = new();
    protected readonly List<IDataSearchField<TDataItem>> _searchFields = new();

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
            if (DataLoader == null)
            {
                // TODO: replace with more complete default DataLoader for IQueryable
                DataLoader = DataItemLoader.Create<TDataItem>(_binder,
                    () => _searchFields.Where(f => f.Predicate != null).ToArray());
            }
        }
    }

    protected override void OnInitialized()
    {
        Screen.SavedChanges += Screen_SavedChanges;
    }

    public void Dispose()
    {
        Screen.SavedChanges -= Screen_SavedChanges;
    }

    private async void Screen_SavedChanges(object? sender, Microsoft.EntityFrameworkCore.SavedChangesEventArgs e)
    {
        await InvokeAsync(ReloadData);
    }

    void IActionContainer.Add(IAction action) => _actions.Add(action);

    void IDataSorter<TDataItem>.Add(IDataSortKey<TDataItem> sk) => _sortKeys.Add(sk);
    void IDataSearcher<TDataItem>.Add(IDataSearchField<TDataItem> sf) => _searchFields.Add(sf);

    internal void Add(KitField<TDataItem> field) => _fields.Add(field);

    /// <summary>
    /// Forces the data list control to refresh its backing data set.
    /// </summary>
    public async Task ReloadData()
    {
        await _table!.ReloadServerData();
        Screen.ScreenStateHasChanged();
    }

    private async Task OnSearch(string search)
    {
        _searchValue = search;
        await _table!.ReloadServerData();
    }

    private async Task<TableData<TDataItem>> OnLoadData(TableState state)
    {
        _isLoading = true;
        StateHasChanged();

        try
        {
            if (DataLoader != null)
            {
                // Sort by the input table state if sort data is provided,
                // otherwise fallback to the TableSorter component's state
                IDataSortKey<TDataItem>? sortKey = null;
                SortDir sortDir = SortDir.None;

                if ((state.SortLabel?.StartsWith("f__") ?? false)
                    && int.TryParse(state.SortLabel.Substring(3), out var fIndex))
                {
                    sortKey = _fields[fIndex];
                    sortDir = state.SortDirection switch
                    {
                        MudSortDir.Ascending => SortDir.Ascending,
                        MudSortDir.Descending => SortDir.Descending,
                        _ => SortDir.None,
                    };
                }

                if (sortKey == null)
                {
                    sortKey = _dataSortPicker?.SelectedSortKey;
                    sortDir = _dataSortPicker?.SelectedSortDirection ?? sortDir;
                }

                var dataArgs = new LoadDataArgs<TDataItem>
                {
                    // Optional WHERE
                    Search = AllowSearch && !string.IsNullOrWhiteSpace(_searchValue)
                        ? new() { SearchValue = _searchValue, } : null,

                    // Optional ORDER BY
                    SortKey = sortKey,
                    SortDirection = sortDir,

                    // SKIP and TAKE
                    Page = state.Page,
                    PageSize = state.PageSize,

                    // Compute COUNT
                    IncludeTotalItems = true,
                };

                var dataPage = await DataLoader(dataArgs);
                return new()
                {
                    Items = dataPage.Items,
                    TotalItems = dataPage.TotalItems,
                };
            }

            return new()
            {
                Items = Enumerable.Empty<TDataItem>(),
                TotalItems = 0,
            };
        }
        finally
        {
            _isLoading = false;
            StateHasChanged();
        }
    }

    string GetEntityState(object entity)
    {
        if (!(Screen?.GetScreen()?.GetDataWorkspace()?.GetEntityEntry(entity, out var entry) ?? false))
            return "?";

        return entry!.State switch
        {
            EntityState.Unchanged => "",
            EntityState.Added => "⨹",  // ➕⍉➖❌❔❓⁉ minus
            EntityState.Deleted => "⍉",
            EntityState.Modified => "Δ",
            EntityState.Detached => "~",
            _ => "??",
        };
    }

    // TODO: there's a weird bug where the native "selection behavior" in MudTable
    // does not work correctly when it's hosted inside of another template container
    // component -- the selection fires twice, once with the selected item and once
    // with null (or specifically the preceding selected item).  Not sure the cause
    // but a temporary fix is to handle the selection behavior ourselves in our own
    // wrapper control for now which calls into this method to set selection
    async Task TemporarySetSelectItem(TDataItem item)
    {
        Console.WriteLine($"{DateTime.Now.ToString("yyyyMMdd_hhmmss")} Setting Selected: {item}");
        //SelectedItemBound = item;

        //SelectedItemBound = item;
        SelectedItem = item;
        await SelectedItemChanged.InvokeAsync(item);
        StateHasChanged();
        Screen.ScreenStateHasChanged();
    }
}
