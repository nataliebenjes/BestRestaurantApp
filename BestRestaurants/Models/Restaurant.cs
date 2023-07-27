using System.Collections.Generic;

namespace BestRestaurants.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public int CuisineId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageLink { get; set; }
        public Cuisine Cuisine { get; set; }
    }
}