namespace BookMyTable.Models
{
    public class Payments
    {
        public int id { get; set; }
        public string PayMethod { get; set; }
        public int amount { get; set; }
        public bool status { get; set; }
        public DateTime created_at { get; set; }
        public int user_id { get; set; }
    }
}
