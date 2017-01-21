using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataTablesMvc.Builders
{
    public class DataTablesBlockBuilder<TModel> : DataTablesBuilder<TModel>, IDisposable
    {
        public DataTablesBlockBuilder(HtmlHelper helper, WebViewPage webPageBase) 
            : base(helper)
        {
            
        }

        public DataTablesToolbarBlockBuilder<TModel> BeginToolbar()
        {
            return new DataTablesToolbarBlockBuilder<TModel>(this);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Dispose()
        {
            WebViewPage.WriteLiteral(this.ToHtmlString());
        }
    }
}
