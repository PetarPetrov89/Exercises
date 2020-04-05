using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int broiDni = int.Parse(Console.ReadLine());

            var work = 365 - broiDni;
            var totalplaydays = work * 63 + broiDni * 127;
            var totalMins = 30000 - totalplaydays;
            var hours = Math.Abs(totalMins / 60);
            var mins = Math.Abs(totalMins % 60);

            if (30000 < totalplaydays)
            {

                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, mins);

            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, mins);
            }
        }
    }
}
