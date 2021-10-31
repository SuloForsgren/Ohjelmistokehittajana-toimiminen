using System;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjeet --> Kirjoita alle nimesi kun ohjelma sitä kysyy. Ohjelma tervehtii seuraavaksi syötetty nimea");
            Console.WriteLine ("Anna nimesi");
            String username = Console.ReadLine();
            Console.WriteLine("Terve " + username);
        }
    }
}
