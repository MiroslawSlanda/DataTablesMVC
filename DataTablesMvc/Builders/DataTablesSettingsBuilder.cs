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
    public class DataTableSettingsBuilder<TModel> : DataTableModuleBuilder<TModel>
    {
        public DataTableSettingsBuilder(DataTableBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            
        }

        public DataTableSettingsBuilder<TModel> Paging(bool paging)
        {
            _dataTables.Model.Paging = paging;
            return this;
        }

        public DataTableSettingsBuilder<TModel> Ordering(bool ordering)
        {
            _dataTables.Model.Ordering = ordering;
            return this;
        }

        public DataTableSettingsBuilder<TModel> Processing()
        {
            _dataTables.Model.Processing = true;
            return this;
        }

        internal bool indexable = false;
        public DataTableSettingsBuilder<TModel> Indexable()
        {
            //_settings.Indexable = true;
            return this;
        }

        internal bool selectable = false;
        internal int selectColumn = 1;
        public DataTableSettingsBuilder<TModel> Selectable(int column = 1)
        {
            this.selectable = true;
            this.selectColumn = column;
            return this;
        }

        internal bool hiddenLengthChange = false;
        public DataTableSettingsBuilder<TModel> HiddenLengthChange()
        {
            this.hiddenLengthChange = true;
            return this;
        }

        internal Dictionary<int, string> lengthMenu = null;
        public DataTableSettingsBuilder<TModel> LengthMenu(Dictionary<int, string> lengthMenu)
        {
            this.lengthMenu = lengthMenu;
            return this;
        }

        internal bool orderCellsTop = false;
        public DataTableSettingsBuilder<TModel> OrderCellsTop()
        {
            this.orderCellsTop = true;
            return this;
        }

        internal bool deferRender = false;
        public DataTableSettingsBuilder<TModel> DeferRender()
        {
            this.deferRender = true;
            return this;
        }

        internal int? orderColumn = null;
        public DataTableSettingsBuilder<TModel> OrderBy(int column)
        {
            this.orderColumn = column;
            return this;
        }

        public DataTableSettingsBuilder<TModel> PageLength(int pageLength)
        {
            _dataTables.Model.PageLength = pageLength;
            return this;
        }

        public DataTableSettingsBuilder<TModel> Searching()
        {
            _dataTables.Model.Searching = true;
            return this;
        }

        public DataTableSettingsBuilder<TModel> AutoWidth()
        {
            _dataTables.Model.AutoWidth = true;
            return this;
        }

        public DataTableSettingsBuilder<TModel> ColReorder(bool colReorder)
        {
            _dataTables.Model.ColReorder = colReorder;
            return this;
        }

        internal bool rowReorder = false;
        internal string rowReorderSelector = string.Empty;
        public DataTableSettingsBuilder<TModel> RowReorder(bool rowReorder, string rowReorderSelector = null)
        {
            this.rowReorder = rowReorder;
            this.rowReorderSelector = rowReorderSelector;
            return this;
        }

        internal bool scrollInfinite = false;
        internal int? scrollY = null;
        public DataTableSettingsBuilder<TModel> ScrollInfinite(bool scrollInfinite, int? scrollY = null)
        {
            this.scrollInfinite = scrollInfinite;
            this.scrollY = scrollY;
            return this;
        }

        public DataTableSettingsBuilder<TModel> SearchDelay(int searchDelay)
        {
            _dataTables.Model.SearchDelay = searchDelay;
            return this;
        }

        public DataTableSettingsBuilder<TModel> Info(bool info)
        {
            _dataTables.Model.Info = info;
            return this;
        }

        public DataTableSettingsBuilder<TModel> StateSave(bool stateSave)
        {
            _dataTables.Model.StateSave = stateSave;
            return this;
        }

        internal bool destroy = false;
        public DataTableSettingsBuilder<TModel> Destroy(bool destroy)
        {
            this.destroy = destroy;
            return this;
        }

        public DataTableSettingsBuilder<TModel> Dom(string dom)
        {
            _dataTables.Model.Dom = dom;
            return this;
        }

        internal bool striped = false;
        public DataTableSettingsBuilder<TModel> Striped()
        {
            this.striped = true;
            return this;
        }

        internal bool bordered = false;
        public DataTableSettingsBuilder<TModel> Bordered()
        {
            this.bordered = true;
            return this;
        }

        internal bool hover = false;
        public DataTableSettingsBuilder<TModel> Hover()
        {
            this.hover = true;
            return this;
        }

        internal bool condensed = false;
        public DataTableSettingsBuilder<TModel> Condensed()
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
