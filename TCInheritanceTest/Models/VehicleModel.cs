using System;

namespace TCInheritanceTest
{
    public class VehicleModel : InventoryItemModel, IRentable, IPurchasable
    {
        public decimal DealerFee { get; set; }

        public void Purchase()
        {
            Quantity--; // Need to add checks
            Console.WriteLine("Item purchased");
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
