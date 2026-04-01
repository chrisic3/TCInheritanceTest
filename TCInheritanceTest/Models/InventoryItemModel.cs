namespace TCInheritanceTest
{
    public class InventoryItemModel : IInventoryItem
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
}
