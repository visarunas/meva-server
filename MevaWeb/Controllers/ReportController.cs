using MevaWeb.DBA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MevaWeb.Controllers
{
    public class ReportController : ApiController
    {
        ApiDbContext dbContext = null;

        public ReportController()
        {
            dbContext = new ApiDbContext();


        }

        [HttpPost]
        public StatusResponse AddReport(Report report)
        {
            dbContext.Reports.Add(report);
            dbContext.SaveChangesAsync();

            var response = new StatusResponse();
            response.Status = "OK";

            return response;
        }
    }
}
