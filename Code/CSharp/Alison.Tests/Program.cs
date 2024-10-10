using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alison.Library.Encoders;
using Alison.Library.StringMetrics;
using Alison.Library.Tools;

namespace Alison.Tests
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string source = "The Boeing Model 247 is an early American airliner, and one of the first such aircraft to incorporate advances such as all-metal (anodized aluminum) semimonocoque construction, a fully cantilevered wing, and retractable landing gear.[2][3] Other advanced features included control surface trim tabs, an autopilot and de-icing boots for the wings and tailplane.[4] The 247 first flew on February 8, 1933, and entered service later that year.";

			string[] zokens = NaiveTokenizer.Tokenize(source);
		}

		private static void TestRusselIndex()
		{
			string[] words = { "Haas", "Christopher", "Niall", "Smith", "Schmidt" };
			string[] results = { "1", "3813428", "715", "3614", "3614" };

			for (int i = 0; i < words.Length; i++)
			{
				string encoded = Russell.Encode(words[i]);
				Console.WriteLine($"{words[i]} -> {encoded}");
			}
		}
	}
}
