using System;

namespace Ehtolause_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valitse ja kirjoita yksi seuraavista: Kokonaisluku(k), double(d) tai jokin teksti(s)");
            char syote = char.Parse(Console.ReadLine().ToLower());

            switch(syote)
            {
                case 'k':
                    Console.WriteLine("Syötä kokonaisluku johon lisätään 1 (yksi)");
                    int luku = int.Parse(Console.ReadLine());
                    Console.WriteLine(luku + 1);
                    break;
                case 'd':
                    Console.WriteLine("Syötä doubleluku johon lisätään 1 (yksi)");
                    double tupla = double.Parse(Console.ReadLine());
                    Console.WriteLine(tupla + 1);
                    break;
                case 's':
                    Console.WriteLine("Syötä teksti johon tulee tähti perään");
                    string teksti = Console.ReadLine();
                    Console.WriteLine(teksti + "*");
                    break;
            }











        }
    }
}
