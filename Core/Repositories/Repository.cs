using BasicToDoListApi.Data;
using Microsoft.EntityFrameworkCore;

namespace BasicToDoListApi.Core.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected ApiDbContext context;
        protected DbSet<TEntity> dbSet;
        protected readonly ILogger _logger;


        public Repository(ApiDbContext context, ILogger logger)
        {
            this.context = context;
            _logger = logger;
        }


        public virtual async Task<bool> Add(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<IEnumerable<TEntity>> All()
        {
            return await dbSet.ToListAsync<TEntity>();
        }

        public virtual Task<bool> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual Task<bool> Upsert(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}