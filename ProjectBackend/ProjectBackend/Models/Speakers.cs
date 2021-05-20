using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackend.Models
{
    public class Speakers
    {
        public int Id { get; set; }
        public string SpeakerImageUrl { get; set; }
        public string SpeakerName { get; set; }
        public string SpeakerQualification { get; set; }
        public List<EventSpeakers> EventSpeakers { get; set; }

    }
}
