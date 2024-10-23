using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Название товара обязательно.")]
        [StringLength(50, ErrorMessage = "Название товара не должно превышать 50 символов.")]
        public required string Name { get; set; }

        [StringLength(500, ErrorMessage = "Название товара не должно превышать 500 символов.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Цена товара обязательна.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Цена товара должна быть больше 0.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [ForeignKey("ProductCategory")]
        public int CategoryId { get; set; }

        public ProductCategory? Category { get; set; }
    }
}
