using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class CoursesOffer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(250)]
        public string SubTitle { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
     
    }
}
