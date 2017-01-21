using DataTablesMvc.Builders;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace DataTablesMvc
{
    public static class DataTablesToolbarExtensions
    {
        #region Partial()
        public static void Partial<TModel>(this DataTablesToolbarBuilder<TModel> dataTableFilter, string partialViewName)
        {
            var element = dataTableFilter.Helper.Partial(partialViewName);
            dataTableFilter.AddElement(element);
        }

        public static void Partial<TModel>(this DataTablesToolbarBuilder<TModel> dataTableFilter, string partialViewName, ViewDataDictionary viewData)
        {
            var element = dataTableFilter.Helper.Partial(partialViewName, viewData);
            dataTableFilter.AddElement(element);
        }

        public static void Partial<TModel>(this DataTablesToolbarBuilder<TModel> dataTableFilter, string partialViewName, object model)
        {
            var element = dataTableFilter.Helper.Partial(partialViewName, model);
            dataTableFilter.AddElement(element);
        }

        public static void Partial<TModel>(this DataTablesToolbarBuilder<TModel> dataTableFilter, string partialViewName, object model, ViewDataDictionary viewData)
        {
            var element = dataTableFilter.Helper.Partial(partialViewName, model, viewData);
            dataTableFilter.AddElement(element);
        }
        #endregion

        #region ActionLink()
        public static void ActionLink<TModel>(this DataTablesToolbarBuilder<TModel> dataTableFilter, string linkText, ActionResult result)
        {
            var element = dataTableFilter.Helper.ActionLink(linkText, result);
            dataTableFilter.AddElement(element);
        }

        public static void ActionLink<TModel>(this DataTablesToolbarBuilder<TModel> dataTableFilter, string linkText, ActionResult result, object htmlAttributes)
        {
            var element = dataTableFilter.Helper.ActionLink(linkText, result, htmlAttributes);
            dataTableFilter.AddElement(element);
        }
        #endregion
    }
}
