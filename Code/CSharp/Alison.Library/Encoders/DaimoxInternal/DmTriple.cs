/***********************************************************************************
* File:         DmTriple.cs                                                        *
* Contents:     Class DmTriple                                                     *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-11-30 0043                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Alison.Library.Encoders.DaimoxIntern
{
	internal class DmTriple
	{
		#region Fields
		public int Start;
		public int Before;
		public int Other;
		#endregion

		#region Construction
		internal DmTriple(int start, int before, int other)
		{
			this.Start	= start;
			this.Before	= before;
			this.Other	= other;
		}
		#endregion

		#region Implicit operators
		public static implicit operator DmTriple((int start, int before, int other) triple) => new DmTriple(triple.start, triple.before, triple.other);
		#endregion

		#region String Representation
		public override string ToString()
		{
			return $"({this.Start},\t{this.Before},\t{this.Other})";
		}
		#endregion
	}
}
