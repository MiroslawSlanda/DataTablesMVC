using DataTablesMvc.Infrastructure;
using DataTablesMvc.Models;
using System;
using System.ComponentModel;
using System.Web;

namespace DataTablesMvc.Builders
{
    public class DataTableEventsBuilder<TModel> : DataTableModuleBuilder<TModel>
    {
        public DataTableEventsBuilder(DataTableBuilder<TModel> dataTables) 
            : base(dataTables)
        {
            _dataTables.Model.Events = new DataTablesEvents();
        }

        #region ColumnSizing()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> ColumnSizing(string handler)
        {
            _dataTables.Model.Events.ColumnSizing = handler;
            return this;
        }

        public BlockBuilder BeginColumnSizing(string handler)
        {
            _dataTables.Model.Events.ColumnSizing = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region ColumnVisibility()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> ColumnVisibility(string handler)
        {
            _dataTables.Model.Events.ColumnVisibility = handler;
            return this;
        }

        public BlockBuilder BeginColumnVisibility(string handler)
        {
            _dataTables.Model.Events.ColumnVisibility = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Destroy()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Destroy(string handler)
        {
            _dataTables.Model.Events.Destroy = handler;
            return this;
        }

        public BlockBuilder BeginDestroy(string handler)
        {
            _dataTables.Model.Events.Destroy = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Draw()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Draw(string handler)
        {
            _dataTables.Model.Events.Draw = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginDraw(string handler)
        {
            _dataTables.Model.Events.Draw = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Error()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Error(string handler)
        {
            _dataTables.Model.Events.Error = handler;
            return this;
        }

        public BlockBuilder BeginError(string handler)
        {
            _dataTables.Model.Events.Error = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Init()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Init(string handler)
        {
            _dataTables.Model.Events.Init = handler;
            return this;
        }

        public BlockBuilder BeginInit(string handler)
        {
            _dataTables.Model.Events.Init = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Length()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Length(string handler)
        {
            _dataTables.Model.Events.Length = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginLength(string handler)
        {
            _dataTables.Model.Events.Length = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Order()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Order(string handler)
        {
            _dataTables.Model.Events.Order = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginOrder(string handler)
        {
            _dataTables.Model.Events.Order = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Page()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Page(string handler)
        {
            _dataTables.Model.Events.Page = handler;
            return this;
        }

        public BlockBuilder BeginPage(string handler)
        {
            _dataTables.Model.Events.Page = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion  

        #region PreInit()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> PreInit(string handler)
        {
            _dataTables.Model.Events.PreInit = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginPreInit(string handler)
        {
            _dataTables.Model.Events.PreInit = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region PreXhr()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> PreXhr(string handler)
        {
            _dataTables.Model.Events.PreXhr = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginPreXhr(string handler)
        {
            _dataTables.Model.Events.PreXhr = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Processing()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Processing(string handler)
        {
            _dataTables.Model.Events.Processing = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginProcessing(string handler)
        {
            _dataTables.Model.Events.Processing = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Search()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Search(string handler)
        {
            _dataTables.Model.Events.Search = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginSearch(string handler)
        {
            _dataTables.Model.Events.Search = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region StateLoaded()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> StateLoaded(string handler)
        {
            _dataTables.Model.Events.StateLoaded = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginStateLoaded(string handler)
        {
            _dataTables.Model.Events.StateLoaded = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region StateLoadParams()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> StateLoadParams(string handler)
        {
            _dataTables.Model.Events.StateLoadParams = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginStateLoadParams(string handler)
        {
            _dataTables.Model.Events.StateLoadParams = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region StateSaveParams()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> StateSaveParams(string handler)
        {
            _dataTables.Model.Events.StateSaveParams = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginStateSaveParams(string handler)
        {
            _dataTables.Model.Events.StateSaveParams = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region Xhr()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> Xhr(string handler)
        {
            _dataTables.Model.Events.Xhr = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginXhr(string handler)
        {
            _dataTables.Model.Events.Xhr = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        #region CreatedRow()
        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public DataTableEventsBuilder<TModel> CreatedRow(string handler)
        {
            _dataTables.Model.Events.CreatedRow = handler;
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handler">The name of the JavaScript function</param>
        /// <returns></returns>
        public BlockBuilder BeginCreatedRow(string handler)
        {
            _dataTables.Model.Events.CreatedRow = handler;
            var block = new BlockBuilder(_dataTables.WebViewPage);
            _dataTables.Scripts.Add(block);
            return block;
        }
        #endregion

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void Dispose()
        {

        }
    }
}
