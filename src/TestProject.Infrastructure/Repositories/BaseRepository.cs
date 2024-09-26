using Microsoft.EntityFrameworkCore;
using TestProject.Core.Common;
using TestProject.Infrastructure.Repositories.Interfaces;
using TestProject.Infrastructure.TestDbContexts;

namespace TestProject.Infrastructure.Repositories;

public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    private readonly TestDbContext context;

    public BaseRepository(TestDbContext  context)
    {
        this.context = context;
    }
    public IQueryable<T> Entities => this.context.Set<T>().AsQueryable();

    public async Task AddAsync(T entity)
    {
        await this.context.Set<T>().AddAsync(entity);    
    }

    public async Task DeleteAsync(T entity)
    {
        this.context.Set<T>().Remove(entity);
    }

    public async Task<T?> GetAsync(long id)
    {
        return await this.context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task UpdateAsync(T entity)
    {
         this.context.Set<T>().Update(entity);
    }
}
