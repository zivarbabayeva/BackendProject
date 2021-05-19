using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Eventdetails
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(350)]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(150)]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        [MaxLength(150)]
        public string StartTime { get; set; }
        [Required]
        [MaxLength(150)]
        public string EndTime { get; set; }
        [Required]
        [MaxLength(350)]
        public string Venue { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(500)]
        public string SubDescription { get; set; }
        [Required]
        [MaxLength(500)]
        public int SpeakerId { get; set; }
        public string SpeakerImageUrl { get; set; }
        public string SpeakerName { get; set; }
        public string SpeakerQualification { get; set; }
        public string Desc { get; set; }
        public Event Event { get; set; }
        [ForeignKey("Event")]
        public int EventId { get; set; }
      
    }
}
