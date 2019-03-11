using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace TrashCanProject.Models
{
    public class TrashCanSchedule
    {


        [Key]
        public int ID { get; set; }
        [Display(Name = "Pick Up Day")]
        public PickUpDays pickUpDays { get; set; }

        [Display(Name = "Extra Pick Up Date")]
        public DateTime ExtraPickupDate { get; set; }
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        public bool Confirmed { get; set; }

        public double? Cost { get; set; }

        [Display(Name = "Start Date Suspension")]
        public DateTime? StartSuspend { get; set; }
        [Display(Name = "End Date Suspension")]
        public DateTime? EndSuspend { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
