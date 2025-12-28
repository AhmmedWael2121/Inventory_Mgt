using Inventory.Domains.Exceptions.ProductExp;
namespace Inventory.Domains.Exceptions.NotFound
{
    public class CategoryNotFoundExp(string Code) : NotFoundExp($"Category with Code {Code} not found.")
    {
    }
}
