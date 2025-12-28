using Inventory.Domains.Contracts;
using Inventory.Domains.Entities;
using Inventory.Persistence.Data.Context;
using Microsoft.EntityFrameworkCore;
namespace Inventory.Persistence.Repos
{
    public class InventoryRepoGeneric<T>(InventoryDbContext _context): IRepository<T> where T : class
    {
        public virtual async Task AddAsync(T entity) => await _context.Set<T>().AddAsync(entity);
        public virtual async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().AsNoTracking().ToListAsync();
        public virtual async Task<T?> GetByIdAsync(string code) => await _context.Set<T>().FindAsync(code);
        public virtual void Remove(T entity) => _context.Set<T>().Remove(entity);
        public virtual void Update(T entity) => _context.Set<T>().Update(entity);
    }
}
