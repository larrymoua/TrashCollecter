using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollecterProject.Models
{
    public class Employee : User
    {
        public int EmployeeId { get; set; }
    }
}