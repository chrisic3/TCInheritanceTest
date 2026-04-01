using System;

namespace TCInheritanceTest
{
    public class BookModel : InventoryItemModel, IPurchasable
    {
        public int PageCount { get; set; }

        public void Purchase()
        {
            Quantity--; // Need to add checks
            Console.WriteLine("Item purchased");
        }
    }
}
