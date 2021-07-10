using System;
using System.Collections.Generic;
using System.Text;
namespace Zoo_ConsoleApp
{
	public class Fisk : Dyr
	{
		public string DyreMad { get; }

		public Fisk(string navn, string mad, string Størelse, int leveTid)
			:base(navn,leveTid)
		{
			this.DyreMad = mad;
		}
	}
}