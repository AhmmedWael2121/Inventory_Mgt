using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Domains.Exceptions.BadRequest
{
    public class InventoryBadRequestExp (string message) : BadRequestExp(message)
    {
    }
}
