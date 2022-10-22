using BasicToDoListApi.Core.Configurations;
using BasicToDoListApi.Models.Repositories;

namespace BasicToDoListApi.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private readonly ApiDbContext _context;
        private readonly ILogger _logger;
        public ICategoryRepository Categories { get; private set; }


        public UnitOfWork(ApiDbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;

            Categories = new CategoryRepository(_context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.DisposeAsync();
        }
    }
}