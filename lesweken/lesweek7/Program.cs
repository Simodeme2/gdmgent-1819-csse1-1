using System;

namespace lesweek7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Voertuig voertuig1 = new Voertuig();
            voertuig1.Laadvermogen = 12;
            voertuig1.Kleur = "blauw";
            Console.WriteLine(voertuig1.ToString());

            Voertuig voertuig2 = new Voertuig(30, "rood");
            Console.WriteLine(voertuig2.ToString());
            //auto1.laadvermogen = 12;

            Auto auto1 = new Auto();
            Console.WriteLine(auto1.ToString());
        }
    }

    /* internal class Voertuig
    {
        private string laadvermogen;
    } */
}
