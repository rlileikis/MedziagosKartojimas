using System;
using System.Collections.Generic;
using System.Text;

namespace MedziagosKartojimas
{
	public class BKlase : AKlase, IZodisKitaip
	{
		public BKlase()
		{

		}
		public BKlase(string name) : base(name)
		{
		}

		public override int NameKodas(int number)
		{
			var vardas = Name;
			int sum = 0;
			for (int i = 0; i < vardas.Length; i++)
			{
				sum += (int)vardas[i] - number;
			}
			return sum;
		}

		public string ZodisBeBalsiu()
		{
			List<char> balses = new List<char>{'a', 'e', 'y', 'u', 'i', 'o'};
			var sb = new StringBuilder();
			foreach (var let in Name)
			{
				sb.Append(balses.Contains(let) ? string.Empty : let.ToString());
			}
			return sb.ToString();
		}

		public string ZodisBePrieBalsiu()
		{
			List<char> balses = new List<char>{'a', 'e', 'y', 'u', 'i', 'o'};
			var sb = new StringBuilder();
			foreach (var let in Name)
			{
				sb.Append(balses.Contains(let) ? let.ToString() : string.Empty);
			}
			return sb.ToString();
		}

		public string ZodisSuPakeistomisBalsemis(char[] letter)
		{
			List<char> balses = new List<char>{'a', 'e', 'y', 'u', 'i', 'o'};
			var sb = new StringBuilder();
			foreach (var let in Name)
			{
				sb.Append(balses.Contains(let) ? letter.ToString() : let.ToString());
			}
			return sb.ToString();
		}

		public string ZodisSuPakeistomisPrieBalsemis(int num)
		{
			List<char> balses = new List<char>{'a', 'e', 'y', 'u', 'i', 'o'};
			var sb = new StringBuilder();
			foreach (var letter in Name)
			{
				sb.Append(balses.Contains(letter) ? letter.ToString() : num.ToString());
			}
			return sb.ToString();
		}
	}
}
