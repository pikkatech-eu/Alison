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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alison.Library.Encoders;

namespace Alison.Demo
{
	public partial class AlisonDemoForm : Form
	{
		public AlisonDemoForm()
		{
			InitializeComponent();
		}

		private void OnEncode(object sender, EventArgs e)
		{
			string word = this._txWord.Text;

			this._lblRusselIndex.Text = Russell.Encode(word);
			this._lblAmericanSoundex.Text = AmericanSoundex.Encode(word);
			this._lblDaitchMokotoff.Text = Daimox.Encode(word);
			this._lblDoubleMetaphone.Text = DoubleMetaphone.Encode(word);
		}

		private void OnCopyRussellIndex(object sender, EventArgs e)
		{
			Clipboard.SetText(this._lblRusselIndex.Text);
		}

		private void OnCopyAmericanSoundex(object sender, EventArgs e)
		{
			Clipboard.SetText(this._lblAmericanSoundex.Text);
		}

		private void OnCopyDaitchMokotoff(object sender, EventArgs e)
		{
			Clipboard.SetText(this._lblDaitchMokotoff.Text);
		}

		private void OnCopyDoubleMetaphone(object sender, EventArgs e)
		{
			Clipboard.SetText(this._lblDoubleMetaphone.Text);
		}
	}
}
