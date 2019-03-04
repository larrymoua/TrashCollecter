using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCanProject.Models
{
    public class Customer:User
    {
        [Key]
        public int CustomerId { get; set; }

    }
}