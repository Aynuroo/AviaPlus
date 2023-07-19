using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AviaPlus.Models
{
    public class Ticket
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
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool IsDeactive { get; set; }
    }
}
