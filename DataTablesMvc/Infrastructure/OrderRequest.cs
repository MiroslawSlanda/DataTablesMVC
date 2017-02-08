using Newtonsoft.Json;
using System;
using System.Linq.Expressions;
using System.Web.Helpers;

namespace DataTablesMvc.Infrastructure
{
    public class OrderRequest
    {
        [JsonProperty(PropertyName = "column")]
        public int Column { get; set; }

        [JsonProperty(PropertyName = "dir")]
        [JsonConverter(typeof(SortDirectionConverter))]
        public SortDirection Dir { get; set; }

    }
}
