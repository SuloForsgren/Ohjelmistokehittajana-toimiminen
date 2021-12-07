using System;

namespace Ehtolause_2
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

            if (luku1 < luku3 && luku2 < luku3)
            {
                Console.WriteLine("Suurin luku on " + luku3);
            }
            else if (luku1 < luku2 && luku3 < luku2)
            {
                Console.WriteLine("Suurin luku on " + luku2);
            }
            else
            {
                Console.WriteLine("Suurin luku on " + luku1);
z            }

        }
    }
}
