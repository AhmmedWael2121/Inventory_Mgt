using Inventory.Domains.Entities.CategoryEntity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Inventory.Domains.Entities.ProductEntity
{
    public class Product : BaseEntity<Guid>
    {
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string Name { get; set; } 
        public string? Description { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public string? CategoryCode { get; set; }
        public Category? Category { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
