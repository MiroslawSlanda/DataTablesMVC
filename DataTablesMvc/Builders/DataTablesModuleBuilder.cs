using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Builders
{
    public abstract class DataTableModuleBuilder<TModel> : IDisposable
    {
        readonly protected DataTableBuilder<TModel> _dataTables;
        public DataTableModuleBuilder(DataTableBuilder<TModel> dataTables)
        {
            _dataTables = dataTables;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract void Dispose();
    }
}
