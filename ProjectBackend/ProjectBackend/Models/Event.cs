using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Event
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
        [MaxLength(150)]
        public string Venue { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public bool IsMain { get; set; }
        public Eventdetails Eventdetails { get; set; }
        public Categories Categories { get; set; }

    }
}
