using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookMyTable.Models
{
    public class Payments
    {
        public int id { get; set; }

        [Required]
        public string PayMethod { get; set; }

        [Required, Column(TypeName = "decimal(10, 2)")]
        public int amount { get; set; }
        public bool status { get; set; }
        public DateTime created_at { get; set; }
        public int user_id { get; set; }
    }
}
