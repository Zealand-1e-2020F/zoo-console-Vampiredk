using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List Zoolist = new List("Zoolist");
            Dyr elefant = new Dyr("Elefant", 25);
            Zoolist.Add(new Dyr("Elefant", 25));
            Zoolist.Add(new Fisk("HammerHaj", "Fisk", "3m", 7));

            Zoolist.ListDyr();
        }
    }
}
