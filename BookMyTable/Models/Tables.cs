namespace BookMyTable.Models
{
    public class Tables
    {
        public int id { get; set; }
        public int table_number { get; set; }
        public int capacity { get; set; }
        public bool avability { get; set; }
        public int restaurant_id { get; set; }
        public int user_id { get; set; }
    }
}
