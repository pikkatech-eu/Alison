/***********************************************************************************
* File:         NeedlemanWunsch.cs                                                 *
* Contents:     Class NeedlemanWunsch                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-01-29 10:04                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison.Library.StringMeasures
{
	public static class NeedlemanWunsch
	{
		public static int SimilarityScore(string src, string tar)
		{
			int n = src.Length + 1;
			int m = tar.Length + 1;

			int[,] d_mat = new int[n, m];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					d_mat[i, j] = 0;
				}
			}

			for (int i = 0; i < n; i++)
			{
				d_mat[i, 0]	= -i;
			}

			for (int j = 0; j < m; j++)
			{
				d_mat[0, j]	= -j;
			}

			for (int i = 1; i < n; i++)
			{
				for (int j = 1; j < m; j++)
				{
					int match = d_mat[i - 1, j - 1] + Delta(src[i - 1], tar[j - 1]);
					int delete = d_mat[i - 1, j] - 1;
					int insert = d_mat[i, j - 1] - 1;

					d_mat[i, j] = Max3(match, delete, insert);
				}
			}

			return d_mat[d_mat.GetUpperBound(0), d_mat.GetUpperBound(1)];
		}

		private static int Delta(char x, char y)
		{
			return x == y ? 1 : 0;
		}

		private static int Max3(int x, int y, int z)
		{
			return Math.Max(Math.Max(x, y), z);
		}
	}
}
