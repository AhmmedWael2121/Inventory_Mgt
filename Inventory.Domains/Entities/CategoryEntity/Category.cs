using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domains.Entities.CategoryEntity
{
    public class Category : BaseEntity<Guid>
    {
        public string CategoryCode { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
    }
}
