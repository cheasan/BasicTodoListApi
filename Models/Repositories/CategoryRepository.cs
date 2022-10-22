using BasicToDoListApi.Core.Repositories;
using BasicToDoListApi.Data;

namespace BasicToDoListApi.Models.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApiDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}