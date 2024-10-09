/***********************************************************************************
* File:         TestLevenshtein.cs                                                 *
* Contents:     Class TestLevenshtein                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-09 13:14                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using Alison.Library;
using NUnit.Framework;

namespace Alison.Tests
{
	[TestFixture]
	public class TestLevenshtein
	{
		[Test]
		public void ComputingLevenshteinDistances_Succeeds()
		{
			(string Word1, string Word2, int ExpectedDistance)[] data = new (string Word1, string Word2, int ExpectedDistance)[]
			{
				("", "", 0),
				("a", "", 1),
				("", "a", 1),
				("abc", "", 3),
				("", "abc", 3),
				("", "", 0),
				("a", "a", 0),
				("abc", "abc", 0),
				("", "a", 1),
				("a", "ab", 1),
				("b", "ab", 1),
				("ac", "abc", 1),
				("abcdefg", "xabxcdxxefxgx", 6),
				("a", "", 1),
				("ab", "a", 1),
				("ab", "b", 1),
				("abc", "ac", 1),
				("xabxcdxxefxgx", "abcdefg", 6),
				("a", "b", 1),
				("ab", "ac", 1),
				("ac", "bc", 1),
				("abc", "axc", 1),
				("xabxcdxxefxgx", "1ab2cd34ef5g6", 6),
				("example", "samples", 3),
				("sturgeon", "urgently", 6),
				("levenshtein", "frankenstein", 6),
				("distance", "difference", 5),
				("java was neat", "scala is great", 7),
			};

			for (int i = 0; i < data.Length; i++)
			{
				string word1 = data[i].Word1;
				string word2 = data[i].Word2;
				int distance = StringMetrics.LevenshteinDistance(word1, word2);

				Assert.That(distance == data[i].ExpectedDistance);
			}
		}
	}
}
