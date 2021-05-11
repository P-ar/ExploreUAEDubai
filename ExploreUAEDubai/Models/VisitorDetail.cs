using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreUAEDubai.Models
{
    public class VisitorDetail
    {
        [Key]
        public int VisitorDetailID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Visitor Name")]
        public string Name { get; set; }

        [StringLength(200)]
        [Display(Name = "User ID")]
        public string UserID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Visitor Address")]
        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Contact No")]
        public string ContactNo { get; set; }

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [NotMapped]
        public SingleFileUpload File { get; set; }
        
    }

    public class SingleFileUpload
    {
        [Required]
        [Display(Name = "File")]
        public IFormFile FormFile { get; set; }
    }
}
