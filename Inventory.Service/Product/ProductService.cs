using Inventory.Service.Abstractions.Product;
using Inventory.Shared.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Service.Product
{
    public class ProductService : IProductService
    {
        public Task<ProductDto> CreateAsync(CreateProductDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetLowStockAsync(int threshold)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ProductDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
