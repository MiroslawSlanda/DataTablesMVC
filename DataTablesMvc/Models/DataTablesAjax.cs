using DataTablesMvc.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Models
{
    public class DataTablesAjax
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get { return "POST"; } }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("contentType")]
        public string ContentType { get { return "application/json"; } }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data")]
        [JsonConverter(typeof(FunctionConverter))]
        public object Data { get { return "function(d) { return JSON.stringify(d); }"; } }
    }
}
