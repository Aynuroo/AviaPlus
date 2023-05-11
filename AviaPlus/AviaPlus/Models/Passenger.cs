using System.ComponentModel.DataAnnotations;

namespace AviaPlus.Models
{
    public class Passenger
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string SeatNumber { get; set; }
        [StringLength(10)]
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        public bool IsDeactive { get; set; }

        public Ticket Ticket { get; set; }
    }
}
