using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreUAEDubai.Models
{
    public class Support
    {
        [Key]
        public int SupportID { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Question")]
        public string Question { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "Answer")]
        public string Answer { get; set; }
    }
}
