using System;

namespace TCInheritanceTest
{
    public class ExcavatorModel : InventoryItemModel, IRentable
    {
        public void Dig()
        {
            Console.WriteLine("Digging...");
        }

        public void Rent()
        {
            Quantity--; // Need to add checks
            Console.WriteLine("Item rented");
        }

        public void ReturnRental()
        {
            Quantity++; // Need to add checks
            Console.WriteLine("Item returned");
        }
    }
}
