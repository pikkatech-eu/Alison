/***********************************************************************************
* File:         StringLengthComparer.cs                                            *
* Contents:     Class StringLengthComparer                                         *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-11-30 0049                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Collections.Generic;

namespace Alison.Library.Encoders.DaimoxIntern
{
	/// <summary>
	/// String comparer by length.
	/// </summary>
	public class StringLengthComparer: IComparer<string>
	{
		public int Compare(string x, string y)
		{
			if (x.Length < y.Length)
			{
				return 1;
			}
			else if (x.Length > y.Length)
			{
				return -1;
			}
			else
			{
				return -x.CompareTo(y);
			}
		}
	}
}
