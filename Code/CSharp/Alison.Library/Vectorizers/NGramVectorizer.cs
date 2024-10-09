/***********************************************************************************
* File:         NGramVectorizer.cs                                                 *
* Contents:     Class NGramVectorizer                                              *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-11-14 1828                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System.Collections.Generic;

namespace Alison.Library.Vectorizers
{
	public static class NGramVectorizer
	{
		/// <summary>
		/// Calculates a vector representation of a word using its representation as a sequence of N-Grams.
		/// </summary>
		/// <param name="word">The word to vectorize.</param>
		/// <param name="NGramLength">Length of the NGram (default: 2).</param>
		/// <returns>Dictionary with the characters of the word as the keys, and frequencies of the characters as the values.</returns>
		internal static Dictionary<string, int> Vectorize(string word, int NGramLength = 2)
		{
			Dictionary<string, int> result = new Dictionary<string, int>();

			if (word.Length >= NGramLength)
			{
				for (int position = 0; position < word.Length; position++)
				{
					if (position + NGramLength > word.Length)
					{
						break;
					}

					string chunk = word.Substring(position, NGramLength);

					if (!result.ContainsKey(chunk))
					{
						result.Add(chunk, 0);
					}

					result[chunk]++;
				}
			}

			return result;
		}
	}
}
