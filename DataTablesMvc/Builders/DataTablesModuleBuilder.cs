using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Builders
{
    public abstract class DataTablesModuleBuilder<TModel> : IDisposable
    {
        readonly protected DataTablesBuilder<TModel> _dataTables;
        public DataTablesModuleBuilder(DataTablesBuilder<TModel> dataTables)
        {
            _dataTables = dataTables;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public abstract void Dispose();
    }
}
