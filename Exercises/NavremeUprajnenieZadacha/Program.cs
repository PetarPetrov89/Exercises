using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavremeUprajnenieZadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int izpitChas = int.Parse(Console.ReadLine());
            int izpitMinuti = int.Parse(Console.ReadLine());
            int pristiganeChas = int.Parse(Console.ReadLine());
            int pristiganeMinuti = int.Parse(Console.ReadLine());

            int totalIzpitMinuti = izpitChas * 60 + izpitMinuti;
            int totalPristiganeMinuti = pristiganeChas * 60 + pristiganeMinuti;

            Console.WriteLine($"Изпитът започва в {izpitChas}:{izpitMinuti:00} часа.");
            Console.WriteLine($"Студента се явява за изпит в {pristiganeChas}:{pristiganeMinuti:00} часа.");

            int razlica = totalIzpitMinuti - totalPristiganeMinuti;
            int chasoveRazlika = 0;

            if (razlica == 0 || razlica > 0 && razlica <= 30)
            {
                Console.WriteLine("On time.");

                if (razlica != 0)
                {
                    Console.WriteLine($"{razlica} minutes before the start");
                }
            }
            else if (razlica > 30)
            {
                Console.WriteLine("Early");
                while (razlica > 59)
                {
                    chasoveRazlika++;
                    razlica -= 60;
                }
                if (chasoveRazlika > 0)
                {
                    Console.WriteLine($"{chasoveRazlika}:{razlica:00} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{razlica} minutes before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");

                razlica = Math.Abs(razlica);

                while (razlica > 59)
                {
                    chasoveRazlika++;
                    razlica -= 60;
                }

                if (chasoveRazlika > 0)
                {
                    Console.WriteLine($"{chasoveRazlika}:{razlica:00} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{razlica} minutes after the start");
                }


            }


        }
    }
}

