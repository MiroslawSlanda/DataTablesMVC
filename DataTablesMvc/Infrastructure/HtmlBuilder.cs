using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataTablesMvc.Infrastructure
{
    public class HtmlBuilder : TagBuilder
    {
        protected List<HtmlBuilder> _controls;
        protected StringBuilder _script;

        public HtmlBuilder(string tagName) 
            : base(tagName)
        {
            _controls = new List<HtmlBuilder>();
            _script = new StringBuilder();
        }

        public void Id(string id)
        {
            this.MergeAttribute("id", id);
        }

        public void AddControl(string tagName, Action<HtmlBuilder> builder)
        {
            var tag = new HtmlBuilder(tagName);
            builder(tag);
            _controls.Add(tag);
        }

        public void AddScript(string script, params object[] args)
        {
            _script.AppendLine(string.Format(script, args));
        }

        public override string ToString()
        {
            var inner = new StringBuilder();
            foreach (var control in _controls)
            {
                inner.AppendLine(control.ToString());
            }
            InnerHtml += inner.ToString();
            var result = base.ToString();
            if(_script.Length > 0)
            {
                result += "<script type=\"text/javascript\">";
                result += _script.ToString();
                result += "</script>";
            }
            
            return result;
        }
    }
}
