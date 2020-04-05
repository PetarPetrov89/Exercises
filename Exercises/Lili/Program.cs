using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int godini = int.Parse(Console.ReadLine());
            double pricePeralnq = long.Parse(Console.ReadLine());
            int priceToys = int.Parse(Console.ReadLine());

            int numberOfToys = 0;
            double money = 0;
            double totalMoney = 0;
            int brotherTakes = 0;

            for (int i = 1; i <= godini; i++)
            {
                if (godini % 2 != 0)
                {
                    numberOfToys++;
                }
                else if (godini % 2 == 0)
                {
                    money += 10;
                    totalMoney = totalMoney + money;
                    brotherTakes++;
                }

            }

            int moneyFromToys = numberOfToys * priceToys;
            double moneyCollected = (moneyFromToys + totalMoney) - brotherTakes;
            double ostatyk = moneyCollected - pricePeralnq;
            double nedostik = pricePeralnq - moneyCollected;

            if (moneyCollected > pricePeralnq)
            {
                Console.WriteLine("Yes! {0:f2}", ostatyk);
            }
            else if (moneyCollected < pricePeralnq)
            {
                Console.WriteLine("No! {0:f2}", nedostik);
            }

        }
    }
}
