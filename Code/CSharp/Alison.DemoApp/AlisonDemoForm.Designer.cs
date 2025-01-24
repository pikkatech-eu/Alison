namespace Alison.Demo
{
	partial class AlisonDemoForm
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
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._tsAlison = new System.Windows.Forms.ToolStrip();
			this._zsAlison = new System.Windows.Forms.StatusStrip();
			this._tcAlisonDemo = new System.Windows.Forms.TabControl();
			this._tpEncoders = new System.Windows.Forms.TabPage();
			this._tlpEncoders = new System.Windows.Forms.TableLayoutPanel();
			this._btCopyDoubleMetaphone = new System.Windows.Forms.Button();
			this._lblDoubleMetaphone = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this._btCopyDaitchMokotoff = new System.Windows.Forms.Button();
			this._lblDaitchMokotoff = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this._btCopyAmericanSoundex = new System.Windows.Forms.Button();
			this._lblAmericanSoundex = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this._txWord = new System.Windows.Forms.TextBox();
			this._btEncode = new System.Windows.Forms.Button();
			this._lblRusselIndex = new System.Windows.Forms.Label();
			this._btCopyRusselIndex = new System.Windows.Forms.Button();
			this._tpStringMetrics = new System.Windows.Forms.TabPage();
			this._tlpMetrics = new System.Windows.Forms.TableLayoutPanel();
			this._btCopyCosineSimilarity = new System.Windows.Forms.Button();
			this._btCopyLevenshtein = new System.Windows.Forms.Button();
			this._lblCosineSimilarity = new System.Windows.Forms.Label();
			this._lblLevenshtein = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this._txText2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this._txText1 = new System.Windows.Forms.TextBox();
			this._btSortText1 = new System.Windows.Forms.Button();
			this._msAlison.SuspendLayout();
			this._tcAlisonDemo.SuspendLayout();
			this._tpEncoders.SuspendLayout();
			this._tlpEncoders.SuspendLayout();
			this._tpStringMetrics.SuspendLayout();
			this._tlpMetrics.SuspendLayout();
			this.SuspendLayout();
			// 
			// _msAlison
			// 
			this._msAlison.Font = new System.Drawing.Font("Consolas", 10F);
			this._msAlison.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
			this._msAlison.Location = new System.Drawing.Point(0, 0);
			this._msAlison.Name = "_msAlison";
			this._msAlison.Size = new System.Drawing.Size(1058, 25);
			this._msAlison.TabIndex = 0;
			this._msAlison.Text = "menuStrip1";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.settingsToolStripMenuItem.Text = "&Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OnSettings);
			// 
			// _tsAlison
			// 
			this._tsAlison.Location = new System.Drawing.Point(0, 25);
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
			this._tcAlisonDemo.Location = new System.Drawing.Point(0, 50);
			this._tcAlisonDemo.Name = "_tcAlisonDemo";
			this._tcAlisonDemo.SelectedIndex = 0;
			this._tcAlisonDemo.Size = new System.Drawing.Size(1058, 595);
			this._tcAlisonDemo.TabIndex = 3;
			// 
			// _tpEncoders
			// 
			this._tpEncoders.Controls.Add(this._tlpEncoders);
			this._tpEncoders.Location = new System.Drawing.Point(4, 24);
			this._tpEncoders.Name = "_tpEncoders";
			this._tpEncoders.Padding = new System.Windows.Forms.Padding(3);
			this._tpEncoders.Size = new System.Drawing.Size(1050, 567);
			this._tpEncoders.TabIndex = 0;
			this._tpEncoders.Text = "Encoders";
			this._tpEncoders.UseVisualStyleBackColor = true;
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
			this._tlpEncoders.Size = new System.Drawing.Size(1044, 561);
			this._tlpEncoders.TabIndex = 0;
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
			this._btCopyDoubleMetaphone.TabIndex = 5;
			this._btCopyDoubleMetaphone.Tag = "DoubleMetaphone";
			this._btCopyDoubleMetaphone.Text = "4";
			this._btCopyDoubleMetaphone.UseVisualStyleBackColor = true;
			this._btCopyDoubleMetaphone.Click += new System.EventHandler(this.OnCopyResults);
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
			// _btCopyDaitchMokotoff
			// 
			this._btCopyDaitchMokotoff.AutoSize = true;
			this._btCopyDaitchMokotoff.Dock = System.Windows.Forms.DockStyle.Left;
			this._btCopyDaitchMokotoff.Font = new System.Drawing.Font("Wingdings", 12F);
			this._btCopyDaitchMokotoff.Location = new System.Drawing.Point(967, 97);
			this._btCopyDaitchMokotoff.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this._btCopyDaitchMokotoff.Name = "_btCopyDaitchMokotoff";
			this._btCopyDaitchMokotoff.Size = new System.Drawing.Size(41, 30);
			this._btCopyDaitchMokotoff.TabIndex = 4;
			this._btCopyDaitchMokotoff.Tag = "Daitch-Mokotoff";
			this._btCopyDaitchMokotoff.Text = "4";
			this._btCopyDaitchMokotoff.UseVisualStyleBackColor = true;
			this._btCopyDaitchMokotoff.Click += new System.EventHandler(this.OnCopyResults);
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
			// _btCopyAmericanSoundex
			// 
			this._btCopyAmericanSoundex.AutoSize = true;
			this._btCopyAmericanSoundex.Dock = System.Windows.Forms.DockStyle.Left;
			this._btCopyAmericanSoundex.Font = new System.Drawing.Font("Wingdings", 12F);
			this._btCopyAmericanSoundex.Location = new System.Drawing.Point(967, 65);
			this._btCopyAmericanSoundex.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this._btCopyAmericanSoundex.Name = "_btCopyAmericanSoundex";
			this._btCopyAmericanSoundex.Size = new System.Drawing.Size(41, 30);
			this._btCopyAmericanSoundex.TabIndex = 3;
			this._btCopyAmericanSoundex.Tag = "AmericanSoundex";
			this._btCopyAmericanSoundex.Text = "4";
			this._btCopyAmericanSoundex.UseVisualStyleBackColor = true;
			this._btCopyAmericanSoundex.Click += new System.EventHandler(this.OnCopyResults);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 32);
			this.label2.TabIndex = 3;
			this.label2.Text = "Russell Index";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this._txWord.TabIndex = 0;
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
			this._btEncode.TabIndex = 1;
			this._btEncode.Text = "Encode";
			this._btEncode.UseVisualStyleBackColor = false;
			this._btEncode.Click += new System.EventHandler(this.OnEncode);
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
			this._btCopyRusselIndex.TabIndex = 2;
			this._btCopyRusselIndex.Tag = "Russell";
			this._btCopyRusselIndex.Text = "4";
			this._btCopyRusselIndex.UseVisualStyleBackColor = true;
			this._btCopyRusselIndex.Click += new System.EventHandler(this.OnCopyResults);
			// 
			// _tpStringMetrics
			// 
			this._tpStringMetrics.Controls.Add(this._tlpMetrics);
			this._tpStringMetrics.Location = new System.Drawing.Point(4, 24);
			this._tpStringMetrics.Name = "_tpStringMetrics";
			this._tpStringMetrics.Padding = new System.Windows.Forms.Padding(3);
			this._tpStringMetrics.Size = new System.Drawing.Size(1050, 567);
			this._tpStringMetrics.TabIndex = 1;
			this._tpStringMetrics.Text = "Metrics";
			this._tpStringMetrics.UseVisualStyleBackColor = true;
			// 
			// _tlpMetrics
			// 
			this._tlpMetrics.ColumnCount = 6;
			this._tlpMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this._tlpMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
			this._tlpMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tlpMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this._tlpMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this._tlpMetrics.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
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
			this._tlpMetrics.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tlpMetrics.Location = new System.Drawing.Point(3, 3);
			this._tlpMetrics.Name = "_tlpMetrics";
			this._tlpMetrics.RowCount = 5;
			this._tlpMetrics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this._tlpMetrics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tlpMetrics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpMetrics.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this._tlpMetrics.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tlpMetrics.Size = new System.Drawing.Size(1044, 561);
			this._tlpMetrics.TabIndex = 0;
			// 
			// _btCopyCosineSimilarity
			// 
			this._btCopyCosineSimilarity.AutoSize = true;
			this._btCopyCosineSimilarity.Dock = System.Windows.Forms.DockStyle.Left;
			this._btCopyCosineSimilarity.Font = new System.Drawing.Font("Wingdings", 12F);
			this._btCopyCosineSimilarity.Location = new System.Drawing.Point(967, 530);
			this._btCopyCosineSimilarity.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this._btCopyCosineSimilarity.Name = "_btCopyCosineSimilarity";
			this._btCopyCosineSimilarity.Size = new System.Drawing.Size(41, 30);
			this._btCopyCosineSimilarity.TabIndex = 10;
			this._btCopyCosineSimilarity.Tag = "Cosine";
			this._btCopyCosineSimilarity.Text = "4";
			this._btCopyCosineSimilarity.UseVisualStyleBackColor = true;
			this._btCopyCosineSimilarity.Click += new System.EventHandler(this.OnCopyResults);
			// 
			// _btCopyLevenshtein
			// 
			this._btCopyLevenshtein.AutoSize = true;
			this._btCopyLevenshtein.Dock = System.Windows.Forms.DockStyle.Left;
			this._btCopyLevenshtein.Font = new System.Drawing.Font("Wingdings", 12F);
			this._btCopyLevenshtein.Location = new System.Drawing.Point(967, 498);
			this._btCopyLevenshtein.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
			this._btCopyLevenshtein.Name = "_btCopyLevenshtein";
			this._btCopyLevenshtein.Size = new System.Drawing.Size(41, 30);
			this._btCopyLevenshtein.TabIndex = 9;
			this._btCopyLevenshtein.Tag = "Levenshtein";
			this._btCopyLevenshtein.Text = "4";
			this._btCopyLevenshtein.UseVisualStyleBackColor = true;
			this._btCopyLevenshtein.Click += new System.EventHandler(this.OnCopyResults);
			// 
			// _lblCosineSimilarity
			// 
			this._lblCosineSimilarity.AutoSize = true;
			this._tlpMetrics.SetColumnSpan(this._lblCosineSimilarity, 3);
			this._lblCosineSimilarity.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblCosineSimilarity.Location = new System.Drawing.Point(211, 529);
			this._lblCosineSimilarity.Name = "_lblCosineSimilarity";
			this._lblCosineSimilarity.Size = new System.Drawing.Size(750, 32);
			this._lblCosineSimilarity.TabIndex = 8;
			this._lblCosineSimilarity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _lblLevenshtein
			// 
			this._lblLevenshtein.AutoSize = true;
			this._tlpMetrics.SetColumnSpan(this._lblLevenshtein, 3);
			this._lblLevenshtein.Dock = System.Windows.Forms.DockStyle.Fill;
			this._lblLevenshtein.Location = new System.Drawing.Point(211, 497);
			this._lblLevenshtein.Name = "_lblLevenshtein";
			this._lblLevenshtein.Size = new System.Drawing.Size(750, 32);
			this._lblLevenshtein.TabIndex = 7;
			this._lblLevenshtein.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this._tlpMetrics.SetColumnSpan(this.label9, 2);
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(3, 529);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(202, 32);
			this.label9.TabIndex = 6;
			this.label9.Text = "Cosine Similarity";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this._tlpMetrics.SetColumnSpan(this.label8, 2);
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(3, 497);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(202, 32);
			this.label8.TabIndex = 5;
			this.label8.Text = "Levenshtein Distance";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _txText2
			// 
			this._tlpMetrics.SetColumnSpan(this._txText2, 3);
			this._txText2.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txText2.Location = new System.Drawing.Point(549, 31);
			this._txText2.Multiline = true;
			this._txText2.Name = "_txText2";
			this._txText2.Size = new System.Drawing.Size(492, 463);
			this._txText2.TabIndex = 4;
			this._txText2.TextChanged += new System.EventHandler(this.OnText2Changed);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(549, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(74, 28);
			this.label7.TabIndex = 2;
			this.label7.Text = "Text 2";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 28);
			this.label6.TabIndex = 1;
			this.label6.Text = "Text 1";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// _txText1
			// 
			this._tlpMetrics.SetColumnSpan(this._txText1, 3);
			this._txText1.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txText1.Location = new System.Drawing.Point(3, 31);
			this._txText1.Multiline = true;
			this._txText1.Name = "_txText1";
			this._txText1.Size = new System.Drawing.Size(540, 463);
			this._txText1.TabIndex = 3;
			this._txText1.TextChanged += new System.EventHandler(this.OnText1Changed);
			// 
			// _btSortText1
			// 
			this._btSortText1.Location = new System.Drawing.Point(964, 3);
			this._btSortText1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._btSortText1.Name = "_btSortText1";
			this._btSortText1.Size = new System.Drawing.Size(75, 23);
			this._btSortText1.TabIndex = 11;
			this._btSortText1.Text = "Sort";
			this._btSortText1.UseVisualStyleBackColor = true;
			this._btSortText1.Click += new System.EventHandler(this.OnSort);
			// 
			// AlisonDemoForm
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
			this.Name = "AlisonDemoForm";
			this.Text = "Alison Demo 1.0";
			this._msAlison.ResumeLayout(false);
			this._msAlison.PerformLayout();
			this._tcAlisonDemo.ResumeLayout(false);
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
	}
}

