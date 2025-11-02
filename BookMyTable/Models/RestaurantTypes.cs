using System.ComponentModel.DataAnnotations;

namespace BookMyTable.Models
{
    public class RestaurantTypes
    {
        public int id { get; set; }

        [Required]
        public string Type_name { get; set; }
        public string Description { get; set; }
    }
}
