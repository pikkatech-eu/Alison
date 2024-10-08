/***********************************************************************************
* File:         TestSoundex.cs                                                     *
* Contents:     Class TestSoundex                                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-08 20:38                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Alison.Library.Encoders;
using Alison.Library.Enumerations;
using NUnit.Framework;

namespace Alison.Tests
{
	[TestFixture]
	public class TestSoundex
	{
		[Test]
		public void SoundexEncoding_Succeeds()
		{
			(string Word, string Soundex)[] data = new (string Word, string Soundex)[]
			{
				("Euler", "E460"),
				("Gauss", "G200"),
				("Hilbert", "H416"),
				("Knuth", "K530"),
				("Lloyd", "L300"),
				("Lukasieicz", "L222"),
				("Ellery", "E460"),
				("Ghosh", "G200"),
				("Heilbronn", "H416"),
				("Kant", "K530"),
				("Ladd", "L300"),
				("Lissajous", "L222"),
				("Rogers", "R262"),
				("Rodgers", "R326"),
				("Htacky", "H320"),
				("Atacky", "A320"),
				("Schmit", "S530"),
				("Schneider", "S536"),
				("Pfister", "P236"),
				("Ashcroft", "A261"),
				("Asicroft", "A226"),
				("Robert", "R163"),
				("Rupert", "R163"),
				("Rubin", "R150"),
				("Tymczak", "T522"),
				("Peters", "P362"),
				("Peterson", "P362"),
				("Moskowitz", "M232"),
				("Moskovitz", "M213"),
				("Auerbach", "A612"),
				("Uhrbach", "U612"),
				("Jackson", "J250"),
				("Jackson-Jackson", "J252"),
			};

			// Soundex.SoundexCompletionMode = SoundexCompletionMode.PadWithZeroes;

			for (int i = 0; i < data.Length; i++)
			{
				string word = data[i].Word;
				string encoding = KnuthSoundex.Encode(word);

				Assert.That(encoding == data[i].Soundex);
			}
		}
	}
}
