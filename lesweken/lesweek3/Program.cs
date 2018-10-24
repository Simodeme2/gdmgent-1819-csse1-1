using System;

namespace lesweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Het afdrukken van een tekst in de console.
            Console.WriteLine("Dag!");

            /*
                Dus deze applicatie doet momenteel nog niet veel...
             */

            // Rekenmachine
            //int c, d;
            int a = 5;
            int b = 6;
            int resultaat1 = optellen(a, b);
            int resultaat2 = deling(a, b);
            int resultaat3 = verhogen(a);
            int test = 0;
            
            Program p = new Program();
            p.test1();
            //Som, verschil, product en quotiënt
        }

        void test1()
        {
            Console.WriteLine("Dag!");
        }

        void test2() => Console.WriteLine("Dag!");

        int test3(){
            Console.WriteLine("Dag!");
            return 0;
        }

        static int optellen(int a, int b)
        {
            return a + b;
        }

        static int verhogen(int a)
        {
            return a++;
        }

        static int deling(int a, int b){
            return a/b;
        }
    }
}
