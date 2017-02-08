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
        [JsonProperty("columnSizing", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string ColumnSizing { get; set; }

        [JsonProperty("columnVisibility", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string ColumnVisibility { get; set; }

        [JsonProperty("destroy", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Destroy { get; set; }

        [JsonProperty("draw", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Draw { get; set; }

        [JsonProperty("error", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Error { get; set; }

        [JsonProperty("init", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Init { get; set; }

        [JsonProperty("length", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Length { get; set; }

        [JsonProperty("order", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Order { get; set; }

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Page { get; set; }

        [JsonProperty("preInit", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string PreInit { get; set; }

        [JsonProperty("preXhr", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string PreXhr { get; set; }

        [JsonProperty("processing", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Processing { get; set; }

        [JsonProperty("search", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Search { get; set; }

        [JsonProperty("stateLoaded", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string StateLoaded { get; set; }

        [JsonProperty("stateLoadParams", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string StateLoadParams { get; set; }

        [JsonProperty("stateSaveParams", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string StateSaveParams { get; set; }

        [JsonProperty("xhr", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string Xhr { get; set; }

        [JsonProperty("createdRow", DefaultValueHandling = DefaultValueHandling.Populate)]
        [JsonConverter(typeof(FunctionConverter))]
        public string CreatedRow { get; set; }
    }
}
