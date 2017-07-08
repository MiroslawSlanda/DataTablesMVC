using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DataTablesMvc.Infrastructure
{
    public class FilterBuilder : IHtmlString
    {
        protected ModelMetadata _metadata;

        public FilterBuilder(ModelMetadata metadata)
        {
            _metadata = metadata;
        }

        public string ToHtmlString()
        {
            var type = _metadata.ModelType;

            if (type == typeof(string))
            {
                return "<input type=\"text\" class=\"form-control\"/>";
            }  
            else if (type == typeof(decimal))
            {
                var html = new StringBuilder();
                html.AppendLine("<div class=\"input-group\">");
                html.AppendLine("<input type=\"text\" class=\"form-control\"/>");
                html.AppendLine("<span class=\"input-group-addon\"></span>");
                html.AppendLine("<input type=\"text\" class=\"form-control\"/>");
                html.AppendLine("</div>");
                return html.ToString();
            }
            else if (type == typeof(bool))
            {
                return "<input type=\"checkbox\" class=\"form-control\"/>" +
                        "<input type=\"text\" class=\"form-control\"/>";
            }
            else if (type.IsEnum)
            {
                var html = new StringBuilder();
                html.AppendLine("<div class=\"dropdown\">");
                html.AppendLine("<button class=\"btn btn-default dropdown-toggle\" type=\"button\" data-toggle=\"dropdown\" aria-haspopup=\"true\" aria-expanded=\"true\">");
                html.AppendLine("Dropdown<span class=\"caret\"></span>");
                html.AppendLine("</button>");
                html.AppendLine("<ul class=\"dropdown-menu\" aria-labelledby=\"dropdownMenu1\">");

                int i = 0;
                foreach(var value in Enum.GetValues(type))
                {
                    html.AppendLine("<li><a href=\"#\">" + value + "</a></li>");
                    i++;
                }
                html.AppendLine("</ul>");
                html.AppendLine("</div>");

                return html.ToString();
            }

            return type.ToString();
        }
    }
}
