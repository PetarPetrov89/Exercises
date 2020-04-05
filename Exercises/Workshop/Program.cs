using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            double table = double.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());
            double priceTable = 7.00;
            double priceKare = 9.00;


            double areaPokrivki = (table * (lenghtTable + 2 * 0.30) * (widthTable + 2 * 0.30));
            double areaKareta = (table * (lenghtTable / 2) * (lenghtTable / 2));

            double priceUSD = (areaPokrivki * priceTable) + (areaKareta * priceKare);
            double priceBGR = priceUSD * 1.85;

            Console.WriteLine($"{priceUSD:f2}" + " " + "USD");
            Console.WriteLine($"{priceBGR:f2}" + " " + "BGN");


        }
    }
}
