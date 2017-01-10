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

        public DataTablesTemplateColumnBuilder<TModel, TValue> Width(string width)
        {
            this.width = width;
            return this;
        }

        public override string GetRender()
        {
            var html = new StringBuilder();
            html.Append("function (data, type, row) { ");
            if (!string.IsNullOrEmpty(render))
            {
                html.Append(" var fn = window['" + render + "']; ");
                html.Append(" if (typeof fn === \"function\") return fn.apply(null, [data, type, row]); ");
                html.Append(" else return data; ");
            }
            else
            {
                html.Append(" return data; ");
            }
            html.Append(" } ");
            return html.ToString();
        }
    }
}
