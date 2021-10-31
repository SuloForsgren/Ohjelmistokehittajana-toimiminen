using System;

namespace Yhteenlasku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita luku");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kirjoita luku");
            int luku2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ohjelma laskee kaksi antamaasi numeroa yhteen");
            Console.WriteLine("Yhteenlasku: " + (luku1 + luku2));
        }
    }
}
