using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Core.Entities;
using TestProject.Infrastructure.Repositories.Interfaces;
using TestProject.Infrastructure.TestDbContexts;

namespace TestProject.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User> , IUserRepository
    {
        public UserRepository(TestDbContext context)
            : base(context)
        {
        }
    }
}
