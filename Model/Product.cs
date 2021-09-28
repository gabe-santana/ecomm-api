using System.ComponentModel.DataAnnotations;

namespace ecomm.api.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        [MinLength(7)]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public decimal Price { get; set; }

        [MaxLength(500)]
        [MinLength(20)]
        public string Description { get; set; }

        public int CategoryId { get; set; }
        
        [Required]
        public Category Category { get; set; }
    }
}