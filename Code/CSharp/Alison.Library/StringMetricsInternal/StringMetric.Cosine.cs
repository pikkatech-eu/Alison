/***********************************************************************************
* File:         StringMetric.Cosine.cs                                             *
* Contents:     Class Cosine                                                       *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-11-14 1754                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Alison.Library.StringMetricsInternal
{
	internal static class Cosine
	{
		#region Internal classes
		internal class Comparer: IComparer<string>
		{
			private string _token = "";
			private int _q = 1;

			public Comparer(string token, int q)
			{
				this._token = token;
				_q = q;
			}

			public int Compare(string x, string y)
			{
				double simX = Similarity(x, this._token, this._q);
				double simY = Similarity(y, this._token, this._q);

				if (simX > simY)
				{
					return -1;
				}
				else if (simX < simY)
				{
					return 1;
				}
				else
				{
					return 0;
				}
			}
		}
		#endregion

		/// <summary>
		/// Calculates Cosine similarity between two words.
		/// The words are assumed to be preprocessed, i.e. space characters removed and, if necessary, brought to upper- or lowercase.
		/// The routine itself is case-sensitive.
		/// </summary>
		/// <param name="word1">The first word.</param>
		/// <param name="word2">The second word.</param>
		/// <param name="NGramLength">The length of the NGram used to vectorize the words.</param>
		/// <returns>The cosine similarity between the words.</returns>
		internal static double Similarity(string word1, string word2, int NGramLength = 1)
		{
			if (word1 == null && word2 == null)
			{
				return 1.0;
			}

			if (word1 == null && word2 != null || word1 != null && word2 == null)
			{
				return 0.0;
			}

			if (word1.Length == 0 && word2.Length != 0 || word1.Length != 0 && word2.Length == 0)
			{
				return 0.0;
			}

			Dictionary<string, int> v1 = Vectorizer.Vectorize(word1, NGramLength);
			Dictionary<string, int> v2 = Vectorizer.Vectorize(word2, NGramLength);

			double norm1 = v1.Sum(kvp => kvp.Value * kvp.Value);
			double norm2 = v2.Sum(kvp => kvp.Value * kvp.Value);
			norm1 = Math.Sqrt(norm1);
			norm2 = Math.Sqrt(norm2);

			IEnumerable<string> intersection = v1.Keys.Intersect(v2.Keys);

			double sum = 0;

			foreach (string c in intersection)
			{
				sum += v1[c] * v2[c];
			}

			return sum / (norm1 * norm2);
		}

		/// <summary>
		/// Finds the index of the element in a string list having the maximum Cosine similarity to the token.
		/// </summary>
		/// <param name="items">The list of strings.</param>
		/// <param name="token">The token string.</param>
		/// <param name="NGramLength">The length of the NGram used to vectorize the words (default: 1).</param>
		/// <returns>The index of the list item Cosine-nearest to the token.</returns>
		public static int IndexOfMostSimilar(List<string> items, string token, int NGramLength = 1)
		{
			int index = -1;
			double similarity = Double.MinValue;

			for (int i = 0; i < items.Count; i++)
			{
				double sim = Similarity(items[i], token, NGramLength);

				if (sim > similarity)
				{
					index = i;
					similarity = sim;
				}
			}

			return index;
		}

		/// <summary>
		/// Sorts a list of strings in the order of cosine similarity to a token string.
		/// </summary>
		/// <param name="items">The list of strings to sort.</param>
		/// <param name="token">The token to compute distances to.</param>
		/// <param name="NGramLength">The length of the NGram used to vectorize the words (default: 1).</param>
		/// <returns>The list sorted in the similarity order.</returns>
		public static List<string> SortStringsByDistanceFromToken(List<string> items, string token, int NGramLength = 1)
		{
			Comparer comparer = new Comparer(token, NGramLength);
			items.Sort(comparer);

			return items;
		}
	}
}