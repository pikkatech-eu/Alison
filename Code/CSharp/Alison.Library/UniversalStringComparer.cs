/***********************************************************************************
* File:         UniversalStringComparer.cs                                         *
* Contents:     Class UniversalStringComparer                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-10 09:45                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Linq;
using Alison.Library.Encoders;
using Alison.Library.Enumerations;
using Alison.Library.StringMeasures;

namespace Alison.Library
{
	/// <summary>
	/// Universal comparer of strings.
	/// Defines a single method to compare strings for similarity.
	/// </summary>
	public static class UniversalStringComparer
	{
		/// <summary>
		/// Checks strings for similarity using a number of supported string encodings and string metrics.
		/// </summary>
		/// <param name="probe">The probe string being checked for similarity with the source string.</param>
		/// <param name="source">The source string with which the probe string is compared.</param>
		/// <param name="algorithm">Similarity check algorithm.</param>
		/// <param name="distance">
		///		The maximum distance between strings, under which they are considered similar. 
		///		Ignored by string encoding algorithms.
		///	</param>
		/// <param name="caseSensitive">If set to true, strings are compared with case-sensitivity, otherwise without.</param>
		/// <returns></returns>
		public static bool AreSimilar
										(
											string probe, 
											string source, 
											StringComparisonAlgorithm algorithm, 
											double? distance = null, 
											bool caseSensitive = false
										)
		{
			if (probe == null && source == null)
			{
				return true;
			}

			if ((probe == null && source != null) || (probe != null && source == null))
			{
				return false;
			}

			if (!caseSensitive)
			{
				probe	= probe.ToLower();
				source	= source.ToLower();
			}

			switch (algorithm)
			{
				case StringComparisonAlgorithm.Containment:
					return source.Contains(probe);

				case StringComparisonAlgorithm.Soundex:
					return AmericanSoundex.Encode(probe) == AmericanSoundex.Encode(source);

				case StringComparisonAlgorithm.DoubleMetaphone:
					return DoubleMetaphone.Encode(probe) == DoubleMetaphone.Encode(source);

				case StringComparisonAlgorithm.DaitchMokotoff:
					string[] daimok1 = DaitchMokotoff.Encode(probe).Split(',');
					string[] daimok2 = DaitchMokotoff.Encode(source).Split(',');

					return daimok1.Intersect(daimok2).Any(); 

				case StringComparisonAlgorithm.Levenshtein:
					return Levenshtein.Distance(probe, source) <= (int)(distance);

				case StringComparisonAlgorithm.Cosine:
					return Cosine.Similarity(probe, source) >= (double)(distance);

				case StringComparisonAlgorithm.NeedlemanWunsch:
					return NeedlemanWunsch.SimilarityScore(probe, source) >= (double)(distance);

				default:
					return false;
			}
		}
	}
}
