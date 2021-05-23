using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(150)]
        public string Bywhom { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public bool IsMain { get; set; }

        public Blogdetails Blogdetails { get; set; }

    }
}
