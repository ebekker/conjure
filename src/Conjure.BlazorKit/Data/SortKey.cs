// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using System.Reflection;

namespace Conjure.BlazorKit.Data;

public class SortKey<TDataItem>
{
    public string? Label { get; init; }

    public Func<IQueryable<TDataItem>, SortDirection, IQueryable<TDataItem>>? Query { get; init; }

    public static SortKey<TDataItem> For<TKey>(Expression<Func<TDataItem, TKey>> exp, string? label = null)
    {
        var ex = exp.Body;
        while (ex is UnaryExpression unaryEx)
        {
            ex = unaryEx.Operand;
        }

        if (label == null)
        {
            switch (ex)
            {
                case MemberExpression mx when mx.Member is PropertyInfo pi:
                    label = pi.Name;
                    break;
                case MemberExpression mx when mx.Member is FieldInfo fi:
                    label = fi.Name;
                    break;
                case MethodCallExpression mcx:
                    label = mcx.Method.Name;
                    break;
            }
        }
        if (label == null)
        {
            throw new Exception("unable to resolve label from expression; explicit label must be provided");
        }

        Func<IQueryable<TDataItem>, SortDirection, IQueryable<TDataItem>> sortExp = (query, dir) =>
            query.OrderByDirection(dir, exp);

        return new SortKey<TDataItem>
        {
            Label = label,
            Query = sortExp,
        };
    }
}
