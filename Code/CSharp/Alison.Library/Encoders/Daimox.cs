/***********************************************************************************
* File:         Daimox.cs                                                          *
* Contents:     Class Daimox                                                       *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-09-24 15:13                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Alison.Library.DaimoxIntern;
using Alison.Library.Encoders.DaimoxIntern;

namespace Alison.Library.Encoders
{
	/// <summary>
	/// Contains methods for the computation of Daitch-Mokotoff Soundex.
	/// Algorithm described, e.g. on https://www.jewishgen.org/InfoFiles/soundex.html .
	/// </summary>
	public static class Daimox
	{
		#region Private static data
		/// <summary>
		/// An instance of string length comparer.
		/// </summary>
		internal static StringLengthComparer Comparer = new StringLengthComparer();

		/// <summary>
		/// String containing all thinkable punctuation signs.
		/// </summary>
		private static readonly string PUNCTUATION = @"'’!?.,;: -–_$%&/()=, @\#~^°§*+`´[]{}0123456789";

		/// <summary>
		/// String containing the vowels.
		/// </summary>
		private static readonly string VOWELS = "AEIOUY";

		/// <summary>
		/// Dictionary of mappings, sorted by string length.
		/// </summary>
		internal static SortedDictionary<string, DmTripleList> MAPPINGS = new SortedDictionary<string, DmTripleList>(Comparer)
		{
			{"SCHTSCH",	new DmTripleList(2,	4,  4)},
			{"ZHDZH",	new DmTripleList(2,	4,	4)},
			{"SHTSH",	new DmTripleList(2,	4,	4)},
			{"TTSCH",	new DmTripleList(4,	4,	4)},
			{"SHTCH",	new DmTripleList(2,	4,	4)},
			{"STSCH",	new DmTripleList(2,	4,	4)},
			{"STCH",	new DmTripleList(2,	4,	4)},
			{"SZCZ",	new DmTripleList(2,	4,	4)},
			{"SZCS",	new DmTripleList(2,	4,	4)},
			{"STSH",	new DmTripleList(2,	4,	4)},
			{"SHCH",	new DmTripleList(2,	4,	4)},
			{"TTSZ",	new DmTripleList(4,	4,	4)},
			{"TTCH",	new DmTripleList(4,	4,	4)},
			{"ZDZH",	new DmTripleList(2,	4,	4)},
			{"STRZ",	new DmTripleList(2,	4,	4)},
			{"STRS",	new DmTripleList(2,	4,	4)},
			{"SCHT",	new DmTripleList(2,	43,	43)},
			{"SCHD",	new DmTripleList(2,	43,	43)},
			{"TSCH",	new DmTripleList(4,	4,	4)},
			{"ZSCH",	new DmTripleList(4,	4,	4)},
			{"DRZ",		new DmTripleList(4,	4,	4)},
			{"DZH",		new DmTripleList(4,	4,	4)},
			{"DRS",		new DmTripleList(4,	4,	4)},
			{"DZS",		new DmTripleList(4,	4,	4)},
			{"TZS",		new DmTripleList(4,	4,	4)},
			{"THS",		new DmTripleList(4,	4,	4)},
			{"CHS",		new DmTripleList(5,	54,	54)},
			{"TSH",		new DmTripleList(4,	4,	4)},
			{"ZDZ",		new DmTripleList(2,	4,	4)},
			{"TSZ",		new DmTripleList(4,	4,	4)},
			{"SHT",		new DmTripleList(2,	43,	43)},
			{"TTZ",		new DmTripleList(4,	4,	4)},
			{"SCH",		new DmTripleList(4,	4,	4)},
			{"TTS",		new DmTripleList(4,	4,	4)},
			{"SZD",		new DmTripleList(2,	43,	43)},
			{"TCH",		new DmTripleList(4,	4,	4)},
			{"SZT",		new DmTripleList(2,	43,	43)},
			{"TRZ",		new DmTripleList(4,	4,	4)},
			{"SHD",		new DmTripleList(2,	43,	43)},
			{"DSH",		new DmTripleList(4,	4,	4)},
			{"CSZ",		new DmTripleList(4,	4,	4)},
			{"TRS",		new DmTripleList(4,	4,	4)},
			{"CZS",		new DmTripleList(4,	4,	4)},
			{"DSZ",		new DmTripleList(4,	4,	4)},
			{"ZHD",		new DmTripleList(2,	43,	43)},
			{"ZSH",		new DmTripleList(4,	4,	4)},
			{"ZH",		new DmTripleList(4,	4,	4)},
			{"OJ",		new DmTripleList(0,	1,	-1)},
			{"OI",		new DmTripleList(0,	1,	-1)},
			{"OY",		new DmTripleList(0,	1,	-1)},
			{"AI",		new DmTripleList(0,	1,	-1)},
			{"PF",		new DmTripleList(7,	7,	7)},
			{"PH",		new DmTripleList(7,	7,	7)},
			{"EI",		new DmTripleList(0,	1,	-1)},
			{"EJ",		new DmTripleList(0,	1,	-1)},
			{"ZD",		new DmTripleList(2,	43,	43)},
			{"IU",		new DmTripleList(1,	-1,	-1)},
			{"EU",		new DmTripleList(1,	1,	-1)},
			{"ZS",		new DmTripleList(4,	4,	4)},
			{"UY",		new DmTripleList(0,	1,	-1)},
			{"MN",		new DmTripleList(66, 66, 66)},
			{"UI",		new DmTripleList(0,	1,	-1)},
			{"UJ",		new DmTripleList(0,	1,	-1)},
			{"UE",		new DmTripleList(0,	-1,	-1)},
			{"EY",		new DmTripleList(0,	1,	-1)},
			{"IA",		new DmTripleList(1,	-1,	-1)},
			{"FB",		new DmTripleList(7,	7,	7)},
			{"NM",		new DmTripleList(66, 66, 66)},
			{"CZ",		new DmTripleList(4,	4,	4)},
			{"CS",		new DmTripleList(4,	4,	4)},
			{"SZ",		new DmTripleList(4,	4,	4)},
			{"KH",		new DmTripleList(5,	5,	5)},
			{"ST",		new DmTripleList(2,	43,	43)},
			{"KS",		new DmTripleList(5,	54,	54)},
			{"SH",		new DmTripleList(4,	4,	4)},
			{"SC",		new DmTripleList(2,	4,	4)},
			{"SD",		new DmTripleList(2,	43,	43)},
			{"DZ",		new DmTripleList(4,	4,	4)},
			{"DT",		new DmTripleList(3,	3,	3)},
			{"DS",		new DmTripleList(4,	4,	4)},
			{"TZ",		new DmTripleList(4,	4,	4)},
			{"TS",		new DmTripleList(4,	4,	4)},
			{"TH",		new DmTripleList(3,	3,	3)},
			{"TC",		new DmTripleList(4,	4,	4)},
			{"AJ",		new DmTripleList(0,	1,	-1)},
			{"AU",		new DmTripleList(0,	7,	-1)},
			{"IO",		new DmTripleList(1,	-1,	-1)},
			{"AY",		new DmTripleList(0,	1,	-1)},
			{"IE",		new DmTripleList(1,	-1,	-1)},
			{"CH",		new DmTripleList((5, 5, 5), (4, 4, 4))},
			{"CK",		new DmTripleList((5, 5, 5), (45, 45, 45))},
			{"RZ",		new DmTripleList((94, 94, 94), (4, 4, 4))},
			{"RS",		new DmTripleList((94, 94, 94), (4, 4, 4))},
			{"D",		new DmTripleList(3,	3,	3)},
			{"H",		new DmTripleList(5,	5,	-1)},
			{"L",		new DmTripleList(8,	8,	8)},
			{"P",		new DmTripleList(7,	7,	7)},
			{"T",		new DmTripleList(3,	3,	3)},
			{"X",		new DmTripleList(5,	54,	54)},
			{"Y",		new DmTripleList(1,	-1,	-1)},
			{"G",		new DmTripleList(5,	5,	5)},
			{"K",		new DmTripleList(5,	5,	5)},
			{"O",		new DmTripleList(0,	-1,	-1)},
			{"S",		new DmTripleList(4,	4,	4)},
			{"W",		new DmTripleList(7,	7,	7)},
			{"B",		new DmTripleList(7,	7,	7)},
			{"F",		new DmTripleList(7,	7,	7)},
			{"N",		new DmTripleList(6,	6,	6)},
			{"R",		new DmTripleList(9,	9,	9)},
			{"U",		new DmTripleList(0,	-1,	-1)},
			{"V",		new DmTripleList(7,	7,	7)},
			{"Z",		new DmTripleList(4,	4,	4)},
			{"A",		new DmTripleList(0,	-1,	-1)},
			{"E",		new DmTripleList(0,	-1,	-1)},
			{"I",		new DmTripleList(0,	-1,	-1)},
			{"M",		new DmTripleList(6,	6,	6)},
			{"Q",		new DmTripleList(5,	5,	5)},
			{"C",		new DmTripleList((5, 5, 5),	(4, 4, 4))},
			{"J",		new DmTripleList((1, -1, -1), (4, 4, 4))},
		};
		#endregion
		
		public static string Encode(string word)
		{
			if (String.IsNullOrEmpty(word))
			{
				return "000000";
			}

			// 1. Working copy of the word, normalized, put into upper case and remove all punctuation and possible whitespaces (R7).
			string work = word.ToAscii();
			work = work.ToUpper();
			work = Regex.Replace(work, @"\s*", "");

			for (int i = 0; i < PUNCTUATION.Length; i++)
			{
				work = work.Replace(PUNCTUATION.Substring(i, 1), "");
			}

			work = work.Trim();

			// 2. Check that the work instance only contains charactes from [A-Z]
			string temp = "";

			foreach (char c in work)
			{
				if (c >= 'A' && c <= 'Z')
				{
					temp += c;
				}
			}

			work = temp;

			if (work.Any(c => c < 'A' || c > 'Z'))
			{
				throw new ArgumentException("The word contains non-ASCII characters.");
			}

			// 3. Segmentize the word.
			string[] chunks = Daimox.Segmentize(work);

			Codem codem = new Codem();

			for (int i = 0; i < chunks.Length; i ++)
			{
				string chunk = chunks[i];

				if (!MAPPINGS.ContainsKey(chunk))
				{
					continue;
				}

				DmTripleList triples = MAPPINGS[chunk];

				int[] codes = triples.Select(t => Daimox.GetCode(t, i == 0, Daimox.IsNextVowel(i, chunks))).ToArray();
				List<string> codeStrings = codes.Select(c => Daimox.GetCodeString(c)).ToList();

				codem ^= codeStrings;
			}

			codem = codem.Reduce();

			codem = Daimox.Recover(codem);

			for (int i = 0; i < codem.Count; i++)
			{
				if (codem[i].Length < 6)
				{
					codem[i] += new string('0', 6 - codem[i].Length);
				}
				else if (codem[i].Length > 6)
				{
					codem[i] = codem[i].Substring(0, 6);
				}
			}

			codem = Codem.RemoveDuplicates(codem);

			return codem.ToString();
		}

		#region Private auxiliary
		/// <summary>
		/// Segmentizes a word according to rules formulated by Daitch & Mokotoff (https://www.jewishgen.org/InfoFiles/soundex.html).
		/// Rules:
		/// R3. The letters A, E, I, O, U, J, and Y are always coded at the beginning of a name as in Alpert 087930.  
		///     In any other situation, they are ignored except when two of them form a pair and the pair comes before a vowel, as in Breuer 791900 but not Freud.
		/// R4. The letter H is coded at the beginning of a name, as in Haber 579000, or preceding a vowel, as in Manheim 665600, otherwise it is not coded.
		/// R5. When adjacent sounds can combine to form a larger sound, they are given the code number of the larger sound.  Mintz which is not coded MIN-T-Z but MIN-TZ 664000.
		/// R6. When adjacent letters have the same code number, they are coded as one sound, as in TOPF, which is not coded TO-P-F 377000 but TO-PF 370000.  
		///     Exceptions to this rule are the letter combinations MN and NM, whose letters are coded separately, as in Kleinman, which is coded 586660 not 586600.
		/// R7. When a surname consists or more than one word, it is coded as if one word, such as "Ben Aron", which is treated as "Benaron".
		/// R8. Several letter and letter combinations pose the problem that they may sound in one of two ways.  
		///     The letter and letter combinations CH, CK, C, J, and RS are assigned two possible code numbers.
		/// TODO: make private after testing.
		/// </summary>
		/// <param name="word">The word to segmentize.</param>
		/// <returns>An array of chunks, elements of the word by D&M.</returns>
		public static string[] Segmentize(string word)
		{
			List<string> chunks = new List<string>();

			string work = word;

			while (work.Length > 0)
			{
				foreach (string key in MAPPINGS.Keys)
				{
					if (work.StartsWith(key))
					{
						chunks.Add(key);

						work = work.Substring(key.Length);

						break;
					}
				}				
			}

			return chunks.ToArray();
		}

		/// <summary>
		/// Gets the code of a triple depending of its position in the word.
		/// </summary>
		/// <param name="triple">The triple to get the code from.</param>
		/// <param name="isStart">True if the triple is in the beginning of the word.</param>
		/// <param name="isNextVowel">True if the next character in the word after the triple is a vowel.</param>
		/// <returns>The integer code.</returns>
		private static int GetCode(DmTriple triple, bool isStart,  bool isNextVowel)
		{
			if (isStart)
			{
				return triple.Start;
			}
			else if (isNextVowel)
			{
				return triple.Before;
			}
			else
			{
				return triple.Other;
			}
		}

		/// <summary>
		/// Gets the provisional string code of an integer value.
		/// </summary>
		/// <param name="code">The integer code value.</param>
		/// <returns>The provisional code string, used to reduce the strings.</returns>
		private static string GetCodeString(int code)
		{
			switch (code)
			{
				case -1:
					return "-";

				case 43:
					return "%";

				case 45:
					return "~";

				case 54:
					return "$";

				case 66:
					return "#";

				case 94:
					return "§";

				default:
					return code.ToString();
			}
		}

		/// <summary>
		/// Recovers the true value of a code from its provisional string value (after reduction).
		/// </summary>
		/// <param name="codeString">The code string to recover.</param>
		/// <returns>The true code string.</returns>
		private static string Recover(string codeString)
		{
			string result = "";

			for (int i = 0; i < codeString.Length; i++)
			{
				string s = codeString.Substring(i, 1);

				switch (s)
				{
					case "%":
						result += "43";
						break;

					case "$":
						result += "54";
						break;

					case "~":
						result += "45";
						break;

					case "#":
						result += "66";
						break;

					case "§":
						result += "94";
						break;

					case "-":
						break;

					default:
						result += s;
						break;
				}
			}

			return result;
		}

		/// <summary>
		/// Recovers the strings of a codem.
		/// </summary>
		/// <param name="codem">The codem to recover.</param>
		/// <returns>The codem with recovered strings.</returns>
		private static Codem Recover(Codem codem)
		{
			Codem result = new Codem();

			foreach (string code in codem)
			{
				string recovered = Daimox.Recover(code);

				result.Add(recovered);
			}

			return result;
		}

		/// <summary>
		/// Determines if the next character after a chunk begins with a vowel.
		/// </summary>
		/// <param name="i">The number of the chunk in the chunk array.</param>
		/// <param name="chunks">The array of consecutive chunks.</param>
		/// <returns>True if the next cjharcter is a vowel.</returns>
		private static bool IsNextVowel(int i, string[] chunks)
		{
			if (i < chunks.Length - 1)
			{
				return VOWELS.Contains(chunks[i + 1][0]);
			}
			else
			{
				return false;
			}
		}
		#endregion
	}
}
