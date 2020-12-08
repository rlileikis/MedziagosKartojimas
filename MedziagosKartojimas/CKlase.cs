using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public class CKlase : BKlase
	{
		public int Skaicius { get; set; }
		public string Zodis { get; set; }
		public double DoubleSkaicius { get; set; }
		public AKlase AObjektas { get; set; }

		public CKlase()
		{
		}

		public CKlase(int skaicius)
		{
			Skaicius = skaicius;
		}

		public CKlase(int skaicius,string zodis): this(skaicius)
		{
			Zodis = zodis;

		}

		public CKlase(int skaicius,string zodis, double doubleSk, AKlase obj) : this(skaicius,zodis)
		{
			DoubleSkaicius = doubleSk;
			AObjektas = obj;

		}
	}
}
