using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n / 2; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int k = 1; k <= n - 2 - 2 * (i - 1); k++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                Console.WriteLine();
            }
            //middle row
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(" ");
            }
            Console.Write("x");
            Console.WriteLine();
            //bottom
            for (int i = 1; i <= n / 2; i++)
            {
                for (int j = n / 2 - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                for (int k = 1; k < 2 * i; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("x");
                Console.WriteLine();
            }
        }
    }
}
