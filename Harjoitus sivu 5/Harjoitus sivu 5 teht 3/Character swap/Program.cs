using System;
using System.Linq;
using System.Text;


namespace Character_swap
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2 = "";
            int i;
            Console.WriteLine("Anna jokin sana");
            str1 = Console.ReadLine();
            string last_char = str1[^1..];
            string result = str1.Remove(str1.Length-1);


            for (i = 1; i < result.Length; i++)
            {
                str2 = str2 + result[i];
            }

            str2 = str2 + result[0];

            string verylast = (last_char + str2);
            Console.WriteLine("Sekoitettuna sana on: " + verylast);


        }
    }
}

