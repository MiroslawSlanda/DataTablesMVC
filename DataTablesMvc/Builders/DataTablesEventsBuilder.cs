using System;
using System.Web;

namespace DataTablesMvc.Builders
{
    public class DataTablesEventsBuilder<TModel> : DataTablesModuleBuilder<TModel>
    {
        public DataTablesEventsBuilder(DataTablesBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            
        }

        #region Init()
        public DataTablesEventsBuilder<TModel> Init(string handler)
        {
            _dataTables.Model.Events.Init = handler;
            return this;
        }

        public DataTablesEventsBuilder<TModel> Init(Func<object, object> code)
        {
            _dataTables.Model.Events.Init = code(null).ToString().Trim();
            return this;
        }
        #endregion

        #region Draw()
        public DataTablesEventsBuilder<TModel> Draw(string handler)
        {
            _dataTables.Model.Events.Draw = handler;
            return this;
        }

        public DataTablesEventsBuilder<TModel> Draw(Func<object, object> code)
        {
            _dataTables.Model.Events.Draw = code(null).ToString().Trim();
            return this;
        }
        #endregion

        #region ColumnSizing()
        public DataTablesEventsBuilder<TModel> ColumnSizing(string handler)
        {
            _dataTables.Model.Events.ColumnSizing = handler;
            return this;
        }

        public DataTablesEventsBuilder<TModel> ColumnSizing(Func<object, object> code)
        {
            _dataTables.Model.Events.ColumnSizing = code(null).ToString().Trim();
            return this;
        }
        #endregion

        #region Length()
        public DataTablesEventsBuilder<TModel> Length(string handler)
        {
            _dataTables.Model.Events.Length = handler;
            return this;
        }

        public DataTablesEventsBuilder<TModel> Length(Func<object, object> code)
        {
            _dataTables.Model.Events.Length = code(null).ToString().Trim();
            return this;
        }
        #endregion

        #region PreInit()
        public DataTablesEventsBuilder<TModel> PreInit(string handler)
        {
            _dataTables.Model.Events.PreInit = handler;
            return this;
        }

        public DataTablesEventsBuilder<TModel> PreInit(Func<object, object> code)
        {
            _dataTables.Model.Events.PreInit = code(null).ToString().Trim();
            return this;
        }

        #endregion

        #region Processing()
        public DataTablesEventsBuilder<TModel> Processing(string handler)
        {
            _dataTables.Model.Events.Processing = handler;
            return this;
        }

        public DataTablesEventsBuilder<TModel> Processing(Func<object, object> code)
        {
            _dataTables.Model.Events.Processing = code(null).ToString().Trim();
            return this;
        }

        #endregion

        #region StateLoaded()
        public DataTablesEventsBuilder<TModel> StateLoaded(string handler)
        {
            _dataTables.Model.Events.StateLoaded = handler;
            return this;
        }

        public DataTablesEventsBuilder<TModel> StateLoaded(Func<object, object> code)
        {
            _dataTables.Model.Events.StateLoaded = code(null).ToString().Trim();
            return this;
        }

        #endregion

        #region CreatedRow()
        public DataTablesEventsBuilder<TModel> CreatedRow(string handler)
        {
            _dataTables.Model.Events.CreatedRow = handler;
            return this;
        }

        public DataTablesEventsBuilder<TModel> CreatedRow(Func<object, object> code)
        {
            _dataTables.Model.Events.CreatedRow = code(null).ToString().Trim();
            return this;
        }

        #endregion
    }
}
