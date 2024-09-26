
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestProject.Infrastructure.Repositories.Interfaces;
using TestProject.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using TestProject.Infrastructure.TestDbContexts;

namespace TestProject.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddBlogDbContext(configuration);
        services.AddRepositories();
    }

    private static void AddBlogDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<TestDbContext>(option => option.UseSqlServer(connectionString));
    }

    private static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPostRepository, PostRepository>();
    }
}
