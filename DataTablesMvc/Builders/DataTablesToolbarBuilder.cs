using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace DataTablesMvc.Builders
{
    public class DataTablesToolbarBuilder<TModel> : DataTablesModuleBuilder<TModel>
    {
        readonly List<IHtmlString> _elements;

        public DataTablesToolbarBuilder(DataTablesBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            _elements = new List<IHtmlString>();
        }

        public HtmlHelper Helper
        {
            get { return _dataTables.Helper; }
        }

        public void AddElement(IHtmlString html)
        {
            _elements.Add(html);
        }

        public void Template(Func<object, IHtmlString> html)
        {           
            _elements.Add(html(null));
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            var html = new StringBuilder();
            foreach(var element in _elements)
            {
                html.Append(element.ToHtmlString());
            }
            return html.ToString();
        }
    }
}
