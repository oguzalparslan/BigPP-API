using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigPP.DataAccess.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public Task AddAsync(TEntity entity);
        public Task AddRangeAsync(IEnumerable<TEntity> entities);
        public void Remove(int id);
        public void Remove(TEntity entity);
        public void RemoveRange(IEnumerable<TEntity> entities);
        public void Update(TEntity entity);
        public IQueryable<TEntity> GetAllAsync(TEntity entity);
        public Task<TEntity> GetByIdAsync(int id);
    }
}
