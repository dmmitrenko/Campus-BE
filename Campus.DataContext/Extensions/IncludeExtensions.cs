﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Campus.DataContext.Extensions;
public static class IncludeExtension
{
    public static IQueryable<TEntity> IncludeMultiple<TEntity>(
        this IQueryable<TEntity> query, params Expression<Func<TEntity, object>>[] includes) where TEntity : class
    {
        if (includes is not null)
        {
            query = includes.Aggregate(query,
                      (current, include) => current.Include(include));
        }

        return query;
    }
}