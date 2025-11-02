namespace BookMyTable.Models
{
    public class Reservations
    {
        public int id { get; set; }


        public int TotalPrice { get; set; }
        public bool payment_status { get; set; }
        public DateTime reservation_time { get; set; }
        public int user_id { get; set; }
        public int restaurant_id { get; set; }
        public int table_id { get; set; }
        public int payment_id { get; set; }
    }
}
