using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alison.Library;
using Alison.Library.StringMetricsInternal;
using NUnit.Framework;

namespace Alison.Tests
{
	[TestFixture]
	public class TestCosineSimilarity
	{
		[Test]
		public void ComputationOfSimilarity_IdenticalWords_Succeeds()
		{
			string word1 = "Nelson";
			string word2 = "nelson";

			double similarity = StringMetrics.CosineSimilarity(word1, word2);

			Assert.That(Math.Abs(similarity - 1.0) <= 1e-4);
		}

		[Test]
		public void ComputationOfSimilarity_OneWordIsEmpty_Succeeds()
		{
			string word1 = "Nelson";
			string word2 = "";

			double similarity = StringMetrics.CosineSimilarity(word1, word2);

			Assert.That(Math.Abs(similarity) <= 1e-4);
		}

		[Test]
		public void ComputationOfSimilarity_SimilarWords_Succeeds()
		{
			string word1 = "Nelson";
			string word2 = "neilsen";

			double similarity = StringMetrics.CosineSimilarity(word1, word2);

			Assert.That(similarity >= 0.5);
		}

		[Test]
		public void ComputationOfSimilarity_UnsimilarWords_Succeeds()
		{
			string word1 = "Nelson";
			string word2 = "Schimpanse";

			double similarity = StringMetrics.CosineSimilarity(word1, word2);

			Assert.That(similarity < 0.1);
		}

		[Test]
		public void ComputationOfMostSimilarWord_Succeeds()
		{
			string[] words = 
			{
				"global", "glory", "globe", "globally", "glorious", "gloves", "globalization", "glow", "glorified", "glowing", 
				"glove", "gloom", "glorify", "gloomy", "gloria", "gloucester", "gloss", "glories", "globalized", "glossy", "glowed", 
				"globes", "glover", "glows", "gloomily", "glorifying", "glorification", "glossary", "globalisation"
			};

			string token = "globus";

			var result = Cosine.MostSimilar(words.ToList(), token);

			double similarity = StringMetrics.CosineSimilarity(token, result.Word);

			Console.WriteLine($"{result.Word}: {result.Index} ({similarity})");
		}

		[Test]
		public void ComputationOfSortedListBySimilarity_Succeeds()
		{
			string[] words = 
			{
				"global", "glory", "globe", "globally", "glorious", "gloves", "globalization", "glow", "glorified", "glowing", 
				"glove", "gloom", "glorify", "gloomy", "gloria", "gloucester", "gloss", "glories", "globalized", "glossy", "glowed", 
				"globes", "glover", "glows", "gloomily", "glorifying", "glorification", "glossary", "globalisation", "Africa", "map", "appartment", "boggling"
			};

			string token = "globus";

			var result = Cosine.SortStringsByDistanceFromToken(words.ToList(), token);

			foreach (var item in result)
			{
				Console.WriteLine($"{item.Word}: {item.Similarity} ");
			}
		}
	}
}
