/***********************************************************************************
* File:         Program.cs                                                         *
* Contents:     Class Program                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-01-29 10:27                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Agadir.Library.Encoders;
using Agadir.Library.StringMeasures;

using Agadir.Library.Tools;

namespace Agadir.Tests
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string source = "Rio de janeiro ciudad del sol";
			string result = Triplex.Encode(source);

			Console.WriteLine(result);
		}

		private static void TestFuzzySoundex()
		{
			string[] words = {"Christopher", "Niall", "Smith", "Schmidt", "Müller", "Zimmermann" };
			string[] codes = {"K6931", "N4000", "55300", "55300", "657", "86766"};

			for (int i = 0; i < words.Length; i++)
			{
				string code = FuzzySoundex.Encode(words[i]);
				
				Console.WriteLine($"{words[i]} => {code}");
			}
		}

		private static void TestCologne()
		{
			string[] words = {"Christopher", "Niall", "Smith", "Schmidt", "Müller", "Zimmermann" };
			string[] codes = {"478237", "65", "862", "862", "657", "86766"};

			for (int i = 0; i < words.Length; i++)
			{
				string code = ColognePhonetics.Encode(words[i]);

				Console.WriteLine($"{words[i]} => {code}");
			}
		}


		private static void TestNeedlemannWunsch()
		{
			string word1 = "Neil";
			string word2 = "Niall";

			int score = NeedlemanWunsch.SimilarityScore(word1, word2);

			Console.WriteLine($"NW score for {word1} and {word2} = {score}");

			double sim = NeedlemanWunsch.Similarity(word1, word2);
		}

		private static void TestDaimokDistance()
		{
			string word1 = "Halberstadt";
			string word2 = "Holubica";

			int d = DaitchMokotoff.Distance(word1, word2);
		}

		private static void TestDaimokLevenstheinDistance()
		{
			string word1 = "Halberstadt";
			string word2 = "Holubica";

			int d = DaitchMokotoff.LevenshteinDistance(word1, word2);
		}

		private static void TestNaiveTokenizer()
		{
			string source = "The Boeing Model 247 is an early American airliner, and one of the first such aircraft to incorporate advances such as all-metal (anodized aluminum) semimonocoque construction, a fully cantilevered wing, and retractable landing gear.[2][3] Other advanced features included control surface trim tabs, an autopilot and de-icing boots for the wings and tailplane.[4] The 247 first flew on February 8, 1933, and entered service later that year.";

			string[] zokens = NaiveTokenizer.Tokenize(source);
		}

		private static void TestRusselIndex()
		{
			string[] words = { "Haas", "Christopher", "Niall", "Smith", "Schmidt" };
			string[] results = { "1", "3813428", "715", "3614", "3614" };

			for (int i = 0; i < words.Length; i++)
			{
				string encoded = Russell.Encode(words[i]);
				Console.WriteLine($"{words[i]} -> {encoded}");
			}
		}
	}
}
