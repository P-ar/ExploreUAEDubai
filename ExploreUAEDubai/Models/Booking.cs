using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreUAEDubai.Models
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "User ID")]
        public string UserID { get; set; }

        [Required]
        public int AttractionID { get; set; }

        [ForeignKey("AttractionID")]
        [InverseProperty("AttractionBookings")]
        public Attraction Attraction { get; set; }

    }
}
