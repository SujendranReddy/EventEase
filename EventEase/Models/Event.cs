using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [ForeignKey("Venue")]
        [Display(Name = "Venue")]
        public int VenueId { get; set; }

        public Venue? Venue { get; set; } 

        [Display(Name = "Venue")]
        public string? VenueName { get; set; }

        [Display(Name = "Event Name")]
        public string? EventName { get; set; }

        [Display(Name = "Date")]
        public DateTime EventDate { get; set; }

        public string? Description { get; set; }
    }
}