using TestProject.Infrastructure.TestDbContexts;

namespace TestProject.Infrastructure.Repositories.Interfaces;

public interface IUnitOfWork : IDisposable
{
    TestDbContext Context { get; }
    IUserRepository Users { get; }
    IPostRepository Posts { get; }
    Task<int> SaveChangesAsync();
    int Save();
}
