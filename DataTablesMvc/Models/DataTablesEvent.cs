using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Models
{
    public class DataTablesEvent
    {
        [JsonProperty("eventName", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string EventName { get; set; }

        [JsonProperty("function", DefaultValueHandling = DefaultValueHandling.Populate)]
        public string Function { get; set; }
    }
}
