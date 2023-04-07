using System;

namespace AviaPlus.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string FlightNumber { get; set; }
        public string PassengerName { get; set; }
        public string PassengerEmail { get; set; }
        public string SeatNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime  { get; set; }
        public decimal Price { get; set; }
        public bool IsCancelled { get; set; }
    }
}
