using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class CourseDetails
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(500)]
        public string AboutCourse { get; set; }
        [Required]
        [MaxLength(500)]
        public string HowToApply { get; set; }
        [Required]
        [MaxLength(500)]
        public string Certification { get; set; }
        [Required]
        [MaxLength(500)]
        public string TabName { get; set; }
        [Required]
        [MaxLength(30)]
        public string Starts { get; set; }
        [Required]
        [MaxLength(30)]
        public string Duration { get; set; }
        [Required]
        [MaxLength(20)]
        public string ClassDuration { get; set; }
        [Required]
        [MaxLength(20)]
        public string SkilLevel { get; set; }
        [Required]
        [MaxLength(20)]
        public string Language { get; set; }
        public int StudentsCount { get; set; }
        [Required]
        [MaxLength(20)]
        public string Assesments { get; set; }
        public int CourseFee { get; set; }
        [ForeignKey("CoursesOffer")]
        public int CoursesOfferId { get; set; }
        public CoursesOffer CoursesOffer { get; set; }

    }
}
