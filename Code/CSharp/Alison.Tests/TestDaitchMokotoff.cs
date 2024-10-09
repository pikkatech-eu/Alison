using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alison.Library.Encoders;
using NUnit.Framework;

namespace Alison.Tests
{
	[TestFixture]
	public class TestDaitchMokotoff
	{
		[Test]
		public void DaimoxEncoding_Succeeds()
		{
			(string Word, string Daimox)[] data = new (string Word, string Soundex)[]
			{
				("", "000000"),
				("Augsburg", "054795"),
				("Breuer", "791900"),
				("Halberstadt", "587433,587943"),
				("Mannheim", "665600"),
				("Chernowitz", "496740,596740"),
				("Cherkassy", "495400,595400"),
				("Kleinman", "586660"),
				("Berlin", "798600"),
				("Ceniow", "467000,567000"),
				("Tsenyuv", "467000"),
				("Holubica", "587400,587500"),
				("Golubitsa", "587400"),
				("Przemysl", "746480,794648"),
				("Pshemeshil", "746480"),
				("Rosochowaciec", "944744,944745,944754,944755,945744,945745,945754,945755"),
				("Rosokhovatsets", "945744"),
				("Peters", "734000,739400"),
				("Peterson", "734600,739460"),
				("Moskowitz", "645740"),
				("Moskovitz", "645740"),
				("Auerbach", "097400,097500"),
				("Uhrbach", "097400,097500"),
				("Jackson", "145460,154600,445460,454600"),
				("Jackson-Jackson", "145464,145465,154644,154645,154654,445464,445465,454644,454645,454654"),
				("OHRBACH", "097400,097500"),
				("LIPSHITZ", "874400"),
				("LIPPSZYC", "874400,874500"),
				("LEWINSKY", "876450"),
				("LEVINSKI", "876450"),
				("SZLAMAWICZ", "486740"),
				("SHLAMOVITZ", "486740"),
				("Schwarzenegger", "474659,479465"),
				("Shwarzenegger", "474659,479465"),
				("Schwartsenegger", "479465")
			};

			for (int i = 0; i < data.Length; i++)
			{
				string word = data[i].Word;
				string encoding = Daimox.Encode(word);

				Assert.That(encoding == data[i].Daimox);
			}
		}
	}
}
