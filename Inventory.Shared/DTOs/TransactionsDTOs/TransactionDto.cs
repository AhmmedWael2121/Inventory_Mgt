using Inventory.Domains.Entities.InventoryEntity;
namespace Inventory.Shared.DTOs.TransactionsDTOs
{
    public record TransactionDto(Guid Id, Guid ProductId,string TransCode, int Quantity, TransactionType Type, DateTime CreatedAt, string? Reference);

}
