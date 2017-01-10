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
    public abstract class DataTablesColumnBuilder<TModel>
    {
        protected readonly DataTablesColumnsBuilder<TModel> _owner;
        
        public DataTablesColumnBuilder(DataTablesColumnsBuilder<TModel> owner)
        {
            _owner = owner;
            _owner.Columns.Add(this);
        }

        public string title;
        public string name;
        public IEnumerable<string> values = new List<string>();
        public string className;
        public string width;
        public bool orderable = true;
        public bool searchable = true;
        public bool editable = false;
        public bool visible = true;
        public string defaultContent;

        public virtual string GetRender()
        {
            return "function (d) { return d; }";
        }

        public virtual DataTablesColumnDef GetColumnDef()
        {
            return new DataTablesColumnDef()
            {
                Name = name,
                Targets = _owner.Columns.IndexOf(this),
                Orderable = orderable,
                Render = GetRender(),
                ClassName = className,
                DefaultContent = defaultContent,
                Visible = visible
            };
        }

        public virtual DataTablesColumn GetColumn()
        {
            return new DataTablesColumn()
            {
                Data = name,
                Name = name,
                Visible = visible,
                Orderable = orderable,
                Searchable = searchable,
                ClassName = className,
                Width = width,
                Title = title
            };
        }

        internal virtual string GetSearch()
        {
            return string.Empty;
        }

        
    }

    
}
