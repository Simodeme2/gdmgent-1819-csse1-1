using System;

namespace lesweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 100;
            int b = 7;
            int c = a + b;
            int d = 3;
            int e = d * c;
            int f = 5;
            int g = 406;
            int h = 7367;
            int i = 69;
            int j = g + h;
            int k = j / i;
            int l = k * f;
            int m = 73;
            int n = 41;
            int o = 39;
            int p = m * n;
            int q = p - o;
            int r = 7;
            int s = 8;
            int t = 19;
            int u = r * s;
            int v = u - t;
            int w = e + l + q + v;
            Console.WriteLine("Het resultaat is: " + w);

            int resultaat1 = som(100, 7);
            int resultaat2 = product(3, resultaat1);
            int resultaat3 = som(406, 7367);
            int resultaat4 = quotient(resultaat3, 69);
            int resultaat5 = product(resultaat4, 5);
            int resultaat6 = product(73, 41);
            int resultaat7 = verschil(resultaat6, 39);
            int resultaat8 = product(7, 8);
            int resultaat9 = verschil(resultaat8, 19);
            int totaal = resultaat2 + resultaat5 + resultaat7 + resultaat9;
            Console.WriteLine("Het resultaat is: " + totaal);

            int resultaatb1 = som(100, 7);
            int resultaatb2 = product(3, som(100, 7));
            int resultaatb3 = som(406, 7367);
            int resultaatb4 = quotient(som(406, 7367), 69);
            int resultaatb5 = product(quotient(som(406, 7367), 69), 5);
            int resultaatb6 = product(73, 41);
            int resultaatb7 = verschil(product(73, 41), 39);
            int resultaatb8 = product(7, 8);
            int resultaatb9 = verschil(product(7, 8), 19);

            int totaal2 = 
            product(3, som(100, 7)) + 
            product(quotient(som(406, 7367), 69), 5) 
            + verschil(product(73, 41), 39) + 
            verschil(product(7, 8), 19);
            Console.WriteLine("Het resultaat is: " + totaal2);

            int totaal3 = som(som(som(product(3, som(100, 7)), product(quotient(som(406, 7367), 69), 5)), verschil(product(73, 41), 39)), verschil(product(7, 8), 19));
            Console.WriteLine("Het resultaat is: " + totaal3);

            totaal3 = 10000;
            if(totaal3 == 3872)
            {
                Console.WriteLine("Het resultaat is perfect!");
            }
            else if(totaal3 > 3872)
            {
                Console.WriteLine("Het resultaat is te groot!");
            }
            else
            {
                Console.WriteLine("Het resultaat is niet correct!");
            }


            for (int teller = 0; teller < 11; teller++)
            {
                Console.WriteLine("De teller is nu: " + teller);
            }

            tafel(1);
            tafel(2);
            tafel(3);

            int getal3 = 4;
            do
            {
                Console.WriteLine("De waarde van het getal is: " + getal3);
                getal3++;
            } while (getal3 < 5);

            int getal4 = 4;
            while(getal4 < 5)
            {
                Console.WriteLine("De waarde van het getal is: " + getal4);
                getal4++;
            }
        }

        void tafel(int getal)
        {
            Console.WriteLine("De tafel van: " + getal);
            for (int teller = 0; teller < 11; teller++)
            {
                int resultaat = teller * getal;
                Console.WriteLine(teller + " * " + getal + " = " + resultaat);
            }
        }

        static int som(int getal1, int getal2){
            return getal1 + getal2;
        }
        static int verschil(int getal1, int  getal2)
        {
            return getal1 - getal2;
        }
        static int quotient(int getal1, int getal2)
        {
            return getal1 / getal2;
        }
        static int product(int getal1, int getal2)
        {
            return getal1 * getal2;
        }
    }
}
