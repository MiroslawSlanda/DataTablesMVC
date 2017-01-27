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
    public class DataTablesHiddenColumnBuilder<TModel> : DataTablesPropertyColumnBuilder<TModel, object>
    {
        public DataTablesHiddenColumnBuilder(DataTablesColumnsBuilder<TModel> owner, Expression<Func<TModel, object>> expression)
			: base(owner, expression)
		{
            visible = false;
        }

        public DataTablesHiddenColumnBuilder<TModel> Searchable(bool searchable)
        {
            this.searchable = searchable;
            return this;
        }

        public override string GetRender()
        {
            return string.Empty;
        }
    }
}
