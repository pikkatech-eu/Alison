using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
