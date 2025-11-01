namespace BookMyTable.Models
{
    public class Restaurants
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public string location { get; set; }
        public string image { get; set; }
        public int capacity { get; set; }
        public string opening_hours { get; set; }
        public string closing_hours { get; set; }
        public DateTime created_at { get; set; }
        public int restaurant_type_id { get; set; }
        public int menu_id { get; set; }
        public int user_id { get; set; }
    }
}
