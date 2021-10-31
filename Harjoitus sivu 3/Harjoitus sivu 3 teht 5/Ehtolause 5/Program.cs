using System;

namespace Ehtolause_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valitse ja kirjoita yksi seuraavista: Kokonaisluku, desimaali luku tai jokin teksti");
            int kokoluku = int.Parse(Console.ReadLine());
            double desimaali = double.Parse(Console.ReadLine());
            string teksti = Console.ReadLine();

            switch(kokoluku, desimaali, teksti)
            {
                case :
                    Console.WriteLine(kokoluku);
                    break;
            }











        }
    }
}
