using DataTablesMvc.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace DataTablesMvc
{
    public static class DataTablesExtension
    {

        #region BeginDataTables()
        public static DataTablesBlockBuilder<TModel> BeginDataTables<TModel>(this HtmlHelper helper)
        {
            return new DataTablesBlockBuilder<TModel>(helper);
        }

        public static DataTablesBlockBuilder<TModel> BeginDataTables<TModel>(this HtmlHelper helper, IEnumerable<TModel> records)
        {
            return new DataTablesBlockBuilder<TModel>(helper, records);
        }
        #endregion

        public static DataTablesResult Execute<TSource>(this IQueryable<TSource> query, DataTablesRequest request) where TSource : class
        {
            return query.Execute(request, null);
        }

        public static DataTablesResult Execute<TSource>(this IQueryable<TSource> query, DataTablesRequest request, Expression<Func<TSource, object>> selector) where TSource : class
        {
            var queryFiltered = query.Where(request);

            var response = new DataTablesResponse(request);
            response.RecordsTotal = query.Count();
            response.RecordsFiltered = queryFiltered.Count();
            if(selector != null)
                response.Data = queryFiltered.OrderBy(request).Select(selector).SkipTake(request).ToArray();
            else
                response.Data = queryFiltered.OrderBy(request).SkipTake(request).ToArray();

            return new DataTablesResult(response);
        }

        public static IQueryable<TModel> Where<TModel>(this IQueryable<TModel> query, DataTablesRequest request)
        {
            var search = request.Search.Value;
            foreach (var column in request.Columns)
            {
                if(column.Searchable)
                {
                    var property = typeof(TModel).GetProperty(column.Name);
                    query = query.Where(x => 
                                    property.GetValue(x, null) != null &&
                                    property.GetValue(x, null).ToString().Contains(request.Search.Value) ||
                                    property.GetValue(x, null).ToString().Contains(column.Search.Value));
                }
            }
            return query;
        }

        public static IQueryable<TModel> OrderBy<TModel>(this IQueryable<TModel> query, DataTablesRequest request)
        {
            foreach(var order in request.Orders)
            {
                var column = request.Columns[order.Column];
                var property = typeof(TModel).GetProperty(column.Name);
                query = query.OrderBy(x => property.GetValue(x, null));
            }
            return query;
        }

        public static IQueryable<TModel> SkipTake<TModel>(this IQueryable<TModel> query, DataTablesRequest request)
        {
            return query.Skip(request.Start).Take(request.Length);
        }
    }
}
