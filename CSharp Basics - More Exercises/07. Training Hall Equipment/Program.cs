using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double totalPrice = 0.00;
            var moneyLeft = budged;
            for (int i = 1; i <= numberOfItems; i++)
            {
                string itemName = Console.ReadLine();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                double totalItemPrice = itemPrice * itemCount;
                totalPrice += totalItemPrice;
                if (budged >= totalItemPrice)
                {
                    if (itemCount > 1)
                    {
                        itemName = itemName + "s";
                    }
                    moneyLeft -= totalItemPrice;
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Subtotal: ${totalPrice:F2}");
                    Console.WriteLine($"Not enough. We need ${Math.Abs(moneyLeft):F2)} more.");
                    return;
                }
            }
            Console.WriteLine($"Subtotal: ${totalPrice:F2}");
            if (moneyLeft > 0)
            {
                Console.WriteLine($"Money left: ${moneyLeft:F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${Math.Abs(moneyLeft):F2} more.");
            }
        }
    }
}
