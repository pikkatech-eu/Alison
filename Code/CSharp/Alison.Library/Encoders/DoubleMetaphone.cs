/***********************************************************************************
* File:         DoubleMetaphone.cs                                                 *
* Contents:     Class DoubleMetaphone                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-09 14:57                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison.Library.Encoders
{
	/// <summary>
	/// Implements the Double Metaphone phonetic matching algorithm published by Lawrence Phillips in June 2000 C/C++ Users Journal. 
	/// Follows the optimized C# code by Adam Nelson (anelson@nullpointer.net).
	/// </summary>
	public static class DoubleMetaphone
	{
		#region Private Variables
		/// <summary>
		/// StringBuilders used to construct the keys
		/// </summary>
		private static StringBuilder m_primaryKey;
		private static StringBuilder m_alternateKey;

		/// <summary>
		/// Actual keys, populated after construction
		/// </summary>
		private static string m_primaryKeyString;
		private static string m_alternateKeyString;

		/// <summary>
		/// Variables to track the key length w/o having to grab the .Length attr (?)
		/// </summary>
		private static int m_primaryKeyLength;
		private static int m_alternateKeyLength;

		/// <summary>
		/// Working copy of the word, and the original word
		/// </summary>
		private static string m_word;
		private static string m_originalWord;

		/// <summary>
		/// Length and last valid zero-based index into word
		/// </summary>
		private static int m_length;
		private static int m_last;

		/// <summary>
		/// Flag indicating if an alternate metaphone key was computed for the word
		/// </summary>
		private static bool m_hasAlternate;
		#endregion

		#region Construction

		#endregion

		public static int METAPHONE_KEY_LENGTH {get;set;} = 4;

		public static string Encode(string word)
		{
			throw new NotImplementedException();
		}
	}
}
