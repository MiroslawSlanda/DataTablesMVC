using DataTablesMvc.Infrastructure;
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
    public class DataTablePropertyColumnBuilder<TModel, TValue> : DataTableColumnBuilder<TModel>
    {
        protected Expression<Func<TModel, TValue>> _expression;
        protected ModelMetadata _metadata;

        public DataTablePropertyColumnBuilder(DataTableColumnsBuilder<TModel> owner, Expression<Func<TModel, TValue>> expression) 
			: base(owner)
		{
            _expression = expression;
            name = GetName(expression);
            _metadata = ModelMetadataProviders.Current.GetMetadataForProperty(null, typeof(TModel), name);
            if(!string.IsNullOrEmpty(_metadata.DisplayName))
                title = _metadata.DisplayName;
            else
                title = _metadata.PropertyName;
        }

        public DataTablePropertyColumnBuilder<TModel, TValue> Title(string title)
        {
            this.title = title;
            return this;
        }

        public DataTablePropertyColumnBuilder<TModel, TValue> Orderable(bool orderable)
        {
            this.orderable = orderable;
            return this;
        }

        public DataTablePropertyColumnBuilder<TModel, TValue> Searchable(bool searchable)
        {
            this.searchable = searchable;
            return this;
        }

        public DataTablePropertyColumnBuilder<TModel, TValue> Width(string width)
        {
            this.width = width;
            return this;
        }

        public DataTablePropertyColumnBuilder<TModel, TValue> Visible(bool visible)
        {
            this.visible = visible;
            return this;
        }

        public DataTablePropertyColumnBuilder<TModel, TValue> Format(IValueFormatter format)
        {
            var key = _owner.DataTables.id + name;
            _owner.DataTables.Helper.ViewContext.ViewData[key] = format;
            return this;
        }

        public DataTablePropertyColumnBuilder<TModel, TValue> Format(Expression<Func<TValue, object>> format)
        {
            var key = _owner.DataTables.id + name;
            _owner.DataTables.Helper.ViewContext.ViewData[key] = format.Compile();
            return this;
        }

        internal bool filterDefault;
        public DataTablePropertyColumnBuilder<TModel, TValue> Filter(bool filter = true)
        {
            this.filterDefault = filter;
            return this;
        }

        internal IHtmlString filterHtml;
        public DataTablePropertyColumnBuilder<TModel, TValue> Filter(IHtmlString html)
        {
            this.filterHtml = html;
            return this;
        }

        internal string renderHandler;
        public DataTablePropertyColumnBuilder<TModel, TValue> Render(string handler)
        {
            this.renderHandler = handler;
            return this;
        }

        public BlockBuilder BeginRender(string handler)
        {
            this.renderHandler = handler;
            var block = new BlockBuilder(_owner.DataTables.WebViewPage);
            _owner.DataTables.Scripts.Add(block);
            return block;
        }

        public override IHtmlString GetFilter()
        {
            if (filterDefault)
                return new FilterBuilder(_metadata);
            else if (filterHtml != null)
                return filterHtml;

            return null;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string GetRender()
        {
            if (!string.IsNullOrEmpty(renderHandler))
                return renderHandler;
            else
                return base.GetRender();
        }

        protected string GetName(Expression<Func<TModel, TValue>> expression)
        {
            MemberExpression body = expression.Body as MemberExpression;
            if (body == null)
            {
                UnaryExpression ubody = (UnaryExpression)expression.Body;
                body = ubody.Operand as MemberExpression;
            }
            return body.Member.Name;
        }
    }
}
