
using System.Data.Entity;
using MevaWeb.Models;

namespace MevaWeb.DBA
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext() : base("Connection")
        {
            Database.SetInitializer<ApiDbContext>(new DropCreateDatabaseAlways< ApiDbContext>());
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Account> Accounts { get; set; }
    }
}