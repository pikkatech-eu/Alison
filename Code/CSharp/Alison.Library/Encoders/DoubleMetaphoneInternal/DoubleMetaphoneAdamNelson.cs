/***********************************************************************************
* File:         DoubleMetaphoneInternal.cs                                         *
* Contents:     Class DoubleMetaphoneInternal                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-09 14:57                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Text;

namespace Alison.Library.Encoders
{
	/// <summary>
	/// Implements the Double Metaphone phonetic matching algorithm published by Lawrence Phillips in June 2000 C/C++ Users Journal. 
	/// Follows the optimized C# code by Adam Nelson (anelson@nullpointer.net).
	/// </summary>
	internal class DoubleMetaphoneAdamNelson
	{
		#region Purlic static Properties
		/// <summary>
		///		The length of the metaphone keys produced.
		/// </summary>
		public static int KeyLength {get;set;}  = 4;
		#endregion

		#region Private Variables
		/// <summary>
		/// StringBuilders used to construct the keys.
		/// </summary>
		private StringBuilder _primaryKeyBuilder;
		private StringBuilder _alternateKeyBuilder;

		/// <summary>
		/// Actual keys, populated after construction.
		/// </summary>
		private string _primaryKey;
		private string _alternateKey;

		/// <summary>
		/// Variables to track the key length (without having to grab the Length attriibute).
		/// </summary>
		private int _primaryKeyLength;
		private int _alternateKeyLength;

		/// <summary>
		/// Working copy of the word, and the original word.
		/// </summary>
		private string _word;
		private string _originalWord;

		/// <summary>
		/// Current length of the word.
		/// </summary>
		private int _length;

		/// <summary>
		/// The last valid zero-based index into word.
		/// </summary>
		private int _last;

		/// <summary>
		/// Flag indicating if an alternate metaphone key was computed for the word.
		/// </summary>
		private bool _hasAlternate;
		#endregion

		#region Construction
		/// <summary>
		/// Default constructor.
		/// Initializes by computing the keys of an empty string, which are both empty strings.
		/// </summary>
		public DoubleMetaphoneAdamNelson()
		{
			// Leave room at the end for writing a bit beyond the length; keys are chopped at the end anyway.
			this._primaryKeyBuilder = new StringBuilder(KeyLength + 2);
			this._alternateKeyBuilder = new StringBuilder(KeyLength + 2);

			this.ComputeKeys("");
		}

		/// <summary>
		///   Constructs a new DoubleMetaphone object, and initializes it with the metaphone keys for a given word.
		/// </summary>
		/// <param name="word">
		///		Word with which to initialize the object.  Computes the metaphone keys of this word.
		///	</param>
		public DoubleMetaphoneAdamNelson(string word)
		{
			// Leave room at the end for writing a bit beyond the length; keys are chopped at the end anyway.
			this._primaryKeyBuilder = new StringBuilder(KeyLength + 2);
			this._alternateKeyBuilder = new StringBuilder(KeyLength + 2);

			this.ComputeKeys(word);
		}
		#endregion

		#region Public Properties
		/// <summary>
		///		The primary metaphone key for the current word.
		/// </summary>
		public string PrimaryKey
		{
			get
			{
				return this._primaryKey;
			}
		}

		/// <summary>
		///		The alternate metaphone key for the current word, 
		///		or null if the current word does not have an alternate key by Double Metaphone.
		/// </summary>
		public string AlternateKey
		{
			get
			{
				return this._hasAlternate ? this._alternateKey : null;
			}
		}

		/// <summary>
		///		Original word for which the keys were computed.
		///	</summary>
		public string Word
		{
			get
			{
				return this._originalWord;
			}
		}
		#endregion

		#region Static Wrapper
		/// <summary>
		///		Static wrapper around the class, enables computation of metaphone keys without instantiating a class.
		///	</summary>
		/// <param name="word">Word whose metaphone keys are to be computed</param>
		/// <param name="primaryKey">Reference to receive primary metaphone key</param>
		/// <param name="alternateKey">
		///		Reference to receive the alternate metaphone key, or be set to null if the word has no alternate key by double metaphone
		///	</param>
		public static void Encode(string word, out string primaryKey, out string alternateKey)
		{
			DoubleMetaphoneAdamNelson mp = new DoubleMetaphoneAdamNelson(word);

			primaryKey = mp.PrimaryKey;
			alternateKey = mp.AlternateKey;
		}
		#endregion

		#region Private Auxiliary
		/// <summary>
		///		Sets a new current word for the instance, computing the new word's metaphone keys.
		/// </summary>
		/// <param name="word">
		///		New word to set to current word. Discards previous metaphone keys and computes new keys for this word.
		///	</param>
		private void ComputeKeys(string word)
		{
			this._primaryKeyBuilder.Length = 0;
			this._alternateKeyBuilder.Length = 0;

			this._primaryKey = "";
			this._alternateKey = "";

			this._primaryKeyLength = 0;
			this._alternateKeyLength = 0;

			this._hasAlternate = false;

			this._originalWord = word;

			// Copy word to an internal working buffer so it can be modified
			this._word = word;

			this._length = this._word.Length;

			// Compute last valid index into word
			this._last = this._length - 1;

			// Pad with four spaces, so word can be over-indexed without fear of exception.
			this._word = String.Concat(this._word, "     ");

			// Convert to upper case, since metaphone is not case sensitive
			this._word = this._word.ToUpper();

			// Now build the keys
			this.BuildMetaphoneKeys();
		}

		/// <summary>
		///		Internal implementation of double metaphone algorithm.  
		///		Populates m_primaryKey and m_alternateKey. 
		///		Modified copy-past of Phillips' original code (Adam Nelson).
		/// </summary>		
		private void BuildMetaphoneKeys()
		{
			int current = 0;

			if (this._length < 1)
				return;

			//skip these when at start of word
			if (AreStringsAt(0, 2, "GN", "KN", "PN", "WR", "PS"))
				current += 1;

			//Initial 'X' is pronounced 'Z' e.g. 'Xavier'
			if (this._word[0] == 'X')
			{
				AddMetaphoneCharacter("S"); //'Z' maps to 'S'
				current += 1;
			}

			// ==== main loop ====
			while ((this._primaryKeyLength < KeyLength) || (this._alternateKeyLength < KeyLength))
			{
				if (current >= this._length)
					break;

				switch (this._word[current])
				{
					case 'A':
					case 'E':
					case 'I':
					case 'O':
					case 'U':
					case 'Y':
						if (current == 0)
							//all init vowels now map to 'A'
							AddMetaphoneCharacter("A");
						current += 1;
						break;

					case 'B':

						//"-mb", e.g", "dumb", already skipped over...
						AddMetaphoneCharacter("P");

						if (this._word[current + 1] == 'B')
							current += 2;
						else
							current += 1;
						break;

					case 'Ç':
						AddMetaphoneCharacter("S");
						current += 1;
						break;

					case 'C':
						//various germanic
						if ((current > 1)
							&& !IsVowel(current - 2)
							&& AreStringsAt((current - 1), 3, "ACH")
							&& ((this._word[current + 2] != 'I') && ((this._word[current + 2] != 'E') || this.AreStringsAt((current - 2), 6, "BACHER", "MACHER"))))
						{
							this.AddMetaphoneCharacter("K");
							current += 2;
							break;
						}

						//special case 'caesar'
						if ((current == 0) && this.AreStringsAt(current, 6, "CAESAR"))
						{
							this.AddMetaphoneCharacter("S");
							current += 2;
							break;
						}

						//italian 'chianti'
						if (this.AreStringsAt(current, 4, "CHIA"))
						{
							this.AddMetaphoneCharacter("K");
							current += 2;
							break;
						}

						if (AreStringsAt(current, 2, "CH"))
						{
							//find 'michael'
							if ((current > 0) && AreStringsAt(current, 4, "CHAE"))
							{
								this.AddMetaphoneCharacter("K", "X");
								current += 2;
								break;
							}

							//greek roots e.g. 'chemistry', 'chorus'
							if ((current == 0)
								&& (this.AreStringsAt((current + 1), 5, "HARAC", "HARIS") || this.AreStringsAt((current + 1), 3, "HOR", "HYM", "HIA", "HEM"))
								&& !this.AreStringsAt(0, 5, "CHORE"))
							{
								this.AddMetaphoneCharacter("K");
								current += 2;
								break;
							}

							//germanic, greek, or otherwise 'ch' for 'kh' sound
							if ((this.AreStringsAt(0, 4, "VAN ", "VON ") || this.AreStringsAt(0, 3, "SCH"))
								// 'architect but not 'arch', 'orchestra', 'orchid'
								|| this.AreStringsAt((current - 2), 6, "ORCHES", "ARCHIT", "ORCHID")
								|| this.AreStringsAt((current + 2), 1, "T", "S")
								|| ((this.AreStringsAt((current - 1), 1, "A", "O", "U", "E") || (current == 0))
									//e.g., 'wachtler', 'wechsler', but not 'tichner'
									&& this.AreStringsAt((current + 2), 1, "L", "R", "N", "M", "B", "H", "F", "V", "W", " ")))
							{
								this.AddMetaphoneCharacter("K");
							}
							else
							{
								if (current > 0)
								{
									if (this.AreStringsAt(0, 2, "MC"))
										//e.g., "McHugh"
										this.AddMetaphoneCharacter("K");
									else
										this.AddMetaphoneCharacter("X", "K");
								}
								else
									this.AddMetaphoneCharacter("X");
							}
							current += 2;
							break;
						}
						//e.g, 'czerny'
						if (this.AreStringsAt(current, 2, "CZ") && !this.AreStringsAt((current - 2), 4, "WICZ"))
						{
							this.AddMetaphoneCharacter("S", "X");
							current += 2;
							break;
						}

						//e.g., 'focaccia'
						if (this.AreStringsAt((current + 1), 3, "CIA"))
						{
							this.AddMetaphoneCharacter("X");
							current += 3;
							break;
						}

						//double 'C', but not if e.g. 'McClellan'
						if (this.AreStringsAt(current, 2, "CC") && !((current == 1) && (_word[0] == 'M')))
							//'bellocchio' but not 'bacchus'
							if (this.AreStringsAt((current + 2), 1, "I", "E", "H") && !this.AreStringsAt((current + 2), 2, "HU"))
							{
								//'accident', 'accede' 'succeed'
								if (((current == 1) && (_word[current - 1] == 'A')) || this.AreStringsAt((current - 1), 5, "UCCEE", "UCCES"))
									AddMetaphoneCharacter("KS");

								//'bacci', 'bertucci', other italian
								else
									this.AddMetaphoneCharacter("X");
								current += 3;
								break;
							}
							else
							{//Pierce's rule
								this.AddMetaphoneCharacter("K");
								current += 2;
								break;
							}

						if (this.AreStringsAt(current, 2, "CK", "CG", "CQ"))
						{
							this.AddMetaphoneCharacter("K");
							current += 2;
							break;
						}

						if (this.AreStringsAt(current, 2, "CI", "CE", "CY"))
						{
							//italian vs. english
							if (this.AreStringsAt(current, 3, "CIO", "CIE", "CIA"))
								this.AddMetaphoneCharacter("S", "X");
							else
								this.AddMetaphoneCharacter("S");
							current += 2;
							break;
						}

						//else
						this.AddMetaphoneCharacter("K");

						//name sent in 'mac caffrey', 'mac gregor
						if (this.AreStringsAt((current + 1), 2, " C", " Q", " G"))
							current += 3;
						else
							if (this.AreStringsAt((current + 1), 1, "C", "K", "Q")
								&& !this.AreStringsAt((current + 1), 2, "CE", "CI"))
							current += 2;
						else
							current += 1;
						break;

					case 'D':
						if (this.AreStringsAt(current, 2, "DG"))
							if (this.AreStringsAt((current + 2), 1, "I", "E", "Y"))
							{
								//e.g. 'edge'
								this.AddMetaphoneCharacter("J");
								current += 3;
								break;
							}
							else
							{
								//e.g. 'edgar'
								this.AddMetaphoneCharacter("TK");
								current += 2;
								break;
							}

						if (this.AreStringsAt(current, 2, "DT", "DD"))
						{
							this.AddMetaphoneCharacter("T");
							current += 2;
							break;
						}

						//else
						this.AddMetaphoneCharacter("T");
						current += 1;
						break;

					case 'F':
						if (this._word[current + 1] == 'F')
							current += 2;
						else
							current += 1;
						this.AddMetaphoneCharacter("F");
						break;

					case 'G':
						if (this._word[current + 1] == 'H')
						{
							if ((current > 0) && !IsVowel(current - 1))
							{
								this.AddMetaphoneCharacter("K");
								current += 2;
								break;
							}

							if (current < 3)
							{
								//'ghislane', ghiradelli
								if (current == 0)
								{
									if (this._word[current + 2] == 'I')
										this.AddMetaphoneCharacter("J");
									else
										this.AddMetaphoneCharacter("K");
									current += 2;
									break;
								}
							}
							//Parker's rule (with some further refinements) - e.g., 'hugh'
							if (((current > 1) && this.AreStringsAt((current - 2), 1, "B", "H", "D"))
								//e.g., 'bough'
								|| ((current > 2) && this.AreStringsAt((current - 3), 1, "B", "H", "D"))
								//e.g., 'broughton'
								|| ((current > 3) && this.AreStringsAt((current - 4), 1, "B", "H")))
							{
								current += 2;
								break;
							}
							else
							{
								//e.g., 'laugh', 'McLaughlin', 'cough', 'gough', 'rough', 'tough'
								if ((current > 2)
									&& (this._word[current - 1] == 'U')
									&& this.AreStringsAt((current - 3), 1, "C", "G", "L", "R", "T"))
								{
									this.AddMetaphoneCharacter("F");
								}
								else
									if ((current > 0) && this._word[current - 1] != 'I')
									this.AddMetaphoneCharacter("K");

								current += 2;
								break;
							}
						}

						if (this._word[current + 1] == 'N')
						{
							if ((current == 1) && IsVowel(0) && !IsWordSlavoGermanic())
							{
								this.AddMetaphoneCharacter("KN", "N");
							}
							else
								//not e.g. 'cagney'
								if (!this.AreStringsAt((current + 2), 2, "EY")
									&& (this._word[current + 1] != 'Y') && !IsWordSlavoGermanic())
							{
								this.AddMetaphoneCharacter("N", "KN");
							}
							else
								this.AddMetaphoneCharacter("KN");
							current += 2;
							break;
						}

						//'tagliaro'
						if (this.AreStringsAt((current + 1), 2, "LI") && !IsWordSlavoGermanic())
						{
							this.AddMetaphoneCharacter("KL", "L");
							current += 2;
							break;
						}

						//-ges-,-gep-,-gel-, -gie- at beginning
						if ((current == 0)
							&& ((this._word[current + 1] == 'Y') || this.AreStringsAt((current + 1), 2, "ES", "EP", "EB", "EL", "EY", "IB", "IL", "IN", "IE", "EI", "ER")))
						{
							this.AddMetaphoneCharacter("K", "J");
							current += 2;
							break;
						}

						// -ger-,  -gy-
						if ((this.AreStringsAt((current + 1), 2, "ER") || (this._word[current + 1] == 'Y'))
							&& !this.AreStringsAt(0, 6, "DANGER", "RANGER", "MANGER")
							&& !this.AreStringsAt((current - 1), 1, "E", "I")
							&& !this.AreStringsAt((current - 1), 3, "RGY", "OGY"))
						{
							this.AddMetaphoneCharacter("K", "J");
							current += 2;
							break;
						}

						// italian e.g, 'biaggi'
						if (this.AreStringsAt((current + 1), 1, "E", "I", "Y") || this.AreStringsAt((current - 1), 4, "AGGI", "OGGI"))
						{
							//obvious germanic
							if ((this.AreStringsAt(0, 4, "VAN ", "VON ") || this.AreStringsAt(0, 3, "SCH")) || this.AreStringsAt((current + 1), 2, "ET"))
								this.AddMetaphoneCharacter("K");
							else
								//always soft if french ending
								if (this.AreStringsAt((current + 1), 4, "IER "))
								this.AddMetaphoneCharacter("J");
							else
								this.AddMetaphoneCharacter("J", "K");
							current += 2;
							break;
						}

						if (this._word[current + 1] == 'G')
							current += 2;
						else
							current += 1;
						this.AddMetaphoneCharacter("K");
						break;

					case 'H':
						//only keep if first & before vowel or btw. 2 vowels
						if (((current == 0) || IsVowel(current - 1))
							&& IsVowel(current + 1))
						{
							this.AddMetaphoneCharacter("H");
							current += 2;
						}
						else//also takes care of 'HH'
							current += 1;
						break;

					case 'J':
						//obvious spanish, 'jose', 'san jacinto'
						if (this.AreStringsAt(current, 4, "JOSE") || this.AreStringsAt(0, 4, "SAN "))
						{
							if (((current == 0) && (this._word[current + 4] == ' ')) || this.AreStringsAt(0, 4, "SAN "))
								this.AddMetaphoneCharacter("H");
							else
							{
								this.AddMetaphoneCharacter("J", "H");
							}
							current += 1;
							break;
						}

						if ((current == 0) && !this.AreStringsAt(current, 4, "JOSE"))
							this.AddMetaphoneCharacter("J", "A");	//Yankelovich/Jankelowicz
						else
							//spanish pron. of e.g. 'bajador'
							if (this.IsVowel(current - 1)
								&& !this.IsWordSlavoGermanic() && ((this._word[current + 1] == 'A') || (this._word[current + 1] == 'O')))
							this.AddMetaphoneCharacter("J", "H");
						else
							if (current == _last)
							this.AddMetaphoneCharacter("J", " ");
						else
							if (!this.AreStringsAt((current + 1), 1, "L", "T", "K", "S", "N", "M", "B", "Z")
								&& !this.AreStringsAt((current - 1), 1, "S", "K", "L"))
							this.AddMetaphoneCharacter("J");

						if (this._word[current + 1] == 'J') //it could happen!
							current += 2;
						else
							current += 1;
						break;

					case 'K':
						if (this._word[current + 1] == 'K')
							current += 2;
						else
							current += 1;
						this.AddMetaphoneCharacter("K");
						break;

					case 'L':
						if (this._word[current + 1] == 'L')
						{
							//spanish e.g. 'cabrillo', 'gallegos'
							if (((current == (_length - 3)) && this.AreStringsAt((current - 1), 4, "ILLO", "ILLA", "ALLE"))
								|| ((this.AreStringsAt((_last - 1), 2, "AS", "OS") || this.AreStringsAt(_last, 1, "A", "O")) && this.AreStringsAt((current - 1), 4, "ALLE")))
							{
								this.AddMetaphoneCharacter("L", " ");
								current += 2;
								break;
							}
							current += 2;
						}
						else
						{
							current += 1;
						}

						this.AddMetaphoneCharacter("L");

						break;

					case 'M':
						if ((this.AreStringsAt((current - 1), 3, "UMB")
								&& (((current + 1) == _last) || this.AreStringsAt((current + 2), 2, "ER")))
							//'dumb','thumb'
							|| (this._word[current + 1] == 'M'))
							current += 2;
						else
							current += 1;
						this.AddMetaphoneCharacter("M");
						break;

					case 'N':
						if (this._word[current + 1] == 'N')
							current += 2;
						else
							current += 1;
						this.AddMetaphoneCharacter("N");
						break;

					case 'Ñ':
						current += 1;
						this.AddMetaphoneCharacter("N");
						break;

					case 'P':
						if (this._word[current + 1] == 'H')
						{
							this.AddMetaphoneCharacter("F");
							current += 2;
							break;
						}

						//also account for "campbell", "raspberry"
						if (this.AreStringsAt((current + 1), 1, "P", "B"))
							current += 2;
						else
							current += 1;
						this.AddMetaphoneCharacter("P");
						break;

					case 'Q':
						if (this._word[current + 1] == 'Q')
							current += 2;
						else
							current += 1;
						this.AddMetaphoneCharacter("K");
						break;

					case 'R':
						//french e.g. 'rogier', but exclude 'hochmeier'
						if ((current == _last)
							&& !this.IsWordSlavoGermanic()
							&& this.AreStringsAt((current - 2), 2, "IE")
							&& !this.AreStringsAt((current - 4), 2, "ME", "MA"))
							this.AddMetaphoneCharacter("", "R");
						else
							this.AddMetaphoneCharacter("R");

						if (this._word[current + 1] == 'R')
							current += 2;
						else
							current += 1;
						break;

					case 'S':
						//special cases 'island', 'isle', 'carlisle', 'carlysle'
						if (this.AreStringsAt((current - 1), 3, "ISL", "YSL"))
						{
							current += 1;
							break;
						}

						//special case 'sugar-'
						if ((current == 0) && this.AreStringsAt(current, 5, "SUGAR"))
						{
							this.AddMetaphoneCharacter("X", "S");
							current += 1;
							break;
						}

						if (this.AreStringsAt(current, 2, "SH"))
						{
							//germanic
							if (this.AreStringsAt((current + 1), 4, "HEIM", "HOEK", "HOLM", "HOLZ"))
								this.AddMetaphoneCharacter("S");
							else
								this.AddMetaphoneCharacter("X");
							current += 2;
							break;
						}

						//italian & armenian
						if (this.AreStringsAt(current, 3, "SIO", "SIA") || this.AreStringsAt(current, 4, "SIAN"))
						{
							if (!IsWordSlavoGermanic())
								this.AddMetaphoneCharacter("S", "X");
							else
								this.AddMetaphoneCharacter("S");
							current += 3;
							break;
						}

						//german & anglicisations, e.g. 'smith' match 'schmidt', 'snider' match 'schneider'
						//also, -sz- in slavic language altho in hungarian it is pronounced 's'
						if (((current == 0) && this.AreStringsAt((current + 1), 1, "M", "N", "L", "W")) || this.AreStringsAt((current + 1), 1, "Z"))
						{
							this.AddMetaphoneCharacter("S", "X");
							if (this.AreStringsAt((current + 1), 1, "Z"))
								current += 2;
							else
								current += 1;
							break;
						}

						if (this.AreStringsAt(current, 2, "SC"))
						{
							//Schlesinger's rule
							if (this._word[current + 2] == 'H')
								//dutch origin, e.g. 'school', 'schooner'
								if (this.AreStringsAt((current + 3), 2, "OO", "ER", "EN", "UY", "ED", "EM"))
								{
									//'schermerhorn', 'schenker'
									if (this.AreStringsAt((current + 3), 2, "ER", "EN"))
									{
										this.AddMetaphoneCharacter("X", "SK");
									}
									else
									{
										this.AddMetaphoneCharacter("SK");
									}

									current += 3;
									break;
								}
								else
								{
									if ((current == 0) && !IsVowel(3) && (this._word[3] != 'W'))
										this.AddMetaphoneCharacter("X", "S");
									else
										this.AddMetaphoneCharacter("X");
									current += 3;
									break;
								}

							if (this.AreStringsAt((current + 2), 1, "I", "E", "Y"))
							{
								this.AddMetaphoneCharacter("S");
								current += 3;
								break;
							}
							//else
							this.AddMetaphoneCharacter("SK");
							current += 3;
							break;
						}

						//french e.g. 'resnais', 'artois'
						if ((current == _last) && this.AreStringsAt((current - 2), 2, "AI", "OI"))
							this.AddMetaphoneCharacter("", "S");
						else
							this.AddMetaphoneCharacter("S");

						if (this.AreStringsAt((current + 1), 1, "S", "Z"))
							current += 2;
						else
							current += 1;
						break;

					case 'T':
						if (this.AreStringsAt(current, 4, "TION"))
						{
							this.AddMetaphoneCharacter("X");
							current += 3;
							break;
						}

						if (this.AreStringsAt(current, 3, "TIA", "TCH"))
						{
							this.AddMetaphoneCharacter("X");
							current += 3;
							break;
						}

						if (this.AreStringsAt(current, 2, "TH") || this.AreStringsAt(current, 3, "TTH"))
						{
							//special case 'thomas', 'thames' or germanic
							if (this.AreStringsAt((current + 2), 2, "OM", "AM")
								|| this.AreStringsAt(0, 4, "VAN ", "VON ")
								|| this.AreStringsAt(0, 3, "SCH"))
							{
								this.AddMetaphoneCharacter("T");
							}
							else
							{
								this.AddMetaphoneCharacter("0", "T");
							}

							current += 2;
							break;
						}

						if (this.AreStringsAt((current + 1), 1, "T", "D"))
							current += 2;
						else
							current += 1;
						this.AddMetaphoneCharacter("T");
						break;

					case 'V':
						if (this._word[current + 1] == 'V')
							current += 2;
						else
							current += 1;
						this.AddMetaphoneCharacter("F");
						break;

					case 'W':
						//can also be in middle of word
						if (this.AreStringsAt(current, 2, "WR"))
						{
							this.AddMetaphoneCharacter("R");
							current += 2;
							break;
						}

						if ((current == 0)
							&& (this.IsVowel(current + 1) || this.AreStringsAt(current, 2, "WH")))
						{
							//Wasserman should match Vasserman
							if (IsVowel(current + 1))
								this.AddMetaphoneCharacter("A", "F");
							else
								//need Uomo to match Womo
								this.AddMetaphoneCharacter("A");
						}

						//Arnow should match Arnoff
						if (((current == _last) && IsVowel(current - 1))
							|| this.AreStringsAt((current - 1), 5, "EWSKI", "EWSKY", "OWSKI", "OWSKY")
							|| this.AreStringsAt(0, 3, "SCH"))
						{
							this.AddMetaphoneCharacter("", "F");
							current += 1;
							break;
						}

						//polish e.g. 'filipowicz'
						if (this.AreStringsAt(current, 4, "WICZ", "WITZ"))
						{
							this.AddMetaphoneCharacter("TS", "FX");
							current += 4;
							break;
						}

						//else skip it
						current += 1;
						break;

					case 'X':
						//french e.g. breaux
						if (!((current == _last) && (this.AreStringsAt((current - 3), 3, "IAU", "EAU") || this.AreStringsAt((current - 2), 2, "AU", "OU"))))
							this.AddMetaphoneCharacter("KS");

						if (this.AreStringsAt((current + 1), 1, "C", "X"))
							current += 2;
						else
							current += 1;
						break;

					case 'Z':
						//chinese pinyin e.g. 'zhao'
						if (this._word[current + 1] == 'H')
						{
							this.AddMetaphoneCharacter("J");
							current += 2;
							break;
						}
						else
							if (this.AreStringsAt((current + 1), 2, "ZO", "ZI", "ZA") || (this.IsWordSlavoGermanic() && ((current > 0) && this._word[current - 1] != 'T')))
						{
							this.AddMetaphoneCharacter("S", "TS");
						}
						else
						{
							this.AddMetaphoneCharacter("S");
						}

						if (this._word[current + 1] == 'Z')
							current += 2;
						else
							current += 1;
						break;

					default:
						current += 1;
						break;
				}
			}

			//Finally, chop off the keys at the proscribed length
			if (this._primaryKeyLength > KeyLength)
			{
				this._primaryKeyBuilder.Length = KeyLength;
			}

			if (this._alternateKeyLength > KeyLength)
			{
				this._alternateKeyBuilder.Length = KeyLength;
			}

			this._primaryKey = this._primaryKeyBuilder.ToString();
			this._alternateKey = this._alternateKeyBuilder.ToString();
		}

		/// <summary>
		///		Returns true if m_word is classified as "slavo-germanic" by Phillips' algorithm
		/// </summary>
		/// <returns>
		///		true if word contains strings that Lawrence's algorithm considers indicative of slavo-germanic origin; otherwise false.
		///	</returns>
		private bool IsWordSlavoGermanic()
		{
			if ((this._word.IndexOf("W") != -1) || (this._word.IndexOf("K") != -1) || (this._word.IndexOf("CZ") != -1) || (this._word.IndexOf("WITZ") != -1))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Returns true if letter at given position in word is a Roman vowel.
		/// </summary>
		/// <param name="pos">Position at which to check for a vowel.</param>
		/// <returns>True if m_word[pos] is a Roman vowel, otherwise false.</returns>
		private bool IsVowel(int pos)
		{
			if ((pos < 0) || (pos >= this._length))
				return false;

			Char it = this._word[pos];

			if ((it == 'E') || (it == 'A') || (it == 'I') || (it == 'O') || (it == 'U') || (it == 'Y'))
				return true;

			return false;
		}


		/// <summary>
		///		Appends the given metaphone character to the primary and alternate keys.
		/// </summary>
		/// <param name="primaryCharacter">Character to append</param>
		private void AddMetaphoneCharacter(string primaryCharacter)
		{
			this.AddMetaphoneCharacter(primaryCharacter, null);
		}

		/// <summary>
		/// Appends a metaphone character to the primary, and a possibly different alternate, metaphone keys for the word.
		/// </summary>
		/// <param name="primaryCharacter">
		///		Primary character to append to primary key, and, if no alternate char is present, the alternate key as well.
		///	</param>
		/// <param name="alternateCharacter">
		///		Alternate character to append to alternate key.  
		///		May be null or a zero-length string, in which case the primary character will be appended to the alternate key instead.
		///	</param>
		private void AddMetaphoneCharacter(string primaryCharacter, string alternateCharacter)
		{
			//Is the primary character valid?
			if (primaryCharacter.Length > 0)
			{
				int idx = 0;
				while (idx < primaryCharacter.Length)
				{
					this._primaryKeyBuilder.Length++;
					this._primaryKeyBuilder[this._primaryKeyLength++] = primaryCharacter[idx++];
				}
			}

			//Is the alternate character valid?
			if (alternateCharacter != null)
			{
				//Alternate character was provided.  If it is not zero-length, append it, else
				//append the primary string as long as it wasn't zero length and isn't a space character
				if (alternateCharacter.Length > 0)
				{
					this._hasAlternate = true;
					if (alternateCharacter[0] != ' ')
					{
						int idx = 0;
						while (idx < alternateCharacter.Length)
						{
							this._alternateKeyBuilder.Length++;
							this._alternateKeyBuilder[this._alternateKeyLength++] = alternateCharacter[idx++];
						}
					}
				}
				else
				{
					//No, but if the primary character is valid, add that instead
					if (primaryCharacter.Length > 0 && (primaryCharacter[0] != ' '))
					{
						int idx = 0;
						while (idx < primaryCharacter.Length)
						{
							this._alternateKeyBuilder.Length++;
							this._alternateKeyBuilder[this._alternateKeyLength++] = primaryCharacter[idx++];
						}
					}
				}
			}
			else if (primaryCharacter.Length > 0)
			{
				//Else, no alternate character was passed, but a primary was, so append the primary character to the alternate key
				int idx = 0;
				while (idx < primaryCharacter.Length)
				{
					this._alternateKeyBuilder.Length++;
					this._alternateKeyBuilder[this._alternateKeyLength++] = primaryCharacter[idx++];
				}
			}
		}

		/// <summary>
		/// Tests if any of the strings passed as variable arguments are at the given start position and length within word.
		/// </summary>
		/// <param name="start">Start position in m_word.</param>
		/// <param name="length">Length of substring starting at start in m_word to compare to the given strings.</param>
		/// <param name="strings">Array of zero or more strings for which to search in m_word.</param>
		/// <returns>
		///		true if any one string in the strings array was found in m_word at the given position and length.
		///	</returns>
		private bool AreStringsAt(int start, int length, params string[] strings)
		{
			if (start < 0)
			{
				//Sometimes, as a result of expressions like "current - 2" for start, 
				//start ends up negative.  Since no string can be present at a negative offset, this is always false
				return false;
			}

			string target = this._word.Substring(start, length);

			for (int idx = 0; idx < strings.Length; idx++)
			{
				if (strings[idx] == target)
				{
					return true;
				}
			}

			return false;
		}
		#endregion
	}
}
