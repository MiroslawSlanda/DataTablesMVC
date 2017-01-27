using DataTablesMvc.Infrastructure;
using System;
using System.ComponentModel;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
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

        public BlockBuilder BeginInit(string handler)
        {
            return new BlockBuilder(_dataTables.WebViewPage);
        }
        #endregion

        #region Draw()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginDraw(string handler)
        {
            return new BlockBuilder(_dataTables.WebViewPage);
        }
        #endregion

        #region ColumnSizing()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginColumnSizing(string handler)
        {
            return new BlockBuilder(_dataTables.WebViewPage);
        }
        #endregion

        #region Length()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginLength(string handler)
        {
            return new BlockBuilder(_dataTables.WebViewPage);
        }
        #endregion

        #region PreInit()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginPreInit(string handler)
        {
            return new BlockBuilder(_dataTables.WebViewPage);
        }
        #endregion

        #region Processing()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginProcessing(string handler)
        {
            return new BlockBuilder(_dataTables.WebViewPage);
        }
        #endregion

        #region StateLoaded()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginStateLoaded(string handler)
        {
            return new BlockBuilder(_dataTables.WebViewPage);
        }
        #endregion

        #region CreatedRow()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginCreatedRow(string handler)
        {
            return new BlockBuilder(_dataTables.WebViewPage);
        }
        #endregion

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void Dispose()
        {

        }
    }
}
