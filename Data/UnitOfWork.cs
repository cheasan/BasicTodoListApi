using BasicToDoListApi.Models.Repositories;

namespace BasicToDoListApi.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private readonly ApiDbContext _context;
        private readonly ILogger _logger;
        public ICategoryRepository Categories { get; }


        public UnitOfWork(ApiDbContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");
            
            Categories = new CategoryRepository(_context, _logger);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}