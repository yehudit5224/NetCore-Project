using System.ComponentModel.DataAnnotations;

namespace Focus.Entities
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        [Required]
        public string CategoryType { get; set; }
    }
}
