using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Models
{
    public class DataTablesLanguage
    {
        public DataTablesLanguage()
        {
            
        }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("processing")]
        public string Processing { get; set; }

        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty("searchPlaceholder")]
        public string SearchPlaceholder { get; set; }

        [JsonProperty("lengthMenu")]
        public string LengthMenu { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("infoEmpty")]
        public string InfoEmpty { get; set; }

        [JsonProperty("infoFiltered")]
        public string InfoFiltered { get; set; }

        [JsonProperty("infoPostFix")]
        public string InfoPostFix { get; set; }

        [JsonProperty("loadingRecords")]
        public string LoadingRecords { get; set; }

        [JsonProperty("zeroRecords")]
        public string ZeroRecords { get; set; }

        [JsonProperty("emptyTable")]
        public string EmptyTable { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("previous")]
        public string Previous { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }

        [JsonProperty("sortAscending")]
        public string SortAscending { get; set; }

        [JsonProperty("sortDescending")]
        public string SortDescending { get; set; }

        [JsonProperty("decimal")]
        public string Decimal { get; set; }

        [JsonProperty("thousands")]
        public string Thousands { get; set; }
    }
}
