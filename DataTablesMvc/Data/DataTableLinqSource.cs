using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc
{
    public class DataTableLinqSource<TEntity> : DataTableSource
    {
        public DataTableLinqSource() 
            : base()
        {

        }

        public virtual void Filter(ref IQueryable<TEntity> query) { }
        public virtual void Order(ref IQueryable<TEntity> query) { }
        public virtual void Select(IQueryable<TEntity> query) { }

        public void Pager(ref IQueryable<TEntity> query)
        {
            
        }
        public void RecordsFiltered(ref IQueryable<TEntity> query)
        {
            Response.RecordsFiltered = query.Count();
        }

        public void RecordsTotal(IQueryable<TEntity> query)
        {
            Response.RecordsTotal = query.Count();
        }

        
    }
}
