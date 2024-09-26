using TestProject.Core.Entities;
using TestProject.Infrastructure.Repositories.Interfaces;
using TestProject.Infrastructure.TestDbContexts;

namespace TestProject.Infrastructure.Repositories;

public class PostRepository : BaseRepository<Post> , IPostRepository
{
    public PostRepository(TestDbContext context) 
        : base(context)
    {
    }
}
