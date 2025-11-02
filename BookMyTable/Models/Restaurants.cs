using System.ComponentModel.DataAnnotations;

namespace BookMyTable.Models
{
    public class Restaurants
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public string location { get; set; }
        public string image { get; set; }
        public int capacity { get; set; }
        public TimeOnly opening_hours { get; set; }
        public TimeOnly closing_hours { get; set; }
        public DateTime created_at { get; set; }
        public int restaurant_type_id { get; set; }
        public int menu_id { get; set; }
        public int user_id { get; set; }
    }
}
