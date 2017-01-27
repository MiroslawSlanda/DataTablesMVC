using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Data
{
    public interface IDataTablesSqlSource<TEntity> : IDataTablesSource
    {
        void Filter();
        void RecordsTotal();
        void Order();
        void RecordsFiltered();
        void Select();
        void OnDataLoaded();
    }
}
