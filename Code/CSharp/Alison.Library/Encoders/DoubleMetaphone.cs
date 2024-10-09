/***********************************************************************************
* File:         DoubleMetaphone.cs                                                 *
* Contents:     Class DoubleMetaphone                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-09 15:21                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using DMI = Alison.Library.Encoders.DoubleMetaphoneInternal;

namespace Alison.Library.Encoders
{
	public static class DoubleMetaphone
	{
		/// <summary>
		/// Wraps the functionality of the implementation by Adam Nelson (anelson@nullpointer.net).
		/// </summary>
		/// <param name="word">The word to encode.</param>
		/// <returns>The encoded word.</returns>
		public static string Encode(string word)
		{
            DMI.DoubleMetaphoneInternal dm = new DMI.DoubleMetaphoneInternal();
			dm.BuildKeys(word);

			if (dm.PrimaryCode == dm.SecondaryCode || dm.SecondaryCode == null)
			{
				return dm.PrimaryCode;
			}
			else
			{
				return $"{dm.PrimaryCode},{dm.SecondaryCode}";
			}
		}
	}
}
