using System;

namespace Harjoitus_sivu_5_teht_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Ohjelma tulostaa kaikki parittomat luvut valilta 1-99");

            for (i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
