using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public class BKlase : AKlase, IZodisKitaip
	{
		public BKlase(string name) : base(name)
		{
		}

		string IZodisKitaip.ZodisBeBalsiu()
		{
			throw new NotImplementedException();
		}

		string IZodisKitaip.ZodisBePrieBalsiu()
		{
			throw new NotImplementedException();
		}

		string IZodisKitaip.ZodisSuPakeistomisBalsemis(char[] letter)
		{
			throw new NotImplementedException();
		}

		string IZodisKitaip.ZodisSuPakeistomisPrieBalsemis(int num)
		{
			throw new NotImplementedException();
		}
	}
}
