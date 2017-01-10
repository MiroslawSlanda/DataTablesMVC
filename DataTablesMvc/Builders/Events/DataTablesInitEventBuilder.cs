using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Builders.Events
{
    public class DataTablesInitEventBuilder<TModel> : DataTablesEventBuilder<TModel>
    {
        public DataTablesInitEventBuilder(DataTablesEventsBuilder<TModel> owner, string function) 
            : base(owner, function)
        {
            
        }
    }
}
