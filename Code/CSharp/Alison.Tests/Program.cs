using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alison.Library.Encoders;

namespace Alison.Tests
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// TestRusselIndex();

			string word = "jose";
			string result = DoubleMetaphone.Encode(word);
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
