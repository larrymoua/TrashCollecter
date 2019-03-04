using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollecterProject.Models
{
    public class Customer : User
    {
        public int CustomerId { get; set; }
    }
}