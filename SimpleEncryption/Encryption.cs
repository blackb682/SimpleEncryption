using System;
using System.Collections.Generic;

namespace SimpleEncryption
{
	public class MessageEncryption
	{

		public static string Encryption(string x)
		{
			IList<char> Letras = new List<char> {'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g',
												'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M',
												'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't',
												'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z',
												'á', 'â', 'ã', 'à', 'é', 'ê', 'í', 'ó', 'õ', 'ô', 'ú', 'ü', 'ç',
												'Á', 'Â', 'Ã', 'À', 'É', 'Ê', 'Í', 'Ó', 'Õ', 'Ô', 'Ú', 'Ü', 'Ç'};

			IList<char> Symbols = new List<char>{ ',', '.', '[', ']', '{', '}' };

			int Aleatorio()
			{
				Random z = new Random();
				return z.Next(1, 10);
			}

			char[] message = x.ToCharArray();
			string encrypted = Aleatorio().ToString("00") + "-";

			foreach (char letra in message)
			{
				if (letra == ' ')
				{
					encrypted += " ";
				}
				else if (Symbols.Contains(letra))
				{
					encrypted += "-";
				}
				else
				{
					int i = Letras.IndexOf(letra);
					int indexEncryption = 0;

					if (i + Aleatorio() < 0)
					{
						indexEncryption = i * -1 + Aleatorio();
					}
					else
					{
						if (i + Aleatorio() > Letras.Count)
						{
							i = (i + Aleatorio()) - Letras.Count;
							indexEncryption = i;
						}
						else
						{
							indexEncryption = i + Aleatorio();
						}
					}
					char k = Letras[indexEncryption];
					encrypted += k + Convert.ToString(i);
				}
			}
			return encrypted;
		}
	}
}
