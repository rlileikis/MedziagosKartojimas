using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public abstract class BaseClass
	{
		public string name { get; }

		public BaseClass(string Name)
		{

			name = Name;
		}

		public abstract string NameMetodas();

		public abstract int NameMetodas(int a);


	}

}
