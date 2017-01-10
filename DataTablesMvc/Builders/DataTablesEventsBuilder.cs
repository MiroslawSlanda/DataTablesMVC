using DataTablesMvc.Builders.Events;
using DataTablesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataTablesMvc.Builders
{
    public class DataTablesEventsBuilder<TModel>
    {
        readonly DataTablesBuilder<TModel> _dataTables;

        public DataTablesEventsBuilder(DataTablesBuilder<TModel> dataTables)
        {
            _dataTables = dataTables;
            Events = new List<DataTablesEventBuilder<TModel>>();
        }

        internal List<DataTablesEventBuilder<TModel>> Events { get; private set; }

        public DataTablesInitEventBuilder<TModel> Init(string function)
        {
            return new DataTablesInitEventBuilder<TModel>(this, function);
        }

        public DataTablesDrawEventBuilder<TModel> Draw(string function)
        {
            return new DataTablesDrawEventBuilder<TModel>(this, function);
        }

        public DataTablesColumnSizingEventBuilder<TModel> ColumnSizing(string function)
        {
            return new DataTablesColumnSizingEventBuilder<TModel>(this, function);
        }

        public DataTablesLengthEventBuilder<TModel> Length(string function)
        {
            return new DataTablesLengthEventBuilder<TModel>(this, function);
        }

        public DataTablesPreInitEventBuilder<TModel> PreInit(string function)
        {
            return new DataTablesPreInitEventBuilder<TModel>(this, function);
        }

        public DataTablesProcessingEventBuilder<TModel> Processing(string function)
        {
            return new DataTablesProcessingEventBuilder<TModel>(this, function);
        }

        public DataTablesStateLoadedEventBuilder<TModel> StateLoaded(string function)
        {
            return new DataTablesStateLoadedEventBuilder<TModel>(this, function);
        }

        public DataTablesCreatedRowEventBuilder<TModel> CreatedRow(string function)
        {
            return new DataTablesCreatedRowEventBuilder<TModel>(this, function);
        }
    }
}
