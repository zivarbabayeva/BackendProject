﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class VideoTour
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string VideoLink { get; set; }
    }
}
