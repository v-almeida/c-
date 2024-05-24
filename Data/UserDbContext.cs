using Microsoft.EntityFrameworkCore;


namespace ExemploORM.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) { }
        public DbSet<UserModel> Users { get; set; }

    }
}