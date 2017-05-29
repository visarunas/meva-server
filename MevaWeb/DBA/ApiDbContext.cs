
using System.Data.Entity;
using MevaWeb.Models;
using MevaWeb.Controllers;

namespace MevaWeb.DBA
{
    public class ApiDbContext : DbContext
    {
        private static bool Initialized = false;

        public ApiDbContext() : base("Connection")
        {
            Database.SetInitializer<ApiDbContext>(new DropCreateDatabaseAlways< ApiDbContext>());
            if (!Initialized)
            {
                var acc = new Account()
                {
                    Name = "tester1234",
                    Password = "123"
                };
                this.Accounts.Add(acc);

                var acc2 = new Account()
                {
                    Name = "Sarunas",
                    Password = "123"
                };
                this.Accounts.Add(acc2);

                var acc3 = new Account()
                {
                    Name = "Justas",
                    Password = "123"
                };
                this.Accounts.Add(acc3);



                this.SaveChanges();

                Initialized = true;
            }
            


        }

        public DbSet<Report> Reports { get; set; }

        public DbSet<Account> Accounts { get; set; }
    }
}