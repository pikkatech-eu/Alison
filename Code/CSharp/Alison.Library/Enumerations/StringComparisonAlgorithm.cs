/***********************************************************************************
* File:         StringComparisonAlgorithm.cs                                       *
* Contents:     Enum StringComparisonAlgorithm                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-10 09:33                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Alison.Library.Enumerations
{
	/// <summary>
	/// Desfines the method by which two strings should be compared.
	/// </summary>
	public enum StringComparisonAlgorithm
	{
		/// <summary>
		/// Strings are similar if the probe string is contained in the string compared.
		/// This method is asymmetric.
		/// </summary>
		Containment		= 0,

		/// <summary>
		/// Strings are similar if their Soundex encodings are equal.
		/// </summary>
		Soundex			= 1,

		/// <summary>
		/// Strings are similar if their Double Methaphone encodings are equal.
		/// </summary>
		DoubleMetaphone	= 2,

		/// <summary>
		/// Strings are similar if there exists an equal encoding in the encoding arrays by Daitch-Mokotoff.
		/// </summary>
		DaitchMokotoff	= 3,

		/// <summary>
		/// Strings are similar if their Levenshtein distance is not greater than a defined value.
		/// </summary>
		Levenshtein		= 101,

		/// <summary>
		/// Strings are similar if their cosine values differ not greater than a defined value.
		/// </summary>
		Cosine			= 102,

		/// <summary>
		/// Strings are similar if their Needleman-Wunsch codes differ not greater than a defined value.
		/// </summary>
		NeedlemanWunsch	= 103
	}
}
