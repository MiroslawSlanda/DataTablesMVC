using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataTablesMvc
{
    public class DataTableResponse
    {
        static DataTableResponse _empty;
        public static DataTableResponse Empty
        {
            get
            {
                return _empty ?? (_empty = new DataTableResponse(DataTableRequest.Empty));
            }
        }

        public DataTableResponse(DataTableRequest request)
        {
            Draw = request.Draw;
        }

        [JsonProperty(PropertyName = "draw")]
        public int Draw { get; private set; }

        [JsonProperty(PropertyName = "recordsTotal")]
        public int RecordsTotal { get; set; }

        [JsonProperty(PropertyName = "recordsFiltered")]
        public int RecordsFiltered { get; set; }

        [JsonProperty(PropertyName = "data")]
        public IEnumerable<object> Data { get; set; }
    }
}
