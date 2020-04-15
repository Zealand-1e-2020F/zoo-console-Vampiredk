using System;
using System.Runtime.InteropServices;

namespace Zoo_ConsoleApp
{

	public class Mamals : Dyr
	{
		public Mamals(string navn, string mad, int Størelse, int leveTid)
			:base(navn,leveTid)
		{

		}
	}
}
