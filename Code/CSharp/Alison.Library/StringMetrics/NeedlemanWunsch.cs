/***********************************************************************************
* File:         NeedlemanWunsch.cs                                                 *
* Contents:     Class NeedlemanWunsch                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-01-29 10:04                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;

namespace Alison.Library.StringMeasures
{
	/// <summary>
	/// Contains routines connected with the Needleman-Wunsch algorithm.
	/// Solution inspired by Abydos library: https://pypi.org/project/abydos/
	/// </summary>
	public static class NeedlemanWunsch
	{
		/// <summary>
		/// The Needleman-Wunsch score of two strings (https://en.wikipedia.org/wiki/Needleman%E2%80%93Wunsch_algorithm).
		/// </summary>
		/// <param name="source">Source string for comparison.</param>
		/// <param name="target">Target string for comparison.</param>
		/// <returns>The value of Needleman-Wunsch score.</returns>
		public static int SimilarityScore(string source, string target)
		{
			int n = source.Length + 1;
			int m = target.Length + 1;

			int[,] matrix = new int[n, m];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					matrix[i, j] = 0;
				}
			}

			for (int i = 0; i < n; i++)
			{
				matrix[i, 0]	= -i;
			}

			for (int j = 0; j < m; j++)
			{
				matrix[0, j]	= -j;
			}

			for (int i = 1; i < n; i++)
			{
				for (int j = 1; j < m; j++)
				{
					int match = matrix[i - 1, j - 1] + Delta(source[i - 1], target[j - 1]);
					int delete = matrix[i - 1, j] - 1;
					int insert = matrix[i, j - 1] - 1;

					matrix[i, j] = Max3(match, delete, insert);
				}
			}

			return matrix[matrix.GetUpperBound(0), matrix.GetUpperBound(1)];
		}

		/// <summary>
		/// The normalized Needleman-Wunsch score of two strings.
		/// </summary>
		/// <param name="source">Source string for comparison.</param>
		/// <param name="target">Target string for comparison.</param>
		/// <returns>Normalized Needleman-Wunsch score.</returns>
		public static double Similarity(string source, string target)
		{
			if (source == target)
			{
				return 1.0;
			}

			int score = SimilarityScore(source, target);
			return (double)score / Math.Sqrt(source.Length * target.Length);
		}

		/// <summary>
		/// Calculates the addition price of two characters.
		/// </summary>
		/// <param name="x">The first character.</param>
		/// <param name="y">The second character.</param>
		/// <returns>1 if the characters are equal, otherwise 0.</returns>
		private static int Delta(char x, char y)
		{
			return x == y ? 1 : 0;
		}

		/// <summary>
		/// Maximum of three integer values.
		/// </summary>
		/// <param name="x">The first number.</param>
		/// <param name="y">The second number.</param>
		/// <param name="z">The third number.</param>
		/// <returns>The maximum of those numbers.</returns>
		private static int Max3(int x, int y, int z)
		{
			return Math.Max(Math.Max(x, y), z);
		}
	}
}
