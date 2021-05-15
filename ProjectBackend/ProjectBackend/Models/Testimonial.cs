using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Pozition { get; set; }
    }
}
