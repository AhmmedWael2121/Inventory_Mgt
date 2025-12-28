using Inventory.Shared.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Service.Abstractions.Product
{
    public interface IProductService
    {
        Task<ProductDto> CreateAsync(CreateProductDto dto);
        Task<ProductDto?> GetByIdAsync(string?  ProductCode);
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<IEnumerable<ProductDto>> GetProductsByCategoryIdAsync(string? catCode);
        Task UpdateAsync(ProductDto dto);
        Task DeleteAsync(string Code);
    }
}
