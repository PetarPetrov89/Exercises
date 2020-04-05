using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksaTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете броя километри: ");
            int km = int.Parse(Console.ReadLine());
            Console.Write("Период на пътуване:");
            string daytime = Console.ReadLine().ToString();


            double taxiStart = 0.70;
            double taxiDay = 0.79;
            double taxiNight = 0.99;
            double Bus = 0.09;
            double Train = 0.06;

            if (km < 20 && daytime == "day")
            {
                Console.WriteLine((km * taxiDay) + taxiStart);
            }
            else if (km < 20 && daytime == "night")
            {
                Console.WriteLine((km * taxiNight) + taxiStart);
            }
            else if (km < 100 && km >= 20)
            {
                double busResult = km * Bus;
                Console.WriteLine(busResult);
            }
            else if (km > 100)
            {
                double trainResult = km * Train;
                trainResult = Math.Round(trainResult, 2);
                Console.WriteLine(trainResult);
            }

        }
    }
}
