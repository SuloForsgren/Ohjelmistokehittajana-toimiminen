using System;

namespace Ikä_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerro ikasi");
            int ika = int.Parse(Console.ReadLine());

        if (ika <= 17)
            {
                Console.WriteLine("Olet alaikainen!");
            }
            else if (ika >= 17 && ika <= 30)
            {
                Console.WriteLine("Olet nuori aikuinen!");
            }
            else if (ika >= 30 && ika <= 50)
            {
                Console.WriteLine("Olet vanheneva aikuinen");
            }
            else if (ika >= 50 && ika <= 80)
            {
                Console.WriteLine("Olet vanhus");
            }
            else if (ika >= 80 && ika <= 150)
            {
                Console.WriteLine("Olet kuolemaisillasi :( ");
            }
            else
            {
                Console.WriteLine("Olet kuollut :O");
            }
        }
    }
}
