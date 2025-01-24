/***********************************************************************************
* File:         NaiveTokenizer.cs                                                  *
* Contents:     Class NaiveTokenizer                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 13:25                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alison.Library.Tools
{
	/// <summary>
	/// Tool to transform a text in English into an array of string tokens.
	/// </summary>
	public static class NaiveTokenizer
	{
		/// <summary>
		/// List of English stopwords.
		/// Source: https://gist.github.com/sebleier/554280 .
		/// </summary>
		private static readonly string[] ENGLISH_STOPWORDS =
		{
			"i",
			"me",
			"my",
			"myself",
			"we",
			"our",
			"ours",
			"ourselves",
			"you",
			"your",
			"yours",
			"yourself",
			"yourselves",
			"he",
			"him",
			"his",
			"himself",
			"she",
			"her",
			"hers",
			"herself",
			"it",
			"its",
			"itself",
			"they",
			"them",
			"their",
			"theirs",
			"themselves",
			"what",
			"which",
			"who",
			"whom",
			"this",
			"that",
			"these",
			"those",
			"am",
			"is",
			"are",
			"was",
			"were",
			"be",
			"been",
			"being",
			"have",
			"has",
			"had",
			"having",
			"do",
			"does",
			"did",
			"doing",
			"a",
			"an",
			"the",
			"and",
			"but",
			"if",
			"or",
			"because",
			"as",
			"until",
			"while",
			"of",
			"at",
			"by",
			"for",
			"with",
			"about",
			"against",
			"between",
			"into",
			"through",
			"during",
			"before",
			"after",
			"above",
			"below",
			"to",
			"from",
			"up",
			"down",
			"in",
			"out",
			"on",
			"off",
			"over",
			"under",
			"again",
			"further",
			"then",
			"once",
			"here",
			"there",
			"when",
			"where",
			"why",
			"how",
			"all",
			"any",
			"both",
			"each",
			"few",
			"more",
			"most",
			"other",
			"some",
			"such",
			"no",
			"nor",
			"not",
			"only",
			"own",
			"same",
			"so",
			"than",
			"too",
			"very",
			"s",
			"t",
			"can",
			"will",
			"just",
			"don",
			"should",
			"now"
		};

		/// <summary>
		/// Tokenizes a string transforming it into an array of tokens.
		/// The tokenization is "naive" in that sense that it does not support subtlelies rendered by modern NLP tokenizers. 
		/// Since it only uses Englisg stopwords, it cannot be used for texts in other languages.
		/// </summary>
		/// <param name="source">The string to tokenize.</param>
		/// <returns>An array of string tokens.</returns>
		public static string[] Tokenize(string source)
		{
			StringBuilder sb = new StringBuilder();

			foreach (char c in source)
			{
				if (Char.IsLetter(c))
				{
					sb.Append(c);
				}
				else if (c == ' ' || c == '\t')
				{
					sb.Append(' ');
				}
			}

			string[] words = sb.ToString().Split(new char[]{'\n', ' '});

			// remove stopwords
			List<string> result = new List<string>();

			foreach (string word in words)
			{
				if (word.Length < 1)
				{
					continue;
				}

				string wordLower = word.ToLower();

				if (!ENGLISH_STOPWORDS.Contains(wordLower))
				{
					result.Add(wordLower);
				}
			}

			return result.ToArray();
		}
	}
}
