/***********************************************************************************
* File:         StringMetrics.cs                                                   *
* Contents:     Class StringMetrics                                                *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-11-02 2325                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using Alison.Library.StringMetricsInternal;

namespace Alison.Library
{
	public static class StringMetrics
	{
		/// <summary>
		/// TODO Implement me!
		/// </summary>
		/// <param name="source"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static int LevenshteinDistance(string source, string target)
		{
			return Levenshtein.Distance(source, target);
		}

		public static double CosineSimilarity(string source, string target, int NGramLength = 2)
		{
			return Cosine.Similarity(source, target, NGramLength);
		}
	}
}
