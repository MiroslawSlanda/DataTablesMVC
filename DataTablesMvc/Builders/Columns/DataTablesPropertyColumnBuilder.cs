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
    public abstract class DataTablesPropertyColumnBuilder<TModel, TValue> : DataTablesColumnBuilder<TModel>
    {
        protected Expression<Func<TModel, TValue>> _expression;
        protected ModelMetadata _metadata;

        public DataTablesPropertyColumnBuilder(DataTablesColumnsBuilder<TModel> owner, Expression<Func<TModel, TValue>> expression) 
			: base(owner)
		{
            _expression = expression;
            name = GetPropertyName(expression);
            _metadata = ModelMetadataProviders.Current.GetMetadataForProperty(null, typeof(TModel), name);
            title = _metadata.DisplayName;
        }

        protected string GetPropertyName(Expression<Func<TModel, TValue>> expression)
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
