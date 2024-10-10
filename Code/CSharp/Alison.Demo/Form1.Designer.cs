namespace Alison.Demo
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._msAlison = new System.Windows.Forms.MenuStrip();
			this._tsAlison = new System.Windows.Forms.ToolStrip();
			this._zsAlison = new System.Windows.Forms.StatusStrip();
			this._tcAlisonDemo = new System.Windows.Forms.TabControl();
			this._tpEncoders = new System.Windows.Forms.TabPage();
			this._tpStringMetrics = new System.Windows.Forms.TabPage();
			this._tlpEncoders = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this._txWord = new System.Windows.Forms.TextBox();
			this._btEncode = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this._lblRusselIndex = new System.Windows.Forms.Label();
			this._btCopyRusselIndex = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this._lblAmericanSoundex = new System.Windows.Forms.Label();
			this._btCopyAmericanSoundex = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this._lblDaitchMokotoff = new System.Windows.Forms.Label();
			this._btCopyDaitchMokotoff = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this._lblDoubleMetaphone = new System.Windows.Forms.Label();
			this._btCopyDoubleMetaphone = new System.Windows.Forms.Button();
			this._tcAlisonDemo.SuspendLayout();
			this._tpEncoders.SuspendLayout();
			this._tlpEncoders.SuspendLayout();
			this.SuspendLayout();
			// 
			// _msAlison
			// 
			this._msAlison.Font = new System.Drawing.Font("Consolas", 10F);
			this._msAlison.Location = new System.Drawing.Point(0, 0);
			this._msAlison.Name = "_msAlison";
			this._msAlison.Size = new System.Drawing.Size(1058, 24);
			this._msAlison.TabIndex = 0;
			this._msAlison.Text = "menuStrip1";
			// 
			// _tsAlison
			// 
			this._tsAlison.Location = new System.Drawing.Point(0, 24);
			this._tsAlison.Name = "_tsAlison";
			this._tsAlison.Size = new System.Drawing.Size(1058, 25);
			this._tsAlison.TabIndex = 1;
			this._tsAlison.Text = "toolStrip1";
			// 
			// _zsAlison
			// 
			this._zsAlison.Font = new System.Drawing.Font("Consolas", 10F);
			this._zsAlison.Location = new System.Drawing.Point(0, 645);
			this._zsAlison.Name = "_zsAlison";
			this._zsAlison.Size = new System.Drawing.Size(1058, 22);
			this._zsAlison.TabIndex = 2;
			this._zsAlison.Text = "statusStrip1";
			// 
			// _tcAlisonDemo
			// 
			this._tcAlisonDemo.Controls.Add(this._tpEncoders);
			this._tcAlisonDemo.Controls.Add(this._tpStringMetrics);
			this._tcAlisonDemo.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tcAlisonDemo.Location = new System.Drawing.Point(0, 49);
			this._tcAlisonDemo.Name = "_tcAlisonDemo";
			this._tcAlisonDemo.SelectedIndex = 0;
			this._tcAlisonDemo.Size = new System.Drawing.Size(1058, 596);
			this._tcAlisonDemo.TabIndex = 3;
			// 
			// _tpEncoders
			// 
			this._tpEncoders.Controls.Add(this._tlpEncoders);
			this._tpEncoders.Location = new System.Drawing.Point(4, 24);
			this._tpEncoders.Name = "_tpEncoders";
			this._tpEncoders.Padding = new System.Windows.Forms.Padding(3);
			this._tpEncoders.Size = new System.Drawing.Size(1050, 568);
			this._tpEncoders.TabIndex = 0;
			this._tpEncoders.Text = "Encoders";
			this._tpEncoders.UseVisualStyleBackColor = true;
			// 
			// _tpStringMetrics
			// 
			this._tpStringMetrics.Location = new System.Drawing.Point(4, 24);
			this._tpStringMetrics.Name = "_tpStringMetrics";
			this._tpStringMetrics.Padding = new System.Windows.Forms.Padding(3);
			this._tpStringMetrics.Size = new System.Drawing.Size(1050, 568);
			this._tpStringMetrics.TabIndex = 1;
			this._tpStringMetrics.Text = "Metrics";
			this._tpStringMetrics.UseVisualStyleBackColor = true;
			// 
			// _tlpEncoders
			// 
			this._tlpEncoders.ColumnCount = 3;
			this._tlpEncoders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
			this._tlpEncoders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpEncoders.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this._tlpEncoders.Controls.Add(this._btCopyDoubleMetaphone, 2, 4);
			this._tlpEncoders.Controls.Add(this._lblDoubleMetaphone, 1, 4);
			this._tlpEncoders.Controls.Add(this.label5, 0, 4);
			this._tlpEncoders.Controls.Add(this._btCopyDaitchMokotoff, 2, 3);
			this._tlpEncoders.Controls.Add(this._lblDaitchMokotoff, 1, 3);
			this._tlpEncoders.Controls.Add(this.label4, 0, 3);
			this._tlpEncoders.Controls.Add(this._btCopyAmericanSoundex, 2, 2);
			this._tlpEncoders.Controls.Add(this._lblAmericanSoundex, 1, 2);
			this._tlpEncoders.Controls.Add(this.label3, 0, 2);
			this._tlpEncoders.Controls.Add(this.label2, 0, 1);
			this._tlpEncoders.Controls.Add(this.label1, 0, 0);
			this._tlpEncoders.Controls.Add(this._txWord, 1, 0);
			this._tlpEncoders.Controls.Add(this._btEncode, 2, 0);
			this._tlpEncoders.Controls.Add(this._lblRusselIndex, 1, 1);
			this._tlpEncoders.Controls.Add(this._btCopyRusselIndex, 2, 1);
			this._tlpEncoders.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpEncoders.Location = new System.Drawing.Point(3, 3);
			this._tlpEncoders.Name = "_tlpEncoders";
			this._tlpEncoders.RowCount = 6;
			this._tlpEncoders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpEncoders.Size = new System.Drawing.Size(1044, 562);
			this._tlpEncoders.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(139, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Word:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _txWord
			// 
			this._txWord.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txWord.Font = new System.Drawing.Font("Consolas", 14F);
			this._txWord.Location = new System.Drawing.Point(145, 1);
			this._txWord.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this._txWord.Name = "_txWord";
			this._txWord.Size = new System.Drawing.Size(819, 29);
			this._txWord.TabIndex = 1;
			// 
			// _btEncode
			// 
			this._btEncode.BackColor = System.Drawing.Color.LimeGreen;
			this._btEncode.Dock = System.Windows.Forms.DockStyle.Fill;
			this._btEncode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
			this._btEncode.ForeColor = System.Drawing.Color.White;
			this._btEncode.Location = new System.Drawing.Point(967, 0);
			this._btEncode.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this._btEncode.Name = "_btEncode";
			this._btEncode.Size = new System.Drawing.Size(74, 32);
			this._btEncode.TabIndex = 2;
			this._btEncode.Text = "Encode";
			this._btEncode.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Russel Index";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _lblRusselIndex
			// 
			this._lblRusselIndex.AutoSize = true;
			this._lblRusselIndex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblRusselIndex.Location = new System.Drawing.Point(148, 32);
			this._lblRusselIndex.Name = "_lblRusselIndex";
			this._lblRusselIndex.Size = new System.Drawing.Size(813, 32);
			this._lblRusselIndex.TabIndex = 4;
			this._lblRusselIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _btCopyRusselIndex
			// 
			this._btCopyRusselIndex.AutoSize = true;
			this._btCopyRusselIndex.Dock = System.Windows.Forms.DockStyle.Left;
			this._btCopyRusselIndex.Font = new System.Drawing.Font("Wingdings", 12F);
			this._btCopyRusselIndex.Location = new System.Drawing.Point(967, 33);
			this._btCopyRusselIndex.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this._btCopyRusselIndex.Name = "_btCopyRusselIndex";
			this._btCopyRusselIndex.Size = new System.Drawing.Size(41, 30);
			this._btCopyRusselIndex.TabIndex = 5;
			this._btCopyRusselIndex.Text = "4";
			this._btCopyRusselIndex.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 32);
			this.label3.TabIndex = 6;
			this.label3.Text = "American Soundex";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _lblAmericanSoundex
			// 
			this._lblAmericanSoundex.AutoSize = true;
			this._lblAmericanSoundex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblAmericanSoundex.Location = new System.Drawing.Point(148, 64);
			this._lblAmericanSoundex.Name = "_lblAmericanSoundex";
			this._lblAmericanSoundex.Size = new System.Drawing.Size(813, 32);
			this._lblAmericanSoundex.TabIndex = 7;
			this._lblAmericanSoundex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _btCopyAmericanSoundex
			// 
			this._btCopyAmericanSoundex.AutoSize = true;
			this._btCopyAmericanSoundex.Dock = System.Windows.Forms.DockStyle.Left;
			this._btCopyAmericanSoundex.Font = new System.Drawing.Font("Wingdings", 12F);
			this._btCopyAmericanSoundex.Location = new System.Drawing.Point(967, 65);
			this._btCopyAmericanSoundex.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this._btCopyAmericanSoundex.Name = "_btCopyAmericanSoundex";
			this._btCopyAmericanSoundex.Size = new System.Drawing.Size(41, 30);
			this._btCopyAmericanSoundex.TabIndex = 8;
			this._btCopyAmericanSoundex.Text = "4";
			this._btCopyAmericanSoundex.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 32);
			this.label4.TabIndex = 9;
			this.label4.Text = "Daitch-Mokotoff";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _lblDaitchMokotoff
			// 
			this._lblDaitchMokotoff.AutoSize = true;
			this._lblDaitchMokotoff.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblDaitchMokotoff.Location = new System.Drawing.Point(148, 96);
			this._lblDaitchMokotoff.Name = "_lblDaitchMokotoff";
			this._lblDaitchMokotoff.Size = new System.Drawing.Size(813, 32);
			this._lblDaitchMokotoff.TabIndex = 10;
			this._lblDaitchMokotoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _btCopyDaitchMokotoff
			// 
			this._btCopyDaitchMokotoff.AutoSize = true;
			this._btCopyDaitchMokotoff.Dock = System.Windows.Forms.DockStyle.Left;
			this._btCopyDaitchMokotoff.Font = new System.Drawing.Font("Wingdings", 12F);
			this._btCopyDaitchMokotoff.Location = new System.Drawing.Point(967, 97);
			this._btCopyDaitchMokotoff.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this._btCopyDaitchMokotoff.Name = "_btCopyDaitchMokotoff";
			this._btCopyDaitchMokotoff.Size = new System.Drawing.Size(41, 30);
			this._btCopyDaitchMokotoff.TabIndex = 11;
			this._btCopyDaitchMokotoff.Text = "4";
			this._btCopyDaitchMokotoff.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(139, 32);
			this.label5.TabIndex = 12;
			this.label5.Text = "Double Metaphone";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _lblDoubleMetaphone
			// 
			this._lblDoubleMetaphone.AutoSize = true;
			this._lblDoubleMetaphone.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblDoubleMetaphone.Location = new System.Drawing.Point(148, 128);
			this._lblDoubleMetaphone.Name = "_lblDoubleMetaphone";
			this._lblDoubleMetaphone.Size = new System.Drawing.Size(813, 32);
			this._lblDoubleMetaphone.TabIndex = 13;
			this._lblDoubleMetaphone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _btCopyDoubleMetaphone
			// 
			this._btCopyDoubleMetaphone.AutoSize = true;
			this._btCopyDoubleMetaphone.Dock = System.Windows.Forms.DockStyle.Left;
			this._btCopyDoubleMetaphone.Font = new System.Drawing.Font("Wingdings", 12F);
			this._btCopyDoubleMetaphone.Location = new System.Drawing.Point(967, 129);
			this._btCopyDoubleMetaphone.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this._btCopyDoubleMetaphone.Name = "_btCopyDoubleMetaphone";
			this._btCopyDoubleMetaphone.Size = new System.Drawing.Size(41, 30);
			this._btCopyDoubleMetaphone.TabIndex = 14;
			this._btCopyDoubleMetaphone.Text = "4";
			this._btCopyDoubleMetaphone.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1058, 667);
			this.Controls.Add(this._tcAlisonDemo);
			this.Controls.Add(this._zsAlison);
			this.Controls.Add(this._tsAlison);
			this.Controls.Add(this._msAlison);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.MainMenuStrip = this._msAlison;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form1";
			this.Text = "Alison Demo 1.0";
			this._tcAlisonDemo.ResumeLayout(false);
			this._tpEncoders.ResumeLayout(false);
			this._tlpEncoders.ResumeLayout(false);
			this._tlpEncoders.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip _msAlison;
		private System.Windows.Forms.ToolStrip _tsAlison;
		private System.Windows.Forms.StatusStrip _zsAlison;
		private System.Windows.Forms.TabControl _tcAlisonDemo;
		private System.Windows.Forms.TabPage _tpEncoders;
		private System.Windows.Forms.TabPage _tpStringMetrics;
		private System.Windows.Forms.TableLayoutPanel _tlpEncoders;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox _txWord;
		private System.Windows.Forms.Button _btEncode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label _lblRusselIndex;
		private System.Windows.Forms.Button _btCopyRusselIndex;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _btCopyDaitchMokotoff;
		private System.Windows.Forms.Label _lblDaitchMokotoff;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button _btCopyAmericanSoundex;
		private System.Windows.Forms.Label _lblAmericanSoundex;
		private System.Windows.Forms.Button _btCopyDoubleMetaphone;
		private System.Windows.Forms.Label _lblDoubleMetaphone;
		private System.Windows.Forms.Label label5;
	}
}

