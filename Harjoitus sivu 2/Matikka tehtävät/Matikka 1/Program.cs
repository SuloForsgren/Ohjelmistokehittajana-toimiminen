using System;

namespace Matikka_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna x:n arvo");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:n arvo");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (y + 3));

            Console.WriteLine("Anna o:n arvo");
            int o = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna z:n arvo");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (z - 3));

            Console.WriteLine("Anna a:n arvo");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna l:n arvo");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (l * 5));

            Console.WriteLine("Anna c:n arvo");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna b:n arvo");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (b * 5));

            Console.WriteLine("Anna d:n arvo");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna e:n arvo");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (d / e));

            Console.WriteLine("Anna f:n arvo");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna g:n arvo");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (f % g));

            Console.WriteLine("Anna h:n arvo");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna i:n arvo");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (h += i));

            Console.WriteLine("Anna j:n arvo");
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna k:n arvo");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (j -= k));

            Console.WriteLine("Anna m:n arvo");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna n:n arvo");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (m *= n * 5));

            Console.WriteLine("Anna p:n arvo");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna q:n arvo");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (p /= q));

        }
    }
}
