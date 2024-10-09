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
	public static class Cosine
	{
		#region Internal classes
		internal class SimilarityComparer: IComparer<(string Word, double Similarity)>
		{
			private string _token = "";
			private int _q = 1;

			public SimilarityComparer(string token, int q)
			{
				this._token = token;
				_q = q;
			}

			public int Compare((string Word, double Similarity) tuple1, (string Word, double Similarity) tuple2)
			{

				double sim1 = Similarity(tuple1.Word, this._token, this._q);
				double sim2 = Similarity(tuple2.Word, this._token, this._q);

				if (sim1 > sim2)
				{
					return -1;
				}
				else if (sim1 < sim2)
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

		public static bool CaseInsensitive	{get;set;} = true;

		/// <summary>
		/// Calculates Cosine similarity between two words.
		/// The words are assumed to be preprocessed, i.e. space characters removed and, if necessary, brought to upper- or lowercase.
		/// The routine itself is case-sensitive.
		/// </summary>
		/// <param name="word1">The first word.</param>
		/// <param name="word2">The second word.</param>
		/// <param name="NGramLength">The length of the NGram used to vectorize the words.</param>
		/// <returns>The cosine similarity between the words.</returns>
		internal static double Similarity(string word1, string word2, int NGramLength = 2)
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

			if (CaseInsensitive)
			{
				word1 = word1.ToLower();
				word2 = word2.ToLower();
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
		/// Finds the element in a string list having the maximum Cosine similarity to the token.
		/// </summary>
		/// <param name="items">The list of strings.</param>
		/// <param name="token">The token string.</param>
		/// <param name="NGramLength">The length of the NGram used to vectorize the words (default: 2).</param>
		/// <returns>The most similar element and its index in the list.</returns>
		public static (string Word, int Index) MostSimilar(List<string> items, string token, int NGramLength = 2)
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

			return (items[index], index);
		}

		/// <summary>
		/// Sorts a list of strings in the order of cosine similarity to a token string.
		/// </summary>
		/// <param name="items">The list of strings to sort.</param>
		/// <param name="token">The token to compute distances to.</param>
		/// <param name="NGramLength">The length of the NGram used to vectorize the words (default: 2).</param>
		/// <returns>The list sorted in the similarity order.</returns>
		public static List<(string Word, double Similarity)> SortStringsByDistanceFromToken(List<string> items, string token, int NGramLength = 2)
		{
			List<(string Word, double Similarity)> result = new List<(string Word, double Similarity)>();

			foreach (string item in items)
			{
				result.Add((item, Similarity(item, token)));
			}

			SimilarityComparer comparer = new SimilarityComparer(token, NGramLength);
			result.Sort(comparer);

			return result;
		}
	}
}