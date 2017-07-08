using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DataTablesMvc
{
    public class DataTableConfig
    {
        public static void Configure()
        {
            ModelBinders.Binders.Add(typeof(IDataTableSource), new DataTableSourceBinder());
        }
    }
}
