using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            var mp = width * hight / 1000000;
            Console.WriteLine($"{width}x{hight} => {Math.Round(mp, 1)}MP");
        }
    }
}
