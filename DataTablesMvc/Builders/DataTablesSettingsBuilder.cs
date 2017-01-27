using DataTablesMvc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataTablesMvc.Builders
{
    public class DataTablesSettingsBuilder<TModel> : DataTablesModuleBuilder<TModel>
    {
        public DataTablesSettingsBuilder(DataTablesBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            
        }

        public DataTablesSettingsBuilder<TModel> Paging(bool paging)
        {
            _dataTables.Model.Paging = paging;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> Ordering(bool ordering)
        {
            _dataTables.Model.Ordering = ordering;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> Processing()
        {
            _dataTables.Model.Processing = true;
            return this;
        }

        internal bool indexable = false;
        public DataTablesSettingsBuilder<TModel> Indexable()
        {
            //_settings.Indexable = true;
            return this;
        }

        internal bool selectable = false;
        internal int selectColumn = 1;
        public DataTablesSettingsBuilder<TModel> Selectable(int column = 1)
        {
            this.selectable = true;
            this.selectColumn = column;
            return this;
        }

        internal bool hiddenLengthChange = false;
        public DataTablesSettingsBuilder<TModel> HiddenLengthChange()
        {
            this.hiddenLengthChange = true;
            return this;
        }

        internal Dictionary<int, string> lengthMenu = null;
        public DataTablesSettingsBuilder<TModel> LengthMenu(Dictionary<int, string> lengthMenu)
        {
            this.lengthMenu = lengthMenu;
            return this;
        }

        internal bool orderCellsTop = false;
        public DataTablesSettingsBuilder<TModel> OrderCellsTop()
        {
            this.orderCellsTop = true;
            return this;
        }

        internal bool deferRender = false;
        public DataTablesSettingsBuilder<TModel> DeferRender()
        {
            this.deferRender = true;
            return this;
        }

        internal int? orderColumn = null;
        public DataTablesSettingsBuilder<TModel> OrderBy(int column)
        {
            this.orderColumn = column;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> PageLength(int pageLength)
        {
            _dataTables.Model.PageLength = pageLength;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> Searching()
        {
            _dataTables.Model.Searching = true;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> AutoWidth()
        {
            _dataTables.Model.AutoWidth = true;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> ColReorder(bool colReorder)
        {
            _dataTables.Model.ColReorder = colReorder;
            return this;
        }

        internal bool rowReorder = false;
        internal string rowReorderSelector = string.Empty;
        public DataTablesSettingsBuilder<TModel> RowReorder(bool rowReorder, string rowReorderSelector = null)
        {
            this.rowReorder = rowReorder;
            this.rowReorderSelector = rowReorderSelector;
            return this;
        }

        internal bool scrollInfinite = false;
        internal int? scrollY = null;
        public DataTablesSettingsBuilder<TModel> ScrollInfinite(bool scrollInfinite, int? scrollY = null)
        {
            this.scrollInfinite = scrollInfinite;
            this.scrollY = scrollY;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> SearchDelay(int searchDelay)
        {
            _dataTables.Model.SearchDelay = searchDelay;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> Info(bool info)
        {
            _dataTables.Model.Info = info;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> StateSave(bool stateSave)
        {
            _dataTables.Model.StateSave = stateSave;
            return this;
        }

        internal bool destroy = false;
        public DataTablesSettingsBuilder<TModel> Destroy(bool destroy)
        {
            this.destroy = destroy;
            return this;
        }

        public DataTablesSettingsBuilder<TModel> Dom(string dom)
        {
            _dataTables.Model.Dom = dom;
            return this;
        }

        internal bool striped = false;
        public DataTablesSettingsBuilder<TModel> Striped()
        {
            this.striped = true;
            return this;
        }

        internal bool bordered = false;
        public DataTablesSettingsBuilder<TModel> Bordered()
        {
            this.bordered = true;
            return this;
        }

        internal bool hover = false;
        public DataTablesSettingsBuilder<TModel> Hover()
        {
            this.hover = true;
            return this;
        }

        internal bool condensed = false;
        public DataTablesSettingsBuilder<TModel> Condensed()
        {
            this.condensed = true;
            return this;
        }

        internal string GetTableClass()
        {
            var result = new List<string>();

            result.Add("table");
            if (striped) result.Add("table-striped");
            if (bordered) result.Add("table-bordered");
            if (hover) result.Add("table-hover");
            if (condensed) result.Add("table-condensed");

            return string.Join(" ", result);
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void Dispose()
        {

        }
    }
}
