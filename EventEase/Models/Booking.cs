using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [ForeignKey("Venue")]
        public int VenueId { get; set; }
        public Venue? Venue { get; set; } 

        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event? Event { get; set; } 

        [Display(Name = "Date Booked")]
        public DateTime BookingDate { get; set; }
        public string? EventName => Event?.EventName;
        public string? VenueName => Venue?.VenueName;

    }
}