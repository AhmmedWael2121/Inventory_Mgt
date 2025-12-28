namespace Inventory.Domains.Exceptions.UnAuthorized
{
    public class NotAuthorized(string message) : Exception(message)
    {
    }
}
