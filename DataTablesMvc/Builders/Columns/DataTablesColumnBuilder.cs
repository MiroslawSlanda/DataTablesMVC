using DataTablesMvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string title;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string name;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public IEnumerable<string> values = new List<string>();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string className;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string width;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool orderable = true;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool searchable = true;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool editable = false;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool visible = true;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string defaultContent;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual string GetRender()
        {
            return "function (d) { return d; }";
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
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

        [EditorBrowsable(EditorBrowsableState.Never)]
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
