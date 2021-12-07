using System;

namespace Ehtolause_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Haluatko antaa kokonaisluvun (k), doubleluvun (d) vai tekstin (t)? Kirjoita kirjain.");
            string x = Console.ReadLine();            

            switch(x)
            {
                case "k":
                    Console.WriteLine("Anna kokonaisluku");
                    int luku = int.Parse(Console.ReadLine());
                    Console.WriteLine(luku + 1);
                    break;
                case "d":
                    Console.WriteLine("Anna doubleluku");
                    double luku2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(luku2 + 1);
                    break;
                case "t":
                    Console.WriteLine("Anna teksti");
                    string teksti = Console.ReadLine();
                    Console.WriteLine(teksti + "*");
                    break;
                default:
                    Console.WriteLine("Et antanut kirjainta tai muu virhe!");
                    break;




            }




        }
    }
}
