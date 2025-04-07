namespace Agadir.Demo
{
	partial class AgadirDemoForm
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
			this._msAgadir = new MenuStrip();
			this.toolsToolStripMenuItem = new ToolStripMenuItem();
			this.settingsToolStripMenuItem = new ToolStripMenuItem();
			this._tsAgadir = new ToolStrip();
			this._zsAgadir = new StatusStrip();
			this._tcAgadirDemo = new TabControl();
			this._tpEncoders = new TabPage();
			this._tlpEncoders = new TableLayoutPanel();
			this._btCopyDoubleMetaphone = new Button();
			this._lblDoubleMetaphone = new Label();
			this.label5 = new Label();
			this._btCopyDaitchMokotoff = new Button();
			this._lblDaitchMokotoff = new Label();
			this.label4 = new Label();
			this._btCopyAmericanSoundex = new Button();
			this._lblAmericanSoundex = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.label1 = new Label();
			this._txWord = new TextBox();
			this._btEncode = new Button();
			this._lblRusselIndex = new Label();
			this._btCopyRusselIndex = new Button();
			this._tpStringMetrics = new TabPage();
			this._tlpMetrics = new TableLayoutPanel();
			this._btCopyCosineSimilarity = new Button();
			this._btCopyLevenshtein = new Button();
			this._lblCosineSimilarity = new Label();
			this._lblLevenshtein = new Label();
			this.label9 = new Label();
			this.label8 = new Label();
			this._txText2 = new TextBox();
			this.label7 = new Label();
			this.label6 = new Label();
			this._txText1 = new TextBox();
			this._btSortText1 = new Button();
			this.button1 = new Button();
			this.button2 = new Button();
			this.label10 = new Label();
			this.label11 = new Label();
			this._lblColognePhonetic = new Label();
			this._lblFuzzySoundex = new Label();
			this._msAgadir.SuspendLayout();
			this._tcAgadirDemo.SuspendLayout();
			this._tpEncoders.SuspendLayout();
			this._tlpEncoders.SuspendLayout();
			this._tpStringMetrics.SuspendLayout();
			this._tlpMetrics.SuspendLayout();
			this.SuspendLayout();
			// 
			// _msAgadir
			// 
			this._msAgadir.Font = new Font("Consolas", 10F);
			this._msAgadir.Items.AddRange(new ToolStripItem[] { this.toolsToolStripMenuItem });
			this._msAgadir.Location = new Point(0, 0);
			this._msAgadir.Name = "_msAgadir";
			this._msAgadir.Size = new Size(1058, 25);
			this._msAgadir.TabIndex = 0;
			this._msAgadir.Text = "menuStrip1";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.settingsToolStripMenuItem });
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new Size(60, 21);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new Size(140, 22);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.Click += this.OnSettings;
			// 
			// _tsAgadir
			// 
			this._tsAgadir.Location = new Point(0, 25);
			this._tsAgadir.Name = "_tsAgadir";
			this._tsAgadir.Size = new Size(1058, 25);
			this._tsAgadir.TabIndex = 1;
			this._tsAgadir.Text = "toolStrip1";
			// 
			// _zsAgadir
			// 
			this._zsAgadir.Font = new Font("Consolas", 10F);
			this._zsAgadir.Location = new Point(0, 645);
			this._zsAgadir.Name = "_zsAgadir";
			this._zsAgadir.Size = new Size(1058, 22);
			this._zsAgadir.TabIndex = 2;
			this._zsAgadir.Text = "statusStrip1";
			// 
			// _tcAgadirDemo
			// 
			this._tcAgadirDemo.Controls.Add(this._tpEncoders);
			this._tcAgadirDemo.Controls.Add(this._tpStringMetrics);
			this._tcAgadirDemo.Dock = DockStyle.Fill;
			this._tcAgadirDemo.Location = new Point(0, 50);
			this._tcAgadirDemo.Name = "_tcAgadirDemo";
			this._tcAgadirDemo.SelectedIndex = 0;
			this._tcAgadirDemo.Size = new Size(1058, 595);
			this._tcAgadirDemo.TabIndex = 3;
			// 
			// _tpEncoders
			// 
			this._tpEncoders.Controls.Add(this._tlpEncoders);
			this._tpEncoders.Location = new Point(4, 24);
			this._tpEncoders.Name = "_tpEncoders";
			this._tpEncoders.Padding = new Padding(3);
			this._tpEncoders.Size = new Size(1050, 567);
			this._tpEncoders.TabIndex = 0;
			this._tpEncoders.Text = "Encoders";
			this._tpEncoders.UseVisualStyleBackColor = true;
			// 
			// _tlpEncoders
			// 
			this._tlpEncoders.ColumnCount = 3;
			this._tlpEncoders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 145F));
			this._tlpEncoders.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			this._tlpEncoders.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			this._tlpEncoders.Controls.Add(this._lblFuzzySoundex, 1, 6);
			this._tlpEncoders.Controls.Add(this._lblColognePhonetic, 1, 5);
			this._tlpEncoders.Controls.Add(this.label11, 0, 6);
			this._tlpEncoders.Controls.Add(this.label10, 0, 5);
			this._tlpEncoders.Controls.Add(this.button2, 2, 5);
			this._tlpEncoders.Controls.Add(this.button1, 2, 6);
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
			this._tlpEncoders.Dock = DockStyle.Fill;
			this._tlpEncoders.Location = new Point(3, 3);
			this._tlpEncoders.Name = "_tlpEncoders";
			this._tlpEncoders.RowCount = 8;
			this._tlpEncoders.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpEncoders.RowStyles.Add(new RowStyle());
			this._tlpEncoders.Size = new Size(1044, 561);
			this._tlpEncoders.TabIndex = 0;
			// 
			// _btCopyDoubleMetaphone
			// 
			this._btCopyDoubleMetaphone.AutoSize = true;
			this._btCopyDoubleMetaphone.Dock = DockStyle.Left;
			this._btCopyDoubleMetaphone.Font = new Font("Wingdings", 12F);
			this._btCopyDoubleMetaphone.Location = new Point(967, 129);
			this._btCopyDoubleMetaphone.Margin = new Padding(3, 1, 3, 1);
			this._btCopyDoubleMetaphone.Name = "_btCopyDoubleMetaphone";
			this._btCopyDoubleMetaphone.Size = new Size(41, 30);
			this._btCopyDoubleMetaphone.TabIndex = 5;
			this._btCopyDoubleMetaphone.Tag = "DoubleMetaphone";
			this._btCopyDoubleMetaphone.Text = "4";
			this._btCopyDoubleMetaphone.UseVisualStyleBackColor = true;
			this._btCopyDoubleMetaphone.Click += this.OnCopyResults;
			// 
			// _lblDoubleMetaphone
			// 
			this._lblDoubleMetaphone.AutoSize = true;
			this._lblDoubleMetaphone.Dock = DockStyle.Fill;
			this._lblDoubleMetaphone.Location = new Point(148, 128);
			this._lblDoubleMetaphone.Name = "_lblDoubleMetaphone";
			this._lblDoubleMetaphone.Size = new Size(813, 32);
			this._lblDoubleMetaphone.TabIndex = 13;
			this._lblDoubleMetaphone.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = DockStyle.Fill;
			this.label5.Location = new Point(3, 128);
			this.label5.Name = "label5";
			this.label5.Size = new Size(139, 32);
			this.label5.TabIndex = 12;
			this.label5.Text = "Double Metaphone";
			this.label5.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _btCopyDaitchMokotoff
			// 
			this._btCopyDaitchMokotoff.AutoSize = true;
			this._btCopyDaitchMokotoff.Dock = DockStyle.Left;
			this._btCopyDaitchMokotoff.Font = new Font("Wingdings", 12F);
			this._btCopyDaitchMokotoff.Location = new Point(967, 97);
			this._btCopyDaitchMokotoff.Margin = new Padding(3, 1, 3, 1);
			this._btCopyDaitchMokotoff.Name = "_btCopyDaitchMokotoff";
			this._btCopyDaitchMokotoff.Size = new Size(41, 30);
			this._btCopyDaitchMokotoff.TabIndex = 4;
			this._btCopyDaitchMokotoff.Tag = "Daitch-Mokotoff";
			this._btCopyDaitchMokotoff.Text = "4";
			this._btCopyDaitchMokotoff.UseVisualStyleBackColor = true;
			this._btCopyDaitchMokotoff.Click += this.OnCopyResults;
			// 
			// _lblDaitchMokotoff
			// 
			this._lblDaitchMokotoff.AutoSize = true;
			this._lblDaitchMokotoff.Dock = DockStyle.Fill;
			this._lblDaitchMokotoff.Location = new Point(148, 96);
			this._lblDaitchMokotoff.Name = "_lblDaitchMokotoff";
			this._lblDaitchMokotoff.Size = new Size(813, 32);
			this._lblDaitchMokotoff.TabIndex = 10;
			this._lblDaitchMokotoff.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = DockStyle.Fill;
			this.label4.Location = new Point(3, 96);
			this.label4.Name = "label4";
			this.label4.Size = new Size(139, 32);
			this.label4.TabIndex = 9;
			this.label4.Text = "Daitch-Mokotoff";
			this.label4.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _btCopyAmericanSoundex
			// 
			this._btCopyAmericanSoundex.AutoSize = true;
			this._btCopyAmericanSoundex.Dock = DockStyle.Left;
			this._btCopyAmericanSoundex.Font = new Font("Wingdings", 12F);
			this._btCopyAmericanSoundex.Location = new Point(967, 65);
			this._btCopyAmericanSoundex.Margin = new Padding(3, 1, 3, 1);
			this._btCopyAmericanSoundex.Name = "_btCopyAmericanSoundex";
			this._btCopyAmericanSoundex.Size = new Size(41, 30);
			this._btCopyAmericanSoundex.TabIndex = 3;
			this._btCopyAmericanSoundex.Tag = "AmericanSoundex";
			this._btCopyAmericanSoundex.Text = "4";
			this._btCopyAmericanSoundex.UseVisualStyleBackColor = true;
			this._btCopyAmericanSoundex.Click += this.OnCopyResults;
			// 
			// _lblAmericanSoundex
			// 
			this._lblAmericanSoundex.AutoSize = true;
			this._lblAmericanSoundex.Dock = DockStyle.Fill;
			this._lblAmericanSoundex.Location = new Point(148, 64);
			this._lblAmericanSoundex.Name = "_lblAmericanSoundex";
			this._lblAmericanSoundex.Size = new Size(813, 32);
			this._lblAmericanSoundex.TabIndex = 7;
			this._lblAmericanSoundex.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = DockStyle.Fill;
			this.label3.Location = new Point(3, 64);
			this.label3.Name = "label3";
			this.label3.Size = new Size(139, 32);
			this.label3.TabIndex = 6;
			this.label3.Text = "American Soundex";
			this.label3.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = DockStyle.Fill;
			this.label2.Location = new Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new Size(139, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Russell Index";
			this.label2.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = DockStyle.Fill;
			this.label1.Location = new Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(139, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Word:";
			this.label1.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _txWord
			// 
			this._txWord.Dock = DockStyle.Fill;
			this._txWord.Font = new Font("Consolas", 14F);
			this._txWord.Location = new Point(145, 1);
			this._txWord.Margin = new Padding(0, 1, 0, 0);
			this._txWord.Name = "_txWord";
			this._txWord.Size = new Size(819, 29);
			this._txWord.TabIndex = 0;
			// 
			// _btEncode
			// 
			this._btEncode.BackColor = Color.LimeGreen;
			this._btEncode.Dock = DockStyle.Fill;
			this._btEncode.Font = new Font("Consolas", 12F, FontStyle.Bold);
			this._btEncode.ForeColor = Color.White;
			this._btEncode.Location = new Point(967, 0);
			this._btEncode.Margin = new Padding(3, 0, 3, 0);
			this._btEncode.Name = "_btEncode";
			this._btEncode.Size = new Size(74, 32);
			this._btEncode.TabIndex = 1;
			this._btEncode.Text = "Encode";
			this._btEncode.UseVisualStyleBackColor = false;
			this._btEncode.Click += this.OnEncode;
			// 
			// _lblRusselIndex
			// 
			this._lblRusselIndex.AutoSize = true;
			this._lblRusselIndex.Dock = DockStyle.Fill;
			this._lblRusselIndex.Location = new Point(148, 32);
			this._lblRusselIndex.Name = "_lblRusselIndex";
			this._lblRusselIndex.Size = new Size(813, 32);
			this._lblRusselIndex.TabIndex = 4;
			this._lblRusselIndex.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// _btCopyRusselIndex
			// 
			this._btCopyRusselIndex.AutoSize = true;
			this._btCopyRusselIndex.Dock = DockStyle.Left;
			this._btCopyRusselIndex.Font = new Font("Wingdings", 12F);
			this._btCopyRusselIndex.Location = new Point(967, 33);
			this._btCopyRusselIndex.Margin = new Padding(3, 1, 3, 1);
			this._btCopyRusselIndex.Name = "_btCopyRusselIndex";
			this._btCopyRusselIndex.Size = new Size(41, 30);
			this._btCopyRusselIndex.TabIndex = 2;
			this._btCopyRusselIndex.Tag = "Russell";
			this._btCopyRusselIndex.Text = "4";
			this._btCopyRusselIndex.UseVisualStyleBackColor = true;
			this._btCopyRusselIndex.Click += this.OnCopyResults;
			// 
			// _tpStringMetrics
			// 
			this._tpStringMetrics.Controls.Add(this._tlpMetrics);
			this._tpStringMetrics.Location = new Point(4, 24);
			this._tpStringMetrics.Name = "_tpStringMetrics";
			this._tpStringMetrics.Padding = new Padding(3);
			this._tpStringMetrics.Size = new Size(1050, 567);
			this._tpStringMetrics.TabIndex = 1;
			this._tpStringMetrics.Text = "Metrics";
			this._tpStringMetrics.UseVisualStyleBackColor = true;
			// 
			// _tlpMetrics
			// 
			this._tlpMetrics.ColumnCount = 6;
			this._tlpMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			this._tlpMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
			this._tlpMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this._tlpMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			this._tlpMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			this._tlpMetrics.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
			this._tlpMetrics.Controls.Add(this._btCopyCosineSimilarity, 5, 3);
			this._tlpMetrics.Controls.Add(this._btCopyLevenshtein, 5, 2);
			this._tlpMetrics.Controls.Add(this._lblCosineSimilarity, 2, 3);
			this._tlpMetrics.Controls.Add(this._lblLevenshtein, 2, 2);
			this._tlpMetrics.Controls.Add(this.label9, 0, 3);
			this._tlpMetrics.Controls.Add(this.label8, 0, 2);
			this._tlpMetrics.Controls.Add(this._txText2, 3, 1);
			this._tlpMetrics.Controls.Add(this.label7, 3, 0);
			this._tlpMetrics.Controls.Add(this.label6, 0, 0);
			this._tlpMetrics.Controls.Add(this._txText1, 0, 1);
			this._tlpMetrics.Controls.Add(this._btSortText1, 5, 0);
			this._tlpMetrics.Dock = DockStyle.Fill;
			this._tlpMetrics.Location = new Point(3, 3);
			this._tlpMetrics.Name = "_tlpMetrics";
			this._tlpMetrics.RowCount = 5;
			this._tlpMetrics.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
			this._tlpMetrics.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			this._tlpMetrics.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpMetrics.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
			this._tlpMetrics.RowStyles.Add(new RowStyle());
			this._tlpMetrics.Size = new Size(1044, 561);
			this._tlpMetrics.TabIndex = 0;
			// 
			// _btCopyCosineSimilarity
			// 
			this._btCopyCosineSimilarity.AutoSize = true;
			this._btCopyCosineSimilarity.Dock = DockStyle.Left;
			this._btCopyCosineSimilarity.Font = new Font("Wingdings", 12F);
			this._btCopyCosineSimilarity.Location = new Point(967, 530);
			this._btCopyCosineSimilarity.Margin = new Padding(3, 1, 3, 1);
			this._btCopyCosineSimilarity.Name = "_btCopyCosineSimilarity";
			this._btCopyCosineSimilarity.Size = new Size(41, 30);
			this._btCopyCosineSimilarity.TabIndex = 10;
			this._btCopyCosineSimilarity.Tag = "Cosine";
			this._btCopyCosineSimilarity.Text = "4";
			this._btCopyCosineSimilarity.UseVisualStyleBackColor = true;
			this._btCopyCosineSimilarity.Click += this.OnCopyResults;
			// 
			// _btCopyLevenshtein
			// 
			this._btCopyLevenshtein.AutoSize = true;
			this._btCopyLevenshtein.Dock = DockStyle.Left;
			this._btCopyLevenshtein.Font = new Font("Wingdings", 12F);
			this._btCopyLevenshtein.Location = new Point(967, 498);
			this._btCopyLevenshtein.Margin = new Padding(3, 1, 3, 1);
			this._btCopyLevenshtein.Name = "_btCopyLevenshtein";
			this._btCopyLevenshtein.Size = new Size(41, 30);
			this._btCopyLevenshtein.TabIndex = 9;
			this._btCopyLevenshtein.Tag = "Levenshtein";
			this._btCopyLevenshtein.Text = "4";
			this._btCopyLevenshtein.UseVisualStyleBackColor = true;
			this._btCopyLevenshtein.Click += this.OnCopyResults;
			// 
			// _lblCosineSimilarity
			// 
			this._lblCosineSimilarity.AutoSize = true;
			this._tlpMetrics.SetColumnSpan(this._lblCosineSimilarity, 3);
			this._lblCosineSimilarity.Dock = DockStyle.Fill;
			this._lblCosineSimilarity.Location = new Point(211, 529);
			this._lblCosineSimilarity.Name = "_lblCosineSimilarity";
			this._lblCosineSimilarity.Size = new Size(750, 32);
			this._lblCosineSimilarity.TabIndex = 8;
			this._lblCosineSimilarity.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// _lblLevenshtein
			// 
			this._lblLevenshtein.AutoSize = true;
			this._tlpMetrics.SetColumnSpan(this._lblLevenshtein, 3);
			this._lblLevenshtein.Dock = DockStyle.Fill;
			this._lblLevenshtein.Location = new Point(211, 497);
			this._lblLevenshtein.Name = "_lblLevenshtein";
			this._lblLevenshtein.Size = new Size(750, 32);
			this._lblLevenshtein.TabIndex = 7;
			this._lblLevenshtein.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this._tlpMetrics.SetColumnSpan(this.label9, 2);
			this.label9.Dock = DockStyle.Fill;
			this.label9.Location = new Point(3, 529);
			this.label9.Name = "label9";
			this.label9.Size = new Size(202, 32);
			this.label9.TabIndex = 6;
			this.label9.Text = "Cosine Similarity";
			this.label9.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this._tlpMetrics.SetColumnSpan(this.label8, 2);
			this.label8.Dock = DockStyle.Fill;
			this.label8.Location = new Point(3, 497);
			this.label8.Name = "label8";
			this.label8.Size = new Size(202, 32);
			this.label8.TabIndex = 5;
			this.label8.Text = "Levenshtein Distance";
			this.label8.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _txText2
			// 
			this._tlpMetrics.SetColumnSpan(this._txText2, 3);
			this._txText2.Dock = DockStyle.Fill;
			this._txText2.Location = new Point(549, 31);
			this._txText2.Multiline = true;
			this._txText2.Name = "_txText2";
			this._txText2.Size = new Size(492, 463);
			this._txText2.TabIndex = 4;
			this._txText2.TextChanged += this.OnText2Changed;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = DockStyle.Fill;
			this.label7.Location = new Point(549, 0);
			this.label7.Name = "label7";
			this.label7.Size = new Size(74, 28);
			this.label7.TabIndex = 2;
			this.label7.Text = "Text 2";
			this.label7.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = DockStyle.Fill;
			this.label6.Location = new Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new Size(74, 28);
			this.label6.TabIndex = 1;
			this.label6.Text = "Text 1";
			this.label6.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _txText1
			// 
			this._tlpMetrics.SetColumnSpan(this._txText1, 3);
			this._txText1.Dock = DockStyle.Fill;
			this._txText1.Location = new Point(3, 31);
			this._txText1.Multiline = true;
			this._txText1.Name = "_txText1";
			this._txText1.Size = new Size(540, 463);
			this._txText1.TabIndex = 3;
			this._txText1.TextChanged += this.OnText1Changed;
			// 
			// _btSortText1
			// 
			this._btSortText1.Location = new Point(964, 3);
			this._btSortText1.Margin = new Padding(0, 3, 0, 0);
			this._btSortText1.Name = "_btSortText1";
			this._btSortText1.Size = new Size(75, 23);
			this._btSortText1.TabIndex = 11;
			this._btSortText1.Text = "Sort";
			this._btSortText1.UseVisualStyleBackColor = true;
			this._btSortText1.Click += this.OnSort;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Dock = DockStyle.Left;
			this.button1.Font = new Font("Wingdings", 12F);
			this.button1.Location = new Point(967, 193);
			this.button1.Margin = new Padding(3, 1, 3, 1);
			this.button1.Name = "button1";
			this.button1.Size = new Size(41, 30);
			this.button1.TabIndex = 14;
			this.button1.Tag = "DoubleMetaphone";
			this.button1.Text = "4";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Dock = DockStyle.Left;
			this.button2.Font = new Font("Wingdings", 12F);
			this.button2.Location = new Point(967, 161);
			this.button2.Margin = new Padding(3, 1, 3, 1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(41, 30);
			this.button2.TabIndex = 15;
			this.button2.Tag = "DoubleMetaphone";
			this.button2.Text = "4";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = DockStyle.Fill;
			this.label10.Location = new Point(3, 160);
			this.label10.Name = "label10";
			this.label10.Size = new Size(139, 32);
			this.label10.TabIndex = 16;
			this.label10.Text = "Kölner Fonetik";
			this.label10.TextAlign = ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = DockStyle.Fill;
			this.label11.Location = new Point(3, 192);
			this.label11.Name = "label11";
			this.label11.Size = new Size(139, 32);
			this.label11.TabIndex = 17;
			this.label11.Text = "Fuzzy Soundex";
			this.label11.TextAlign = ContentAlignment.MiddleRight;
			// 
			// _lblColognePhonetic
			// 
			this._lblColognePhonetic.AutoSize = true;
			this._lblColognePhonetic.Dock = DockStyle.Fill;
			this._lblColognePhonetic.Location = new Point(148, 160);
			this._lblColognePhonetic.Name = "_lblColognePhonetic";
			this._lblColognePhonetic.Size = new Size(813, 32);
			this._lblColognePhonetic.TabIndex = 18;
			this._lblColognePhonetic.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// _lblFuzzySoundex
			// 
			this._lblFuzzySoundex.AutoSize = true;
			this._lblFuzzySoundex.Dock = DockStyle.Fill;
			this._lblFuzzySoundex.Location = new Point(148, 192);
			this._lblFuzzySoundex.Name = "_lblFuzzySoundex";
			this._lblFuzzySoundex.Size = new Size(813, 32);
			this._lblFuzzySoundex.TabIndex = 19;
			this._lblFuzzySoundex.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// AgadirDemoForm
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(1058, 667);
			this.Controls.Add(this._tcAgadirDemo);
			this.Controls.Add(this._zsAgadir);
			this.Controls.Add(this._tsAgadir);
			this.Controls.Add(this._msAgadir);
			this.Font = new Font("Consolas", 10F);
			this.MainMenuStrip = this._msAgadir;
			this.Margin = new Padding(4, 3, 4, 3);
			this.Name = "AgadirDemoForm";
			this.Text = "Agadir Demo 1.0";
			this._msAgadir.ResumeLayout(false);
			this._msAgadir.PerformLayout();
			this._tcAgadirDemo.ResumeLayout(false);
			this._tpEncoders.ResumeLayout(false);
			this._tlpEncoders.ResumeLayout(false);
			this._tlpEncoders.PerformLayout();
			this._tpStringMetrics.ResumeLayout(false);
			this._tlpMetrics.ResumeLayout(false);
			this._tlpMetrics.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.MenuStrip _msAgadir;
		private System.Windows.Forms.ToolStrip _tsAgadir;
		private System.Windows.Forms.StatusStrip _zsAgadir;
		private System.Windows.Forms.TabControl _tcAgadirDemo;
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
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel _tlpMetrics;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox _txText2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox _txText1;
		private System.Windows.Forms.Button _btCopyLevenshtein;
		private System.Windows.Forms.Label _lblCosineSimilarity;
		private System.Windows.Forms.Label _lblLevenshtein;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button _btCopyCosineSimilarity;
		private System.Windows.Forms.Button _btSortText1;
		private Button button1;
		private Button button2;
		private Label label11;
		private Label label10;
		private Label _lblColognePhonetic;
		private Label _lblFuzzySoundex;
	}
}

