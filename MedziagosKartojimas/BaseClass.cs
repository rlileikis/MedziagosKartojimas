using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public abstract class BaseClass
	{
		public string Name { get; }

		public BaseClass(string name)
		{

			Name = name;
		}
		protected BaseClass()
		{

		}

		
		public abstract string NameMetodas();

		public abstract int NameKodas(int a);


	}

}
