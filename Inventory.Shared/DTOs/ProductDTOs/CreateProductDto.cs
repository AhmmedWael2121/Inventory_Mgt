using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Shared.DTOs.ProductDTOs
{
    public class CreateProductDto
    {
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public Guid? CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
