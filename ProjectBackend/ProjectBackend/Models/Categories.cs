using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        public List<CoursesOffer> CourseOffers { get; set; }
        public List<Event> Event { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
