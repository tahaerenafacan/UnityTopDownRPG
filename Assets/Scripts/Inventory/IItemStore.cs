namespace RPG.InventorySystem
{
    public interface IItemStore
    {
        int AddItems(InventoryItem item, int number);
    }
}