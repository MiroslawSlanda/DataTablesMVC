using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Data
{
    public interface IDataTablesSource
    {
        DataTablesRequest Request { get; set; }
        DataTablesResponse Response { get; set; }
    }
}
