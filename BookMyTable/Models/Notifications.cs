using System.ComponentModel.DataAnnotations;

namespace BookMyTable.Models
{
    public class Notifications
    {
        public int id { get; set; }

        [Required]
        public string Message_Title { get; set; }

        [Required]
        public string Message_Body { get; set; }
        public string Message_Type { get; set; }
        public bool Message_IsRead { get; set; }
        public int user_id { get; set; }
        public DateTime created_at { get; set; }
    }
}
