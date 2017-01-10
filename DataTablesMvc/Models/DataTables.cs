﻿using Newtonsoft.Json;
using System;
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
            //Dom = "<\"dt-toolbar\"><\"dt-settings\"f>rt<\"dt-bottom\"lip><\"clear\">";
            Searching = true;
            AutoWidth = true;
            Ajax = new DataTablesAjaxSettings();
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

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [DefaultValue(true)]
        [JsonProperty("searching")]
        public bool Searching { get; set; }

        [JsonProperty("colReorder")]
        public bool ColReorder { get; set; }

        [JsonProperty("orderCellsTop")]
        public bool OrderCellsTop { get; set; }

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
        public DataTablesAjaxSettings Ajax { get; private set; }

        [JsonProperty("language")]
        public DataTablesLanguage Language { get; internal set; }

        [JsonProperty("columnDef")]
        public List<DataTablesColumnDef> ColumnDefs { get; set; }

        [JsonProperty("columns")]
        public List<DataTablesColumn> Columns { get; set; }

        [JsonProperty("events")]
        public List<DataTablesEvent> Events { get; set; }

        [JsonProperty("toolbars")]
        public string Toolbars { get; set; }
    }
}
