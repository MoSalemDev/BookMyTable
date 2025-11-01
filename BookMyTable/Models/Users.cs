namespace BookMyTable.Models
{
    public class Users
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string Password { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string Description { get; set; }
        public DateTime created_at { get; set; }
        public int role_id { get; set; }
    }
}
