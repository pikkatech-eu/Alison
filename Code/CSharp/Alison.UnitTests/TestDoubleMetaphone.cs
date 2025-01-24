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
	public class TestDoubleMetaphone
	{
		[Test]
		public void ComputationOfDoublemetaphone_Succeeds()
		{
			(string Word, string Metaphone)[] data = new (string Word, string Metaphone)[]
			{
				("Jose", "HS"),
				("cambrillo", "KMPRL,KMPR"),
				("otto", "AT"),
				("aubrey", "APR"),
				("maurice", "MRS"),
				("auto", "AT"),
				("maisey", "MS"),
				("catherine", "K0RN,KTRN"),
				("geoff", "JF,KF"),
				("Chile", "XL"),
				("katherine", "K0RN,KTRN"),
				("steven", "STFN"),
				("zhang", "JNK"),
				("bob", "PP"),
				("ray", "R"),
				("Tux", "TKS"),
				("bryan", "PRN"),
				("bryce", "PRS"),
				("Rapelje", "RPL"),
				("richard", "RXRT,RKRT"),
				("solilijs", "SLLS"),
				("Dallas", "TLS"),
				("Schwein", "XN,XFN"),
				("dave", "TF"),
				("eric", "ARK"),
				("Parachute", "PRKT"),
				("brian", "PRN"),
				("randy", "RNT"),
				("Through", "0R,TR"),
				("Nowhere", "NR"),
				("heidi", "HT"),
				("Arnow", "ARN,ARNF"),
				("Thumbail", "0MPL,TMPL"),
				("Bartoš", "PRT"),
				("Bartosz", "PRTS,PRTX"),
				("Bartosch", "PRTX"),
				("Bartos", "PRTS"),
				("andestādītu", "ANTSTTT"),
				("français", "FRNS,FRNSS"),
				("garçon", "KRSN"),
				("leçon", "LSN"),
				("ach", "AK"),
				("bacher", "PKR"),
				("macher", "MKR"),
				("bacci", "PX"),
				("bertucci", "PRTX"),
				("bellocchio", "PLX"),
				("bacchus", "PKS"),
				("focaccia", "FKX"),
				("chianti", "KNT"),
				("tagliaro", "TKLR,TLR"),
				("biaggi", "PJ,PK"),
				("bajador", "PJTR,PHTR"),
				("cabrillo", "KPRL,KPR"),
				("gallegos", "KLKS,KKS"),
				("San Jacinto", "SNHSNT"),
				("rogier", "RJ,RJR"),
				("breaux", "PR"),
				("Wewski", "ASK,FFSK"),
				("zhao", "J"),
				("school", "SKL"),
				("schooner", "SKNR"),
				("schermerhorn", "XRMRRN,SKRMRRN"),
				("schenker", "XNKR,SKNKR"),
				("Charac", "KRK"),
				("Charis", "KRS"),
				("chord", "KRT"),
				("Chym", "KM"),
				("Chia", "K"),
				("chem", "KM"),
				("chore", "XR"),
				("orchestra", "ARKSTR"),
				("architect", "ARKTKT"),
				("orchid", "ARKT"),
				("accident", "AKSTNT"),
				("accede", "AKST"),
				("succeed", "SKST"),
				("mac caffrey", "MKFR"),
				("mac gregor", "MKRKR"),
				("mc crae", "MKR"),
				("mcclain", "MKLN"),
				("laugh", "LF"),
				("cough", "KF"),
				("rough", "RF"),
				("gya", "K,J"),
				("ges", "KS,JS"),
				("gep", "KP,JP"),
				("geb", "KP,JP"),
				("gel", "KL,JL"),
				("gey", "K,J"),
				("gib", "KP,JP"),
				("gil", "KL,JL"),
				("gin", "KN,JN"),
				("gie", "K,J"),
				("gei", "K,J"),
				("ger", "KR,JR"),
				("danger", "TNJR,TNKR"),
				("manager", "MNKR,MNJR"),
				("dowager", "TKR,TJR"),
				("Campbell", "KMPL"),
				("raspberry", "RSPR"),
				("Thomas", "TMS"),
				("Thames", "TMS"),
				("Xavier", "SF,SFR"),
				("Michael", "MKL,MXL"),
				("Ignacio", "AKNS,ANX"),
				("Ajjam", "AJM"),
				("Akkad", "AKT"),
				("Año", "AN"),
				("Año", "AN"),
				("Caucasian", "KKSN,KKXN"),
				("Kaukasian", "KKSN"),
				("Zaqqum", "SKM"),
				("stevven", "STFN"),
				("Tuxx", "TKS"),
				("Ghiradelli", "JRTL"),
				("ghoul", "KL"),
				("hej", "HJ,H")
			};

			for (int i = 0; i < data.Length; i++)
			{
				string word = data[i].Word;
				DoubleMetaphone.MaxLength = 7;

				string encoding = DoubleMetaphone.Encode(word);

				Console.WriteLine($"{i}:\tword={word}\tencoded={encoding}\texpected={data[i].Metaphone}");

				Assert.That(encoding == data[i].Metaphone);
			}
		}
	}
}
