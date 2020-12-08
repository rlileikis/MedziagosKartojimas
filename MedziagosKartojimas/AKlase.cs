using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public class AKlase : BaseClass
	{
		public AKlase(string name) : base(name)
		{
		}
		public override string NameMetodas()
		{
			List<char> Balses = new List<char>{'a', 'e', 'y', 'u', 'i', 'o'};
			StringBuilder sb = new StringBuilder();
			var zodis = Name;
			for (int i = 0; i < zodis.Length; i++)
			{
				char raide = zodis[i];
				if (Balses.Contains(raide))	sb.Append((int)raide);
				else sb.Append(raide);
			}
			return sb.ToString();
		}

		public override int NameKodas(int a)
		{
			var zodis = Name;
			int sum = 0;
			for (int i = 0; i < zodis.Length; i++)
			{
				sum += (int)zodis[i] * a;
			}
			return sum;
		}
	}
}