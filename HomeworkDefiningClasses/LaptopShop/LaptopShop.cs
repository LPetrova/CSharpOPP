using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Laptop laptopFull = new Laptop("Lenovo Yoga 2 Pro", 2259.00m, new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5))
            {
                Manufacturer = "Lenovo",
                Processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache",
                Ram = 8,
                GraphicsCard = "Intel HD Graphics 4400",
                Hdd = 128,
                Screen = @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display"
            };

            Console.WriteLine(laptopFull);
           
        }
    }
}
