using Newtonsoft.Json;
using System;
using System.IO;
using System.Web.Mvc;

namespace DataTablesMvc
{
    /// <summary>
    /// 
    /// </summary>
    public class DataTablesRequestBinder : IModelBinder
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
                return null;

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

            return JsonConvert.DeserializeObject<DataTablesRequest>(bodyText);
        }
    }
}
