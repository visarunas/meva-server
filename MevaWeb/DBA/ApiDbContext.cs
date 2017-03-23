
using System.Data.Entity;
using MevaWeb.Models;

namespace MevaWeb.DBA
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext() : base("Connection")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}