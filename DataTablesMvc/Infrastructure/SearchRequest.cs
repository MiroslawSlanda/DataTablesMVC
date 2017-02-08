using Newtonsoft.Json;

namespace DataTablesMvc.Infrastructure
{
    public class SearchRequest
    {
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        [JsonProperty(PropertyName = "regex")]
        public bool Regex { get; set; }

        [JsonIgnore]
        public bool HasValue
        {
            get { return !string.IsNullOrEmpty(Value); }
        }
    }
}
