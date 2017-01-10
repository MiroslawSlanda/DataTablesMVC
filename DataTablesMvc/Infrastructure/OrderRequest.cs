using Newtonsoft.Json;

namespace DataTablesMvc.Infrastructure
{
    public class OrderRequest
    {
        [JsonProperty(PropertyName = "column")]
        public int Column { get; set; }
        [JsonProperty(PropertyName = "dir")]
        public string Dir { get; set; }
    }
}
