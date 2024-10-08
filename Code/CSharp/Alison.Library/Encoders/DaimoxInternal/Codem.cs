/***********************************************************************************
* File:         Codem.cs                                                           *
* Contents:     Class Codem                                                        *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2023-12-02 1334                                                    *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Alison.Library.Encoders.DaimoxIntern
{
	/// <summary>
	/// Codem represents a list of D&M codes.
	/// </summary>
	public class Codem: List<string>
	{
		#region Construction
		/// <summary>
		/// Creates a codem containing a single code.
		/// </summary>
		/// <param name="code">The code to initialize with.</param>
		public Codem(string code): base()
		{
			this.Add(code);
		}

		/// <summary>
		/// Creates a codem consisting of a number of codes.
		/// The codes are deep copied.
		/// </summary>
		/// <param name="codes">The codes to initialize with.</param>
		public Codem(List<string> codes): base()
		{
			foreach (string code in codes)
			{
				this.Add(code);
			}
		}

		/// <summary>
		/// Default constructor.
		/// Initializes an empty codem.
		/// </summary>
		public Codem(): base()
		{
		}
		#endregion

		#region Operations
		/// <summary>
		/// Spawns a codem with a list of codes.
		/// If the list consists of a single element, this element will be added to each code of the codem;
		/// if the list contains more than one code, new codes will be creates so that each old code is extended with each code of the list.
		/// </summary>
		/// <example>
		///		The list contains one element.
		///		=============================
		///		codem = ["4", "5"]
		///		codes = ["8"]
		///		result = ["48", "58"]
		///		
		///		The list contains more than one element:
		///		=======================================
		///		codem = ["4", "5"]
		///		codes = ["8", "9"]
		///		result = ["48", "49", "58", "59"]
		/// </example>
		/// <param name="codem">Codem to spawn.</param>
		/// <param name="codes">List of codes to spawn with.</param>
		/// <returns>The codem spawned.</returns>
		public static Codem Spawn(Codem codem, List<string> codes)
		{
			Codem result = null;

			if (codem.Count == 0)
			{
				// Initialization with the first string list
				result = new Codem();

				foreach (string code in codes)
				{
					result.Add(code);
				}
			}
			else
			{
				string[] temp = new string[codem.Count];
				for (int i = 0; i < codem.Count; i++)
				{
					temp[i] = codem[i];
				}

				result = new Codem();

				for (int j = 0; j < temp.Length; j++)
				{
					for (int i = 0; i < codes.Count; i++)
					{
						string code = temp[j] + codes[i];

						result.Add(code);
					}
				}
			}

			return result;
		}

		/// <summary>
		/// The spawn operator.
		/// Added for convenience.
		/// Does the same thing as the Spawn() method.
		/// </summary>
		/// <param name="codem">Codem to spawn.</param>
		/// <param name="codes">List of codes to spawn with.</param>
		/// <returns>The codem spawned.</returns>
		public static Codem operator ^ (Codem codem, List<string> codes)
		{
			return Spawn(codem, codes);
		}

		/// <summary>
		/// The spawn operator with a string argument.
		/// Added for convenience.
		/// Does the same thing as the Spawn() method using a list with one string only.
		/// </summary>
		/// <param name="codem">Codem to spawn.</param>
		/// <param name="code">String to spawn with.</param>
		/// <returns>The codem spawned.</returns>
		public static Codem operator ^ (Codem codem, string code)
		{
			return codem ^ new List<string>{code};
		}

		/// <summary>
		/// Reduction of a codem:
		/// Subsequent equal characters are removed, e.g. "Mann" -> "Man", "Fforde" -> "Forde".
		/// </summary>
		/// <returns>The codem with strings reduced.</returns>
		public Codem Reduce()
		{
			Codem result = new Codem();

			foreach (string code in this)
			{
				string s = code.Substring(0, 1);

				for (int i = 1; i < code.Length; i++)
				{
					if (code[i] != code[i - 1])
					{
						s += code.Substring(i, 1);
					}
				}

				result.Add(s);
			}

			return result;
		}
		#endregion

		#region String representation
		/// <summary>
		/// String representation of the codem.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string result = "[";

			for (int i = 0; i < this.Count; i++)
			{
				result += $"{this[i]}, ";
			}

			result = result.Substring(0, result.Length - 2);

			result += "]";

			return result;
		}
		#endregion

		#region Conversion To Integers
		internal int[] ToIntegerArray()
		{
			return this.Select(t => Int32.Parse(t)).ToArray();
		}
		#endregion
	}
}


