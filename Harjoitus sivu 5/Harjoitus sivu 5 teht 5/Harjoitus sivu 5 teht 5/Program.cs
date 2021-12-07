using System;

namespace Harjoitus_sivu_5_teht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringList;
            int ni = 0, len, max = 0;


            Console.WriteLine("Anna lause!");
            string s = Console.ReadLine();
            Console.WriteLine("Lauseesi jonka annoit: " + s);

            stringList = s.Split(' ');
            len = stringList.Length;

            for (int i = 0; i < len; i++)
            {
                if (stringList[i].Length > max)
                {
                    max = stringList[i].Length;
                    ni = i;
                }
            }

            Console.WriteLine("Pisin kaikista sanoista: {0} \nKirjainten maara sanassa: {1}", stringList[ni], max);
            Console.ReadLine();

        }
    }
}
