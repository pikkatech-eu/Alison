/***********************************************************************************
* File:         AmericanSoundex.cs                                                 *
* Contents:     Class AmericanSoundex                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-08 21:25                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Alison.Library.Enumerations;
using Alison.Library.Tools;

namespace Alison.Library.Encoders
{
	/// <summary>
	/// American Soundex, as described in Knuth TAOCP Vol3 Edition 2, pg 394-395.
	/// Follows Richard Birkby's algorithm (https://github.com/rbirkby/soundex/), with slight modifications.
	/// </summary>
	public static class AmericanSoundex
	{
        #region Static constants
        private static readonly string[] SURNAME_PREFIXES = {"VAN", "CON", "DE", "DI", "LA", "LE"};
        #endregion

        #region Static Properties
        /// <summary>
        /// Default length of the Soundex code (=4).
        /// </summary>
        public static int CodeLength {get;set;} = 4;

        /// <summary>
        /// Completion mode.
        /// Default: pad with zeros.
        /// </summary>
        public static SoundexCompletionMode SoundexCompletionMode   {get;set;} = SoundexCompletionMode.PadWithZeroes;

        /// <summary>
        /// If set to true, the following prefixes will be removed at the beginning of the word: "Van", "Con", "De", "Di", "La", "Le".
        /// Defined by: United States. Soundex system: the soundex indexing system. 2007. URL: https://www.archives.gov/research/census/soundex.html.
        /// </summary>
        /// <example>"VanDeusen" will be encoded as "D250" instead of "V532".</example>
        public static bool RemoveSurnamePrefixes    {get;set;} = false;
		#endregion

		#region Public Features
		public static string Encode(string word)
		{
			if (word.Length == 0)
            {
                return string.Empty;
            }

            // Remove spaces.
            word = word.Replace(" ", "");

            // Convert non-Ascii characters.
            word = word.ToAscii();

            // If RemoveSurnamePrefixes is set, remove surname prefixes.
            if (RemoveSurnamePrefixes)
            {
                for (int i = 0; i < SURNAME_PREFIXES.Length; i++)
                {
                    if (word.ToUpper().StartsWith(SURNAME_PREFIXES[i]))
                    {
                        word = word.Substring(SURNAME_PREFIXES[i].Length);
                        break;
                    }
                }
            }

            string output = new string(char.ToUpperInvariant(word[0]), 1);

            // Stop at a maximum of CodeLength characters
            for (int i = 1; i < word.Length && output.Length < CodeLength; i++)
            {
                string c = EncodeChar(word[i]);

                // We either append or ignore, determined by the preceding char
                switch (char.ToLowerInvariant(word[i - 1]))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        // Chars separated by a vowel - OK to encode
                        output += c;
                        break;

                    case 'h':
                    case 'w':
                    default:
                        // Ignore duplicated phonetic sounds
                        if (output.Length == 1)
                        {
                            // We only have the first character, which is never
                            // encoded. However, we need to check whether it is
                            // the same phonetically as the next char
                            if (EncodeChar(output[output.Length - 1]) != c)
                            {
                                output += c;
                            }
                        }
                        else
                        {
                            if (output[output.Length - 1].ToString() != c)
                            {
                                output += c;
                            }
                        }

                        break;
                }
            }

            // Pad with zeros
            if (SoundexCompletionMode == SoundexCompletionMode.PadWithZeroes)
            {
                output += new string('0', CodeLength - output.Length);
            }

            return output.ToString();
		}
		#endregion

		#region Private Auxiliary
		private static string EncodeChar(char c)
        {
            // C# will re-order this list and produce a look-up list from it
            // C# will do all the work we would otherwise do by building arrays of values
            switch (char.ToLowerInvariant(c))
            {
                case 'b':
                case 'f':
                case 'p':
                case 'v':
                    return "1";

                case 'c':
                case 'g':
                case 'j':
                case 'k':
                case 'q':
                case 's':
                case 'x':
                case 'z':
                    return "2";

                case 'd':
                case 't':
                    return "3";

                case 'l':
                    return "4";

                case 'm':
                case 'n':
                    return "5";

                case 'r':
                    return "6";

                default:
                    return string.Empty;
            }
        }
        #endregion
	}
}
