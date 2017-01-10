using DataTablesMvc.Builders.Columns;
using DataTablesMvc.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DataTablesMvc.Builders
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public class DataTablesBuilder<TModel> : IHtmlString
    {
        IEnumerable<TModel> _records;
        
        public DataTablesBuilder(HtmlHelper helper)
        {
            Helper = helper;
            _records = new List<TModel>();
            Model = new DataTables();
         
            id = GenerateId();
        }

        public HtmlHelper Helper { get; private set; }
        internal DataTables Model { get; private set; }

        internal string id;
        public DataTablesBuilder<TModel> Id(string Id)
        {
            id = Id;
            return this;
        }

        public DataTablesBuilder<TModel> Records(IEnumerable<TModel> records)
        {
            _records = records;
            return this;
        }

        public DataTablesBuilder<TModel> AjaxSource(ActionResult result)
        {
            var urlHelper = new UrlHelper(Helper.ViewContext.RequestContext);
            Model.ServerSide = true;
            Model.Ajax.Url = urlHelper.Action(result);
            return this;
        }

        string _rowDetails;
        public DataTablesBuilder<TModel> RowDetails(ActionResult result)
        {
            //_rowDetails = _urlHelper.Action(result);
            return this;
        }

        string _class = null;
        public DataTablesBuilder<TModel> Class(string className)
        {
            _class = className;
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

            Model.Events = item.Events.Select(e => e.GetEvent()).ToList();
            return this;
        }

        #region ToHtmlString()
        public string ToHtmlString()
        {
            var html = new StringBuilder();
            html.AppendLine(string.Format("<div id=\"{0}\" class=\"dt-view\">", id));

            html.AppendLine("<table class=\"table table-striped table-bordered\">");
            html.AppendLine("<thead>");
            html.AppendLine("<tr>");
            this.Model.Columns.ForEach(c => html.AppendLine(string.Format("<th>{0}</th>", c.Title)));
            html.AppendLine("</tr>");
            html.AppendLine("</thead>");

            html.AppendLine("<tbody>");
            if (_records != null)
            {
                _records.ToList().ForEach(r =>
                {
                    html.AppendLine("<tr>");
                    this.Model.Columns.ForEach(c => { html.AppendLine("<td></td>"); });
                    html.AppendLine("</tr>");
                });
            }
            html.AppendLine("</tbody>");
            html.AppendLine("</table>");
            html.AppendLine("</div>");
            html.AppendLine("<script>");
            html.AppendFormat(@"  $('#{0}').DataTableMvc({1}); ", id, ToJson());
            html.AppendLine("</script>");
            return html.ToString();
        }
        #endregion

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
