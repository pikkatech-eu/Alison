using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison.Library.Encoders
{
	public static class KnuthSoundex
	{
		public static string Encode(string s)
		{
			if (s.Length == 0)
            {
                return string.Empty;
            }

            var output = new StringBuilder();

            output.Append(char.ToUpperInvariant(s[0]));

            // Stop at a maximum of 4 characters
            for (int i = 1; i < s.Length && output.Length < 4; i++)
            {
                string c = EncodeChar(s[i]);

                // We either append or ignore, determined by the preceding char
                switch (char.ToLowerInvariant(s[i - 1]))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        // Chars separated by a vowel - OK to encode
                        output.Append(c);
                        break;
                    case 'h':
                    case 'w':
                    default:
                        // Ignore duplicated phonetic sounds
                        if (output.Length == 1)
                        {
                            // We only have the first character, which is never
                            // encoded. However, we need to check whether it is
                            // the same phonetically as the next char
                            if (EncodeChar(output[output.Length - 1]) != c)
                                output.Append(c);
                        }
                        else
                        {
                            if (output[output.Length - 1].ToString() != c)
                                output.Append(c);
                        }

                        break;
                }
            }

            // Pad with zeros
            output.Append(new string('0', 4 - output.Length));

            return output.ToString();
		}

        private static string EncodeChar(char c)
        {
            // C# will re-order this list and produce a look-up list from it
            // C# will do all the work we would otherwise do by building arrays of values
            switch (char.ToLowerInvariant(c))
            {
                case 'b':
                case 'f':
                case 'p':
                case 'v':
                    return "1";
                case 'c':
                case 'g':
                case 'j':
                case 'k':
                case 'q':
                case 's':
                case 'x':
                case 'z':
                    return "2";
                case 'd':
                case 't':
                    return "3";
                case 'l':
                    return "4";
                case 'm':
                case 'n':
                    return "5";
                case 'r':
                    return "6";
                default:
                    return string.Empty;
            }
        }
	}
}
