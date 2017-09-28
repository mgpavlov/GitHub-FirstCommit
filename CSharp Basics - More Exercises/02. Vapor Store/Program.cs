using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double budged = double.Parse(Console.ReadLine());
            var money = budged;
            var price = 0.00;
            var totalPrice = 0.00;


            while (money > 0)
            {
                string name = Console.ReadLine();
                switch (name)
                {
                    case "OutFall 4":
                        price = 39.99;
                        if (price > money)
                        {
                            Console.WriteLine($"Too Expensive");
                        }
                        else
                        {
                            totalPrice += price;
                            money -= price;
                            Console.WriteLine($"Bought {name}");
                            if (money == 0)
                            {
                                Console.WriteLine($"Out of money!");
                                return;
                            }
                        }

                        break;
                    case "CS: OG":
                        price = 15.99;
                        if (price > money)
                        {
                            Console.WriteLine($"Too Expensive");
                        }
                        else
                        {
                            totalPrice += price;
                            money -= price;
                            Console.WriteLine($"Bought {name}");
                            if (money == 0)
                            {
                                Console.WriteLine($"Out of money!");
                                return;
                            }
                        }
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        if (price > money)
                        {
                            Console.WriteLine($"Too Expensive");
                        }
                        else
                        {
                            totalPrice += price;
                            money -= price;
                            Console.WriteLine($"Bought {name}");
                            if (money == 0)
                            {
                                Console.WriteLine($"Out of money!");
                                return;
                            }
                        }
                        break;
                    case "Honored 2":
                        price = 59.99;
                        if (price > money)
                        {
                            Console.WriteLine($"Too Expensive");
                        }
                        else
                        {
                            totalPrice += price;
                            money -= price;
                            Console.WriteLine($"Bought {name}");
                            if (money == 0)
                            {
                                Console.WriteLine($"Out of money!");
                                return;
                            }
                        }
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        if (price > money)
                        {
                            Console.WriteLine($"Too Expensive");
                        }
                        else
                        {
                            totalPrice += price;
                            money -= price;
                            Console.WriteLine($"Bought {name}");
                            if (money == 0)
                            {
                                Console.WriteLine($"Out of money!");
                                return;
                            }
                        }
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        if (price > money)
                        {
                            Console.WriteLine($"Too Expensive");
                        }
                        else
                        {
                            totalPrice += price;
                            money -= price;
                            Console.WriteLine($"Bought {name}");
                            if (money == 0)
                            {
                                Console.WriteLine($"Out of money!");
                                return;
                            }
                        }
                        break;
                    case "Game Time":
                        Console.WriteLine($"Total spent: ${totalPrice:F2}. Remaining: ${money:F2}");
                        return;
                    default:
                        Console.WriteLine($"Not Found");
                        break;
                }
            }
        }
    }
}
