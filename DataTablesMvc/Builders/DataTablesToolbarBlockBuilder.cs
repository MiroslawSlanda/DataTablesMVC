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
    public class DataTableToolbarBlockBuilder<TModel> : IDisposable
    {
        DataTableBuilder<TModel> _dataTables;

        public DataTableToolbarBlockBuilder(DataTableBuilder<TModel> dataTables)
        {
            _dataTables = dataTables;
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
