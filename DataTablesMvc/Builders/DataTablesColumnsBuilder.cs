using DataTablesMvc.Builders.Columns;
using DataTablesMvc.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace DataTablesMvc.Builders
{
    public class DataTablesColumnsBuilder<TModel> : DataTablesModuleBuilder<TModel>
    {
        public DataTablesColumnsBuilder(DataTablesBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            DataTables = dataTables;
            Columns = new List<DataTablesColumnBuilder<TModel>>();
        }

        internal DataTablesBuilder<TModel> DataTables { get; private set; }
        internal List<DataTablesColumnBuilder<TModel>> Columns { get; private set; }

        public DataTablesPropertyColumnBuilder<TModel, object> ColumnFor(Expression<Func<TModel, object>> expression)
        {
            return new DataTablesPropertyColumnBuilder<TModel, object>(this, expression);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void Dispose()
        {
            _dataTables.Model.Columns = Columns.Select(c => c.GetColumn()).Where(c => c.HasValue()).ToList();
        }
    }
}
