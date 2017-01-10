using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Builders.Events
{
    public class DataTablesLengthEventBuilder<TModel> : DataTablesEventBuilder<TModel>
    {
        public DataTablesLengthEventBuilder(DataTablesEventsBuilder<TModel> owner, string function) 
            : base(owner, function)
        {

        }
    }
}
