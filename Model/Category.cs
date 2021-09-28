using System.ComponentModel.DataAnnotations;

namespace ecomm.api.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(7)]
        [MinLength(20)]
        public string Name { get; set; }
    }
}