using System;

namespace Kirjasto_tehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            alku:

            Console.WriteLine("Minkä kirjan haluat lainata/palauttaa?");

            Console.WriteLine("Kirjoita (h) jos haluat Harry potterin, (t) jos taru sormusten herrasta taikka (m) jolloin saat muumien taikatalven");
            string kirjain = Console.ReadLine();

            Kirjantiedot kirja1 = new Kirjantiedot("Harry Potter", "J.K Rowling", 335, 5, 1998);
            Kirjantiedot kirja2 = new Kirjantiedot("Taru sormusten herrasta", "Tolkien", 359, 4, 1966);
            Kirjantiedot kirja3 = new Kirjantiedot("Taikatalvi", "Tove Jansson", 168, 3, 1957);

            if (kirjain == "h")
            {
                Console.WriteLine(kirja1.Naytakirjannimi()); 
                Console.WriteLine(kirja1.Naytakirjailija()); 
                Console.WriteLine(kirja1.Naytasivut()); 
                Console.WriteLine(kirja1.Naytarvostelu()); 
                Console.WriteLine(kirja1.Naytajulkaisuvuosi());
            }
            else if (kirjain == "t")
            {
                Console.WriteLine(kirja2.Naytakirjannimi());
                Console.WriteLine(kirja2.Naytakirjailija());
                Console.WriteLine(kirja2.Naytasivut());
                Console.WriteLine(kirja2.Naytarvostelu());
                Console.WriteLine(kirja2.Naytajulkaisuvuosi());
            }
            else if (kirjain == "m")
            {
                Console.WriteLine(kirja3.Naytakirjannimi());
                Console.WriteLine(kirja3.Naytakirjailija());
                Console.WriteLine(kirja3.Naytasivut());
                Console.WriteLine(kirja3.Naytarvostelu());
                Console.WriteLine(kirja3.Naytajulkaisuvuosi());
            }
            else
            {
                Console.WriteLine("Olet syöttänyt väärän kirjaimen palataan alkuun");
                goto alku;
            }

            lainaus:

            Console.WriteLine("Halutako lainata vai palauttaa kirjan? kirjoita (l) tai (p) ilman sulkuja");
            string lp = Console.ReadLine();

            if (lp == "l")
            {
                Console.WriteLine("Olet lainannut kirjan onnistuneesti!");
            }
            else if (lp == "p")
            {
                Console.WriteLine("Olet palauttanut kirjan onnistuneesti!");
            }
            else
            {
                Console.WriteLine("On tapahtunut virhe palataan takaisin alkuun.");
                goto lainaus;
            }
            
            cp3:
            Console.WriteLine("Haluatko suorittaa ohjelman uudestaan?");
            Console.WriteLine("Kirjoita k jos haluat ja e jos et");
            string uudestaan = Console.ReadLine();

            if (uudestaan == "k" || uudestaan == "K")
            {
                goto alku;
            }
            else if (uudestaan == "e" || uudestaan == "E")
            {
                Console.WriteLine("Kiitos käynnistäsi kirjastossa!");
            }
            else
            {
                Console.WriteLine("En aivan saa selvää kirjoititko kyllä vai ei. Kokeile uudelleen");
                goto cp3;
            }
        }
    }
}
