/***********************************************************************************
* File:         Form1.cs                                                           *
* Contents:     Class Form1                                                        *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-10-10 10:40                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Windows.Forms;
using Alison.Library.Encoders;
using Alison.Library.StringMetrics;

namespace Alison.Demo
{
	public partial class AlisonDemoForm : Form
	{
		private Dictionary<string, Label> TAGGED_LABELS = new Dictionary<string, Label>()
		{
		};

		private const string SETTINGS_FILE_NAME = "alison_demo_settings.xml";
		private AlisonDemoSettings _settings = new AlisonDemoSettings();

		public AlisonDemoForm()
		{
			InitializeComponent();

			this.TAGGED_LABELS.Add("Russell", this._lblRusselIndex);
			this.TAGGED_LABELS.Add("AmericanSoundex", this._lblAmericanSoundex);
			this.TAGGED_LABELS.Add("Daitch-Mokotoff", this._lblDaitchMokotoff);
			this.TAGGED_LABELS.Add("DoubleMetaphone", this._lblDoubleMetaphone);
			this.TAGGED_LABELS.Add("Levenshtein", this._lblLevenshtein);
			this.TAGGED_LABELS.Add("Cosine", this._lblCosineSimilarity);

			try
			{
				this._settings = AlisonDemoSettings.Load(SETTINGS_FILE_NAME);

				this.ApplySettingsValues();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void ApplySettingsValues()
		{
			AmericanSoundex.CodeLength = this._settings.SoundexCodeLength;
			AmericanSoundex.SoundexCompletionMode = this._settings.SoundexCompletionMode;
			AmericanSoundex.RemoveSurnamePrefixes = this._settings.SoundexRemoveSurnamePrefix;

			DoubleMetaphone.MaxLength = this._settings.MetaphoneMaxLength;

			Cosine.CaseInsensitive	= this._settings.CosineSimilarityCaseSensitive;
		}

		private void OnEncode(object sender, EventArgs e)
		{
			string word = this._txWord.Text;

			this._lblRusselIndex.Text = Russell.Encode(word);
			this._lblAmericanSoundex.Text = AmericanSoundex.Encode(word);
			this._lblDaitchMokotoff.Text = Daimox.Encode(word);
			this._lblDoubleMetaphone.Text = DoubleMetaphone.Encode(word);
		}

		private void OnCopyResults(object sender, EventArgs e)
		{
			if (sender is Button)
			{
				Button button = sender as Button;
				string tag = button.Tag as string;

				Label label = this.TAGGED_LABELS[tag];

				Clipboard.SetText(label.Text);
			}
		}

		private void OnSettings(object sender, EventArgs e)
		{
			AlisonDemoSettingsDialog dialog = new AlisonDemoSettingsDialog();
			dialog.Settings = this._settings;

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				this._settings = dialog.Settings;
				this._settings.Save(SETTINGS_FILE_NAME);
				this.ApplySettingsValues();
			}
		}

		private void OnText1Changed(object sender, EventArgs e)
		{
			string text1 = this._txText1.Text;
			string text2 = this._txText2.Text;

			int distance = Levenshtein.Distance(text1, text2);
			this._lblLevenshtein.Text = distance.ToString();

			double cosineSimilarity = Cosine.Similarity(text1, text2);
			this._lblCosineSimilarity.Text	= cosineSimilarity.ToString();
		}

		private void OnText2Changed(object sender, EventArgs e)
		{
			string text1 = this._txText1.Text;
			string text2 = this._txText2.Text;

			int distance = Levenshtein.Distance(text1, text2);
			this._lblLevenshtein.Text = distance.ToString();

			double cosineSimilarity = Cosine.Similarity(text1, text2);
			this._lblCosineSimilarity.Text	= cosineSimilarity.ToString();
		}
	}
}
