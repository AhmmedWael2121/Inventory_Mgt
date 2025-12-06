using Inventory.Domains.Entities.ProductEntity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Domains.Entities.InventoryEntity
{
    public class InventoryTransaction : BaseEntity
    {
        public string TransactionCode { get; set; } = null!;
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public TransactionType Type { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? Reference { get; set; }
    }
}
