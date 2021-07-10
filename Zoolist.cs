using System;
using System.Collections.Generic;
using System.Text;

namespace zoo_console
{
    public class Zoolist
    {
        public int ZooNavn { get; }

        public List(string navn)
        {
            List<Dyr> Zoolist = new List<Dyr>();
            this.ZooNavn = navn;
        }


        public ListDyr()
        {
            foreach (var Dyr in Zoolist)
            {
                if (Dyr is Fisk)
                {
                    Console.WriteLine($"{Fisk.DyreNavn} og {Fisk.DyreLeveTid} og {Fisk.DyreMad}");
                }
                else
                {
                    Console.WriteLine($"{Dyr.DyreNavn}");
                    get { return Dyr.DyreNavn; }
                }
            }
        }

    }
}