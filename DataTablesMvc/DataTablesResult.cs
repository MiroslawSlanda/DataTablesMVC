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
    public class DataTablesResult : JsonResult
    {
        readonly DataTablesResponse _response;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        /// <param name="request"></param>
        public DataTablesResult(DataTablesResponse response)
        {
            _response = response;
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
                    JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings());
                    serializer.Serialize(writer, _response);
                    writer.Flush();
                }
            }
        }
    }
}
