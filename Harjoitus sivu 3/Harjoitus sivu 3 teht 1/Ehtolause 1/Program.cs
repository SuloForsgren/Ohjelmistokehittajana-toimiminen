using System;

namespace Ehtolause_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoittaisitko luvun?");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Antaisitko toisenkin luvun?");
            int luku2 = int.Parse(Console.ReadLine());

            if (luku1 < luku2)
            {
                Console.WriteLine(luku1 + " on pienempi kuin " + luku2);
            }
            else {
                Console.WriteLine(luku2 + " on pienempi kuin " + luku1);
            }
            



        }
    }
}
