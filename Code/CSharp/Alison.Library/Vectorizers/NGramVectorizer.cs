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
	/// <summary>
	/// Contains functionality to vectorize strings using n-grams.
	/// </summary>
	public static class NGramVectorizer
	{
		/// <summary>
		/// Calculates a vector representation of a word using its representation as a sequence of N-Grams.
		/// </summary>
		/// <param name="word">The word to vectorize.</param>
		/// <param name="nGramLength">Length of the NGram (default: 2).</param>
		/// <returns>Dictionary with the characters of the word as the keys, and frequencies of the characters as the values.</returns>
		internal static Dictionary<string, int> Vectorize(string word, int nGramLength = 2)
		{
			Dictionary<string, int> result = new Dictionary<string, int>();

			if (word.Length >= nGramLength)
			{
				for (int position = 0; position < word.Length; position++)
				{
					if (position + nGramLength > word.Length)
					{
						break;
					}

					string chunk = word.Substring(position, nGramLength);

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
