/***********************************************************************************
* File:         EncoderTools.cs                                                    *
* Contents:     Class EncoderTools                                                 *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-02-01 15:33                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Linq;

namespace Alison.Library.Tools
{
	public static class EncoderTools
	{
		#region Private Auxiliary
		/// <summary>
		/// Checks if a character is contained in a set of letters.
		/// </summary>
		/// <param name="c">The character to check.</param>
		/// <param name="letters">The set of letters.</param>
		/// <returns>True if the character is in the set.</returns>
		public static bool IsIn(char c, params char[] letters)
		{
			return letters.Contains(c);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="strings"></param>
		/// <returns></returns>
		public static bool IsIn(string s, params string[] strings)
		{
			return strings.Contains(s);
		}

		/// <summary>
		/// Checks if the character after a defined position of a word is contained in a set of letters.
		/// </summary>
		/// <param name="word">The word to check.</param>
		/// <param name="position">The position in the word.</param>
		/// <param name="letters">The set of letters.</param>
		/// <returns>True if the character is in the set.</returns>
		public static bool IsAfter(string word, int position, params char[] letters)
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
		public static bool IsBefore(string word, int position, params char[] letters)
		{
			return position + 1 < word.Length && letters.Contains(word[position + 1]);
		}
		#endregion
	}
}
