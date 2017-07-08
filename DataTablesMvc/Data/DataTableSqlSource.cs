using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Data
{
    public class DataTableSqlSource : DataTableSource
    {
        public DataTableSqlSource()
        {

        }

        public virtual void RecordsTotal() { }
        public virtual void Filter() { }
        public virtual void RecordsFiltered() { }
        public virtual void Select() { }
    }
}
