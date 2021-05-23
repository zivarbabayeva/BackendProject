using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Upcomming
    {
        public int Id { get; set; }
    public DateTime Date { get; set; }
        [Required]
        [MaxLength(250)]
        public string SubTitle { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [Required]
        [MaxLength(250)]
        public string Venue { get; set; }

    }
}
