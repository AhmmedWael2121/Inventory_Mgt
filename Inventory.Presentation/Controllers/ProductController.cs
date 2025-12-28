using Inventory.Domains.Contracts;
using Inventory.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Presentation.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class ProductController(IUnitOfWork _uOW , IServiceManager _serviceManager)  : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(string? ProdCode)
        {
            var product = await _serviceManager.ProductService.GetByIdAsync(ProdCode);
            return Ok(product);
        }
    }
}
