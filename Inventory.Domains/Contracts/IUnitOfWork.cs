using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domains.Contracts
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        Task<int> SaveChangesAsync();
    }
}
