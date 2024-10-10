/***********************************************************************************
* File:         Russel.cs                                                          *
* Contents:     Class Russel                                                       *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-08 18:26                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Collections.Generic;
using System.Linq;
using Alison.Library.Tools;

namespace Alison.Library.Encoders
{
	/// <summary>
	/// Russell Index Routines.
	/// Implements Russell index encoding as described in Russell, Robert C., US Patent #1261167, 1918.
	/// https://patentimages.storage.googleapis.com/31/35/a1/f697a3ab85ced6/US1261167.pdf .
	/// Code inspired by the abydos Python framework (https://github.com/chrislit/abydos).
	/// </summary>
	public static class Russell
	{
		#region Private constatnts
		private static readonly string UC_SET = "ABCDEFGIKLMNOPQRSTUVXYZ";
        private static readonly Dictionary<char, char>  CHAR_TO_DIGIT = new Dictionary<char, char>()
        {
            {'A',  '1'},
            {'B',  '2'},
            {'C',  '3'},
            {'D',  '4'},
            {'E',  '1'},
            {'F',  '2'},
            {'G',  '3'},
            {'I',  '1'},
            {'K',  '3'},
            {'L',  '5'},
            {'M',  '6'},
            {'N',  '7'},
            {'O',  '1'},
            {'P',  '2'},
            {'Q',  '3'},
            {'R',  '8'},
            {'S',  '3'},
            {'T',  '4'},
            {'U',  '1'},
            {'V',  '2'},
            {'X',  '3'},
            {'Y',  '1'},
            {'Z',  '3'}
        };
        private static readonly Dictionary<char, char> DIGIT_TO_CHAR = new Dictionary<char, char>()
        {
            {'1', 'A'},
            {'2', 'B'},
            {'3', 'C'},
            {'4', 'D'},
            {'5', 'L'},
            {'6', 'M'},
            {'7', 'N'},
            {'8', 'R'}
        };
		#endregion

		#region Public Features
        /// <summary>
        /// Computes the Russell Index of a word encoded as digits.
        /// </summary>
        /// <param name="word">The word to transform.</param>
        /// <returns>The Russell Index value.</returns>
		public static string Encode(string word)
        {
            word = word.ToAscii().ToUpper().Trim();
            word = word.Replace("GH", "");

            word = word.TrimEnd('S').TrimEnd('Z');

            string result = "";

            for (int i = 0; i < word.Length; i++)
            {
                if (UC_SET.Contains(word[i]))
                {
                    result += word[i];
                }
            }

            string sdx = "";
            for (int i = 0; i < result.Length; i++)
            {
                sdx += CHAR_TO_DIGIT[result[i]];
            }

            int posOne = sdx.IndexOf('1');

            if (posOne >= 0)
            {
                result = sdx.Substring(0, posOne + 1);

                for (int i = posOne + 1; i < sdx.Length; i++)
                {
                    if (sdx[i] == '1')
                    {
                        continue;
                    }
                    else
                    {
                        result += sdx[i];
                    }
                }
            }

            result = result.DeleteConsecutiveRepeats();

            return result;
        }

        /// <summary>
        /// Computes the Russell Index of a word (alphabetic output).
        /// </summary>
        /// <param name="word">The word to transform.</param>
        /// <returns>The Russell Index value as an alphabetic string.</returns>
        public static string EncodeAlpha(string word)
        {
            string encoded = Encode(word);

            string result = "";

            for (int i = 0; i < encoded.Length; i++)
            {
                char c = encoded[i];
                char v = DIGIT_TO_CHAR[c];

                result += v;
            }

            return result;
        }
        #endregion
	}
}
