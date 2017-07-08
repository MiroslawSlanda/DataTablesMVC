using DataTablesMvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DataTablesMvc.Builders.Columns
{
    public abstract class DataTableColumnBuilder<TModel> : IDisposable
    {
        protected readonly DataTableColumnsBuilder<TModel> _owner;
        
        public DataTableColumnBuilder(DataTableColumnsBuilder<TModel> owner)
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
        public virtual IHtmlString GetFilter()
        {
            return null;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual string GetRender()
        {
            return string.Empty;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual DataTablesColumn GetColumn()
        {
            return new DataTablesColumn()
            {
                Data = name,
                Visible = visible,
                Orderable = orderable,
                Searchable = searchable,
                ClassName = className,
                DefaultContent = defaultContent,
                Width = width,
                Title = title,
                Filter = GetFilter(),
                Render = GetRender()
            };
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Dispose()
        {
            
        }

        internal virtual string GetSearch()
        {
            return string.Empty;
        }

        
    }
}
