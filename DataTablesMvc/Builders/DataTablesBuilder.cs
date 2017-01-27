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
    public abstract class DataTablesBuilder<TModel> : IHtmlString
    {
        protected string _id;

        public DataTablesBuilder(HtmlHelper helper, IEnumerable<TModel> records = null)
        {
            Helper = helper;
            WebViewPage = (WebViewPage)helper.ViewDataContainer;
            Model = new DataTables();

            if (records != null)
                Records = records;
            else
                Records = new List<TModel>();

            _id = GenerateId();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public HtmlHelper Helper { get; private set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public WebViewPage WebViewPage { get; private set; }

        internal DataTables Model { get; private set; }

        internal IEnumerable<TModel> Records { get; set; }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ToHtmlString()
        {
            var html = new HtmlBuilder("div");

            html.Id(_id);
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
                        this.Model.Columns.ForEach(c => 
                        {
                            var property = typeof(TModel).GetProperty(c.Data);
                            thead.InnerHtml += "<td>" + property.GetValue(r, null) + "</td>";
                        });
                        thead.InnerHtml += "</tr>";
                    });
                });
            });

            html.AddScript("$('#{0}').DataTableMvc({1});", _id, ToJson());

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
