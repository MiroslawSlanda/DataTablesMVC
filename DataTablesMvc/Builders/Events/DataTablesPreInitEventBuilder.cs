﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Builders.Events
{
    public class DataTablesPreInitEventBuilder<TModel> : DataTablesEventBuilder<TModel>
    {
        public DataTablesPreInitEventBuilder(DataTablesEventsBuilder<TModel> owner, string function) 
            : base(owner, function)
        {

        }
    }
}