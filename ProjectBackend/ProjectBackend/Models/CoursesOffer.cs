using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class CoursesOffer
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(100)]
        public string SubTitle { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        public CourseDetails CourseDetails { get; set; }
        public Categories Categories { get; set; }


    }
}
