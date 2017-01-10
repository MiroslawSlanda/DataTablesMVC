using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataTablesMvc
{
    public class DataTablesResponse
    {
        [JsonProperty(PropertyName = "draw")]
        public int Draw { get; set; }
        [JsonProperty(PropertyName = "recordsTotal")]
        public int RecordsTotal { get; set; }
        [JsonProperty(PropertyName = "recordsFiltered")]
        public int RecordsFiltered { get; set; }
        [JsonProperty(PropertyName = "data")]
        public object[] Data { get; set; }
        [JsonProperty(PropertyName = "params")]
        public object Params { get; set; }
    }
}
