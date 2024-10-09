/***********************************************************************************
* File:         SoundexCompletionMode.cs                                           *
* Contents:     Enum SoundexCompletionMode                                         *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-09 11:42                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Alison.Library.Enumerations
{
	/// <summary>
	/// Defines the mode in which names will be reduced (stripped of vowels) if the result is too short
	/// </summary>
	public enum SoundexCompletionMode
	{
		/// <summary>
		/// Reduced name is left as is if too short
		/// </summary>
		AdmitShort		= 0,

		/// <summary>
		/// Reduced name will be padded with zeroes
		/// </summary>
		PadWithZeroes	= 1
	}
}
