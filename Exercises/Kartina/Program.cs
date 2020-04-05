using System;

namespace Kartina
{
    class Program
    {
        static void Main(string[] args)
        {
            int shirinaNaDupkata = int.Parse(Console.ReadLine());
            int dyljnaNaDupkata = int.Parse(Console.ReadLine());
            int stranaNaKArtinite = int.Parse(Console.ReadLine());
            int broiKartini = int.Parse(Console.ReadLine());
            int ploshtDupka = shirinaNaDupkata * dyljnaNaDupkata;
            int ploshtKartini = (stranaNaKArtinite * stranaNaKArtinite) * broiKartini;
            int razlika = ploshtKartini - ploshtDupka;
            int difference = ploshtDupka - ploshtKartini;

            if (ploshtDupka > ploshtKartini)
            {
                Console.WriteLine($"The pictures fit in the hole. Hole area is {difference} bigger than pictures area.");


            }
            else

                Console.WriteLine($"The pictures don't fit in the hole. Picture area is {razlika} bigger than hole area.");
        }

    }
}
