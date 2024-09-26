using Microsoft.EntityFrameworkCore;
using TestProject.Infrastructure.Repositories.Interfaces;
using TestProject.Infrastructure.TestDbContexts;

namespace TestProject.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly TestDbContext _dbContext;
    public UnitOfWork(TestDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public TestDbContext Context { get => this._dbContext; }

    private IUserRepository _users;
    public IUserRepository Users => _users ??= new UserRepository(this._dbContext);
    private IPostRepository _posts;
    public IPostRepository Posts => this._posts ??= new PostRepository(this._dbContext);

    public void Dispose()
    {
        Dispose();
        GC.SuppressFinalize(this);
    }

    public  int Save()
    {
       return _dbContext.SaveChanges();
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _dbContext.SaveChangesAsync();
    }
}
