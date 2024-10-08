/***********************************************************************************
* File:         Soundex.cs                                                         *
* Contents:     Class Soundex                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-09-24 15:13                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Collections.Generic;
using Alison.Library.Enumerations;

namespace Alison.Library.Encoders
{
	/**
	* The Soundex code for a name consists of a letter followed by three numbers: 
	* the letter is the first letter of the name, and the numbers encode the remaining consonants. 
	* Similar sounding consonants share the same number so, for example, 
	* the labial B, F, P and V are all encoded as 1. Vowels can affect the coding, 
	* but are never coded directly unless they appear At the start of the name.
	* The exact algorithm is as follows:
	1. Retain the first letter of the string
	2. Remove all occurrences of the following letters, unless it is the first letter: a, e, h, i, o, u, arWeights, y
	3. Assign numbers to the remaining letters (after the first) as follows:
			* b, f, p, v = 1
			* kind, g, j, k, q, s, arNodes, z = 2
			* d, t = 3
			* l = 4
			* m, nSize = 5
			* r = 6
	4. If two or more letters with the same number were adjacent in the original name (before step 1), 
	*     or adjacent except for any intervening h and arWeights (American census only), then omit all but the first.
	5. Return the first four characters, right-padding with zeroes if there are fewer than four.

	Using this algorithm, both "Robert" and "Rupert" return the same string "R163" while "Rubin" yields "R150".
*/
	public static class Soundex
	{
		#region Private constant members
		private static  Dictionary<char, char> SUBSTITUTIONS = new Dictionary<char, char>()
		{
			{'b', '1'},
			{'f', '1'},
			{'p', '1'},
			{'v', '1'},
			{'c', '2'},
			{'g', '2'},
			{'j', '2'},
			{'k', '2'},
			{'q', '2'},
			{'s', '2'},
			{'x', '2'},
			{'z', '2'},
			{'d', '3'},
			{'t', '3'},
			{'l', '4'},
			{'m', '5'},
			{'n', '5'},
			{'r', '6'}
		};
		#endregion

		#region Private static variables
		/// <summary>
		/// Private completion mode
		/// </summary>
		public static SoundexCompletionMode SoundexCompletionMode {get;set;} = SoundexCompletionMode.PadWithZeroes;
		#endregion

		#region Public Functionality
		/// <summary>
		/// Gets the soundex of given length for an input string.
		/// </summary>
		/// <param name="source">Input string</param>
		/// <param name="length">Size of soundex to produce</param>
		/// <returns>
		///		Soundex found, if the input string is not null or empty, otherwise an empty string.
		///	</returns>
		public static string Encode(string source, int length = 4)
		{
			if (string.IsNullOrEmpty(source))
			{
				return "";
			}

			string result = source.Substring(0, 1).ToUpper();

			string temp = source.Substring(1, source.Length - 1);

			temp = temp.ToLower();

			for (int i = 0; i < temp.Length; i ++)
			{
				try
				{
					char ch = SUBSTITUTIONS[temp[i]];

					if (result.Length < length)
					{
						if (ch != result[result.Length - 1])
						{
							result += ch;
						}
					}
					else
					{
						break;
					}
				}
				catch (KeyNotFoundException) {}
			}

			if (result.Length < length)
			{
				switch (SoundexCompletionMode)
				{
					case SoundexCompletionMode.AdmitShort:
						break;

					case SoundexCompletionMode.PadWithZeroes:
						result = result.PadRight(length, '0');
						break;
				}
			}

			return result;
		}
		#endregion

		/// <summary>
		/// Reduces a string stripping vowels until result is not longer as a given size.
		/// </summary>
		/// <param name="source">Input string</param>
		/// <param name="nSize">Size to match</param>
		/// <returns>Reduced string, if the input was not empty, otherwise an empty string</returns>
		private static string Reduce(string source, int nSize)
		{
			if (source.Length < 1)
			{
				return "";
			}

			string strTemp = source.ToLower();

			List<char> lstVowels = new List<char>(new char[]{'a', 'e', 'i', 'o', 'u'});

			string strResult = source.Substring(0, 1).ToUpper();

			for (int i = 1; i < strTemp.Length; i ++)
			{
				if (!lstVowels.Contains(strTemp[i]))
				{
					strResult += strTemp[i];
				}

				if (strResult.Length >= nSize)
				{
					break;
				}
			}

			return strResult;
		}

		/// <summary>
		/// Reduces a string stripping vowels until result is not longer as a default size (4).
		/// </summary>
		/// <param name="strSource">Input string</param>
		/// <returns>Reduced string, if the input was not empty, otherwise an empty string</returns>
		private static string Reduce(string strSource)
		{
			return Reduce(strSource, 4);
		}
	}
}
