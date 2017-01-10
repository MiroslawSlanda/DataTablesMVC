using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Interfaces
{
    public interface IHyperlink
    {
        string Href { get; set; }
        string Text { get; set; }
    }
}
