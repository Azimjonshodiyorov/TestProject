using Microsoft.EntityFrameworkCore;
using TestProject.Core.Entities;
using TestProject.Infrastructure.Configurations;

namespace TestProject.Infrastructure.TestDbContexts; 

public class TestDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public TestDbContext(DbContextOptions<TestDbContext> dbContext) : base(dbContext)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        base.OnModelCreating(modelBuilder);
    }
}
