using BigPP.DataAccess.Abstract;
using BigPP.DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BigPP.DataAccess.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _appDbContext;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }
        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }
        public IQueryable<TEntity> GetAllAsync(TEntity entity)
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                return null;
            }
        }
        public void Remove(int id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }
        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
