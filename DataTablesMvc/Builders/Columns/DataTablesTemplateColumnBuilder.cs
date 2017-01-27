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
    public class DataTablesTemplateColumnBuilder<TModel, TValue> : DataTablesPropertyColumnBuilder<TModel, TValue>
    {
        public DataTablesTemplateColumnBuilder(DataTablesColumnsBuilder<TModel> owner, Expression<Func<TModel, TValue>> expression)
			: base(owner, expression)
		{
            _expression = expression;
        }

        internal string render;
        public DataTablesTemplateColumnBuilder<TModel, TValue> Render(string render)
        {
            this.render = render;
            return this;
        }

        public DataTablesTemplateColumnBuilder<TModel, TValue> Title(string title)
        {
            this.title = title;
            return this;
        }

        public DataTablesTemplateColumnBuilder<TModel, TValue> Orderable(bool orderable)
        {
            this.orderable = orderable;
            return this;
        }

        public DataTablesTemplateColumnBuilder<TModel, TValue> Searchable(bool searchable)
        {
            this.searchable = searchable;
            return this;
        }

        public DataTablesTemplateColumnBuilder<TModel, TValue> Width(string width)
        {
            this.width = width;
            return this;
        }

        public override string GetRender()
        {
            return render;
        }
    }
}
