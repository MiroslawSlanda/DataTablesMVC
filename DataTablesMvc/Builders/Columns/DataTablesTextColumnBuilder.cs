using DataTablesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataTablesMvc.Builders.Columns
{
    public class DataTablesTextColumnBuilder<TModel> : DataTablesPropertyColumnBuilder<TModel, object>
    {
        public DataTablesTextColumnBuilder(DataTablesColumnsBuilder<TModel> owner, Expression<Func<TModel, object>> expression)
			: base(owner, expression)
		{

        }

        public DataTablesTextColumnBuilder<TModel> Title(string title)
        {
            this.title = title;
            return this;
        }

        public DataTablesTextColumnBuilder<TModel> Orderable(bool orderable)
        {
            this.orderable = orderable;
            return this;
        }

        public DataTablesTextColumnBuilder<TModel> Searchable(bool searchable)
        {
            this.searchable = searchable;
            return this;
        }

        public DataTablesTextColumnBuilder<TModel> Width(string width)
        {
            this.width = width;
            return this;
        }
    }
}
