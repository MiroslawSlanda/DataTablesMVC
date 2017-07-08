using DataTablesMvc.Infrastructure;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataTablesMvc
{
    /// <summary>
    /// 
    /// </summary>
    public class DataTableRequest
    {
        static DataTableRequest _empty;
        public static DataTableRequest Empty
        {
            get
            {
                return _empty ?? (_empty = new DataTableRequest()
                {
                    Length = 20
                });
            }
        }

        public DataTableRequest()
        {
            Search = new SearchRequest();
            Columns = new List<ColumnsRequest>();
            Orders = new List<OrderRequest>();
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "draw")]
        public int Draw { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public int Start { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public int Length { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "search")]
        public SearchRequest Search { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "columns")]
        public List<ColumnsRequest> Columns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public List<OrderRequest> Orders { get; set; }
    }
}
