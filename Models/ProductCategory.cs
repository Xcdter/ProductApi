using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Название категории обязательно.")]
        [StringLength(50, ErrorMessage = "Название товара не должно превышать 50 символов.")]
        public required string Name { get; set; }

        [StringLength(500, ErrorMessage = "Название товара не должно превышать 500 символов.")]
        public string? Description { get; set; }
    }
}
