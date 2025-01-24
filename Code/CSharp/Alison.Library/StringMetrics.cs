/***********************************************************************************
* File:         StringMetrics.cs                                                   *
* Contents:     Class StringMetrics                                                *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-11-02 2325                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using SM = Alison.Library.StringMeasures;

namespace Alison.Library
{
	/// <summary>
	/// Facade class containing calls to actual metric routines.
	/// </summary>
	public static class StringMetrics
	{
		/// <summary>
		/// Computes the Levenshtein distance between two string.
		/// </summary>
		/// <param name="source">The first string.</param>
		/// <param name="target">The second string.</param>
		/// <returns>The Levenshtein distance between the strings.</returns>
		public static int LevenshteinDistance(string source, string target)
		{
			return SM.Levenshtein.Distance(source, target);
		}

		/// <summary>
		/// Computes Cosine similarity between two strings.
		/// </summary>
		/// <param name="source">The first string.</param>
		/// <param name="target">The second string.</param>
		/// <param name="nGramLength">The length of the n-gram with which to vectorize the strings.</param>
		/// <returns>The value of cosine similarity between the strings.</returns>
		public static double CosineSimilarity(string source, string target, int nGramLength = 2)
		{
			return SM.Cosine.Similarity(source, target, nGramLength);
		}
	}
}
