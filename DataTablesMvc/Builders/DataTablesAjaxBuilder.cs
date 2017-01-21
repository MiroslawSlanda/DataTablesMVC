using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataTablesMvc.Builders
{
    public class DataTablesAjaxBuilder<TModel> : DataTablesModuleBuilder<TModel>
    {
        public DataTablesAjaxBuilder(DataTablesBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            
        }

        public DataTablesAjaxBuilder<TModel> Url(ActionResult result)
        {
            var urlHelper = new UrlHelper(_dataTables.Helper.ViewContext.RequestContext);
            _dataTables.Model.ServerSide = true;
            _dataTables.Model.Ajax.Url = urlHelper.Action(result);
            return this;
        }

        public DataTablesAjaxBuilder<TModel> Records(IEnumerable<TModel> records)
        {
            if (records == null)
                throw new ArgumentNullException("Records cannot be null.");

            _dataTables.Records = records;
            return this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString()
        {
            return base.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
