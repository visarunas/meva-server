using MevaWeb.DBA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MevaWeb.Models;

namespace MevaWeb.Controllers
{
    public class StudentAPIController : ApiController
    {
        ApiDbContext dbContext = null;

        public StudentAPIController()
        {
            dbContext = new ApiDbContext();
        }

        [HttpPost]
        public IHttpActionResult InsertStudent(Student student)
        {

            dbContext.Students.Add(student);
            dbContext.SaveChangesAsync();

            return Ok(student.Id);
        }

        public IEnumerable<Student> GetAllStudent()
        {
            var list = dbContext.Students.ToList();

            return list;
        }

        [HttpGet]
        public IHttpActionResult DeleteStudent(int id)
        {
            var student = dbContext.Students.Find(id);

            dbContext.Students.Remove(student);

            dbContext.SaveChangesAsync();

            return Ok(student.FirstName + " " + student.LastName + " is deleted successfully.");

        }

        [HttpGet]
        public IHttpActionResult ViewStudent(int id)
        {
            var student = dbContext.Students.Find(id);
            return Ok(student);
        }


    }
}
