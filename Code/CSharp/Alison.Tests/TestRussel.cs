/***********************************************************************************
* File:         TestRussel.cs                                                      *
* Contents:     Class TestRussel                                                   *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-08 20:01                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Alison.Library.Encoders;
using NUnit.Framework;

namespace Alison.Tests
{
	/// <summary>
	/// Russell index tests.
	/// Data from https://github.com/chrislit/abydos/blob/master/tests/phonetic/test_phonetic_russell_index.py .
	/// </summary>
	[TestFixture]
	public class TestRussel
	{
		[Test]
		public void Encoding_DigitOutput_Succeds()
		{
			string[] words =
			{
				"", 
				"H", 
				"Hoppa",
				"Hopley", 
				"Highfield",
				"Wright", 
				"Carter", 
				"Hopf", 
				"Hay", 
				"Haas", 
				"Meyers", 
				"Myers", 
				"Meyer",
				"Myer", 
				"Mack", 
				"Knack"
			};

			string[] encodings =
			{
				"",
				"",
				"12",
				"125",
				"1254",
				"814",
				"31848",
				"12",
				"1",
				"1",
				"618",
				"618",
				"618",
				"618",
				"613",
				"3713"
			};

			for (int i = 0; i < words.Length; i++)
			{
				string word = words[i];
				string encoded = Russell.Encode(word);

				Assert.That(encoded == encodings[i]);
			}
		}

		[Test]
		public void Encoding_StringOutput_Succeds()
		{
			string[] words =
			{
				"", 
				"H", 
				"Hoppa",
				"Hopley", 
				"Highfield",
				"Wright", 
				"Carter", 
				"Hopf", 
				"Hay", 
				"Haas", 
				"Meyers", 
				"Myers", 
				"Meyer",
				"Myer", 
				"Mack", 
				"Knack"
			};

			string [] alphaEncodings =
			{
				"",
				"",
				"AB",
				"ABL",
				"ABLD",
				"RAD",
				"CARDR",
				"AB",
				"A",
				"A",
				"MAR",
				"MAR",
				"MAR",
				"MAR",
				"MAC",
				"CNAC",
			};
			
			for (int i = 0; i < words.Length; i++)
			{
				string word = words[i];
				string encoded = Russell.EncodeAlpha(word);

				Assert.That(encoded == alphaEncodings[i]);
			}
		}
	}
}
