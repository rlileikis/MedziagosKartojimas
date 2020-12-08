using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public interface IZodisKitaip
	{
	public string ZodisBeBalsiu();
	public string ZodisBePrieBalsiu();
	public string ZodisSuPakeistomisBalsemis(char[] letter);
	public string ZodisSuPakeistomisPrieBalsemis(int num);
	}

}
