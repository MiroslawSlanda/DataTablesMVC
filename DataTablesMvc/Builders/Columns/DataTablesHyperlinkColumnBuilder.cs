using DataTablesMvc.Interfaces;
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
    public class DataTablesHyperlinkColumnBuilder<TModel> : DataTablesPropertyColumnBuilder<TModel, IHyperlink>
    {
        public DataTablesHyperlinkColumnBuilder(DataTablesColumnsBuilder<TModel> owner, Expression<Func<TModel, IHyperlink>> expression) 
            : base(owner, expression)
        {
            
        }

        public DataTablesHyperlinkColumnBuilder<TModel> Title(string title)
        {
            this.title = title;
            return this;
        }

        public override string GetRender()
        {
            return "function(d) { return '<a href=\"' + d.Href + '\">' + d.Text + '</a>'; }";
        }
    }
}
