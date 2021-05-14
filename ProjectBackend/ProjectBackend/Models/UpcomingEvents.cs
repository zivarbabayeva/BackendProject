using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class UpcomingEvents
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        [MaxLength(350)]
        public DateTime StartEndTime { get; set; }
        [Required]
        [MaxLength(350)]
        public string Venue { get; set; }

    }
}
