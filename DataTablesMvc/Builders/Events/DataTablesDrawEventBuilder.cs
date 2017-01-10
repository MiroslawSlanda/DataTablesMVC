using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Builders.Events
{
    public class DataTablesDrawEventBuilder<TModel> : DataTablesEventBuilder<TModel>
    {
        public DataTablesDrawEventBuilder(DataTablesEventsBuilder<TModel> owner, string function) 
            : base(owner, function)
        {

        }
    }
}
