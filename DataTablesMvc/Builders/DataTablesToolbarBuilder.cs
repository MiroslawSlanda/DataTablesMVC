using DataTablesMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataTablesMvc.Builders
{
    public class DataTablesToolbarBuilder<TModel> where TModel : class
    {
        readonly HtmlHelper _helper;
        readonly DataTables _model;

        public DataTablesToolbarBuilder(HtmlHelper helper, DataTables model)
        {
            _helper = helper;
            _model = model;
        }

        public BootstrapActionLinkButton ActionLinkButton(string linkText, ActionResult result)
        {
            var button = new BootstrapActionLinkButton(_helper, linkText, result);
            button.Data(new { datatable = "#" + _dataTable.Id });
            _toolbars.Add(button);
            return button;
        }

        public BootstrapButton<TModel> AddRowButton(ActionResult result)
        {
            var url = new UrlHelper(_helper.ViewContext.RequestContext);

            var button = new BootstrapButton<TModel>(_helper, "button");
            button.Data(new
            {
                datatable = "#" + _dataTable.Id,
                add_row = url.Action(result)
            });
            _toolbars.Add(button);
            return button;
        }

        public BootstrapButton<TModel> Button()
        {
            var button = new BootstrapButton<TModel>(_helper, "button");
            button.Data(new { datatable = "#" + _dataTable.Id });
            _toolbars.Add(button);
            return button;
        }
    }
}
