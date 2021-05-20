using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Blogdetails
    {
        public int Id { get; set; }
        [Required()]
        [MaxLength(250)]
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string Bywhom { get; set; }
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(500)]
        public string SubDescription { get; set; }
        [Required]
        [MaxLength(500)]
        public string Desc { get; set; }
        [Required]
        [MaxLength(500)]
        public string Subdesc { get; set; }
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
