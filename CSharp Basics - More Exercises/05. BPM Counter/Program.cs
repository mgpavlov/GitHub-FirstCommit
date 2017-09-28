using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double bpm = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());

            var bars = numberOfBeats / 4;
            var time = 60 * numberOfBeats / bpm;

            if (time < 60)
            {
                Console.WriteLine($"{Math.Round(bars, 1)} bars - 0m {Math.Floor(time)}s");
            }
            else
            {
                var minutes = (int)time / 60;
                var seconds = time % 60;
                Console.WriteLine($"{Math.Round(bars, 1)} bars - {minutes}m {Math.Floor(seconds)}s");
            }
        }
    }
}
