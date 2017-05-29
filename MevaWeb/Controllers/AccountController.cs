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


        }

        [HttpPost]
        public AuthResponse LogIn(LogInObject obj)
        {
            var acc = new Account();
            acc.Name = obj.userName;
            acc.Password = obj.password;

            var response = new AuthResponse();
            response.Status = "OK";

            return response;
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
