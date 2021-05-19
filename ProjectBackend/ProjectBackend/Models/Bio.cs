using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Bio
    {
        public int Id { get; set; }
       [Required]
       [MaxLength(250)]
        public string Search { get; set; }
        [Required]
        [MaxLength(250)]
        public string Categories { get; set; }
        [Required]
        [MaxLength(250)]
        public string CSSEngineering { get; set; }
        [Required]
        [MaxLength(250)]
        public string PoliticalScience { get; set; }
        [Required]
        [MaxLength(250)]
        public string MicroBiology { get; set; }
        [Required]
        [MaxLength(250)]
        public string HTML5CSS3 { get; set; }
        [Required]
        [MaxLength(250)]
        public string WebDesign { get; set; }
        [Required]
        [MaxLength(250)]
        public string PHP { get; set; }
        [Required]
        [MaxLength(250)]
        public string ImageUrl { get; set; }
        [Required]
        [MaxLength(250)]
        public string LatestPost { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Required]
        [MaxLength(250)]
        public string SubTitle { get; set; }
        [Required]
        [MaxLength(50)]
        public string ByAlex { get; set; }
       
        public string Tag { get; set; }
    }
}
