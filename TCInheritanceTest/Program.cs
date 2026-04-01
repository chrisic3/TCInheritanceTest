using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCInheritanceTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> rentables = new List<IRentable>();
            List<IPurchasable> purchasables = new List<IPurchasable>();

            VehicleModel vehicle = new VehicleModel { ProductName = "Kia Optima", DealerFee = 25, Quantity = 1 };
            BookModel book = new BookModel { ProductName = "A Tale of Two Cities", PageCount = 350, Quantity = 5 };
            ExcavatorModel excavator = new ExcavatorModel { ProductName = "Bulldozer", Quantity = 2 };

            rentables.Add(vehicle);
            rentables.Add(excavator);

            purchasables.Add(book);
            purchasables.Add(vehicle);

            // Need to refactor this UI
            Console.Write("Do you want to rent or purchase? (rent/purchase): ");
            string input = Console.ReadLine();

            if (input.ToLower() == "rent")
            {
                foreach (IRentable r in rentables)
                {
                    Console.WriteLine($"Item: {r.ProductName}");
                    Console.Write("Do you want to rent this item? (yes/no): ");
                    string wantToRent = Console.ReadLine();

                    if (wantToRent.ToLower() == "yes")
                    {
                        r.Rent();
                    }

                    Console.Write("Do you want to return this item? (yes/no): ");
                    string wantToReturn = Console.ReadLine();

                    if (wantToReturn.ToLower() == "yes")
                    {
                        r.ReturnRental();
                    }
                }
            }
            else
            {
                foreach (IPurchasable p in purchasables)
                {
                    Console.WriteLine($"Item: {p.ProductName}");
                    Console.Write("Do you want to purchase this item? (yes/no): ");
                    string wantToPurchase = Console.ReadLine();

                    if (wantToPurchase.ToLower() == "yes")
                    {
                        p.Purchase();
                    }
                }
            }

                Console.ReadLine();
        }
    }
}
