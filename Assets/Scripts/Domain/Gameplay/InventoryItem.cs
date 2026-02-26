namespace Game.Domain.Gameplay
{
    public class InventoryItem
    {
        public string ItemId { get; }
        public int Quantity { get; private set; }

        public InventoryItem(string itemId, int quantity)
        {
            ItemId = itemId;
            Quantity = quantity;
        }

        public void Add(int amount)
        {
            Quantity += amount;
        }
    }
}
