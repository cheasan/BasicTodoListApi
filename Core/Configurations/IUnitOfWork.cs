using BasicToDoListApi.Models.Repositories;

namespace BasicToDoListApi.Core.Configurations
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }

        Task CompleteAsync();
    }
}