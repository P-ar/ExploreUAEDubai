using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreUAEDubai.Models
{
    public class Attraction
    {
        [Key]
        public int AttractionID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Attraction Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }

        public virtual ICollection<Booking> AttractionBookings { get; set; }
    }
}
