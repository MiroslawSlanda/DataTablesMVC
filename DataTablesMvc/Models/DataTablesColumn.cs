using DataTablesMvc.Infrastructure;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Web;

namespace DataTablesMvc.Models
{
    public class DataTablesColumn
    {
        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Data { get; set; }

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

        [JsonProperty("defaultContent")]
        public string DefaultContent { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonIgnore]
        public IHtmlString Filter { get; set; }

        [DefaultValue(null)]
        [JsonProperty("render", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Render { get; set; }

        public bool HasValue()
        {
            return !Orderable ||
                    !Searchable ||
                    !Visible ||
                    !string.IsNullOrEmpty(ClassName) ||
                    !string.IsNullOrEmpty(Width) ||
                    !string.IsNullOrEmpty(Title) ||
                    !string.IsNullOrEmpty(Render);
        }
    }
}
