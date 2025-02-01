/***********************************************************************************
* File:         ColognePhonetics.cs                                                *
* Contents:     Class ColognePhonetics                                             *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu}               *
* Date:         2025-02-01 12:37                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu}                                    *
***********************************************************************************/

using System;
using System.Linq;
using System.Text;
using Alison.Library.Tools;

namespace Alison.Library.Encoders
{
	/// <summary>
	/// Inspired by  https://abydos.readthedocs.io/en/v0.3.0/_modules/abydos/phonetic.html .
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
		#region Constants
		private const string VOWELS		= "AEIOUJY";
		private const string CONSONANTS	= "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		#endregion

		#region Private Auxiliary
		/// <summary>
		/// Checks if a character is contained in a set of letters.
		/// </summary>
		/// <param name="c">The character to check.</param>
		/// <param name="letters">The set of letters.</param>
		/// <returns>True if the character is in the set.</returns>
		private static bool IsIn(char c, params char[] letters)
		{
			return letters.Contains(c);
		}

		/// <summary>
		/// Checks if the character after a defined position of a word is contained in a set of letters.
		/// </summary>
		/// <param name="word">The word to check.</param>
		/// <param name="position">The position in the word.</param>
		/// <param name="letters">The set of letters.</param>
		/// <returns>True if the character is in the set.</returns>
		private static bool IsAfter(string word, int position, params char[] letters)
		{
			return position > 0 && letters.Contains(word[position - 1]);
		}

		/// <summary>
		/// Checks if the character before a defined position of a word is contained in a set of letters.
		/// </summary>
		/// <param name="word">The word to check.</param>
		/// <param name="position">The position in the word.</param>
		/// <param name="letters">The set of letters.</param>
		/// <returns>True if the character is in the set.</returns>
		private static bool IsBefore(string word, int position, params char[] letters)
		{
			return position + 1 < word.Length && letters.Contains(word[position + 1]);
		}
		#endregion

		/// <summary>
		/// Encodes a word using the Kölner Phonetik algorithm.
		/// </summary>
		/// <param name="word">The word to encode.</param>
		/// <returns>The word encoded.</returns>
		public static string Encode(string word)
		{
			string result = "";

			word	= word.Normalize(NormalizationForm.FormKD);
			word	= word.ToUpper();

			word	= word.Replace("Ä", "AE");
			word	= word.Replace("Ö", "OE");
			word	= word.Replace("Ü", "UE");

			string temp = "";

			foreach (char c in word)
			{
				if (CONSONANTS.Contains(c))
				{
					temp += c;
				}
			}

			word = temp;

			if (String.IsNullOrEmpty(word))
			{
				return result;
			}

			for (int i = 0; i < word.Length; i++)
			{
				char c = word[i];

				if (VOWELS.Contains(c))
				{
					result += '0';
				}
				else if (c == 'B')
				{
					result += '1';
				}
				else if (c == 'P')
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
				else if (c == 'D' || c == 'T')
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
				else if (IsIn(c, 'F', 'V', 'W'))
				{
					result += '3';
				}
				else if (IsIn(c, 'G', 'K', 'Q'))
				{
					result += '4';
				}
				else if (c == 'C')
				{
					if (IsAfter(word, i, 'S', 'Z'))
					{
						result += '8';
					}
					else if (i == 0)
					{
						if (IsBefore(word, i, 'A', 'H', 'K', 'L', 'O', 'Q', 'R', 'U', 'X'))
						{
							result += '4';
						}
						else
						{
							result += '8';
						}
					}
					else if (IsBefore(word, i, 'A', 'H', 'K', 'O', 'Q', 'U', 'X'))
					{
						result += '4';
					}
					else
					{
						result += '8';
					}
				}
				else if (c == 'X')
				{
					if (IsAfter(word, i, 'C', 'K', 'Q'))
					{
						result += '8';
					}
					else
					{
						result += "48";
					}
				}
				else if (c == 'L')
				{
					result += '5';
				}
				else if (IsIn(c, 'M', 'N'))
				{
					result += '6';
				}
				else if (c == 'R')
				{
					result += '7';
				}
				else if (IsIn(c, 'S', 'Z'))
				{
					result += '8';
				}

			}
			
			result = result.DeleteConsecutiveRepeats();

			bool startsWithZero = result.StartsWith("0");

			result	= result.Replace("0", "");

			if (startsWithZero)
			{
				result = "0" + result;
			}

			return result;
		}
	}
}
