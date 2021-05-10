using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Required]
        [MaxLength(150)]
        public string QualificationId { get; set; }
        [Required]
        [MaxLength(150)]
        public string AboutTeacher { get; set; }
        [Required]
        [MaxLength(150)]
        public string Degree { get; set; }
        [Required]
        [MaxLength(150)]
        public string Experience { get; set; }
        [Required]
        [MaxLength(350)]
        public string Hobbies { get; set; }
        [Required]
        [MaxLength(150)]
        public string Faculty  { get; set; }
        [Required]
        [MaxLength(150)]
        public string Mail { get; set; }
        [Required]
        [MaxLength(150)]
        public string CallNumber { get; set; }
        [Required]
        [MaxLength(150)]
        public string Skype { get; set; }
        [Required]
        [MaxLength(150)]
        public string SosialIcons { get; set; }

    }
}
