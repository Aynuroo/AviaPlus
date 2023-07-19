using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AviaPlus.Models
{
    public class Spirit
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Volume { get; set; }
        [Required]
        public string Packing { get; set; }
        [Required]
        public string DrinkType { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required]
        public bool IsCancelled { get; set; }
    }
}
