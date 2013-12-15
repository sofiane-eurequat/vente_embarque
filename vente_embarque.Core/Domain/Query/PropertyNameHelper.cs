﻿using System;
using System.Linq.Expressions;

namespace vente_embarque.Core.Domain.Query
{
public static class PropertyNameHelper
{
    public static string ResolvePropertyName<T>(
    Expression<Func<T, object>> expression)
    {
    var expr = expression.Body as MemberExpression;
    if (expr == null)
    {
        var u = expression.Body as UnaryExpression;
        if (u != null) expr = u.Operand as MemberExpression;
    }
        if (expr != null) return expr.ToString().Substring(expr.ToString().IndexOf(".") + 1);
        return null;
    }
}
}
