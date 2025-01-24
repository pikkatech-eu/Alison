/***********************************************************************************
* File:         StringMetrics.cs                                                   *
* Contents:     Class StringMetrics                                                *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-11-02 2325                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using SM=Alison.Library.StringMeasures;

namespace Alison.Library
{
	public static class StringMetrics
	{
		/// <summary>
		/// </summary>
		/// <param name="source"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static int LevenshteinDistance(string source, string target)
		{
			return SM.Levenshtein.Distance(source, target);
		}

		public static double CosineSimilarity(string source, string target, int nGramLength = 2)
		{
			int oldNGramLength = SM.Cosine.NGramLength;
			SM.Cosine.NGramLength = nGramLength;

			return SM.Cosine.Similarity(source, target);

			SM.Cosine.NGramLength = oldNGramLength;
		}
	}
}
