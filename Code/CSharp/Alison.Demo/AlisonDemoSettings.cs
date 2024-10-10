/***********************************************************************************
* File:         AlisonDemoSettings.cs                                              *
* Contents:     Class AlisonDemoSettings                                           *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 11:30                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using System.Xml.Linq;
using Alison.Library.Enumerations;
using Alison.Library.Tools.Xml;

namespace Alison.Demo
{
	public class AlisonDemoSettings
	{
		[Category("American Soundex")]
		[Description("Length of American Soundex code")]
		public int SoundexCodeLength	{get;set;} = 4;

		[Category("American Soundex")]
		[Description("Pad short code with zeroes or leave them?")]
		public SoundexCompletionMode SoundexCompletionMode	{get;set;} = SoundexCompletionMode.PadWithZeroes;

		[Category("American Soundex")]
		[Description("Remove eventual surname prefixes such as 'de' and 'von'?")]
		public bool SoundexRemoveSurnamePrefix	{get;set;} = false;

		[Category("Double Metaphone")]
		[Description("Maximum length of double metaphone codes")]
		public int MetaphoneMaxLength	{get;set;} = 4;

		public XElement	ToXElement()
		{
			XElement x = new XElement("AlisonDemoSettings");

			XElement xSoundex = new XElement("AmericanSoundex");
			x.Add(xSoundex);

			xSoundex.Add(new XElement("SoundexCodeLength", this.SoundexCodeLength));
			xSoundex.Add(new XElement("SoundexCompletionMode", this.SoundexCompletionMode));
			xSoundex.Add(new XElement("SoundexRemoveSurnamePrefix", this.SoundexRemoveSurnamePrefix));

			XElement xMetaphone = new XElement("DoubleMetaphone");
			x.Add(xMetaphone);
			xMetaphone.Add(new XElement("MetaphoneMaxLength"), this.MetaphoneMaxLength);

			return x;
		}

		public static AlisonDemoSettings FromXElement(XElement x)
		{
			XElement xSoundex = x.Element("AmericanSoundex");
			XElement xMetaphone = x.Element("DoubleMetaphone");

			AlisonDemoSettings settings = new AlisonDemoSettings();
			settings.SoundexCodeLength	= xSoundex.ElementValue<int>("SoundexCodeLength", 4);
			settings.SoundexCompletionMode = (SoundexCompletionMode)xSoundex.ElementEnum(typeof(SoundexCompletionMode), "SoundexCompletionMode", SoundexCompletionMode.PadWithZeroes);
			settings.SoundexRemoveSurnamePrefix = xSoundex.ElementValue<bool>("SoundexRemoveSurnamePrefix", false);

			settings.MetaphoneMaxLength = xMetaphone.ElementValue<int>("MetaphoneMaxLength", 4);

			return settings;
		}

		public void Save(string fileName)
		{
			this.ToXElement().Save(fileName);
		}

		public static AlisonDemoSettings Load(string fileName)
		{
			return FromXElement(XElement.Load(fileName));
		}
	}
}
