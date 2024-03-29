﻿using ProjectBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.ViewModel
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public Caption Caption { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<NoticeTwo> NoticeTwos { get; set; }
        public WhyChoose WhyChooses { get; set; }
        public List<Upcomming> Upcomming { get; set; }
        public Testimonial Testimonial { get; set; }
    }
}
