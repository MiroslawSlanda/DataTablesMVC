using DataTablesMvc.Models;
using System.Web.Mvc;

namespace DataTablesMvc.Builders
{
    public class DataTablesLanguageBuilder<TModel> : DataTablesModuleBuilder<TModel>
    {
        public DataTablesLanguageBuilder(DataTablesBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            
        }

        public DataTablesLanguageBuilder<TModel> Processing(string processing)
        {
            _dataTables.Model.Language.Processing = processing;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> Search(string search)
        {
            _dataTables.Model.Language.Search = search;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> SearchPlaceholder(string searchPlaceholder)
        {
            _dataTables.Model.Language.SearchPlaceholder = searchPlaceholder;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> LengthMenu(string lengthMenu)
        {
            _dataTables.Model.Language.LengthMenu = lengthMenu;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> Info(string info)
        {
            _dataTables.Model.Language.Info = info;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> InfoEmpty(string infoEmpty)
        {
            _dataTables.Model.Language.InfoEmpty = infoEmpty;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> InfoFiltered(string infoFiltered)
        {
            _dataTables.Model.Language.InfoFiltered = infoFiltered;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> InfoPostFix(string infoPostFix)
        {
            _dataTables.Model.Language.InfoPostFix = infoPostFix;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> LoadingRecords(string loadingRecords)
        {
            _dataTables.Model.Language.LoadingRecords = loadingRecords;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> ZeroRecords(string zeroRecords)
        {
            _dataTables.Model.Language.ZeroRecords = zeroRecords;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> EmptyTable(string emptyTable)
        {
            _dataTables.Model.Language.EmptyTable = emptyTable;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> First(string first)
        {
            _dataTables.Model.Language.First = first;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> Previous(string previous)
        {
            _dataTables.Model.Language.Previous = previous;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> Next(string next)
        {
            _dataTables.Model.Language.Next = next;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> Last(string last)
        {
            _dataTables.Model.Language.Last = last;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> SortAscending(string sortAscending)
        {
            _dataTables.Model.Language.SortAscending = sortAscending;
            return this;
        }

        public DataTablesLanguageBuilder<TModel> SortDescending(string sortDescending)
        {
            _dataTables.Model.Language.SortDescending = sortDescending;
            return this;
        }
    }
}
