using DataTablesMvc.Infrastructure;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DataTablesMvc
{
    /// <summary>
    /// 
    /// </summary>
    public class DataTableResult : JsonResult
    {
        readonly DataTableResponse _response;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        public DataTableResult(DataTableResponse response)
        {
            _response = response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        public DataTableResult(DataTableRequest request, Action<DataTableResponse> response)
        {
            _response = new DataTableResponse(request);
            response(_response);
        }

        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            HttpResponseBase response = context.HttpContext.Response;
            response.ContentType = "application/json";
            response.ContentEncoding = Encoding.UTF8;

            if (_response != null)
            {
                using (var writer = new JsonTextWriter(response.Output) { Formatting = Formatting.Indented })
                {
                    var settings = new JsonSerializerSettings();
                    settings.Converters.Add(new DataConverter());

                    JsonSerializer serializer = JsonSerializer.Create(settings);
                    serializer.Serialize(writer, _response);
                    writer.Flush();
                }
            }
        }
    }
}
