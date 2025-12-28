using AutoMapper;
using Inventory.Domains.Entities.InventoryEntity;
using Inventory.Shared.DTOs.TransactionsDTOs;
namespace Inventory.Persistence.Mapping
{
    public class TransactionMapping : Profile
    {
        public TransactionMapping()
        {
            CreateMap<InventoryTransaction, TransactionDto>().ReverseMap();
        }
    }
}
