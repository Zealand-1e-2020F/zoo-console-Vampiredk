using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_ConsoleApp
{
    /// <summary>
    /// base klasse for dyr i zoo
    /// </summary>
    public class Dyr
    {
        public string DyreNavn { get; }
        public int DyreLeveTid { get; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Dyr()
        {

        }

        /// <param name="navn">navnet på typen af dyr</param>
        public Dyr(string navn, int levetid)
        {
            this.DyreNavn = navn;
            this.DyreLeveTid = levetid;
        }


    }
}
