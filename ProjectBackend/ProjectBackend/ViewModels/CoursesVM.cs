using ProjectBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.ViewModel
{
    public class CoursesVM
    {
        public List<CoursesOffer> CoursesOffers { get; set; }
        public List<CourseDetails> CourseDetails { get; set; }
        public List<Categories>Categories { get; set; }
    }
}
