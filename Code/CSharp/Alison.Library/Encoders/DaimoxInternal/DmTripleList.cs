/***********************************************************************************
* File:         DmTripleList.cs                                                    *
* Contents:     Class DmTripleList                                                 *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-11-30 0047                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Collections.Generic;
using Alison.Library.Encoders.DaimoxIntern;

namespace Alison.Library.DaimoxIntern
{
	internal class DmTripleList: List<DmTriple>
	{
		#region Construction
		public DmTripleList(): base() {}

		public DmTripleList(params DmTriple[] triples)
		{
			this.AddRange(triples);
		}

		public DmTripleList(int start, int beforeVowel, int other)
		{
			this.Add(new DmTriple(start, beforeVowel, other));
		}
		#endregion
	}
}
