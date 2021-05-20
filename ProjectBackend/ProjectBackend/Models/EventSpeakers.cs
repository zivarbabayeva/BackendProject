using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class EventSpeakers
    {
        public int Id { get; set; }
        public int SpeakersId { get; set; }
        public Speakers Speakers { get; set; }
        public int EventdetailsId { get; set; }
        public Eventdetails Eventdetails { get; set; }
    }
}
