using Inventory.Domains.Exceptions.ProductExp;
namespace Inventory.Domains.Exceptions.NotFound
{
    public class InventoryNotFoundExp(string Code) : NotFoundExp($"Inventory with Code {Code} not found.")
    {
    }
}
