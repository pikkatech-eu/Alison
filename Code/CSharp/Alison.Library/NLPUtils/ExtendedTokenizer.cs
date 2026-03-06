/***********************************************************************************
* File:         ExtendedTokenizer.cs                                               *
* Contents:     Class ExtendedTokenizer                                            *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2026-02-27 21:48                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Linq;
using NLPUtils;

namespace Factotum.NLPUtils
{
	public static class ExtendedTokenizer
	{
		public static string[] TokenizeToWords(string source)
		{
			var tokens = Tokenizer.Tokenize(source).Where(e=>e.Type == TokenType.Word).ToArray();

			return tokens.Select(t=>t.Content).ToArray();
		}
	}
}
