using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

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

        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
      
    }
}