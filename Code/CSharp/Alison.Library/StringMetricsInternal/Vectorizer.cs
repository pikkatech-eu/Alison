/***********************************************************************************
* File:         Vectorizer.cs                                                      *
* Contents:     Class Vectorizer                                                   *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-11-14 1828                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System.Collections.Generic;

namespace Alison.Library.StringMetricsInternal
{
	public static class Vectorizer
	{
		/// <summary>
		/// Calculates a vector representation of a word.
		/// </summary>
		/// <param name="word">The word to vectorize.</param>
		/// <param name="q">Length of the NGram.</param>
		/// <returns>Dictionary with the characters of the word as the keys, and frequencies of the characters as the values.</returns>
		internal static Dictionary<string, int> NGraphVectorize(string word, int q = 2)
		{
			Dictionary<string, int> result = new Dictionary<string, int>();

			if (word.Length >= q)
			{
				for (int position = 0; position < word.Length; position++)
				{
					if (position + q > word.Length)
					{
						break;
					}

					string chunk = word.Substring(position, q);

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
