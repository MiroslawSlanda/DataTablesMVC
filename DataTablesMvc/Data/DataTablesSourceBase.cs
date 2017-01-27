using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Data
{
    public abstract class DataTablesSourceBase : IDataTablesSource
    {
        public DataTablesSourceBase()
        {
            
        }

        public DataTablesRequest Request { get; set; }
        public DataTablesResponse Response { get; set; }
    }
}
