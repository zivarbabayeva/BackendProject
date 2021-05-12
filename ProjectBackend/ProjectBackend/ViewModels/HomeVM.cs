using ProjectBackend.Models;
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
    }
}
