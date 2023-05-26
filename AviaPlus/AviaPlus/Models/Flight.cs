using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace AviaPlus.Models
{
    public class Flight
    {
        public int Id { get; set; }
        [Required]
        [StringLength(4)]
        public string FlightNumber { get; set; }
        [Required]
        public DateTime DepartureTime { get; set; }
        [Required]
        public DateTime ArrivalTime { get; set; }
        [Required]
        public string Departure { get; set; }
        [Required]
        public string Gate { get; set; }
        [Required]
        public string Carousel { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool IsCancelled { get; set; }
        [Required]
        public int TicketId { get; set; }

        [ForeignKey("TicketId")]
        public Ticket Ticket { get; set; }
    }
}
