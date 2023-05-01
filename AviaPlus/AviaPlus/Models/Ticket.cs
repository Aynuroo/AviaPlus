using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace AviaPlus.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        [Required]
        public string FlightNumber { get; set; }
        [Required]
        public DateTime DepartureTime { get; set; }
        [Required]
        public DateTime ArrivalTime { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public bool IsCancelled { get; set; }

        [ForeignKey("Passenger")]
        public int PassengerId { get; set; }

        public Passenger Passenger { get; set; }
    }
}
