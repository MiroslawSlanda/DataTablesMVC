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
using System.Web.WebPages;

namespace DataTablesMvc.Builders
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class DataTablesBuilder<TModel> : IHtmlString
    {      
        public DataTablesBuilder(HtmlHelper helper)
        {
            Helper = helper;
            WebViewPage = (WebViewPage)helper.ViewDataContainer;
            Model = new DataTables();
            Records = new List<TModel>();

            id = GenerateId();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public HtmlHelper Helper { get; private set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebViewPage WebViewPage { get; private set; }

        internal DataTables Model { get; private set; }

        internal IEnumerable<TModel> Records { get; set; }

        public string id;
        public DataTablesBuilder<TModel> Id(string Id)
        {
            id = Id;
            return this;
        }

        string _class = null;
        public DataTablesBuilder<TModel> Class(string className)
        {
            _class = className;
            return this;
        }

        public DataTablesBuilder<TModel> Ajax(Action<DataTablesAjaxBuilder<TModel>> action)
        {
            var builder = new DataTablesAjaxBuilder<TModel>(this);
            action(builder);
            return this;
        }

        public DataTablesBuilder<TModel> Toolbar(Action<DataTablesToolbarBuilder<TModel>> action)
        {
            var builder = new DataTablesToolbarBuilder<TModel>(this);
            action(builder);

            Model.Toolbar = builder.ToString();
            return this;
        }

        public DataTablesBuilder<TModel> Settings(Action<DataTablesSettingsBuilder<TModel>> action)
        {
            var builder = new DataTablesSettingsBuilder<TModel>(this);
            action(builder);
            return this;
        }

        public DataTablesBuilder<TModel> Language(Action<DataTablesLanguageBuilder<TModel>> builder)
        {
            Model.Language = new DataTablesLanguage();

            var item = new DataTablesLanguageBuilder<TModel>(this);
            builder(item);
            return this;
        }
      
        public DataTablesBuilder<TModel> Columns(Action<DataTablesColumnsBuilder<TModel>> builder)
        {
            var item = new DataTablesColumnsBuilder<TModel>(this);
            builder(item);

            Model.ColumnDefs = item.Columns.Select(c => c.GetColumnDef()).ToList();
            Model.Columns = item.Columns.Select(c => c.GetColumn()).ToList();
            return this;
        }

        public DataTablesBuilder<TModel> Events(Action<DataTablesEventsBuilder<TModel>> builder)
        {
            var item = new DataTablesEventsBuilder<TModel>(this);
            builder(item);
            return this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ToHtmlString()
        {
            var html = new HtmlBuilder("div");

            html.Id(id);
            html.AddCssClass("dataTables_container");
            html.AddControl("table", table =>
            {
                table.AddCssClass("table table-striped table-bordered");
                table.AddControl("thead", thead =>
                {
                    thead.InnerHtml += "<tr>";
                    this.Model.Columns.ForEach(c => thead.InnerHtml += string.Format("<th>{0}</th>", c.Title));
                    thead.InnerHtml += "</tr>";
                });
                table.AddControl("tbody", thead =>
                {
                    Records.ToList().ForEach(r =>
                    {
                        thead.InnerHtml += "<tr>";
                        this.Model.Columns.ForEach(c => { thead.InnerHtml += "<td></td>"; });
                        thead.InnerHtml += "</tr>";
                    });
                });
            });

            html.AddScript("$('#{0}').DataTableMvc({1});", id, ToJson());

            /*var page = (WebViewPage)Helper.ViewDataContainer;
            if (ConfigurationManager.AppSettings["DataTablesMVC_Section"] != null)
            {
                var section = ConfigurationManager.AppSettings["DataTablesMVC_Section"].ToString();
                if(page.IsSectionDefined(section))
                {
                    page.DefineSection(section, () =>
                    {
                        page.WriteLiteral("<script>");
                        page.WriteLiteral(script);
                        page.WriteLiteral("</script>");
                    });
                }
                else
                {
                    html.AddScript(script);
                }
            }*/

            return html.ToString();
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
