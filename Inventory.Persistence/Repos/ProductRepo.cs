using Inventory.Domains.Contracts;
using Inventory.Domains.Entities.ProductEntity;
using Inventory.Persistence.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace Inventory.Persistence.Repos
{
    public class ProductRepo(InventoryDbContext Context) : InventoryRepoGeneric<Product>(Context), IProductRepository
    {
        private readonly DbContext _context = Context;

        public async Task<Product?> GetByProductCodeAsync(string Code)
        {
            return await _context.Set<Product>().AsNoTracking().FirstOrDefaultAsync(p => p.ProductCode == Code);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryIdAsync(string? catCode)
        {
            return await _context.Set<Product>().Where(p => p.Category.CategoryCode == catCode).ToListAsync();

        }
    }
}