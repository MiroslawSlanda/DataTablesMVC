using Newtonsoft.Json;
using System.ComponentModel;

namespace DataTablesMvc.Models
{
    public class DataTablesColumn
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Data { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Name { get; set; }

        [JsonProperty("targets", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int Targets { get; set; }

        [DefaultValue(true)]
        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [DefaultValue(true)]
        [JsonProperty("orderable")]
        public bool Orderable { get; set; }

        [JsonProperty("searchable")]
        public bool Searchable { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
