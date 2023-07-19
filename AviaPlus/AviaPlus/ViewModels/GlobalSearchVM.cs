using AviaPlus.Models;
using System.Collections.Generic;

namespace AviaPlus.ViewModels
{
    public class GlobalSearchVM
    {
        public List<Flight> Flights { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Perfumery> Perfumeries { get; set; }
        public List<Cosmetic> Cosmetics { get; set; }
        public List<Spirit> Spirits { get; set; }
        public List<GourmetFood> GourmetFoods { get; set; }
        public List<Food> Foods { get; set; }
        public List<Beverage> Beverages { get; set; }
        public List<Jewelry> Jewelries { get; set; }
        public List<Clothes> Clothes { get; set; }

    }
}
