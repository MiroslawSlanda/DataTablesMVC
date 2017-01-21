using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Builders
{
    public abstract class DataTablesModuleBuilder<TModel>
    {
        readonly protected DataTablesBuilder<TModel> _dataTables;
        public DataTablesModuleBuilder(DataTablesBuilder<TModel> dataTables)
        {
            _dataTables = dataTables;
        }

        protected virtual string Render()
        {
            return string.Empty;
        }
    }
}
