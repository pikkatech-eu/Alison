/***********************************************************************************
* File:         ColognePhonetics.cs                                                *
* Contents:     Class ColognePhonetics                                             *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu}               *
* Date:         2025-02-01 12:37                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu}                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Alison.Library.Encoders
{
	/// <summary>
	/// Inspired by https://www.php.net/manual/de/function.soundex.php#84881 
	/// and https://abydos.readthedocs.io/en/v0.3.0/_modules/abydos/phonetic.html .
	/// A function for retrieving the Kölner Phonetik value of a string.
	/// 
	/// As described at http://de.wikipedia.org/wiki/Kölner_Phonetik
	/// Based on Hans Joachim Postel: Die Kölner Phonetik. 
	/// Ein Verfahren zur Identifizierung von Personennamen auf der 
	/// Grundlage der Gestaltanalyse. 
	/// in: IBM-Nachrichten, 19. Jahrgang, 1969, S. 925-931
	/// </summary>
	public static class ColognePhonetics
	{
		//private static readonly Dictionary<string, string> SUBSTITUTIONS = new Dictionary<string, string>
		//{
		//	["ä"]	="a",
  //          ["ö"]	="o",
  //          ["ü"]	="u",
  //          ["ß"]	="ss",
  //          ["ph"]	="f"
		//};

		//private static readonly Dictionary<int, string[]> EXCEPTIONS_LEADING	= new Dictionary<int, string[]>
		//{
		//	[4] = new string[]{"ca","ch","ck","cl","co","cq","cu","cx" },
		//	[8] = new string[]{"dc","ds","dz","tc","ts","tz" }
		//};

		//private static readonly string[] EXCEPTIONS_FOLLOWING = new string[]{"sc","zc","cx","kx","qx"};

		//private static readonly Dictionary<int, string[]> CODING_TABLE	= new Dictionary<int, string[]>
		//{
		//	[0]	= new string[]{"a","e","i","j","o","u","y"},
		//	[1]	= new string[]{"b","p"},
		//	[2]	= new string[]{"d","t"},
		//	[3]	= new string[]{"f","v","w"},
		//	[4]	= new string[]{"c","g","k","q"},
		//	[4]	8 new string[]{("x"},
		//	[5]	= new string[]{"l"},
		//	[6]	= new string[]{"m","n"},
		//	[7]	= new string[]{"r"},
		//	[8]	= new string[]{"c","s","z"},
		//};

		//public static string Encode(string word)
		//{
		//	word	= word.ToLower();

		//	foreach (string letter in SUBSTITUTIONS.Keys)
		//	{
		//		word	= word.Replace(letter, SUBSTITUTIONS[letter]);
		//	}

		//	int length	= word.Length;

		//	List<string> value = new List<string>();

		//	for (int i = 0; i < length; i++)
		//	{
		//		if (i == 0 && word[..^1] == "cr")
		//		{
		//			value[i] = "4";
		//		}
		//	}

		private const string UCVSET = "AEIOUJY";
		private const string UCSET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


		private static readonly Dictionary<int, char> NUMTRANS = new Dictionary<int, char>
		{ 
			[0]	= 'A',
			[1]	= 'P',
			[2]	= 'T',
			[3]	= 'F',
			[4]	= 'K',
			[5]	= 'L',
			[6]	= 'N',
			[7]	= 'R',
			[8]	= 'S',
		};

		private static bool IsIn(char c, params char[] letters)
		{
			return letters.Contains(c);
		}

		private static bool IsAfter(string word, int pos, params char[] letters)
		{
			return pos > 0 && letters.Contains(word[pos-1]);
		}

		private static bool IsBefore(string word, int pos, params char[] letters)
		{
			return pos + 1 < word.Length && letters.Contains(word[pos + 1]);
		}

		public static string Encode(string word)
		{
			string result = "";

			word	= word.Normalize(NormalizationForm.FormKD);
			word	= word.ToUpper();

			word	= word.Replace("Ä", "AE");
			word	= word.Replace("Ö", "OE");
			word	= word.Replace("Ü", "UE");

			string word1 = "";

			foreach (char c in word)
			{
				if (UCSET.Contains(c))
				{
					word1 += c;
				}
			}

			word = word1;

			if (String.IsNullOrEmpty(word))
			{
				return result;
			}

			for (int i = 0; i < word.Length; i++)
			{
				if (UCVSET.Contains(word[i]))
				{
					result += '0';
				}
				else if (word[i] == 'B')
				{
					result += '1';
				}
				else if (word[i] == 'P')
				{
					if (IsBefore(word, i, 'H'))
					{
						result += '3';
					}
					else
					{
						result += '1';
					}
				}
				else if (word[i] == 'D' || word[i] == 'T')
				{
					if (IsBefore(word, i, 'C', 'S', 'Z'))
					{
						result += '8';
					}
					else
					{
						result += '2';
					}
				}
			}

			return result;
		}
	}
}
