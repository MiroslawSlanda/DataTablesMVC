using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTablesMvc.Data
{
    public interface IDataTablesLinqSource<TEntity> : IDataTablesSource
    {
        void Filter(ref IQueryable<TEntity> query);
        void RecordsTotal(IQueryable<TEntity> query);
        void Order(ref IQueryable<TEntity> query);
        void Pager(ref IQueryable<TEntity> query);
        void RecordsFiltered(ref IQueryable<TEntity> query);
        void Select(IQueryable<TEntity> query);
        void OnDataLoaded();
    }
}
