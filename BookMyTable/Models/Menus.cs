using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookMyTable.Models
{
    public class Menus
    {
        public int id { get; set; }

        [Required]
        public string item_name { get; set; }

        [MaxLength(1000)]
        public string description { get; set; }

        [Required ,Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        [Required]
        public string image { get; set; }
    }
}
