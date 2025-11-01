namespace BookMyTable.Models
{
    public class Reviews
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int restaurant_id { get; set; }
        public string rate { get; set; }
        public DateTime created_at { get; set; }
    }
}
