using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Infrastructure
{
    public class ColumnsRequest
    {
        [JsonProperty(PropertyName = "data")]
        public string Data { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "searchable")]
        public bool Searchable { get; set; }
        [JsonProperty(PropertyName = "orderable")]
        public bool Orderable { get; set; }
        [JsonProperty(PropertyName = "search")]
        public SearchRequest Search { get; set; }
    }
}
