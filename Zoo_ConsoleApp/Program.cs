using System;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Zoo!");

            Dyr elefant = new Dyr("Elefant", 25);

            Console.WriteLine(elefant.DyreNavn);

        }
    }
}
