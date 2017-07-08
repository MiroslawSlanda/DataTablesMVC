using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Models
{
    public class DataTables
    {
        public DataTables()
        {
            Paging = true;
            if(ConfigurationManager.AppSettings["DataTablesMVC_Dom"] != null)
                Dom = ConfigurationManager.AppSettings["DataTablesMVC_Dom"].ToString();
            Searching = true;
            Ordering = true;
            AutoWidth = true;
            Info = true;
            PageLength = 10;
        }

        [DefaultValue(false)]
        [JsonProperty("processing")]
        public bool Processing { get; set; }

        [DefaultValue(false)]
        [JsonProperty("serverSide")]
        public bool ServerSide { get; set; }

        [JsonProperty("dom")]
        public string Dom { get; set; }

        [DefaultValue(true)]
        [JsonProperty("paging")]
        public bool Paging { get; set; }

        [DefaultValue(true)]
        [JsonProperty("ordering")]
        public bool Ordering { get; set; }

        [DefaultValue(true)]
        [JsonProperty("info")]
        public bool Info { get; set; }

        [JsonProperty("stateSave")]
        public bool StateSave { get; set; }

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [DefaultValue(true)]
        [JsonProperty("searching")]
        public bool Searching { get; set; }

        [DefaultValue(false)]
        [JsonProperty("colReorder")]
        public bool ColReorder { get; set; }

        [DefaultValue(false)]
        [JsonProperty("orderCellsTop")]
        public bool OrderCellsTop
        {
            get { return Columns.Any(c => c.Filter != null); }
        }

        [DefaultValue(true)]
        [JsonProperty("autoWidth")]
        public bool AutoWidth { get; set; }

        [DefaultValue(null)]
        [JsonProperty("searchDelay")]
        public int? SearchDelay { get; set; }

        [DefaultValue(10)]
        [JsonProperty("pageLength")]
        public int PageLength { get; set; }

        [JsonProperty("ajax")]
        public DataTablesAjax Ajax { get; internal set; }

        [JsonProperty("language")]
        public DataTablesLanguage Language { get; internal set; }

        [JsonProperty("columns")]
        public List<DataTablesColumn> Columns { get; set; }

        [JsonProperty("events")]
        public DataTablesEvents Events { get; set; }

        [JsonProperty("toolbar")]
        public string Toolbar { get; set; }
    }
}
