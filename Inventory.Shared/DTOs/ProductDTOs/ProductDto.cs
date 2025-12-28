using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Shared.DTOs.ProductDTOs
{
    public record ProductDto(string Code, string Name, string? Description, int Quantity, decimal UnitPrice, string? CategoryCode);

}
