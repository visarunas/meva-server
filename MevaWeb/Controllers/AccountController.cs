using MevaWeb.DBA;
using MevaWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MevaWeb.Controllers
{
    public class AccountController : ApiController
    {
        ApiDbContext dbContext = null;

        public AccountController()
        {
            dbContext = new ApiDbContext();

            var acc = new Account();
            acc.Name = "test";
            acc.Password = "aaaa";

            dbContext.Accounts.Add(acc);
            dbContext.SaveChanges();
        }

        [HttpPost]
        public IHttpActionResult LogIn(string userName, string password)
        {
            var acc = new Account();
            acc.Name = userName;
            acc.Password = password;

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult InsertAccount(Account account)
        {

            dbContext.Accounts.Add(account);
            dbContext.SaveChangesAsync();

            return Ok(account.Id);
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            var list = dbContext.Accounts.ToList();

            return list;
        }
    }
}
