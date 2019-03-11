using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCanProject.Models
{
    public class CustomerAndSchedule
    {
        public TrashCanSchedule trashCanSchedule {get;set;}
        public Customer customer { get; set; }
    } 
}