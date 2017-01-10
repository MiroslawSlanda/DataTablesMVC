using DataTablesMvc.Infrastructure;
using Newtonsoft.Json;
using System.ComponentModel;

namespace DataTablesMvc.Models
{
    public class DataTablesColumnDef
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Name { get; set; }

        [JsonProperty("targets", DefaultValueHandling = DefaultValueHandling.Populate)]
        public int Targets { get; set; }

        [DefaultValue(true)]
        [JsonProperty("orderable")]
        public bool Orderable { get; set; }

        [JsonProperty("render")]
        [JsonConverter(typeof(FunctionConverter))]
        public string Render { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("defaultContent")]
        public string DefaultContent { get; set; }

        [DefaultValue(true)]
        [JsonProperty("visible")]
        public bool Visible { get; set; }
    }
}
