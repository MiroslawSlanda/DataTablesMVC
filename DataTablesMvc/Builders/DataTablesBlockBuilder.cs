using DataTablesMvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace DataTablesMvc.Builders
{
    public class DataTablesBlockBuilder<TModel> : DataTablesBuilder<TModel>, IDisposable
    {
        public DataTablesBlockBuilder(HtmlHelper helper, IEnumerable<TModel> records = null) 
            : base(helper, records)
        {
            
        }

        public DataTablesBlockBuilder<TModel> Id(string Id)
        {
            _id = Id;
            return this;
        }

        string _class = null;
        public DataTablesBlockBuilder<TModel> Class(string className)
        {
            _class = className;
            return this;
        }

        public virtual DataTablesBlockBuilder<TModel> AjaxSource(ActionResult result)
        {
            var urlHelper = new UrlHelper(Helper.ViewContext.RequestContext);

            Model.ServerSide = true;
            Model.Ajax = new DataTablesAjax();
            Model.Ajax.Url = urlHelper.Action(result);
            return this;
        }

        #region Toolbars

        public void Toolbar(string partialViewName)
        {
            Model.Toolbar = Helper.Partial(partialViewName).ToHtmlString();
        }

        public void Toolbar(string partialViewName, ViewDataDictionary viewData)
        {
            Model.Toolbar = Helper.Partial(partialViewName, viewData).ToHtmlString();
        }

        public void Toolbar(string partialViewName, object model)
        {
            Model.Toolbar = Helper.Partial(partialViewName, model).ToHtmlString();
        }

        public void Toolbar(string partialViewName, object model, ViewDataDictionary viewData)
        {
            Model.Toolbar = Helper.Partial(partialViewName, model, viewData).ToHtmlString();
        }

        public DataTablesToolbarBlockBuilder<TModel> BeginToolbar()
        {
            return new DataTablesToolbarBlockBuilder<TModel>(this);
        }

        #endregion

        public DataTablesSettingsBuilder<TModel> BeginSettings()
        {
            return new DataTablesSettingsBuilder<TModel>(this);
        }

        public DataTablesLanguageBuilder<TModel> BeginLanguage()
        {
            return new DataTablesLanguageBuilder<TModel>(this);
        }

        public DataTablesColumnsBuilder<TModel> BeginColumns()
        {
            return new DataTablesColumnsBuilder<TModel>(this);
        }

        public DataTablesEventsBuilder<TModel> BeginEvents()
        {
            return new DataTablesEventsBuilder<TModel>(this);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Dispose()
        {
            WebViewPage.WriteLiteral(this.ToHtmlString());
        }
    }
}
