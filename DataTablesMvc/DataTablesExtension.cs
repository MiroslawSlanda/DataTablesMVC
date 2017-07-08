using DataTablesMvc.Builders;
using DataTablesMvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.Helpers;
using System.Web.Mvc;

namespace DataTablesMvc
{
    public static class DataTableExtension
    {

        #region DataTable()
        public static DataTableBuilder<TModel> DataTable<TModel>(this HtmlHelper helper)
        {
            return new DataTableBuilder<TModel>(helper);
        }

        public static DataTableBuilder<TModel> DataTable<TModel>(this HtmlHelper helper, IEnumerable<TModel> records)
        {
            return new DataTableBuilder<TModel>(helper, records);
        }

        public static DataTableBuilder<TModel> DataTable<TModel>(this HtmlHelper helper, DataTableResult result)
        {
            return new DataTableBuilder<TModel>(helper, result);
        }

        public static DataTableBuilder<TModel> DataTable<TModel>(this HtmlHelper helper, string id)
        {
            return new DataTableBuilder<TModel>(helper, id);
        }
        #endregion

        public static DataTableResult Execute<TSource>(this IQueryable<TSource> query, DataTableLinqSource<TSource> source) where TSource : class
        {
            source.RecordsTotal(query);
            source.Filter(ref query);
            source.RecordsFiltered(ref query);
            source.Select(query);

            return new DataTableResult(source.Response);
        }

        public static DataTableResult Execute<TSource>(this IQueryable<TSource> query, DataTableRequest request) where TSource : class
        {
            return query.Execute(request, null);
        }

        public static DataTableResult Execute<TSource>(this IQueryable<TSource> query, DataTableRequest request, Expression<Func<TSource, object>> selector) where TSource : class
        {
            var queryFiltered = query.Where(request);

            var response = new DataTableResponse(request);
            response.RecordsTotal = query.Count();
            response.RecordsFiltered = queryFiltered.Count();

            return new DataTableResult(response);
        }

        public static IQueryable<TModel> Where<TModel>(this IQueryable<TModel> query, DataTableRequest request)
        {
            var search = request.Search.Value;
            foreach (var column in request.Columns)
            {
                if(column.Searchable)
                {
                    if (string.IsNullOrEmpty(column.Name))
                        throw new ArgumentNullException("Name for a column cannot be null");

                    var property = typeof(TModel).GetProperty(column.Name);
                    query = query.Where(x => 
                                    property.GetValue(x, null) != null &&
                                    property.GetValue(x, null).ToString().Contains(request.Search.Value) ||
                                    property.GetValue(x, null).ToString().Contains(column.Search.Value));
                }
            }
            return query;
        }

        public static IQueryable<TModel> SkipTake<TModel>(this IQueryable<TModel> query, DataTableRequest request)
        {
            return query.Skip(request.Start).Take(request.Length);
        }

        public static DataTableResult DataTable(this ControllerBase controller, DataTableResponse response)
        {
            return new DataTableResult(response);
        }
    }
}
