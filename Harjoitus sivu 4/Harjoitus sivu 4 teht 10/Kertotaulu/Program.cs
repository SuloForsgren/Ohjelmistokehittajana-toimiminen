using System;

namespace Kertotaulu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna jokin luku");
            int luku = int.Parse(Console.ReadLine());

            Console.Write("\n");
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", luku, j, luku * j);
            }




        }
    }
}
