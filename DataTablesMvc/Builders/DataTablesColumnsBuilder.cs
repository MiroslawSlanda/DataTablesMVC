using DataTablesMvc.Builders.Columns;
using DataTablesMvc.Interfaces;
using System;
using System.Collections.Generic;
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

        public DataTablesHyperlinkColumnBuilder<TModel> HyperlinkFor(Expression<Func<TModel, IHyperlink>> expression)
        {
            return new DataTablesHyperlinkColumnBuilder<TModel>(this, expression);
        }

        public DataTablesTextColumnBuilder<TModel> TextFor(Expression<Func<TModel, object>> expression)
        {
            return new DataTablesTextColumnBuilder<TModel>(this, expression);
        }

        public DataTablesTemplateColumnBuilder<TModel, TValue> TemplateFor<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            return new DataTablesTemplateColumnBuilder<TModel, TValue>(this, expression);
        }

        public DataTablesHiddenColumnBuilder<TModel> HiddenFor(Expression<Func<TModel, object>> expression)
        {
            return new DataTablesHiddenColumnBuilder<TModel>(this, expression);
        }
    }
}
