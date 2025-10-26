using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Focus.Entities
{
    public class Transactions
    {
        [Key]
        public int TransId { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public double amount { get; set; }
        public string Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public Boolean IsIncome {  get; set; }
    }
}
