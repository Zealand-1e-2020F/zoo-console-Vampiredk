using System;
using System.Collections.Generic;
using System.Text;
namespace Zoo_ConsoleApp
{
	public class Insekt : Dyr
	{
		public Insekt(string navn, string mad, int Størelse, int leveTid)
			: base(navn,leveTid)
		{

		}
	}
}
