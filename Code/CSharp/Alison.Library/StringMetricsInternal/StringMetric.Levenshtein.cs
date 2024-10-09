/***********************************************************************************
* File:         StringMetric.Levenshtein.cs                                        *
* Contents:     Class Levenshtein                                                  *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-09 12:50                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;

namespace Alison.Library.StringMetricsInternal
{
	internal static class Levenshtein
	{
		#region Internal classes
		public class Comparer: IComparer<string>
		{
			private string _token = "";

			public Comparer(string token)
			{
				this._token = token;
			}

			public int Compare(string x, string y)
			{
				int dX = Distance(x, this._token);
				int dY = Distance(y, this._token);

				if (dX < dY)
				{
					return -1;
				}
				else if (dX > dY)
				{
					return 1;
				}
				else
				{
					return 0;
				}
			}
		}
		#endregion

		#region Distance
		/// <summary>
		///     Calculate the difference between 2 strings using the Levenshtein distance algorithm
		///     Inspired by: https://gist.github.com/Davidblkx/e12ab0bb2aff7fd8072632b396538560 (David Pires).
		/// </summary>
		/// <param name="source1">First string</param>
		/// <param name="source2">Second string</param>
		/// <returns>
		///		0, if both arguments are null,
		///		Int32.MaxValue if one of the arguments is null and the other one not;
		///		Levenshtein distance if both are not null.
		/// </returns>
		internal static int Distance(string source1, string source2)
		{
			if (source1 == null && source2 == null)
			{
				return 0;
			}

			if (source1 == null || source2 == null)
			{
				return Int32.MaxValue;
			}

			int l1 = source1.Length;
			int l2 = source2.Length;

			int[,] matrix = new int[l1 + 1, l2 + 1];

			// First calculation, if one entry is empty return full length
			if (l1 == 0)
			{
				return l2;
			}

			if (l2 == 0)
			{
				return l1;
			}

			// Initialization of matrix with row size source1Length and columns size source2Length
			for (int i = 0; i <= l1; matrix[i, 0] = i++) 
			{ 
			}

			for (int j = 0; j <= l2; matrix[0, j] = j++) 
			{ 
			}

			// Calculate rows and collumns distances
			for (int i = 1; i <= l1; i++)
			{
				for (int j = 1; j <= l2; j++)
				{
					int cost = (source2[j - 1] == source1[i - 1]) ? 0 : 1;

					matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1, matrix[i, j - 1] + 1), matrix[i - 1, j - 1] + cost);
				}
			}

			return matrix[l1, l2];
		}
		#endregion

		#region Internal Searching
		/// <summary>
		/// Finds the element in a string list having the minimal Levenshtein distance from the token.
		/// </summary>
		/// <param name="items">The list of strings.</param>
		/// <param name="token">The token string.</param>
		/// <returns>The index of the list item Levenshtein-nearest to the token.</returns>
		internal static int NextElement(List<string> items, string token)
		{
			int index = -1;
			int distance = Int32.MaxValue;

			for (int i = 0; i < items.Count; i++)
			{
				int d = Distance(items[i], token);

				if (d < distance)
				{
					index = i;
					distance = d;
				}
			}

			return index;
		}
		#endregion

		#region Internal Sorting
		internal static List<string> SortStringsByDistanceFromToken(List<string> items, string token)
		{
			Comparer comparer = new Comparer(token);
			items.Sort(comparer);

			return items;
		}

		internal static List<int> SortByDistanceFromToken(List<string> items, string token)
		{
			List<string> temp = new List<string>(items);

			List<int> result = new List<int>();

			List<string> sorted = SortStringsByDistanceFromToken(items, token);

			foreach (string s in sorted)
			{
				int index = temp.IndexOf(s);
				result.Add(index);
			}

			return result;
		}
		#endregion
	}
}
