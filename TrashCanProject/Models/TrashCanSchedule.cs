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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy h:mm tt}", ApplyFormatInEditMode = true)]
        public DateTime PickUpDate { get; set; }
        public DateTime ExtraPickupDate { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        [ForeignKey("EmployeeId")]
        public Customer Customer { get; set; }
    }
}