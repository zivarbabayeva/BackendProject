using ProjectBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.ViewModel
{
    public class AboutVM
    {
        public About About { get; set; }
        public Testimonial Testimonial { get; set; }
        public List<NoticeBoard> NoticeBoard { get; set; }
        public VideoTour VideoTour { get; set; }
    }
}
