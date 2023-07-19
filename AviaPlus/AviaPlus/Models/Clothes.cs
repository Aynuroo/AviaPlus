using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AviaPlus.Models
{
    public class Clothes
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string MainFabric { get; set; }
        [Required]
        public string Size { get; set;}
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool IsFemale { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        [NotMapped]
        public IFormFile Photo { get; set; }
        [Required]
        public bool IsCancelled { get; set; }
    }
}
