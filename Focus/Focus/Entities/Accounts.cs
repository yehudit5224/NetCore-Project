using System.ComponentModel.DataAnnotations;

namespace Focus.Entities
{
    public class Accounts
    {
        [Key]
        public int AccountId { get; set; }
        [Required]
        public string AccountName { get; set; }
        [Required]
        public double StartingBallansed { get; set; }
    }
}
