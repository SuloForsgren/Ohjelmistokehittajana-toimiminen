using System;

namespace Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna jokin celsius lukema");
            int celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheitteina antamasi lukema on " + (celsius * 1.8 + 32) + " Fahrenheittia");
        }
    }
}
