using DataTablesMvc.Builders.Columns;
using DataTablesMvc.Infrastructure;
using DataTablesMvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.WebPages;

namespace DataTablesMvc.Builders
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class DataTableBuilder<TModel> : IDisposable
    {
        internal string id;
        protected string _class = "";

        public DataTableBuilder(HtmlHelper helper)
        {
            Helper = helper;
            WebViewPage = (WebViewPage)helper.ViewDataContainer;
            Model = new DataTables();
            Scripts = new List<IHtmlString>();
            Records = new List<TModel>();
            id = GenerateId();
        }
        public DataTableBuilder(HtmlHelper helper, IEnumerable<TModel> records) 
            : this(helper)
        {
            Records = records;
        }
        public DataTableBuilder(HtmlHelper helper, DataTableResult result)
            : this(helper)
        {
            AjaxSource(result);
        }
        public DataTableBuilder(HtmlHelper helper, string id)
            : this(helper)
        {
            Id(id);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public HtmlHelper Helper { get; private set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebViewPage WebViewPage { get; private set; }

        internal DataTables Model { get; private set; }

        internal IEnumerable<TModel> Records { get; set; }

        internal ICollection<IHtmlString> Scripts { get; private set; }

        public DataTableBuilder<TModel> Id(string Id)
        {
            this.id = Id;
            return this;
        }
        
        public DataTableBuilder<TModel> Class(string className)
        {
            _class = className;
            return this;
        }

        public virtual DataTableBuilder<TModel> AjaxSource(ActionResult result)
        {
            var urlHelper = new UrlHelper(Helper.ViewContext.RequestContext);

            Model.ServerSide = true;
            Model.Ajax = new DataTablesAjax();
            Model.Ajax.Url = urlHelper.Action(result);
            return this;
        }

        public DataTableToolbarBlockBuilder<TModel> Toolbar()
        {
            return new DataTableToolbarBlockBuilder<TModel>(this);
        }

        public DataTableSettingsBuilder<TModel> Settings()
        {
            return new DataTableSettingsBuilder<TModel>(this);
        }

        public DataTableLanguageBuilder<TModel> Language()
        {
            return new DataTableLanguageBuilder<TModel>(this);
        }

        public DataTableColumnsBuilder<TModel> Columns()
        {
            return new DataTableColumnsBuilder<TModel>(this);
        }

        public DataTableEventsBuilder<TModel> Events()
        {
            return new DataTableEventsBuilder<TModel>(this);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Dispose()
        {
            var html = new HtmlBuilder("table");

            html.Id(id);
            html.AddCssClass("table table-striped table-bordered " + _class);
            html.AddControl("thead", thead =>
            {
                thead.InnerHtml += "<tr>";
                this.Model.Columns.ForEach(c => thead.InnerHtml += string.Format("<th>{0}</th>", c.Title));
                thead.InnerHtml += "</tr>";
                if(Model.Columns.Any(c => c.Filter != null))
                {
                    thead.InnerHtml += "<tr class=\"filter-row\">";
                    this.Model.Columns.ForEach(c => thead.InnerHtml += string.Format("<th>{0}</th>", c.Filter != null ? c.Filter.ToHtmlString() : string.Empty));
                    thead.InnerHtml += "</tr>";
                }
            });
            html.AddControl("tbody", thead =>
            {
                Records.ToList().ForEach(r =>
                {
                    thead.InnerHtml += "<tr>";
                    this.Model.Columns.ForEach(c =>
                    {
                        var property = typeof(TModel).GetProperty(c.Data);
                        thead.InnerHtml += "<td>" + property.GetValue(r, null) + "</td>";
                    });
                    thead.InnerHtml += "</tr>";
                });
            });

            html.AddScript(s =>
            {
                s.AppendLine("<script type=\"text/javascript\">");
                s.AppendLine(string.Format("jQuery(function(){{ jQuery('#{0}').DataTableMvc({1}); }});", id, ToJson()));
                s.AppendLine("</script>");
            });

            foreach (var script in Scripts)
            {
                html.AddScript(script.ToHtmlString());
            }

            WebViewPage.WriteLiteral(html.ToString());
        }

        private string ToJson()
        {
            return JsonConvert.SerializeObject(
                this.Model,
                Formatting.Indented,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore
                });
        }

        private string GenerateId()
        {
            return "dt-" + Guid.NewGuid().ToString().Substring(0, 5);
        }
    }
}
