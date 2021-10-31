using System;

namespace Harjoitus_sivu_5_teht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna kokonaisluku");
            int luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kokonaisluku");
            int luku2 = int.Parse(Console.ReadLine());

            if (0 < luku1 && 0 < luku2)
            {
                Console.WriteLine("Molemmat luvut ovat positiivisia");
            }
            else if(luku1 < 0 && luku2 < 0) 
            {
                Console.WriteLine("Molemmat luvut ovat negatiivisia");
            }
            else
            {
                Console.WriteLine("Toinen luku on positiivinen ja toinen negatiivinen");
            }



        }
    }
}
