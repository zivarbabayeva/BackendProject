using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public DateTime CreatedDate { get; set; }
        [Required]
        [MaxLength(250)]
        public string Description { get; set; }
    }
}
