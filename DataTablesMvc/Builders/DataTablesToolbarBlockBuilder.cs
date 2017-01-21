using DataTablesMvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Builders
{
    public class DataTablesToolbarBlockBuilder<TModel> : DataTablesToolbarBuilder<TModel>, IDisposable
    {
        public DataTablesToolbarBlockBuilder(DataTablesBlockBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            _dataTables.WebViewPage.OutputStack.Push(new StringWriter());
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Dispose()
        {
            var str = (StringWriter)_dataTables.WebViewPage.OutputStack.Pop();
            _dataTables.Model.Toolbar = str.ToString();
        }
    }
}
