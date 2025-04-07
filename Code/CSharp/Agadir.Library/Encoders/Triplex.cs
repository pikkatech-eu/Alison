/***********************************************************************************
* File:         Triplex.cs                                                         *
* Contents:     Class Triplex                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-03-17 10:51                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using Agadir.Library.Tools;

namespace Agadir.Library.Encoders
{
	/// <summary>
	/// Encoding of strings into 3-character strings.
	/// </summary>
    public static class Triplex
    {
		// List of vowels.
		private const string VOWELS = "aeiou";

		/// <summary>
		/// Computes the Triplex code of a string.
		/// </summary>
		/// <param name="source">
		///		The string to encode. Can consist of one or more components divided by a space character or '-'.
		///	</param>
		/// <returns>The triplex code of source string.</returns>
		/// <exception cref="ArgumentException">Thrown if the source string is null or empty.</exception>
		public static string Encode(string source)
		{
			string[] components = Regex.Split(source, @"\s+|-");

			if (components.Length == 1)
			{
				return EncodeSimple(source);
			}

			if (components.Length > 3)
			{
				components = components.Take(3).ToArray();
			}

			string[] simple_codes = components.Select(c => EncodeSimple(c)).ToArray();

			string result = new string(simple_codes.Select(c => c[0]).ToArray());

			if (result.Length == 2)
			{
				result = result + simple_codes[1][1];
			}

			return result.ToUpper();
		}

		/// <summary>
		/// Computes the Triplex code of a one-component string.
		/// </summary>
		/// <param name="source">The string to encode.</param>
		/// <returns>The triplex code of source string.</returns>
		/// <exception cref="ArgumentException">Thrown if the source string is null or empty.</exception>
		private static string EncodeSimple(string source)
		{
			if (String.IsNullOrEmpty(source))
			{
				throw new ArgumentException("The source was null or empty");
			}
			
			source = source.ToAscii().ToLower();

			if (source.Length <= 3)
			{
				return source.ToUpper();
			}

			// assign the first char to result, whether it is a vowel or not
			string result = source[0..1];
			
			// remove all vowels from the source
			string sourceConsonants = new string(source[1..].Where(c => !VOWELS.Contains(c)).ToArray());

			// try adding chars from source_without_vowels to result
			if (sourceConsonants.Length >= 2)
				result += sourceConsonants[0..2];
			else
				result += sourceConsonants;

			if (result.Length < 3)
			{
				string vowels = String.Join("", source[1..].Where(c => VOWELS.Contains(c)));
				
				if (result.Length == 2)
					result = result[0..1] + vowels[0..1] + result[1..2];
				else
					result += vowels[0..2];
			}
            
			return result.ToUpper();
		}
    }
}
