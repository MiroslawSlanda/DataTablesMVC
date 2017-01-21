using DataTablesMvc.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Models
{
    public class DataTablesEvents
    {
        [JsonProperty("preInit", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string PreInit { get; set; }

        [JsonProperty("init", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Init { get; set; }

        [JsonProperty("draw", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Draw { get; set; }

        [JsonProperty("columnSizing", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string ColumnSizing { get; set; }

        [JsonProperty("length", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Length { get; set; }

        [JsonProperty("processing", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Processing { get; set; }

        [JsonProperty("stateLoaded", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string StateLoaded { get; set; }

        [JsonProperty("createdRow", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string CreatedRow { get; set; }
    }
}
