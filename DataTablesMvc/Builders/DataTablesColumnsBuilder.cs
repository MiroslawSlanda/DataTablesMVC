using DataTablesMvc.Builders.Columns;
using DataTablesMvc.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace DataTablesMvc.Builders
{
    public class DataTableColumnsBuilder<TModel> : DataTableModuleBuilder<TModel>
    {
        public DataTableColumnsBuilder(DataTableBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            DataTables = dataTables;
            Columns = new List<DataTableColumnBuilder<TModel>>();
        }

        internal DataTableBuilder<TModel> DataTables { get; private set; }
        internal List<DataTableColumnBuilder<TModel>> Columns { get; private set; }

        public DataTablePropertyColumnBuilder<TModel, object> ColumnFor(Expression<Func<TModel, object>> expression)
        {
            return new DataTablePropertyColumnBuilder<TModel, object>(this, expression);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void Dispose()
        {
            _dataTables.Model.Columns = Columns.Select(c => c.GetColumn()).Where(c => c.HasValue()).ToList();
        }
    }
}
