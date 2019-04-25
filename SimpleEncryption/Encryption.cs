using System;
using System.Collections.Generic;

namespace SimpleEncryption
{
	public class MessageEncryption
	{

		public static string Encryption(string x)
		{
			List<char> Letras = new List<char> {'a','A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g',
												'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M',
												'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
												           
												    'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
												'á', 'â', 'ã', 'à', 'é', 'ê', 'í', 'ó', 'õ', 'ô', 'ú', 'ü', 'ç',
												'Á', 'Â', 'Ã', 'À', 'É', 'Ê', 'Í', 'Ó', 'Õ', 'Ô', 'Ú', 'Ü', 'Ç'};

			char[] message = x.ToCharArray();
			string encrypted = "";

			foreach (char letra in message)
			{
				if (letra == ' ')
				{
					encrypted += " ";
				}
				else
				{
					int i = Letras.BinarySearch(letra);
					int indexEncryption;

					if (i < 0)
					{
						indexEncryption = i * -1;
					}
					else
					{
						if (i + i > Letras.Count)
						{
							indexEncryption = i + 2;
						}
						else
						{
							indexEncryption = i + i;
						}
					}
					char k = Letras[indexEncryption];
					encrypted += k;
				}
			}
			return encrypted;
		}
	}
}
