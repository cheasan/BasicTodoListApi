using BasicToDoListApi.Core.Repositories;
using BasicToDoListApi.Data;
using BasicToDoListApi.Models.Entities;

namespace BasicToDoListApi.Models.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApiDbContext context, ILogger logger) : base(context, logger)
        {
        }
    }
}