// Conjure application framework.
// Copyright (C) Conjure.

using System.Linq.Expressions;
using System.Reflection;

namespace Conjure.BlazorKit.Data;

// Adapted from:
//    http://www.albahari.com/nutshell/predicatebuilder.aspx
public static class PredicateBuilder
{
    public static Expression<Func<T, bool>> True<T>() { return f => true; }
    public static Expression<Func<T, bool>> False<T>() { return f => false; }

    public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> expr1,
        Expression<Func<T, bool>> expr2)
    {
        var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
        return Expression.Lambda<Func<T, bool>>
              (Expression.OrElse(expr1.Body, invokedExpr), expr1.Parameters);
    }

    public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1,
        Expression<Func<T, bool>> expr2)
    {
        var invokedExpr = Expression.Invoke(expr2, expr1.Parameters.Cast<Expression>());
        return Expression.Lambda<Func<T, bool>>
              (Expression.AndAlso(expr1.Body, invokedExpr), expr1.Parameters);
    }

    private static readonly MethodInfo ContainsMethod =
        typeof(string).GetMethod(nameof(string.Contains), new[] { typeof(string) })!;
    private static readonly MethodInfo ContainsMethodCaseInsensitive =
        typeof(string).GetMethod(nameof(string.Contains),
            new[] { typeof(string), typeof(StringComparison) })!;

    private static readonly ConstantExpression NullConstantExpression = Expression.Constant(null);
    private static readonly ConstantExpression IgnoreCaseConstantExpression = Expression.Constant(StringComparison.OrdinalIgnoreCase);

    // TODO: losing strongly-typed STRING return to make it
    // more generic for KitField, what does this break???
    //public static Expression<Func<T, bool>> Contains<T>(this Expression<Func<T, string>> expr1,
    public static Expression<Func<T, bool>> Contains<T>(this Expression<Func<T, object>> expr1,
        string arg, bool caseInsensitive = false)
    {
        var con = Expression.Constant(arg);
        var call = caseInsensitive
            ? Expression.Call(expr1.Body, ContainsMethodCaseInsensitive, con, IgnoreCaseConstantExpression)
            : Expression.Call(expr1.Body, ContainsMethod, con);

        var and = Expression.AndAlso(Expression.NotEqual(expr1.Body, NullConstantExpression), call);

        return Expression.Lambda<Func<T, bool>>(and, expr1.Parameters);
    }
}
