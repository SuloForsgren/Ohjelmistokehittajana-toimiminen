using System;

namespace Ehtolause_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoittaisitko luvun?");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Antaisitko toisenkin luvun?");
            int luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjoittaisitko kolmannenkin luvun?");
            int luku3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjoittaisitko luvun?");
            int luku4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Antaisitko viidennen luvun?");
            int luku5 = int.Parse(Console.ReadLine());

            if (luku2 < luku1 && luku3 < luku1 && luku4 < luku1 && luku5 < luku1) 
            {
                Console.WriteLine("Suurin oli " + luku1);
            }

            else if (luku1 < luku2 && luku3 < luku2 && luku4 < luku2 && luku5 < luku2)
            {
                Console.WriteLine("Suurin oli " + luku2);
            }

            else if (luku1 < luku3 && luku2 < luku3 && luku4 < luku3 && luku5 < luku3)
            {
                Console.WriteLine("Suurin oli " + luku3);
            }

            else if (luku1 < luku4 && luku2 < luku4 && luku3 < luku4 && luku5 < luku4)
            {
                Console.WriteLine("Suurin oli " + luku4);
            }

            else
            {
                Console.WriteLine("Suurin oli " + luku5);
            }




        }
    }
}
