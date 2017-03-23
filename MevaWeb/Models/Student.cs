﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MevaWeb.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
 
    }
}