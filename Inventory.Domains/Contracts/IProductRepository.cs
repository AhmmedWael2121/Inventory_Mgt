using Inventory.Domains.Entities.ProductEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domains.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product?> GetByProductCodeAsync(string Code);
        Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(Guid categoryId);
    }
}
