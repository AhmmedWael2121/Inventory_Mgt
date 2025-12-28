using Inventory.Domains.Exceptions.ProductExp;

namespace Inventory.Domains.Exceptions.NotFound
{
    public  class ProductNotFoundExp (string? Code) : NotFoundExp($"Product with Code {Code} not found.")
    {
    }
}
