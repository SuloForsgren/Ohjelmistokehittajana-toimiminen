using System;

namespace Harjoitus_sivu_5_teht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna suurempi numero kuin 10: ");
            int luku = int.Parse(Console.ReadLine());

            for (int y = 0; y < luku; y++)
            {
                Console.Write(luku + " ");
            }
            Console.WriteLine();
            for (int y = 0; y < luku; y++)
            {
                Console.Write(luku);
            }
            Console.WriteLine();
        }
    }
}

