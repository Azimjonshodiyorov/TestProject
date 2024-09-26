using TestProject.Core.Common;

namespace TestProject.Infrastructure.Repositories.Interfaces;

public interface IBaseRepository<T> where T  : BaseEntity
{
    IQueryable<T> Entities { get; }
    Task AddAsync(T entity);
    Task DeleteAsync(T entity);
    Task UpdateAsync(T entity);
    Task<T?> GetAsync(long id);

}
