using DataTablesMvc.Models;
using System;
using System.ComponentModel;
using System.Web.Mvc;

namespace DataTablesMvc.Builders
{
    public class DataTableLanguageBuilder<TModel> : DataTableModuleBuilder<TModel>
    {
        public DataTableLanguageBuilder(DataTableBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            _dataTables.Model.Language = new DataTablesLanguage();
        }

        public DataTableLanguageBuilder<TModel> Url(string url)
        {
            _dataTables.Model.Language.Url = url;
            return this;
        }

        public DataTableLanguageBuilder<TModel> Processing(string processing)
        {
            _dataTables.Model.Language.Processing = processing;
            return this;
        }

        public DataTableLanguageBuilder<TModel> Search(string search)
        {
            _dataTables.Model.Language.Search = search;
            return this;
        }

        public DataTableLanguageBuilder<TModel> SearchPlaceholder(string searchPlaceholder)
        {
            _dataTables.Model.Language.SearchPlaceholder = searchPlaceholder;
            return this;
        }

        public DataTableLanguageBuilder<TModel> LengthMenu(string lengthMenu)
        {
            _dataTables.Model.Language.LengthMenu = lengthMenu;
            return this;
        }

        public DataTableLanguageBuilder<TModel> Info(string info)
        {
            _dataTables.Model.Language.Info = info;
            return this;
        }

        public DataTableLanguageBuilder<TModel> InfoEmpty(string infoEmpty)
        {
            _dataTables.Model.Language.InfoEmpty = infoEmpty;
            return this;
        }

        public DataTableLanguageBuilder<TModel> InfoFiltered(string infoFiltered)
        {
            _dataTables.Model.Language.InfoFiltered = infoFiltered;
            return this;
        }

        public DataTableLanguageBuilder<TModel> InfoPostFix(string infoPostFix)
        {
            _dataTables.Model.Language.InfoPostFix = infoPostFix;
            return this;
        }

        public DataTableLanguageBuilder<TModel> LoadingRecords(string loadingRecords)
        {
            _dataTables.Model.Language.LoadingRecords = loadingRecords;
            return this;
        }

        public DataTableLanguageBuilder<TModel> ZeroRecords(string zeroRecords)
        {
            _dataTables.Model.Language.ZeroRecords = zeroRecords;
            return this;
        }

        public DataTableLanguageBuilder<TModel> EmptyTable(string emptyTable)
        {
            _dataTables.Model.Language.EmptyTable = emptyTable;
            return this;
        }

        public DataTableLanguageBuilder<TModel> First(string first)
        {
            _dataTables.Model.Language.First = first;
            return this;
        }

        public DataTableLanguageBuilder<TModel> Previous(string previous)
        {
            _dataTables.Model.Language.Previous = previous;
            return this;
        }

        public DataTableLanguageBuilder<TModel> Next(string next)
        {
            _dataTables.Model.Language.Next = next;
            return this;
        }

        public DataTableLanguageBuilder<TModel> Last(string last)
        {
            _dataTables.Model.Language.Last = last;
            return this;
        }

        public DataTableLanguageBuilder<TModel> SortAscending(string sortAscending)
        {
            _dataTables.Model.Language.SortAscending = sortAscending;
            return this;
        }

        public DataTableLanguageBuilder<TModel> SortDescending(string sortDescending)
        {
            _dataTables.Model.Language.SortDescending = sortDescending;
            return this;
        }

        public DataTableLanguageBuilder<TModel> Decimal(string value)
        {
            _dataTables.Model.Language.Decimal = value;
            return this;
        }

        public DataTableLanguageBuilder<TModel> Thousands(string thousands)
        {
            _dataTables.Model.Language.Thousands = thousands;
            return this;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void Dispose()
        {
            
        }
    }
}
