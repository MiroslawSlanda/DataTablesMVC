using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataTablesMvc
{
    public class DataTableSourceBinder : IModelBinder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="controllerContext"></param>
        /// <param name="bindingContext"></param>
        /// <returns></returns>
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var contentType = controllerContext.HttpContext.Request.ContentType;
            if (!contentType.StartsWith("application/json", StringComparison.OrdinalIgnoreCase))
                throw new Exception("Content type '" + contentType + "' is not valid.");

            var request = controllerContext.HttpContext.Request;

            string bodyText;
            using (var stream = request.InputStream)
            {
                stream.Seek(0, SeekOrigin.Begin);
                using (var reader = new StreamReader(stream))
                    bodyText = reader.ReadToEnd();
            }

            if (string.IsNullOrEmpty(bodyText))
                return null;

            bodyText = bodyText.Trim('\'');

            var dataTableRequest = JsonConvert.DeserializeObject<DataTableRequest>(bodyText);
            if (dataTableRequest == null)
                throw new Exception("Cannot deserialize DataTableRequest with body: " + bodyText);

            return new DataTableSource()
            {
                Request = dataTableRequest,
                Response = new DataTableResponse(dataTableRequest)
            };
        }
    }
}
