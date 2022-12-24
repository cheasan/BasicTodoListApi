using BasicToDoListApi.Models.Repositories;

namespace BasicToDoListApi.Data
{
    public interface IUnitOfWork
    {
        ICategoryRepository Categories { get; }

        Task Save();
    }
}