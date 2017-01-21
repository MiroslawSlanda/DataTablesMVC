using System;
using System.ComponentModel;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace DataTablesMvc.Infrastructure
{
    public class BlockBuilder : IDisposable, IHtmlString
    {
        readonly WebViewPage _webPageBase;
        StringWriter _content;

        public BlockBuilder(WebViewPage webPageBase)
        {
            _webPageBase = webPageBase;
            _webPageBase.OutputStack.Push(new StringWriter());
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Dispose()
        {
            _content = (StringWriter)_webPageBase.OutputStack.Pop();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ToHtmlString()
        {
            return _content.ToString();
        }
    }
}
