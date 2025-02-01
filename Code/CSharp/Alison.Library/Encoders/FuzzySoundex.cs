/***********************************************************************************
* File:         FuzzySoundex.cs                                                    *
* Contents:     Class FuzzySoundex                                                 *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-02-01 15:29                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;
using Alison.Library.Tools;
using ET = Alison.Library.Tools.EncoderTools;

namespace Alison.Library.Encoders
{
	public static class FuzzySoundex
	{
		public static int MaxLength	{get;set;}	= 5;

		private static Dictionary<char, char> TRANSLATE = new Dictionary<char, char>
		{
			['A'] = '0',
			['B'] = '1',
			['C'] = '9',
			['D'] = '3',
			['E'] = '0',
			['F'] = '1',
			['G'] = '7',
			['H'] = '-',
			['I'] = '0',
			['J'] = '7',
			['K'] = '7',
			['L'] = '4',
			['M'] = '5',
			['N'] = '5',
			['O'] = '0',
			['P'] = '1',
			['Q'] = '7',
			['R'] = '6',
			['S'] = '9',
			['T'] = '3',
			['U'] = '0',
			['V'] = '1',
			['W'] = '-',
			['X'] = '7',
			['Y'] = '-',
			['Z'] = '9'
		};

		private static string Translate(string word)
		{
			if (String.IsNullOrEmpty(word))
			{
				return word;
			}

			string result = "";

			for (int i = 0;  i < word.Length; i++)
			{
				result += TRANSLATE[word[i]];
			}

			return result;
		}

		public static string Encode(string word)
		{
			word	= word.ToAscii();
			word	= word.ToUpper();

			string result = "0";

			if (String.IsNullOrEmpty(word))
			{
				return result;
			}

			string start = word[..2];

			if (ET.IsIn(start, "CS", "CZ", "TS", "TZ"))
			{
				word = "SS" + word[^1..];
			}
			else if (start == "GN")
			{
				word = "NN" + word[^1..];
			}
			else if (ET.IsIn(start, "HR", "WR"))
			{
				word = "RR" + word[^1..];
			}
			else if (start == "HW")
			{
				word = "WW" + word[^1..];
			}
			else if (ET.IsIn(start, "KN", "NG"))
			{
				word = "NN" + word[^1..];
			}

			string end = word[^2..];

			if (end == "CH")
			{
				word = word[2..] + "KK";
			}
			else if (end == "NT")
			{
				word = word[2..] + "TT";
			}
			else if (end == "RT")
			{
				word = word[2..] + "RR";
			}
			else if (word[2..] == "RDT")
			{
				word = word[3..] + "RR";
			}

			word = word.Replace("CA", "KA");
			word = word.Replace("CC", "KK");
			word = word.Replace("CK", "KK");
			word = word.Replace("CE", "SE");
			word = word.Replace("CHL", "KL");
			word = word.Replace("CL", "KL");
			word = word.Replace("CHR", "KR");
			word = word.Replace("CR", "KR");
			word = word.Replace("CI", "SI");
			word = word.Replace("CO", "KO");
			word = word.Replace("CU", "KU");
			word = word.Replace("CY", "SY");
			word = word.Replace("DG", "GG");
			word = word.Replace("GH", "HH");
			word = word.Replace("MAC", "MK");
			word = word.Replace("MC", "MK");
			word = word.Replace("NST", "NSS");
			word = word.Replace("PF", "FF");
			word = word.Replace("PH", "FF");
			word = word.Replace("SCH", "SSS");
			word = word.Replace("TIO", "SIO");
			word = word.Replace("TIA", "SIO");
			word = word.Replace("TCH", "CHH");

			result = Translate(word);

			result = result.Replace("-", "");

			result = result.DeleteConsecutiveRepeats();

			if (ET.IsIn(word[0], 'H', 'W', 'Y'))
			{
				result = word[0] + result;
			}
			else
			{
				result = word[0] + result[1..];
			}

			result = result.Replace("0", "");

			if (result.Length > MaxLength)
			{
				result = result[..MaxLength];
			}
			else if (result.Length < MaxLength)
			{
				result += new string('0', MaxLength - result.Length);
			}

			return result;
		}
	}
}
