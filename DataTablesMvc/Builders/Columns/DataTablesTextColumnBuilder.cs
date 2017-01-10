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

        public DataTablesTextColumnBuilder<TModel> Width(string width)
        {
            this.width = width;
            return this;
        }
    }
}
