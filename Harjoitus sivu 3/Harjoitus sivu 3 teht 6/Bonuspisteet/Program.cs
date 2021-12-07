using System;

namespace Bonuspisteet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Anna luku 0-9: ");
            int luku = int.Parse(Console.ReadLine());
            Console.WriteLine("Lukusi on " + luku);
            
            switch(luku)
            {
                case 0:
                    Console.WriteLine("Virhe: Et saanut yhtäkään pistettä!");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine(luku * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine(luku * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine(luku * 1000);
                    break;
                default:
                    Console.WriteLine("Lukusi on liian suuri!");
                    break;


            }

        }
    }
}
