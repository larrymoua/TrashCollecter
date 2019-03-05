using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCanProject.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
}