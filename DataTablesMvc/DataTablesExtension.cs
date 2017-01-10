using DataTablesMvc.Builders;
using System.Web.Mvc;

namespace DataTablesMvc
{
    public static class DataTablesExtension
    {
        public static DataTablesBuilder<TModel> DataTables<TModel>(this HtmlHelper helper) where TModel : class
        {
            return new DataTablesBuilder<TModel>(helper);
        }
    }
}
