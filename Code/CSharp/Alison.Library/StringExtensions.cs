/***********************************************************************************
* File:         StringExtensions.cs                                                *
* Contents:     Class StringExtensions                                             *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-08 19:00                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;

namespace Alison.Library
{
	public static class StringExtensions
	{
		/// <summary>
		/// Deletes consecutive characters in a word.
		/// </summary>
		/// <param name="word">Word to delete consecutive characters in.</param>
		/// <returns>The word with consecutive characters removed.</returns>
		public static string DeleteConsecutiveRepeats(this string word)
		{
			if (String.IsNullOrEmpty(word))
			{
				return word;
			}

			string result = word.Substring(0, 1);

			int i = 1;

			while (i < word.Length)
			{
				if (word[i] != result[result.Length - 1])
				{
					result += word[i];
				}

				i++;
			}

			return result;
		}
	}
}
