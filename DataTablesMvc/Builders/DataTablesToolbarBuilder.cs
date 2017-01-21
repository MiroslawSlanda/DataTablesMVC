using DataTablesMvc.Infrastructure;
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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public HtmlHelper Helper
        {
            get { return _dataTables.Helper; }
        }

        public void Template(Func<object, IHtmlString> html)
        {           
            _elements.Add(html(null));
        }

        public BlockBuilder BeginTemplate()
        {
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _elements.Add(block);
            return block;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void AddElement(IHtmlString html)
        {
            _elements.Add(html);
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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override string Render()
        {
            return base.Render();
        }
    }
}
