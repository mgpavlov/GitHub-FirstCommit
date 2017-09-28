using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int m = 1; m <= 4; m++)
                {

                    for (int n = 1; n <= 4; n++)
                    {
                        counter++;
                        if (i + m + n >= sum)
                        {
                            Console.Write(("O" + i + m + n + "O" + " ").Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T'));
                        }
                        else
                        {
                            Console.Write(("X" + i + m + n + "X" + " ").Replace('1', 'A').Replace('2', 'C').Replace('3', 'G').Replace('4', 'T'));
                        }
                        if (counter % 4 == 0)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
