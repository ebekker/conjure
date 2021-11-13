// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using System.Reflection;
using Conjure.BlazorKit.Data;
using ConjureApp.Data.Entities;

namespace MudBlazorUI.Sample1.Pages;

public partial class Test6
{
    string search = "ba";
    IEnumerable<Customer> _customers = Enumerable.Empty<Customer>();

    protected override void OnInitialized()
    {
        OnSearch();
    }

    protected void OnSearch()
    {
        IQueryable<Customer> query = DWS.AdventureWorksLT2017.Customers;

        Expression<Func<Customer, string>> f1 = (Customer c) => c.FirstName;
        Expression<Func<Customer, string>> f2 = (Customer c) => c.LastName;

        Expression<Func<Customer, bool>> p1 = (Customer c) => c.FirstName.Contains(search);
        Expression<Func<Customer, bool>> p2 = (Customer c) => c.LastName.Contains(search);

        Expression<Func<Customer, bool>> predicate;
        predicate = PredicateBuilder.Contains(f1, search);
        predicate = PredicateBuilder.Or(predicate, PredicateBuilder.Contains(f2, search));

        query = query.Where(predicate);

        query = query.OrderByDirection(Conjure.BlazorKit.Data.SortDirection.Descending, c => c.LastName);

        _customers = query.Take(12).ToList();
    }
}
