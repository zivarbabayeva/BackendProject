using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class TeacherDetails
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        [Required]
        [MaxLength(250)]
        public string Qualification { get; set; }
      
        [Required]
        [MaxLength(250)]
        public string AboutMe { get; set; }
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
        public string Faculty { get; set; }
        [Required]
        [MaxLength(150)]
        public string ContactInformation { get; set; }
        [Required]
        [MaxLength(150)]
        public string MailMe { get; set; }
        [Required]
        [MaxLength(150)]
        public string CallNumber { get; set; }
        [Required]
        [MaxLength(150)]
        public string Skype { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
