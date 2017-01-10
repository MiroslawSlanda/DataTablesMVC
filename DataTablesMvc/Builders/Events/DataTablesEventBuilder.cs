using DataTablesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Builders.Events
{
    public abstract class DataTablesEventBuilder<TModel>
    {
        protected readonly DataTablesEventsBuilder<TModel> _owner;

        public DataTablesEventBuilder(DataTablesEventsBuilder<TModel> owner, string function)
        {
            _owner = owner;
            this.eventName = this.GetType().Name;
            this.function = function;
            _owner.Events.Add(this);
        }

        public string eventName;
        public string function;

        public virtual DataTablesEvent GetEvent()
        {
            return new DataTablesEvent()
            {
                EventName = eventName,
                Function = function
            };
        }
    }
}
