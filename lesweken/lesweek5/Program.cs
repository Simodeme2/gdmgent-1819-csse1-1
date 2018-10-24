using System;

namespace lesweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string tekst = " Dit is een testje!       ";
            int lengte = tekst.Length;

            for (int i = 0; i < lengte; i++)
            {
                // Methode 1 met behulp van de index van een karakter in de tekenreeks (string).
                //Console.WriteLine(tekst[i]);
                // Methode 2 met behulp van de functie Substring.
                Console.WriteLine(tekst.Substring(i,1));
                
            }

            string[] woorden = tekst.Split(' ');
            string zinZonderSpaties = "";
            foreach (var woord in woorden)
            {
                zinZonderSpaties = string.Concat(zinZonderSpaties, woord);
                Console.WriteLine(woord);
            }
            Console.WriteLine("De volledige zin zonder spaties: {0}", zinZonderSpaties);

            Console.WriteLine(tekst.ToLower());
            Console.WriteLine(tekst.ToUpper());
            char[] spatie = { ' ' };
            Console.WriteLine(tekst.Trim(spatie));

            string wachtwoord = "test";
            bool test1 = wachtwoord.Contains('b');
            Console.WriteLine(test1);
            bool test2 = wachtwoord.Contains('b');
            Console.WriteLine(test2);
            bool test3 = wachtwoord.Contains('t');
            Console.WriteLine(test3);

            if(wachtwoord == "test")
            {
                Console.WriteLine("Het wachtwoord is gelijk aan test");
            }
            
            //string.Equals(wachtwoord, "test") ? Console.WriteLine("Het wachtwoord is gelijk aan test") : Console.WriteLine("Het wachtwoord is niet gelijk aan test");

            Random randomGetal = new Random();
            int getal1 = randomGetal.Next(0, 20);
            Console.WriteLine(getal1);
            int getal2 = randomGetal.Next(0, 20);
            Console.WriteLine(getal2);
            int getal3 = randomGetal.Next(0, 20);
            Console.WriteLine(getal3);                    
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(randomGetal.Next(0, 20));
            }

            char[] chars = new char[8];
            chars[0] = ' ';
            chars[1] = 'G';
            // Char aanroepen met behulp van integer waarde.
            chars[2] = (char)78; 
            // Char aanroepen door middel van de unicode van het karakter.
            chars[3] = '\u002E';
            chars[4] = 'f';
            chars[5] = 'a';
            chars[6] = 'i';
            chars[7] = (char)85;

            foreach (char c in chars)
            {
                Console.Write(c);
            }

            char[] campus = {'M','A','R'};

            string[] menu1 = new string[3];
            menu1[0] = "broodje martino";
            menu1[1] = "broodje ham";
            menu1[2] = "broodje kaas";

            foreach (var item in menu1)
            {
                Console.WriteLine(item);
            }

            string[] menu2 = new string[] {"broodje scampi", "broodje brie", "broodje boulet"};
            foreach (var item in menu2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("For Loop:");

            for (int i = 0; i < menu2.Length; i++)
            {
                Console.WriteLine(menu2[i]);
            }

            string[,] menu3 = new string[,] {{"broodje scampi", "4"}, {"broodje brie", "3"}, {"broodje boulet", "5"}};
            foreach (var item in menu3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
