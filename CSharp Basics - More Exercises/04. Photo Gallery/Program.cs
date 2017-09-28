using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            double photosNumber = double.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photosSizeBytes = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            string photosType = "";
            var mb = 0.00;
            string typeRam = "";

            if (photosSizeBytes < 1000)
            {
                mb = photosSizeBytes;
                typeRam = "B";
            }
            else if (photosSizeBytes < 1000000)
            {
                mb = photosSizeBytes / 1000;
                typeRam = "KB";
            }
            else
            {
                mb = photosSizeBytes / 1000000;
                typeRam = "MB";
            }

            if (width > hight)
            {
                photosType = "landscape";
            }
            else if (width < hight)
            {
                photosType = "portrait";
            }
            else
            {
                photosType = "square";
            }

            Console.WriteLine($"Name: DSC_{photosNumber:0000}.jpg\nDate Taken: {day:00}/{month:00}/{year} {hours:00}:{minutes:00}\nSize: {mb}{typeRam}\nResolution: {width}x{hight} ({photosType})");
        }
    }
}
