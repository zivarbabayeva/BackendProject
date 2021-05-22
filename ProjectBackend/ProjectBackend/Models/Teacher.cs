﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [MaxLength(150)]
        public string Qualification { get; set; }
        public bool IsDeleted { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required]
        [MaxLength(150)]
        public TeacherDetails TeacherDetails { get; set; }
        public TeacherSpeciality TeacherSpeciality { get; set; }
    
      
        //[Required]
        //[MaxLength(150)]
        //public string QualificationId { get; set; }





    }
}
